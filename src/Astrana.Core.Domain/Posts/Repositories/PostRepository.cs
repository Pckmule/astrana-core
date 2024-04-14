/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data;
using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Data.Repositories;
using Astrana.Core.Domain.Models.Attachments.Enums;
using Astrana.Core.Domain.Models.Posts.Contracts;
using Astrana.Core.Domain.Models.Posts.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Extensions;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System.Collections.ObjectModel;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Domain.Posts.Repositories
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

            var query = databaseSession.Posts.Include(o => o.Attachments)
                .ThenInclude(attachment => attachment.Link)
                .ThenInclude(attachment => attachment.PreviewImage)
                .Include(o => o.Attachments)
                .ThenInclude(attachment => attachment.Image)
                .Include(o => o.Attachments)
                .ThenInclude(attachment => attachment.Video)
                .Include(o => o.Attachments)
                .ThenInclude(attachment => attachment.ContentCollection)
                .ThenInclude(contentCollection => contentCollection.ContentCollectionItems)
                .ThenInclude(contentCollectionItem => contentCollectionItem.Image)
                .Include(o => o.Attachments)
                .ThenInclude(attachment => attachment.ContentCollection)
                .ThenInclude(contentCollection => contentCollection.ContentCollectionItems)
                .ThenInclude(contentCollectionItem => contentCollectionItem.Video)
                .AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.PostId));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.PostId));

            if (options.AttachmentTypes != null && options.AttachmentTypes.Any())
                query = query.Where(o => o.Attachments.Any(a => options.AttachmentTypes.Contains(a.Type)));

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

            var posts = queryResults.Select(Data.Entities.Content.ModelMappings.Post.MapToDomainModel).ToList();

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
        /// <param name="postsToAdd"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.Posts.Post>>> CreateAsync(IList<DM.Posts.Post> postsToAdd, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newEntityIds = new List<long>();

            try
            {
                foreach (var postToAdd in postsToAdd)
                {
                    var newPostEntity = new Post
                    {
                        Text = postToAdd.Text,
                        Attachments = new Collection<PostAttachment>()
                    };

                    foreach (var attachment in postToAdd.Attachments.OrEmptyIfNull())
                    {
                        var newAttachmentEntity = new PostAttachment
                        {
                            Title = attachment.Title,
                            Caption = attachment.Caption,
                            Type = attachment.Type,

                            CreatedBy = actioningUserId,
                            LastModifiedBy = actioningUserId,
                        };

                        switch (attachment.Type)
                        {
                            case AttachmentType.Link:
                            {
                                var linkId = attachment.LinkId ?? attachment.Link?.Id;

                                if (!linkId.HasValue && attachment.Link == null)
                                    continue;
                            
                                if (linkId.HasValue && await databaseSession.Links.FindAsync(linkId) != null)
                                {
                                    newAttachmentEntity.LinkId = linkId;
                                }
                                else if (!linkId.HasValue && attachment.Link != null)
                                {
                                    newAttachmentEntity.Link = new Link
                                    {
                                        Url = attachment.Link.Url,
                                        Title = attachment.Link.Title,
                                        Description = attachment.Link.Description,
                                        Locale = attachment.Link.Locale,
                                        CharSet = attachment.Link.CharSet,
                                        Robots = attachment.Link.Robots,
                                        SiteName = attachment.Link.SiteName
                                    };
                                }

                                newPostEntity.Attachments.Add(newAttachmentEntity);
                                break;
                            }

                            case AttachmentType.Image:
                            {
                                var attachmentEntity = await databaseSession.Images.FindAsync(attachment.ImageId);

                                if (attachmentEntity != null)
                                {
                                    newAttachmentEntity.ImageId = attachment.ImageId;
                                }
                                else if (attachment.Image != null)
                                {
                                    newAttachmentEntity.Image = new Image
                                    {
                                        Caption = attachment.Image.Caption,
                                        Copyright = attachment.Image.Copyright,
                                        Location = attachment.Image.Location
                                    };
                                }

                                newPostEntity.Attachments.Add(newAttachmentEntity);
                                break;
                            }

                            case AttachmentType.Video:
                            {
                                var attachmentEntity = await databaseSession.Videos.FindAsync(attachment.VideoId);

                                if (attachmentEntity != null)
                                {
                                    newAttachmentEntity.VideoId = attachment.VideoId;
                                }
                                else if (attachment.Video != null)
                                {
                                    newAttachmentEntity.Video = new Video
                                    {
                                        Caption = attachment.Video.Caption,
                                        Copyright = attachment.Video.Copyright,
                                        Location = attachment.Video.Location
                                    };
                                }

                                newPostEntity.Attachments.Add(newAttachmentEntity);
                                break;
                            }

                            case AttachmentType.ContentCollection:
                            {
                                var attachmentEntity = await databaseSession.ContentCollections.FindAsync(attachment.ContentCollectionId);

                                if (attachmentEntity != null)
                                {
                                    newAttachmentEntity.ContentCollectionId = attachment.ContentCollectionId;
                                }
                                else if (attachment.ContentCollection != null)
                                {
                                    newAttachmentEntity.ContentCollection = new ContentCollection
                                    {
                                        Name = attachment.ContentCollection.Name
                                    };
                                }

                                newPostEntity.Attachments.Add(newAttachmentEntity);
                                break;
                            }
                        }
                    }

                    newPostEntity.CreatedBy = actioningUserId;
                    newPostEntity.LastModifiedBy = actioningUserId;

                    databaseSession.Posts.Add(newPostEntity);

                    await databaseSession.SaveChangesAsync();

                    countAdded++;

                    newEntityIds.Add(newPostEntity.PostId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newEntityIds.Count, nameof(Post) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.Posts.Post>>((await GetPostsAsync(new PostQueryOptions<long, Guid>(newEntityIds))).Data, countAdded);
                
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
                foreach (var update in requestedUpdates)
                {
                    //var existingPostEntity = await ctx.Posts.FirstOrDefaultAsync(o => o.Id == update.Id);

                    //if (existingPostEntity == null)
                    //    continue;

                    //// Update entity fields

                    //existingPostEntity.Text = update.Text.Trim();

                    //existingPostEntity.LastModifiedBy = actioningUserId;
                    //existingPostEntity.LastModifiedTimestamp = now;

                    //// Save changes to records.
                    //ctx.Posts.Update(existingPostEntity);

                    //await ctx.SaveChangesAsync();

                    //countUpdated++;

                    //updatedPostIds.Add(existingPostEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedPostIds.Count, nameof(Post) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.Posts.Post>>((await GetPostsAsync(new PostQueryOptions<long, Guid>(updatedPostIds))).Data, countUpdated);
                
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
