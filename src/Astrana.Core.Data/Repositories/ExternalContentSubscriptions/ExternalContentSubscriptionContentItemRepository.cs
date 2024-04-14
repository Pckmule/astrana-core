/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.ExternalContent.ContentItems.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Utilities;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.ExternalContentSubscriptions
{
    public class ExternalContentSubscriptionContentItemRepository : BaseRepository<ExternalContentSubscriptionContentItemRepository, Guid>, IExternalContentSubscriptionContentItemRepository<Guid>
    {
        public ExternalContentSubscriptionContentItemRepository(ILogger<ExternalContentSubscriptionContentItemRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<ExternalContentSubscriptionContentItem> BuildQuery(ExternalContentSubscriptionContentItemQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new ExternalContentSubscriptionContentItemQueryOptions<Guid, Guid>();

            var query = databaseSession.ExternalContentSubscriptionContentItems
                .Include(o => o.Thumbnail)
                .Include(o => o.Image)
                .Include(o => o.Source)
                .Include(o => o.Authors)
                .Include(o => o.Categories)
                .Include(o => o.Links).AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.ExternalContentSubscriptionContentItemId));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.ExternalContentSubscriptionContentItemId));

            if (options.CreatedBefore.HasValue)
                query = query.Where(o => o.CreatedTimestamp < options.CreatedBefore.Value);

            if (options.CreatedAfter.HasValue)
                query = query.Where(o => o.CreatedTimestamp > options.CreatedAfter.Value);

            // Add Ordering
            query = query.OrderByDescending(o => o.CreatedTimestamp);

            // Add Paging
            if (options is { PagingDisabled: false, PageSize: { }, CurrentPage: { } })
                query = query.Skip(options.PageSize.Value * (options.CurrentPage.Value - 1)).Take(options.PageSize.Value);

            return query;
        }

        /// <summary>
        /// Returns a count of ExternalContentSubscriptionContentItem according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetExternalContentSubscriptionContentItemsCountAsync(ExternalContentSubscriptionContentItemQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new ExternalContentSubscriptionContentItemQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of ExternalContentSubscriptionContentItem according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.ExternalContent.ContentItems.ExternalContentSubscriptionContentItem>> GetExternalContentSubscriptionContentItemsAsync(ExternalContentSubscriptionContentItemQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new ExternalContentSubscriptionContentItemQueryOptions<Guid, Guid>();

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

            var externalContentSubscriptions = queryResults.Select(Entities.Content.ModelMappings.ExternalContentSubscriptionContentItem.MapToDomainModel).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(ExternalContentSubscriptionContentItem)), queryOptions);

            return CreateGetResultWithPagination(externalContentSubscriptions, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns a ExternalContentSubscriptionContentItem by it's Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.ExternalContent.ContentItems.ExternalContentSubscriptionContentItem?> GetExternalContentSubscriptionContentItemByIdAsync(Guid id)
        {
            return (await GetExternalContentSubscriptionContentItemsAsync(new ExternalContentSubscriptionContentItemQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Adds new ExternalContentSubscriptionContentItem to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.ExternalContent.ContentItems.ExternalContentSubscriptionContentItem>>> CreateAsync(IEnumerable<DM.ExternalContent.ContentItems.ExternalContentSubscriptionContentItem> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newExternalContentSubscriptionContentItemIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newExternalContentSubscriptionContentItemEntity = new ExternalContentSubscriptionContentItem
                    {
                        Url = addition.Url,
                        
                        Title = addition.Title,
                        Summary = addition.Summary,

                        Content = addition.Content,
                        Rights = addition.Rights,
                        ContentRating = addition.ContentRating,

                        Published = addition.Published,
                        LastUpdated = addition.LastUpdated,

                        Source = new ExternalContentSource
                        {
                            Url = addition.Source.Url,
                            Name = addition.Source.Name,
                            IconUrl = addition.Source.IconUrl
                        }
                    };

                    if (addition.Thumbnail != null)
                        newExternalContentSubscriptionContentItemEntity.ThumbnailId = addition.Thumbnail.ImageId;

                    if (addition.Image != null)
                        newExternalContentSubscriptionContentItemEntity.ImageId = addition.Image.ImageId;

                    newExternalContentSubscriptionContentItemEntity.CreatedTimestamp = now;

                    newExternalContentSubscriptionContentItemEntity.LastModifiedBy = actioningUserId;
                    newExternalContentSubscriptionContentItemEntity.LastModifiedTimestamp = now;

                    // Save records.
                    databaseSession.ExternalContentSubscriptionContentItems.Add(newExternalContentSubscriptionContentItemEntity);
                    await databaseSession.SaveChangesAsync();

                    countAdded++;

                    newExternalContentSubscriptionContentItemIds.Add(newExternalContentSubscriptionContentItemEntity.ExternalContentSubscriptionContentItemId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newExternalContentSubscriptionContentItemIds.Count, nameof(ExternalContentSubscriptionContentItem) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.ExternalContent.ContentItems.ExternalContentSubscriptionContentItem>>((await GetExternalContentSubscriptionContentItemsAsync(new ExternalContentSubscriptionContentItemQueryOptions<Guid, Guid>(newExternalContentSubscriptionContentItemIds))).Data, countAdded);
                
                return new AddSuccessResult<List<DM.ExternalContent.ContentItems.ExternalContentSubscriptionContentItem>>(new List<DM.ExternalContent.ContentItems.ExternalContentSubscriptionContentItem>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                if (ex.InnerException is SqlException sqlException)
                {
                    if (sqlException.Number == 2601)
                    {
                        var result = new AddAbortResult<List<DM.ExternalContent.ContentItems.ExternalContentSubscriptionContentItem>>(null, 0, "Duplicate key exists.");

                        result.Errors.Add(new ResultError("", "Duplicate key exists", ErrorCodes.DuplicateKey));

                        return result;
                    }
                }

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing ExternalContentSubscriptionContentItem in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.ExternalContent.ContentItems.ExternalContentSubscriptionContentItem>>> UpdateAsync(IEnumerable<DM.ExternalContent.ContentItems.ExternalContentSubscriptionContentItem> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedExternalContentSubscriptionContentItemIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingExternalContentSubscriptionContentItemEntity = await databaseSession.ExternalContentSubscriptionContentItems.FirstOrDefaultAsync(o => o.ExternalContentSubscriptionContentItemId == update.ExternalContentSubscriptionContentItemId);

                    if (existingExternalContentSubscriptionContentItemEntity == null)
                        continue;

                    // Update entity fields

                    existingExternalContentSubscriptionContentItemEntity.Title = update.Title.Trim();

                    existingExternalContentSubscriptionContentItemEntity.LastModifiedBy = actioningUserId;
                    existingExternalContentSubscriptionContentItemEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    databaseSession.ExternalContentSubscriptionContentItems.Update(existingExternalContentSubscriptionContentItemEntity);

                    await databaseSession.SaveChangesAsync();

                    countUpdated++;

                    updatedExternalContentSubscriptionContentItemIds.Add(existingExternalContentSubscriptionContentItemEntity.ExternalContentSubscriptionContentItemId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedExternalContentSubscriptionContentItemIds.Count, nameof(ExternalContentSubscriptionContentItem) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.ExternalContent.ContentItems.ExternalContentSubscriptionContentItem>>((await GetExternalContentSubscriptionContentItemsAsync(new ExternalContentSubscriptionContentItemQueryOptions<Guid, Guid>(updatedExternalContentSubscriptionContentItemIds))).Data, countUpdated);
                
                return new UpdateSuccessResult<List<DM.ExternalContent.ContentItems.ExternalContentSubscriptionContentItem>>(new List<DM.ExternalContent.ContentItems.ExternalContentSubscriptionContentItem>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedExternalContentSubscriptionContentItemsToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
