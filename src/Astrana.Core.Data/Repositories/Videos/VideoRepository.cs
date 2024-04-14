/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.Videos.Contracts;
using Astrana.Core.Domain.Models.Videos.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.Videos
{
    public class VideoRepository : BaseRepository<VideoRepository, Guid>, IVideoRepository<Guid>
    {
        public VideoRepository(ILogger<VideoRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<Video> BuildQuery(VideoQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new VideoQueryOptions<Guid, Guid>();

            var query = databaseSession.Videos.AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.VideoId));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.VideoId));

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
        /// Returns a count of Videos according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetVideosCountAsync(VideoQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new VideoQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of Videos according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.Videos.Video>> GetVideosAsync(VideoQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new VideoQueryOptions<Guid, Guid>();

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

            var videos = queryResults.Select(Entities.Content.ModelMappings.Video.MapToDomainModel).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(Video)), queryOptions);

            return CreateGetResultWithPagination(videos, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns a Video by it's Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.Videos.Video?> GetVideoByIdAsync(Guid id)
        {
            return (await GetVideosAsync(new VideoQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }
        
        /// <summary>
        /// Adds new Videos to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.Videos.Video>>> CreateAsync(IEnumerable<IVideoToAdd> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newVideoIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newVideoEntity = ModelMapper.MapModel<Video, IVideoToAdd>(addition);
                    
                    newVideoEntity.CreatedBy = actioningUserId;
                    newVideoEntity.CreatedTimestamp = now;

                    newVideoEntity.LastModifiedBy = actioningUserId;
                    newVideoEntity.LastModifiedTimestamp = now;

                    // Save records.
                    databaseSession.Videos.Add(newVideoEntity);
                    await databaseSession.SaveChangesAsync();

                    countAdded++;

                    newVideoIds.Add(newVideoEntity.VideoId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newVideoIds.Count, nameof(Video) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.Videos.Video>>((await GetVideosAsync(new VideoQueryOptions<Guid, Guid>(newVideoIds))).Data, countAdded);

                return new AddSuccessResult<List<DM.Videos.Video>>(new List<DM.Videos.Video>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing Videos in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.Videos.Video>>> UpdateAsync(IEnumerable<DM.Videos.Video> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedVideoIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingVideoEntity = await databaseSession.Videos.FirstOrDefaultAsync(o => o.VideoId == update.VideoId);

                    if (existingVideoEntity == null)
                        continue;

                    // Update entity fields

                    existingVideoEntity.LastModifiedBy = actioningUserId;
                    existingVideoEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    databaseSession.Videos.Update(existingVideoEntity);

                    await databaseSession.SaveChangesAsync();

                    countUpdated++;

                    updatedVideoIds.Add(existingVideoEntity.VideoId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedVideoIds.Count, nameof(Video) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.Videos.Video>>((await GetVideosAsync(new VideoQueryOptions<Guid, Guid>(updatedVideoIds))).Data, countUpdated);

                return new UpdateSuccessResult<List<DM.Videos.Video>>(new List<DM.Videos.Video>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedVideosToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
