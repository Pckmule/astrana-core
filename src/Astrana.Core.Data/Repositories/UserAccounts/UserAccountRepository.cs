/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Constants;
using Astrana.Core.Data.Entities.Identity;
using Astrana.Core.Data.Exceptions;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Domain.Models.UserAccounts.Contracts;
using Astrana.Core.Domain.Models.UserAccounts.Enums;
using Astrana.Core.Domain.Models.UserAccounts.Options;
using Astrana.Core.Utilities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.Repositories.UserAccounts
{
    public class UserAccountRepository : BaseRepository<UserAccountRepository, Guid>, IUserAccountRepository<Guid>
    {
        public UserAccountRepository(ILogger<UserAccountRepository> logger, ApplicationDbContext context) : base(logger, context)
        {
        }

        /// <summary>
        /// Returns a User Account with the username and password.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="plainTextPassword"></param>
        /// <returns></returns>
        public async Task<DM.UserAccounts.UserAccount> GetUserAccountByCredentialsAsync(string username, string plainTextPassword)
        {
            var query = ctx.UserAccounts.Include(o => o.UserAccountRoles).AsQueryable();
            
            query = query.Where(o => o.UserName == username);

            var userAccount = await query.FirstOrDefaultAsync();

            if (userAccount == null)
                return null;

            var hashedPassword = new PasswordHasher(plainTextPassword, userAccount.PasswordSalt).HashString;

            if (userAccount.PasswordHash != hashedPassword)
                return null;

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(UserAccount)), username);

            return ModelMapper.MapModel<DM.UserAccounts.UserAccount, UserAccount>(userAccount);
        }

        /// <summary>
        /// Builds up an IQueryable according to the specified filter criteria.
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        private IQueryable<UserAccount> BuildQuery(UserAccountQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new UserAccountQueryOptions<Guid, Guid>();

            var query = ctx.UserAccounts.Include(o => o.UserAccountRoles).AsQueryable();

            // Add Filters
            if (options.Ids.Any())
                query = query.Where(o => options.Ids.Contains(o.Id));

            if (options.AccountTypes.Any())
                query = query.Where(o => options.AccountTypes.Contains(o.Type));

            if (options.Usernames.Any())
                query = query.Where(o => options.Usernames.Contains(o.UserName));

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
        /// Returns a count of User Accounts according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<ICountResult> GetUserAccountsCountAsync(UserAccountQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new UserAccountQueryOptions<Guid, Guid>();

            queryOptions.PagingDisabled = true;

            return new CountResult(await BuildQuery(queryOptions).CountAsync());
        }

        /// <summary>
        /// Returns a list of User Accounts according to the specified filter criteria.
        /// </summary>
        /// <param name="queryOptions"></param>
        /// <returns></returns>
        public async Task<IGetResult<DM.UserAccounts.UserAccount>> GetUserAccountsAsync(UserAccountQueryOptions<Guid, Guid>? queryOptions = null)
        {
            queryOptions ??= new UserAccountQueryOptions<Guid, Guid>();

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

            var userAccounts = queryResults.Select(userAccount => ModelMapper.MapModel<DM.UserAccounts.UserAccount, UserAccount>(userAccount)).ToList();

            logger.LogInformation(string.Format(MessageRetrievedEntity, nameof(UserAccount)), queryOptions);

            return CreateGetResultWithPagination(userAccounts, queryOptions, resultSetCount);
        }

        /// <summary>
        /// Finds and returns an User Account by it's ID.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public async Task<DM.UserAccounts.UserAccount?> GetUserAccountByIdAsync(Guid id)
        {
            return (await GetUserAccountsAsync(new UserAccountQueryOptions<Guid, Guid>(new List<Guid> { id }))).Data.FirstOrDefault();
        }

        /// <summary>
        /// Returns the instance User Account.
        /// </summary>
        /// <returns></returns>
        public async Task<DM.UserAccounts.UserAccount?> GetInstanceUserAccountAsync()
        {
            return (await GetUserAccountsAsync(new UserAccountQueryOptions<Guid, Guid>
            {
                AccountTypes = new List<UserAccountType> { UserAccountType.Instance }

            })).Data.FirstOrDefault();
        }

        /// <summary>
        /// Adds new User Accounts to the Data Source.
        /// </summary>
        /// <param name="requestedAdditions"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IAddResult<List<DM.UserAccounts.UserAccount>>> CreateAsync(IEnumerable<IUserAccountToAdd> requestedAdditions, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countAdded = 0;
            var newUserAccountIds = new List<Guid>();

            var results = new Dictionary<string, List<ResultError>>();

            try
            {
                var now = DateTime.UtcNow;

                var i = 0;
                foreach (var addition in requestedAdditions)
                {
                    i++;

                    results.Add($"{i}", new List<ResultError>());

                    if (ctx.UserAccounts.Any(o => o.Type == UserAccountType.Instance))
                        results[$"{i}"].Add(new ResultError(nameof(addition.UserName), "Only one instance account is allowed.", ErrorCodes.UniqueValueRequired));

                    if (ctx.UserAccounts.Any(o => o.UserName == addition.UserName))
                        results[$"{i}"].Add(new ResultError(nameof(addition.UserName), "User Name already in use.", ErrorCodes.UniqueValueRequired));

                    if (ctx.UserAccounts.Any(o => o.EmailAddress == addition.EmailAddress))
                        results[$"{i}"].Add(new ResultError(nameof(addition.EmailAddress), "Email Address already in use.", ErrorCodes.UniqueValueRequired));

                    if (!string.IsNullOrWhiteSpace(addition.PhoneNumber) && ctx.UserAccounts.Any(o => o.PhoneNumber == addition.PhoneNumber))
                        results[$"{i}"].Add(new ResultError(nameof(addition.PhoneNumber), "Phone number already in use.", ErrorCodes.UniqueValueRequired));

                    if(results[$"{i}"].Count > 0)
                        continue;

                    var newUserAccountEntity = ModelMapper.MapModel<UserAccount, IUserAccountToAdd>(addition);

                    var passwordHasher = new PasswordHasher(addition.Password);

                    newUserAccountEntity.PasswordHash = passwordHasher.HashString;
                    newUserAccountEntity.PasswordSalt = passwordHasher.SaltString;

                    if (newUserAccountEntity == null)
                        continue;

                    newUserAccountEntity.CreatedBy = actioningUserId;
                    newUserAccountEntity.CreatedTimestamp = now;

                    newUserAccountEntity.LastModifiedBy = actioningUserId;
                    newUserAccountEntity.LastModifiedTimestamp = now;

                    // Save records.
                    ctx.UserAccounts.Add(newUserAccountEntity);
                    await ctx.SaveChangesAsync();

                    countAdded++;

                    newUserAccountIds.Add(newUserAccountEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyCreatedEntity, newUserAccountIds.Count, nameof(UserAccount) + "(s)"));

                // Return the current records.
                if (returnRecords)
                {
                    if(results.Values.All(o => o.Count < 1))
                        return new AddSuccessResult<List<DM.UserAccounts.UserAccount>>((await GetUserAccountsAsync(new UserAccountQueryOptions<Guid, Guid> { Ids = newUserAccountIds })).Data, countAdded);

                    return new AddPartialSuccessResult<List<DM.UserAccounts.UserAccount>>((await GetUserAccountsAsync(new UserAccountQueryOptions<Guid, Guid> { Ids = newUserAccountIds })).Data, countAdded)
                    {
                        Errors = results.Values.SelectMany(x => x).ToList()
                    };
                }

                if (results.Values.Count < 1)
                    return new AddSuccessResult<List<DM.UserAccounts.UserAccount>>(new List<DM.UserAccounts.UserAccount>(), countAdded)
                    {
                        Errors = results.Values.SelectMany(x => x).ToList()
                    };
                
                return new AddSuccessResult<List<DM.UserAccounts.UserAccount>>(new List<DM.UserAccounts.UserAccount>(), countAdded);
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
        /// Updates existing User Accounts in the Data Source.
        /// </summary>
        /// <param name="requestedUpdates"></param>
        /// <param name="actioningUserId"></param>
        /// <param name="returnRecords"></param>
        /// <returns></returns>
        public async Task<IUpdateResult<List<DM.UserAccounts.UserAccount>>> UpdateAsync(IEnumerable<IUserAccount> requestedUpdates, Guid actioningUserId, bool returnRecords = true)
        {
            ValidateActioningUserId(actioningUserId);

            var countUpdated = 0;
            var updatedUserAccountIds = new List<Guid>();

            try
            {
                var now = DateTime.UtcNow;

                foreach (var update in requestedUpdates)
                {
                    var existingUserAccountEntity = await ctx.UserAccounts.FirstOrDefaultAsync(o => o.Id == update.Id);

                    if (existingUserAccountEntity == null)
                        continue;

                    // Update entity fields

                    existingUserAccountEntity.CountryCode = update.CountryCode.Trim();
                    existingUserAccountEntity.TimeZone = update.TimeZone;

                    existingUserAccountEntity.LastModifiedBy = actioningUserId;
                    existingUserAccountEntity.LastModifiedTimestamp = now;

                    // Save changes to records.
                    ctx.UserAccounts.Update(existingUserAccountEntity);

                    await ctx.SaveChangesAsync();

                    countUpdated++;

                    updatedUserAccountIds.Add(existingUserAccountEntity.Id);
                }

                logger.LogInformation(string.Format(MessageSuccessfullyUpdatedEntity, updatedUserAccountIds.Count, nameof(UserAccount) + "(s)"));

                // Return the current records.
                if (returnRecords)
                    return new UpdateSuccessResult<List<DM.UserAccounts.UserAccount>>((await GetUserAccountsAsync(new UserAccountQueryOptions<Guid, Guid>() { Ids = updatedUserAccountIds })).Data, countUpdated);

                return new UpdateSuccessResult<List<DM.UserAccounts.UserAccount>>(new List<DM.UserAccounts.UserAccount>(), countUpdated);
            }
            catch (Exception ex)
            {
                logger.LogError(ex, ex.Message);

                throw new CannotUpdateRecordsException(ex);
            }
        }

        public Task<IUpdateResult<string>> SetEmailAddressAsync(Guid userAccountId, string emailAddress, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateResult<bool>> SetEmailAddressConfirmedAsync(Guid userAccountId, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateResult<bool>> SetEmailAddressUnconfirmedAsync(Guid userAccountId, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateResult<string>> SetPhoneNumberAsync(Guid userAccountId, string phoneNumber, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateResult<bool>> SetPhoneNumberConfirmedAsync(Guid userAccountId, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateResult<bool>> SetPhoneNumberUnconfirmedAsync(Guid userAccountId, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateResult<string>> SetTimeZoneAsync(Guid userAccountId, string timeZoneId, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateResult<bool>> SetTwoFactorEnabledAsync(Guid userAccountId, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateResult<bool>> SetTwoFactorDisabledAsync(Guid userAccountId, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateResult<bool>> SetLockoutEnabledAsync(Guid userAccountId, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateResult<bool>> SetLockoutDisabledAsync(Guid userAccountId, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateResult<string>> SetLockoutEndAsync(Guid userAccountId, DateTimeOffset lockoutEnd, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateResult<short>> IncrementFailedAccessCountAsync(Guid userAccountId, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateResult<short>> ResetFailedAccessCountAsync(Guid userAccountId, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateResult<string>> SetLastLoginTimestampAsync(Guid userAccountId, DateTimeOffset lastLoginTimestamp, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateResult<string>> SetSecurityStampAsync(Guid userAccountId, string securityStamp, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateResult<string>> SetConcurrencyStampAsync(Guid userAccountId, string concurrencyStamp, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IUpdateResult<List<Guid>>> DeactivateAsync(IEnumerable<Guid> validatedUserAccountsToDeactivateIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }

        public Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedUserAccountsToRemoveIds, Guid actioningUserId)
        {
            throw new NotImplementedException();
        }
    }
}
