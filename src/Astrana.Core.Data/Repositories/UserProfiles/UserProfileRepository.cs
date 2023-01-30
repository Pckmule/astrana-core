/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.User;
using Astrana.Core.Data.Exceptions;
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

            var query = ctx.UserProfiles.Include(o => o.ProfilePicture).Include(o => o.CoverPicture).AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.Id));

            // Add Filters
            if (options.AccountIds.Any())
                query = query.Where(o => options.AccountIds.Contains(o.UserAccountId));

            if (options.CreatedBefore.HasValue)
                query = query.Where(o => o.CreatedTimestamp < options.CreatedBefore.Value);

            if (options.CreatedAfter.HasValue)
                query = query.Where(o => o.CreatedTimestamp > options.CreatedAfter.Value);

            // Add Ordering
            query = query.OrderByDescending(o => o.CreatedTimestamp);

            // Add Paging
            if (!options.PagingDisabled && options.PageSize.HasValue && options.CurrentPage.HasValue)
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

            var userProfiles = queryResults.Select(userProfile => ModelMapper.MapModel<DM.UserProfiles.UserProfile, UserProfile>(userProfile)).ToList();

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
            Guid newUserProfileId;

            var results = new Dictionary<string, List<ResultError>>();

            try
            {
                var now = DateTime.UtcNow;

                var newUserProfileEntity = ModelMapper.MapModel<UserProfile, IUserProfileToAdd>(requestedAddition);

                newUserProfileEntity.CreatedBy = actioningUserId;
                newUserProfileEntity.CreatedTimestamp = now;

                newUserProfileEntity.LastModifiedBy = actioningUserId;
                newUserProfileEntity.LastModifiedTimestamp = now;

                // Save records.
                ctx.UserProfiles.Add(newUserProfileEntity);
                await ctx.SaveChangesAsync();

                countAdded++;

                newUserProfileId = newUserProfileEntity.Id;
               
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
                    var existingUserProfileEntity = await ctx.UserProfiles.FirstOrDefaultAsync(o => o.Id == update.Id);

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
                    ctx.UserProfiles.Update(existingUserProfileEntity);

                    await ctx.SaveChangesAsync();

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

        public Task<IUpdateResult<List<Guid>>> DeactivateAsync(IEnumerable<Guid> validatedUserProfilesToDeactivateIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedUserProfilesToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
