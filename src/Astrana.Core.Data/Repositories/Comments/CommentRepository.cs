/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.Comments.Contracts;
using Astrana.Core.Domain.Models.Comments.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.Comments
{
    public class CommentRepository : BaseRepository<CommentRepository, Guid>, ICommentRepository<Guid>
    {
        public CommentRepository(ILogger<CommentRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<Comment> BuildQuery(CommentQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new CommentQueryOptions<Guid, Guid>();

            var query = databaseSession.Comments.AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.CommentId));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.CommentId));

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
        /// Returns a count of Comments according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetCommentsCountAsync(CommentQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new CommentQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of Comments according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.Comments.Comment>> GetCommentsAsync(CommentQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new CommentQueryOptions<Guid, Guid>();

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

            var comments = queryResults.Select(Data.Entities.Content.ModelMappings.Comment.MapToDomainModel).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(Comment)), queryOptions);

            return CreateGetResultWithPagination(comments, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns a Comment by it's Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.Comments.Comment?> GetCommentByIdAsync(Guid id)
        {
            return (await GetCommentsAsync(new CommentQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Adds new Comments to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.Comments.Comment>>> CreateAsync(IEnumerable<DM.Comments.Comment> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newCommentIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newCommentEntity = ModelMapper.MapModel<Comment, DM.Comments.Comment>(addition);

                    if (newCommentEntity == null)
                        continue;
                    
                    newCommentEntity.CreatedBy = actioningUserId;
                    newCommentEntity.CreatedTimestamp = now;

                    newCommentEntity.LastModifiedBy = actioningUserId;
                    newCommentEntity.LastModifiedTimestamp = now;

                    // Save records.
                    databaseSession.Comments.Add(newCommentEntity);
                    await databaseSession.SaveChangesAsync();

                    countAdded++;

                    newCommentIds.Add(newCommentEntity.CommentId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newCommentIds.Count, nameof(Comment) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.Comments.Comment>>((await GetCommentsAsync(new CommentQueryOptions<Guid, Guid>(newCommentIds))).Data, countAdded);
                
                return new AddSuccessResult<List<DM.Comments.Comment>>(new List<DM.Comments.Comment>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing Comments in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.Comments.Comment>>> UpdateAsync(IEnumerable<IComment> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedCommentIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingCommentEntity = await databaseSession.Comments.FirstOrDefaultAsync(o => o.CommentId == update.CommentId);

                    if (existingCommentEntity == null)
                        continue;

                    // Update entity fields

                    existingCommentEntity.Text = update.Text.Trim();

                    existingCommentEntity.LastModifiedBy = actioningUserId;
                    existingCommentEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    databaseSession.Comments.Update(existingCommentEntity);

                    await databaseSession.SaveChangesAsync();

                    countUpdated++;

                    updatedCommentIds.Add(existingCommentEntity.CommentId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedCommentIds.Count, nameof(Comment) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.Comments.Comment>>((await GetCommentsAsync(new CommentQueryOptions<Guid, Guid>(updatedCommentIds))).Data, countUpdated);
                
                return new UpdateSuccessResult<List<DM.Comments.Comment>>(new List<DM.Comments.Comment>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedCommentsToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
