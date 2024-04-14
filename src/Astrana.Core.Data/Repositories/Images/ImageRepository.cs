/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.Images.Contracts;
using Astrana.Core.Domain.Models.Images.Options;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.Images
{
    public class ImageRepository : BaseRepository<ImageRepository, Guid>, IImageRepository<Guid>
    {
        public ImageRepository(ILogger<ImageRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<Image> BuildQuery(ImageQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new ImageQueryOptions<Guid, Guid>();

            var query = databaseSession.Images.AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.ImageId));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.ImageId));

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
        /// Returns a count of Images according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetImagesCountAsync(ImageQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new ImageQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of Images according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.Images.Image>> GetImagesAsync(ImageQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new ImageQueryOptions<Guid, Guid>();

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

            var images = queryResults.Select(Entities.Content.ModelMappings.Image.MapToDomainModel).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(Image)), queryOptions);

            return CreateGetResultWithPagination(images, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns a Image by it's Id.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.Images.Image?> GetImageByIdAsync(Guid id)
        {
            return (await GetImagesAsync(new ImageQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }
        
        /// <summary>
        /// Adds new Images to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.Images.Image>>> CreateAsync(IEnumerable<IImageToAdd> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newImageIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newImageEntity = ModelMapper.MapModel<Image, IImageToAdd>(addition);
                    
                    newImageEntity.CreatedBy = actioningUserId;
                    newImageEntity.CreatedTimestamp = now;

                    newImageEntity.LastModifiedBy = actioningUserId;
                    newImageEntity.LastModifiedTimestamp = now;

                    // Save records.
                    databaseSession.Images.Add(newImageEntity);
                    await databaseSession.SaveChangesAsync();

                    countAdded++;

                    newImageIds.Add(newImageEntity.ImageId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newImageIds.Count, nameof(Image) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.Images.Image>>((await GetImagesAsync(new ImageQueryOptions<Guid, Guid>(newImageIds))).Data, countAdded);

                return new AddSuccessResult<List<DM.Images.Image>>(new List<DM.Images.Image>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing Images in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.Images.Image>>> UpdateAsync(IEnumerable<DM.Images.Image> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedImageIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingImageEntity = await databaseSession.Images.FirstOrDefaultAsync(o => o.ImageId == update.ImageId);

                    if (existingImageEntity == null)
                        continue;

                    // Update entity fields

                    existingImageEntity.LastModifiedBy = actioningUserId;
                    existingImageEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    databaseSession.Images.Update(existingImageEntity);

                    await databaseSession.SaveChangesAsync();

                    countUpdated++;

                    updatedImageIds.Add(existingImageEntity.ImageId);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedImageIds.Count, nameof(Image) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.Images.Image>>((await GetImagesAsync(new ImageQueryOptions<Guid, Guid>(updatedImageIds))).Data, countUpdated);

                return new UpdateSuccessResult<List<DM.Images.Image>>(new List<DM.Images.Image>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedImagesToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
