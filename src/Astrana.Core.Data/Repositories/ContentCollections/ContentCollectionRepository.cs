/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.ContentCollections.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.ContentCollections
{
    public class ContentCollectionRepository : BaseRepository<ContentCollectionRepository, Guid>, IContentCollectionRepository<Guid>
    {
        public ContentCollectionRepository(ILogger<ContentCollectionRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<ContentCollection> BuildQuery(ContentCollectionQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new ContentCollectionQueryOptions<Guid, Guid>();

            IQueryable<ContentCollection> query;

            if (options.IncludeCollectionItems)
            {
                query = databaseSession.ContentCollections
                    .Include(o => o.ContentCollectionItems)
                    .ThenInclude(o => o.Image)
                    .Include(o => o.ContentCollectionItems)
                    .ThenInclude(o => o.Video)
                    .Include(o => o.ContentCollectionItems)
                    .ThenInclude(o => o.Audio)
                    .Include(o => o.ContentCollectionItems)
                    .ThenInclude(o => o.Link)
                    .AsQueryable();
            }
            else
            {
                query = databaseSession.ContentCollections.AsQueryable();
            }

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.ContentCollectionId));
            
            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.ContentCollectionId));

            if (options.CollectionType.HasValue)
                query = query.Where(o => o.CollectionType == options.CollectionType);

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
        /// Returns a count of ContentCollections according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetContentCollectionsCountAsync(ContentCollectionQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new ContentCollectionQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of ContentCollections according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.ContentCollections.ContentCollection>> GetContentCollectionsAsync(ContentCollectionQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new ContentCollectionQueryOptions<Guid, Guid>();

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

            var contentCollections = queryResults.Select(Entities.Content.ModelMappings.ContentCollection.MapToDomainModel).ToList();

            foreach (var contentCollection in contentCollections)
            {
                if (contentCollection != null && contentCollection.ContentItems != null)
                    contentCollection.ContentItems = contentCollection.ContentItems.OrderByDescending(o => o.CreatedTimestamp).ToList();
            }

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(ContentCollection)), queryOptions);

            return CreateGetResultWithPagination(contentCollections, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns a ContentCollection by it's Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.ContentCollections.ContentCollection?> GetContentCollectionByIdAsync(Guid id)
        {
            return (await GetContentCollectionsAsync(new ContentCollectionQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Adds new ContentCollections to the Data Source.
        /// </summary>
        /// <param name="newContentCollectionsToCreate"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.ContentCollections.ContentCollection>>> CreateAsync(IEnumerable<DM.ContentCollections.ContentCollection> newContentCollectionsToCreate, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newContentCollectionIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var newContentCollection in newContentCollectionsToCreate)
                {
                    var newContentCollectionEntity = new ContentCollection
                    {
                        Name = newContentCollection.Name
                    };

                    if (newContentCollection.ContentItems != null)
                    {
                        newContentCollectionEntity.ContentCollectionItems = newContentCollection.ContentItems.Select(o => new ContentCollectionItem
                        {
                            MediaType = o.MediaType,

                            ImageId = o.ImageId,
                            VideoId = o.VideoId,
                            AudioId = o.AudioId,

                            CreatedBy = actioningUserId,
                            LastModifiedBy = actioningUserId

                        }).ToList();
                    }
                    
                    newContentCollectionEntity.CreatedBy = actioningUserId;
                    //newContentCollectionEntity.CreatedTimestamp = now;

                    newContentCollectionEntity.LastModifiedBy = actioningUserId;
                    //newContentCollectionEntity.LastModifiedTimestamp = now;

                    // Save records.
                    databaseSession.ContentCollections.Add(newContentCollectionEntity);
                    await databaseSession.SaveChangesAsync();

                    countAdded++;

                    newContentCollectionIds.Add(newContentCollectionEntity.ContentCollectionId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newContentCollectionIds.Count, nameof(ContentCollection) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.ContentCollections.ContentCollection>>((await GetContentCollectionsAsync(new ContentCollectionQueryOptions<Guid, Guid> { Ids = newContentCollectionIds })).Data, countAdded);
                
                return new AddSuccessResult<List<DM.ContentCollections.ContentCollection>>(new List<DM.ContentCollections.ContentCollection>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing ContentCollections in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.ContentCollections.ContentCollection>>> UpdateAsync(IEnumerable<DM.ContentCollections.ContentCollection> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedContentCollectionIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingContentCollectionEntity = await databaseSession.ContentCollections.FirstOrDefaultAsync(o => o.ContentCollectionId == update.ContentCollectionId);

                    if (existingContentCollectionEntity == null)
                        continue;

                    // Update entity fields

                    existingContentCollectionEntity.Name = update.Name.Trim();

                    existingContentCollectionEntity.LastModifiedBy = actioningUserId;
                    existingContentCollectionEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    databaseSession.ContentCollections.Update(existingContentCollectionEntity);

                    await databaseSession.SaveChangesAsync();

                    countUpdated++;

                    updatedContentCollectionIds.Add(existingContentCollectionEntity.ContentCollectionId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedContentCollectionIds.Count, nameof(ContentCollection) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.ContentCollections.ContentCollection>>((await GetContentCollectionsAsync(new ContentCollectionQueryOptions<Guid, Guid>() { Ids = updatedContentCollectionIds })).Data, countUpdated);
                
                return new UpdateSuccessResult<List<DM.ContentCollections.ContentCollection>>(new List<DM.ContentCollections.ContentCollection>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedContentCollectionsToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
