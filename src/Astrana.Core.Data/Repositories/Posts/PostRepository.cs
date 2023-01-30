/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.Posts.Contracts;
using Astrana.Core.Domain.Models.Posts.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.Posts
{
    public class PostRepository : BaseRepository<PostRepository, Guid>, IPostRepository<Guid>
    {
        public PostRepository(ILogger<PostRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<Post> BuildQuery(PostQueryOptions<long, Guid>? options = null)
        {
            options ??= new PostQueryOptions<long, Guid>();

            var query = ctx.Posts.Include(o => o.Attachment).AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.Id));

            if (options.CreatedBefore.HasValue)
                query = query.Where(o => o.CreatedTimestamp < options.CreatedBefore.Value);

            if (options.CreatedAfter.HasValue)
                query = query.Where(o => o.CreatedTimestamp > options.CreatedAfter.Value);

            if (!options.IncludeDeactivated)
                query = query.Where(o => !o.DeactivatedTimestamp.HasValue);

            // Add Ordering
            query = query.OrderByDescending(o => o.CreatedTimestamp);

            // Add Paging
            if (!options.PagingDisabled && options.PageSize.HasValue && options.CurrentPage.HasValue)
                query = query.Skip(options.PageSize.Value * (options.CurrentPage.Value - 1)).Take(options.PageSize.Value);

            return query;
        }

        /// <summary>
        /// Returns a count of Posts according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetPostsCountAsync(PostQueryOptions<long, Guid>? queryOptions = null)
        {
            queryOptions ??= new PostQueryOptions<long, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of Posts according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.Posts.Post>> GetPostsAsync(PostQueryOptions<long, Guid>? queryOptions = null)
        {
            queryOptions ??= new PostQueryOptions<long, Guid>();

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

            var posts = queryResults.Select(post => ModelMapper.MapModel<DM.Posts.Post, Post>(post)).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(Post)), queryOptions);

            return CreateGetResultWithPagination(posts, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns a Post by it's Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.Posts.Post?> GetPostByIdAsync(long id)
        {
            return (await GetPostsAsync(new PostQueryOptions<long, Guid>(new List<long> { id }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Adds new Posts to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.Posts.Post>>> CreateAsync(IEnumerable<IPostToAdd> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newPostIds = new List<long>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newPostEntity = ModelMapper.MapModel<Post, IPostToAdd>(addition);

                    if (newPostEntity == null)
                        continue;
                    
                    newPostEntity.CreatedBy = actioningUserId;
                    newPostEntity.CreatedTimestamp = now;

                    newPostEntity.LastModifiedBy = actioningUserId;
                    newPostEntity.LastModifiedTimestamp = now;

                    // Save records.
                    ctx.Posts.Add(newPostEntity);
                    await ctx.SaveChangesAsync();

                    countAdded++;

                    newPostIds.Add(newPostEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newPostIds.Count, nameof(Post) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.Posts.Post>>((await GetPostsAsync(new PostQueryOptions<long, Guid>() { Ids = newPostIds })).Data, countAdded);
                
                return new AddSuccessResult<List<DM.Posts.Post>>(new List<DM.Posts.Post>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing Posts in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.Posts.Post>>> UpdateAsync(IEnumerable<IPost> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedPostIds = new List<long>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingPostEntity = await ctx.Posts.FirstOrDefaultAsync(o => o.Id == update.Id);

                    if (existingPostEntity == null)
                        continue;

                    // Update entity fields

                    existingPostEntity.Text = update.Text.Trim();

                    existingPostEntity.LastModifiedBy = actioningUserId;
                    existingPostEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    ctx.Posts.Update(existingPostEntity);

                    await ctx.SaveChangesAsync();

                    countUpdated++;

                    updatedPostIds.Add(existingPostEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedPostIds.Count, nameof(Post) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.Posts.Post>>((await GetPostsAsync(new PostQueryOptions<long, Guid>() { Ids = updatedPostIds })).Data, countUpdated);
                
                return new UpdateSuccessResult<List<DM.Posts.Post>>(new List<DM.Posts.Post>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IDeleteResult<List<long>>> DeleteAsync(IEnumerable<long> validatedPostsToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
