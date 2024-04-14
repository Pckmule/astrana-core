/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.Feelings.Contracts;
using Astrana.Core.Domain.Models.Feelings.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.Feelings
{
    public class FeelingRepository : BaseRepository<FeelingRepository, Guid>, IFeelingRepository<Guid>
    {
        public FeelingRepository(ILogger<FeelingRepository> logger, ApplicationDbContext context) : base(logger, context) { }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<Feeling> BuildQuery(FeelingsQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new FeelingsQueryOptions<Guid, Guid>();

            var query = databaseSession.Feelings.AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.FeelingId));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.FeelingId));

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
        /// Returns a count of feelings according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetFeelingsCountAsync(FeelingsQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new FeelingsQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of feelings according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.Feelings.Feeling>> GetFeelingsAsync(FeelingsQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new FeelingsQueryOptions<Guid, Guid>();

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

            var feelings = queryResults.Select(Data.Entities.Content.ModelMappings.Feeling.MapToDomainModel).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(Feeling)), queryOptions);

            return CreateGetResultWithPagination(feelings, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns a feeling by it's Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.Feelings.Feeling?> GetFeelingByIdAsync(Guid id)
        {
            return (await GetFeelingsAsync(new FeelingsQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }
        
        /// <summary>
        /// Adds new feelings to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.Feelings.Feeling>>> CreateAsync(IEnumerable<IFeelingToAdd> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newFeelingIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newFeelingEntity = ModelMapper.MapModel<Feeling, IFeelingToAdd>(addition);

                    if (newFeelingEntity == null)
                        continue;

                    newFeelingEntity.CreatedBy = actioningUserId;
                    newFeelingEntity.CreatedTimestamp = now;

                    newFeelingEntity.LastModifiedBy = actioningUserId;
                    newFeelingEntity.LastModifiedTimestamp = now;

                    // Save records.
                    databaseSession.Feelings.Add(newFeelingEntity);
                    await databaseSession.SaveChangesAsync();

                    countAdded++;

                    newFeelingIds.Add(newFeelingEntity.FeelingId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newFeelingIds.Count, nameof(Feeling) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.Feelings.Feeling>>((await GetFeelingsAsync(new FeelingsQueryOptions<Guid, Guid>(newFeelingIds))).Data, countAdded);

                return new AddSuccessResult<List<DM.Feelings.Feeling>>(new List<DM.Feelings.Feeling>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing feelings in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.Feelings.Feeling>>> UpdateAsync(IEnumerable<DM.Feelings.Feeling> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedFeelingIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingFeelingEntity = await databaseSession.Feelings.FirstOrDefaultAsync(o => o.FeelingId == update.FeelingId);

                    if (existingFeelingEntity == null)
                        continue;

                    // Update entity fields

                    existingFeelingEntity.Name = update.Name.Trim();
                                        
                    existingFeelingEntity.LastModifiedBy = actioningUserId;
                    existingFeelingEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    databaseSession.Feelings.Update(existingFeelingEntity);

                    await databaseSession.SaveChangesAsync();

                    countUpdated++;

                    updatedFeelingIds.Add(existingFeelingEntity.FeelingId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedFeelingIds.Count, nameof(Feeling) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.Feelings.Feeling>>((await GetFeelingsAsync(new FeelingsQueryOptions<Guid, Guid>(updatedFeelingIds))).Data, countUpdated);

                return new UpdateSuccessResult<List<DM.Feelings.Feeling>>(new List<DM.Feelings.Feeling>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedFeelingsToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
