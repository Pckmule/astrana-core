/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.Links.Contracts;
using Astrana.Core.Domain.Models.Links.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.Links
{
    public class LinkRepository : BaseRepository<LinkRepository, Guid>, ILinkRepository<Guid>
    {
        public LinkRepository(ILogger<LinkRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<Link> BuildQuery(LinkQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new LinkQueryOptions<Guid, Guid>();

            var query = databaseSession.Links.AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.LinkId));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.LinkId));

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
        /// Returns a count of Links according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetLinksCountAsync(LinkQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new LinkQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of Links according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.Links.Link>> GetLinksAsync(LinkQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new LinkQueryOptions<Guid, Guid>();

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

            var links = queryResults.Select(link => ModelMapper.MapModel<DM.Links.Link, Link>(link)).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(Link)), queryOptions);

            return CreateGetResultWithPagination(links, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns a Link by it's Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.Links.Link?> GetLinkByIdAsync(Guid id)
        {
            return (await GetLinksAsync(new LinkQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Adds new Links to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.Links.Link>>> CreateAsync(IEnumerable<DM.Links.Link> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newLinkIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newLinkEntity = ModelMapper.MapModel<Link, DM.Links.Link>(addition);

                    if (newLinkEntity == null)
                        continue;

                    newLinkEntity.PreviewImageId = newLinkEntity.PreviewImage.ImageId;
                    newLinkEntity.PreviewImage = null;


                    newLinkEntity.CreatedBy = actioningUserId;
                    newLinkEntity.CreatedTimestamp = now;

                    newLinkEntity.LastModifiedBy = actioningUserId;
                    newLinkEntity.LastModifiedTimestamp = now;

                    // Save records.
                    databaseSession.Links.Add(newLinkEntity);
                    await databaseSession.SaveChangesAsync();

                    countAdded++;

                    newLinkIds.Add(newLinkEntity.LinkId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newLinkIds.Count, nameof(Link) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.Links.Link>>((await GetLinksAsync(new LinkQueryOptions<Guid, Guid> { Ids = newLinkIds })).Data, countAdded);
                
                return new AddSuccessResult<List<DM.Links.Link>>(new List<DM.Links.Link>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing Links in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.Links.Link>>> UpdateAsync(IEnumerable<ILink> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedLinkIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingLinkEntity = await databaseSession.Links.FirstOrDefaultAsync(o => o.LinkId == update.LinkId);

                    if (existingLinkEntity == null)
                        continue;

                    // Update entity fields

                    existingLinkEntity.Title = update.Title.Trim();

                    existingLinkEntity.LastModifiedBy = actioningUserId;
                    existingLinkEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    databaseSession.Links.Update(existingLinkEntity);

                    await databaseSession.SaveChangesAsync();

                    countUpdated++;

                    updatedLinkIds.Add(existingLinkEntity.LinkId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedLinkIds.Count, nameof(Link) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.Links.Link>>((await GetLinksAsync(new LinkQueryOptions<Guid, Guid>() { Ids = updatedLinkIds })).Data, countUpdated);
                
                return new UpdateSuccessResult<List<DM.Links.Link>>(new List<DM.Links.Link>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedLinksToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
