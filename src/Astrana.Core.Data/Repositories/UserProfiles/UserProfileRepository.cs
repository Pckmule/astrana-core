/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Entities.User;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.ContentCollections.Enums;
using Astrana.Core.Domain.Models.Links.Contracts;
using Astrana.Core.Domain.Models.Media.Enums;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Domain.Models.UserProfiles.Contracts;
using Astrana.Core.Domain.Models.UserProfiles.Options;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.UserProfiles
{
    public class UserProfileRepository : BaseRepository<UserProfileRepository, Guid>, IUserProfileRepository<Guid>
    {
        public UserProfileRepository(ILogger<UserProfileRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<UserProfile> BuildQuery(UserProfileQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new UserProfileQueryOptions<Guid, Guid>();

            var query = databaseSession.UserProfiles
                .Include(o => o.ProfilePicturesCollection)
                .ThenInclude(o => o.ContentCollectionItems)
                .Include(o => o.ProfilePicturesCollection)
                .ThenInclude(o => o.ContentCollectionItems)
                .ThenInclude(o => o.Image)
                .Include(o => o.CoverPicturesCollection)
                .ThenInclude(o => o.ContentCollectionItems)
                .Include(o => o.CoverPicturesCollection)
                .ThenInclude(o => o.ContentCollectionItems)
                .ThenInclude(o => o.Image)
                .AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.Id));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.Id));
            
            if (options.AccountIds.Any())
                query = query.Where(o => options.AccountIds.Contains(o.UserAccountId));

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
        /// Returns a count of User Profiles according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetUserProfilesCountAsync(UserProfileQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new UserProfileQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of User Profiles according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.UserProfiles.UserProfile>> GetUserProfilesAsync(UserProfileQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new UserProfileQueryOptions<Guid, Guid>();

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

            var userProfiles = queryResults.Select(Entities.User.ModelMappings.UserProfile.MapToDomainModel).ToList();

            foreach (var userProfile in userProfiles)
            {
                if(userProfile == null)
                    continue;

                if (userProfile.ProfilePicturesCollection != null && userProfile.ProfilePicturesCollection.ContentItems != null)
                    userProfile.ProfilePicturesCollection.ContentItems = userProfile.ProfilePicturesCollection.ContentItems.OrderByDescending(o => o.CreatedTimestamp).ToList();

                if (userProfile.CoverPicturesCollection != null && userProfile.CoverPicturesCollection.ContentItems != null)
                    userProfile.CoverPicturesCollection.ContentItems = userProfile.CoverPicturesCollection.ContentItems.OrderByDescending(o => o.CreatedTimestamp).ToList();
            }

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(UserProfile)), queryOptions);

            return CreateGetResultWithPagination(userProfiles, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns an User Profile by it's ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.UserProfiles.UserProfile?> GetUserProfileByIdAsync(Guid id)
        {
            return (await GetUserProfilesAsync(new UserProfileQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Finds and returns an User Profile by it's User Account ID.
        /// </summary>
        /// <param name="userAccountId"></param>
        /// <returns></returns>
        public async Task<DM.UserProfiles.UserProfile?> GetUserProfileByUserAccountIdAsync(Guid userAccountId)
        {
            return (await GetUserProfilesAsync(new UserProfileQueryOptions<Guid, Guid>
            {
                AccountIds = new List<Guid> { userAccountId }

            })).Data.FirstOrDefault();
        }

        /// <summary>
        /// Adds new User Profiles to the Data Source.
        /// </summary>
        /// <param name="requestedAddition"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<DM.UserProfiles.UserProfile>> CreateAsync(IUserProfileToAdd requestedAddition, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;

            var results = new Dictionary<string, List<ResultError>>();

            try
            {
                var now = DateTime.UtcNow;

                var newUserProfileEntity = ModelMapper.MapModel<UserProfile, IUserProfileToAdd>(requestedAddition);

                newUserProfileEntity.ProfilePicturesCollection = new ContentCollection
                {
                    Name = "Profile Pictures"
                };

                newUserProfileEntity.CoverPicturesCollection = new ContentCollection
                {
                    Name = "Profile Cover Pictures"
                };

                newUserProfileEntity.CreatedBy = actioningUserId;
                newUserProfileEntity.CreatedTimestamp = now;

                newUserProfileEntity.LastModifiedBy = actioningUserId;
                newUserProfileEntity.LastModifiedTimestamp = now;

                // Save records.
                databaseSession.UserProfiles.Add(newUserProfileEntity);
                await databaseSession.SaveChangesAsync();

                countAdded++;

                var newUserProfileId = newUserProfileEntity.Id;
               
                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, 1, nameof(UserProfile) + "(s)"));

                // Return the current records.
                if (returnRecords)
                {
                    if (results.Values.All(o => o.Count < 1))
                        return new AddSuccessResult<DM.UserProfiles.UserProfile>(await GetUserProfileByIdAsync(newUserProfileId), countAdded);

                    return new AddPartialSuccessResult<DM.UserProfiles.UserProfile>(await GetUserProfileByIdAsync(newUserProfileId), countAdded)
                    {
                        Errors = results.Values.SelectMany(x => x).ToList()
                    };
                }

                if (results.Values.Count < 1)
                    return new AddSuccessResult<DM.UserProfiles.UserProfile>(null, countAdded)
                    {
                        Errors = results.Values.SelectMany(x => x).ToList()
                    };

                return new AddSuccessResult<DM.UserProfiles.UserProfile>(null, countAdded);
            }
            catch (DbUpdateException ex)
            {
                if (ex.InnerException?.GetType() == typeof(Microsoft.Data.SqlClient.SqlException))
                {
                    logger.LogError(ex, ex.InnerException.Message);

                    throw new CannotCreateRecordsException(ex, ex.InnerException.Message);
                }

                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing User Profiles in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.UserProfiles.UserProfile>>> UpdateAsync(IEnumerable<DM.UserProfiles.UserProfile> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedUserProfileIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingUserProfileEntity = await databaseSession.UserProfiles.FirstOrDefaultAsync(o => o.Id == update.ProfileId);

                    if (existingUserProfileEntity == null)
                        continue;

                    // Update entity fields

                    existingUserProfileEntity.FirstName = update.FirstName.Trim();
                    existingUserProfileEntity.MiddleNames = update.MiddleNames.Trim();
                    existingUserProfileEntity.LastName = update.LastName.Trim();

                    existingUserProfileEntity.DateOfBirth = update.DateOfBirth;

                    existingUserProfileEntity.Introduction = update.Introduction.Trim();

                    existingUserProfileEntity.LastModifiedBy = actioningUserId;
                    existingUserProfileEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    databaseSession.UserProfiles.Update(existingUserProfileEntity);

                    await databaseSession.SaveChangesAsync();

                    countUpdated++;

                    updatedUserProfileIds.Add(existingUserProfileEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedUserProfileIds.Count, nameof(UserProfile) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.UserProfiles.UserProfile>>((await GetUserProfilesAsync(new UserProfileQueryOptions<Guid, Guid> { Ids = updatedUserProfileIds })).Data, countUpdated);

                return new UpdateSuccessResult<List<DM.UserProfiles.UserProfile>>(new List<DM.UserProfiles.UserProfile>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }
        
        /// <summary>
        /// Updates the introduction for an existing User Profile by User Profile ID.
        /// </summary>
        /// <param name="userProfileId"></param>
        /// <param name="updatedUserProfileIntroduction"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<DM.UserProfiles.UserProfile>> UpdateProfileIntroductionAsync(Guid userProfileId,  string updatedUserProfileIntroduction, Guid actioningUserId, bool returnRecords = false)
        {
            ValidateActioningUserId(actioningUserId);

            if(userProfileId.Equals(Guid.Empty))
                return new UpdateFailResult<DM.UserProfiles.UserProfile>(null, 0, "Profile ID is invalid.");

            var countUpdated = 0;
            var updatedUserProfileIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                var existingUserProfileEntity = await databaseSession.UserProfiles.FirstOrDefaultAsync(o => o.Id == userProfileId);

                if (existingUserProfileEntity == null)
                    return new UpdateFailResult<DM.UserProfiles.UserProfile>(null, countUpdated, "Profile ID is invalid.");

                // Update entity fields
                existingUserProfileEntity.Introduction = updatedUserProfileIntroduction.Trim();

                existingUserProfileEntity.LastModifiedBy = actioningUserId;
                existingUserProfileEntity.LastModifiedTimestamp = now;

                // Save changes to records.
                databaseSession.UserProfiles.Update(existingUserProfileEntity);

                await databaseSession.SaveChangesAsync();

                countUpdated++;

                updatedUserProfileIds.Add(existingUserProfileEntity.Id);

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedUserProfileIds.Count, nameof(UserProfile) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<DM.UserProfiles.UserProfile>(await GetUserProfileByIdAsync(userProfileId), countUpdated);

                return new UpdateSuccessResult<DM.UserProfiles.UserProfile>(null, countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates the User Profile Picture by User Profile ID.
        /// </summary>
        /// <param name="userProfileId"></param>
        /// <param name="imageId"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        /// <exception cref="CannotUpdateRecordsException"></exception>
        public async Task<IUpdateResult<DM.UserProfiles.UserProfile>> UpdateProfilePictureAsync(Guid userProfileId, Guid imageId, Guid actioningUserId, bool returnRecords = false)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedUserProfileIds = new List<Guid>();

            try
            {
                var existingUserProfileEntity = await databaseSession.UserProfiles.FirstOrDefaultAsync(o => o.Id == userProfileId);
                
                if(existingUserProfileEntity == null)
                    return new UpdateFailResult<DM.UserProfiles.UserProfile>(null, countUpdated, "User Profile Not Found");
                
                var imageEntity = await databaseSession.Images.FirstOrDefaultAsync(o => o.ImageId == imageId);

                if (imageEntity == null)
                    return new UpdateFailResult<DM.UserProfiles.UserProfile>(null, countUpdated, "Image Not Found");
                
                var profilePictureContentCollectionEntity = await databaseSession.ContentCollections.FirstOrDefaultAsync(o => o.ContentCollectionId == existingUserProfileEntity.ProfilePicturesCollection.ContentCollectionId);

                if (profilePictureContentCollectionEntity == null)
                    return new UpdateFailResult<DM.UserProfiles.UserProfile>(null, countUpdated, "Profile Picture Collection Not Found");

                databaseSession.ContentCollections.First(o => o.ContentCollectionId == existingUserProfileEntity.ProfilePicturesCollection.ContentCollectionId).ContentCollectionItems.Add(new ContentCollectionItem
                {
                    MediaType = MediaType.Image,
                    ImageId = imageEntity.ImageId,

                    CreatedBy = actioningUserId,
                    LastModifiedBy = actioningUserId
                });
                
                await databaseSession.SaveChangesAsync();

                countUpdated++;

                updatedUserProfileIds.Add(existingUserProfileEntity.Id);

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedUserProfileIds.Count, nameof(UserProfile) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<DM.UserProfiles.UserProfile>(await GetUserProfileByIdAsync(userProfileId), countUpdated);

                return new UpdateSuccessResult<DM.UserProfiles.UserProfile>(null, countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates the User Profile Cover Picture by User Profile ID.
        /// </summary>
        /// <param name="userProfileId"></param>
        /// <param name="imageId"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        /// <exception cref="CannotUpdateRecordsException"></exception>
        public async Task<IUpdateResult<DM.UserProfiles.UserProfile>> UpdateCoverPictureAsync(Guid userProfileId, Guid imageId, Guid actioningUserId, bool returnRecords = false)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedUserProfileIds = new List<Guid>();

            try
            {
                var existingUserProfileEntity = await databaseSession.UserProfiles.FirstOrDefaultAsync(o => o.Id == userProfileId);

                if (existingUserProfileEntity == null)
                    return new UpdateFailResult<DM.UserProfiles.UserProfile>(null, countUpdated, "User Profile Not Found");

                var imageEntity = await databaseSession.Images.FirstOrDefaultAsync(o => o.ImageId == imageId);

                if (imageEntity == null)
                    return new UpdateFailResult<DM.UserProfiles.UserProfile>(null, countUpdated, "Image Not Found");

                var profileCoverPictureContentCollectionEntity = await databaseSession.ContentCollections.FirstOrDefaultAsync(o => o.ContentCollectionId == existingUserProfileEntity.CoverPicturesCollection.ContentCollectionId);

                if (profileCoverPictureContentCollectionEntity == null)
                    return new UpdateFailResult<DM.UserProfiles.UserProfile>(null, countUpdated, "Profile Cover Picture Collection Not Found");

                databaseSession.ContentCollections.First(o => o.ContentCollectionId == existingUserProfileEntity.CoverPicturesCollection.ContentCollectionId).ContentCollectionItems.Add(new ContentCollectionItem
                {
                    MediaType = MediaType.Image,
                    ImageId = imageEntity.ImageId,

                    CreatedBy = actioningUserId,
                    LastModifiedBy = actioningUserId
                });

                await databaseSession.SaveChangesAsync();

                countUpdated++;

                updatedUserProfileIds.Add(existingUserProfileEntity.Id);

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedUserProfileIds.Count, nameof(UserProfile) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<DM.UserProfiles.UserProfile>(await GetUserProfileByIdAsync(userProfileId), countUpdated);

                return new UpdateSuccessResult<DM.UserProfiles.UserProfile>(null, countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IUpdateResult<List<Guid>>> DeactivateAsync(IEnumerable<Guid> validatedUserProfilesToDeactivateIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedUserProfilesToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }



        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<UserProfileDetail> BuildUserProfileDetailsQuery(UserProfileDetailQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new UserProfileDetailQueryOptions<Guid, Guid>();

            var query = databaseSession.UserProfileDetails.AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.Id));

            if (options.ExcludeIds.Any())
                query = query.Where(o => !options.ExcludeIds.Contains(o.Id));

            if (options.Labels.Any())
                query = query.Where(o => options.Labels.Contains(o.Label));

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
        /// Returns a count of User Profile Details according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetUserProfileDetailsCountAsync(UserProfileDetailQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new UserProfileDetailQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildUserProfileDetailsQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of User Profile Details according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.UserProfiles.UserProfileDetail>> GetUserProfileDetailsAsync(UserProfileDetailQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new UserProfileDetailQueryOptions<Guid, Guid>();

            var queryResults = await BuildUserProfileDetailsQuery(queryOptions).ToListAsync();

            int resultSetCount;
            if (queryOptions.PagingDisabled)
            {
                var countResultSetQueryOptions = queryOptions.Clone();
                countResultSetQueryOptions.PagingDisabled = true;

                resultSetCount = await BuildUserProfileDetailsQuery(queryOptions).CountAsync();
            }
            else
                resultSetCount = queryResults.Count;

            var userProfiles = queryResults.Select(userProfileDetail => ModelMapper.MapModel<DM.UserProfiles.UserProfileDetail, UserProfileDetail>(userProfileDetail)).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(UserProfileDetail)), queryOptions);

            return CreateGetResultWithPagination(userProfiles, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns an User Profile Detail by it's ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.UserProfiles.UserProfileDetail?> GetUserProfileDetailByIdAsync(Guid id)
        {
            return (await GetUserProfileDetailsAsync(new UserProfileDetailQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Adds new User Profile Details to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.UserProfiles.UserProfileDetail>>> CreateProfileDetailsAsync(IEnumerable<IUserProfileDetailToAdd> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newUserProfileDetailIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var addition in requestedAdditions)
                {
                    var newUserProfileDetailEntity = ModelMapper.MapModel<UserProfileDetail, IUserProfileDetailToAdd>(addition);

                    if (newUserProfileDetailEntity == null)
                        continue;

                    newUserProfileDetailEntity.CreatedBy = actioningUserId;
                    newUserProfileDetailEntity.CreatedTimestamp = now;

                    newUserProfileDetailEntity.LastModifiedBy = actioningUserId;
                    newUserProfileDetailEntity.LastModifiedTimestamp = now;

                    // Save records.
                    databaseSession.UserProfileDetails.Add(newUserProfileDetailEntity);
                    await databaseSession.SaveChangesAsync();

                    countAdded++;

                    newUserProfileDetailIds.Add(newUserProfileDetailEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newUserProfileDetailIds.Count, nameof(UserProfileDetail) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new AddSuccessResult<List<DM.UserProfiles.UserProfileDetail>>((await GetUserProfileDetailsAsync(new UserProfileDetailQueryOptions<Guid, Guid> { Ids = newUserProfileDetailIds })).Data, countAdded);

                return new AddSuccessResult<List<DM.UserProfiles.UserProfileDetail>>(new List<DM.UserProfiles.UserProfileDetail>(), countAdded);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotCreateRecordsException(ex);
            }
        }

        /// <summary>
        /// Updates existing User Profile Details in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.UserProfiles.UserProfileDetail>>> UpdateProfileDetailsAsync(IEnumerable<DM.UserProfiles.UserProfileDetail> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedUserProfileDetailIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingUserProfileDetailEntity = await databaseSession.UserProfileDetails.FirstOrDefaultAsync(o => o.Id == update.UserProfileDetailId);

                    if (existingUserProfileDetailEntity == null)
                        continue;

                    // Update entity fields

                    existingUserProfileDetailEntity.Label = update.Label.Trim();
                    existingUserProfileDetailEntity.Value = update.Value.Trim();
                    existingUserProfileDetailEntity.IconName = update.IconName.Trim();

                    existingUserProfileDetailEntity.LastModifiedBy = actioningUserId;
                    existingUserProfileDetailEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    databaseSession.UserProfileDetails.Update(existingUserProfileDetailEntity);

                    await databaseSession.SaveChangesAsync();

                    countUpdated++;

                    updatedUserProfileDetailIds.Add(existingUserProfileDetailEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedUserProfileDetailIds.Count, nameof(UserProfile) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.UserProfiles.UserProfileDetail>>((await GetUserProfileDetailsAsync(new UserProfileDetailQueryOptions<Guid, Guid> { Ids = updatedUserProfileDetailIds })).Data, countUpdated);

                return new UpdateSuccessResult<List<DM.UserProfiles.UserProfileDetail>>(new List<DM.UserProfiles.UserProfileDetail>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IDeleteResult<List<Guid>>> DeleteProfileDetailsAsync(IEnumerable<Guid> validatedUserProfileDetailsToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
