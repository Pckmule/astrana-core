/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.ExternalContentSubscriptions.Contracts;
using Astrana.Core.Domain.Models.ExternalContentSubscriptions.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.ExternalContentSubscriptions
{
    public class ExternalContentSubscriptionRepository : BaseRepository<ExternalContentSubscriptionRepository, Guid>, IExternalContentSubscriptionRepository<Guid>
    {
        public ExternalContentSubscriptionRepository(ILogger<ExternalContentSubscriptionRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<ExternalContentSubscription> BuildQuery(ExternalContentSubscriptionQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new ExternalContentSubscriptionQueryOptions<Guid, Guid>();

            var query = databaseSession.ExternalContentSubscriptions.AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.Id));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.Id));

            if (options.CreatedBefore.HasValue)
                query = query.Where(o => o.CreatedTimestamp < options.CreatedBefore.Value);

            if (options.CreatedAfter.HasValue)
                query = query.Where(o => o.CreatedTimestamp > options.CreatedAfter.Value);

            if (!options.IncludeDeactivated)
                query = query.Where(o => !o.DeactivatedTimestamp.HasValue);

            // Add Ordering
            query = query.OrderByDescending(o => o.CreatedTimestamp);

            // Add Paging
            if (options is { PagingDisabled: false, PageSize: { }, CurrentPage: { } })
                query = query.Skip(options.PageSize.Value * (options.CurrentPage.Value - 1)).Take(options.PageSize.Value);

            return query;
        }

        /// <summary>
        /// Returns a count of ExternalContentSubscription according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetExternalContentSubscriptionsCountAsync(ExternalContentSubscriptionQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new ExternalContentSubscriptionQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of ExternalContentSubscription according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.ExternalContentSubscriptions.ExternalSubscription>> GetExternalContentSubscriptionsAsync(ExternalContentSubscriptionQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new ExternalContentSubscriptionQueryOptions<Guid, Guid>();

            var queryResults = await BuildQuery(queryOptions).ToListAsync();

            int resultSetCount;
            if (queryOptions.PagingDisabled)
            {
                var countResultSetQueryOptions = queryOptions.Clone();
                countResultSetQueryOptions.PagingDisabled = true;

                resultSetCount = await BuildQuery(queryOptions).CountAsync();
            }
            else
                resultSetCount = queryResults.Count;

            var links = queryResults.Select(link => ModelMapper.MapModel<DM.ExternalContentSubscriptions.ExternalSubscription, ExternalContentSubscription>(link)).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(ExternalContentSubscription)), queryOptions);

            return CreateGetResultWithPagination(links, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns a ExternalContentSubscription by it's Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.ExternalContentSubscriptions.ExternalSubscription?> GetExternalContentSubscriptionByIdAsync(Guid id)
        {
            return (await GetExternalContentSubscriptionsAsync(new ExternalContentSubscriptionQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Adds new ExternalContentSubscription to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.ExternalContentSubscriptions.ExternalSubscription>>> CreateAsync(IEnumerable<IExternalSubscriptionToAdd> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newExternalContentSubscriptionIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newExternalContentSubscriptionEntity = ModelMapper.MapModel<ExternalContentSubscription, IExternalSubscriptionToAdd>(addition);

                    if (newExternalContentSubscriptionEntity == null)
                        continue;
                    
                    newExternalContentSubscriptionEntity.CreatedBy = actioningUserId;
                    newExternalContentSubscriptionEntity.CreatedTimestamp = now;

                    newExternalContentSubscriptionEntity.LastModifiedBy = actioningUserId;
                    newExternalContentSubscriptionEntity.LastModifiedTimestamp = now;

                    // Save records.
                    databaseSession.ExternalContentSubscriptions.Add(newExternalContentSubscriptionEntity);
                    await databaseSession.SaveChangesAsync();

                    countAdded++;

                    newExternalContentSubscriptionIds.Add(newExternalContentSubscriptionEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newExternalContentSubscriptionIds.Count, nameof(ExternalContentSubscription) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.ExternalContentSubscriptions.ExternalSubscription>>((await GetExternalContentSubscriptionsAsync(new ExternalContentSubscriptionQueryOptions<Guid, Guid> { Ids = newExternalContentSubscriptionIds })).Data, countAdded);
                
                return new AddSuccessResult<List<DM.ExternalContentSubscriptions.ExternalSubscription>>(new List<DM.ExternalContentSubscriptions.ExternalSubscription>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing ExternalContentSubscription in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.ExternalContentSubscriptions.ExternalSubscription>>> UpdateAsync(IEnumerable<IExternalSubscription> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedExternalContentSubscriptionIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingExternalContentSubscriptionEntity = await databaseSession.ExternalContentSubscriptions.FirstOrDefaultAsync(o => o.Id == update.LinkId);

                    if (existingExternalContentSubscriptionEntity == null)
                        continue;

                    // Update entity fields

                    existingExternalContentSubscriptionEntity.Title = update.Title.Trim();

                    existingExternalContentSubscriptionEntity.LastModifiedBy = actioningUserId;
                    existingExternalContentSubscriptionEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    databaseSession.ExternalContentSubscriptions.Update(existingExternalContentSubscriptionEntity);

                    await databaseSession.SaveChangesAsync();

                    countUpdated++;

                    updatedExternalContentSubscriptionIds.Add(existingExternalContentSubscriptionEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedExternalContentSubscriptionIds.Count, nameof(ExternalContentSubscription) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.ExternalContentSubscriptions.ExternalSubscription>>((await GetExternalContentSubscriptionsAsync(new ExternalContentSubscriptionQueryOptions<Guid, Guid>() { Ids = updatedExternalContentSubscriptionIds })).Data, countUpdated);
                
                return new UpdateSuccessResult<List<DM.ExternalContentSubscriptions.ExternalSubscription>>(new List<DM.ExternalContentSubscriptions.ExternalSubscription>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedExternalContentSubscriptionsToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
