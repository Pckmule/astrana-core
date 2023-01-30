/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Domain.Models.UserAccounts;
using Astrana.Core.Domain.Models.UserAccounts.Contracts;
using Astrana.Core.Domain.Models.UserAccounts.Options;

namespace Astrana.Core.Data.Repositories.UserAccounts
{
    public interface IUserAccountRepository<TUserId> where TUserId : struct
    {
        Task<UserAccount> GetUserAccountByCredentialsAsync(string username, string plainTextPassword);

        Task<ICountResult> GetUserAccountsCountAsync(UserAccountQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<UserAccount>> GetUserAccountsAsync(UserAccountQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<UserAccount> GetUserAccountByIdAsync(TUserId id);

        Task<UserAccount> GetInstanceUserAccountAsync();

        Task<IAddResult<List<UserAccount>>> CreateAsync(IEnumerable<IUserAccountToAdd> requestedAdditions, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<List<UserAccount>>> UpdateAsync(IEnumerable<IUserAccount> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);

        Task<IUpdateResult<string>> SetEmailAddressAsync(TUserId userAccountId, string emailAddress, TUserId actioningUserId);

        Task<IUpdateResult<bool>> SetEmailAddressConfirmedAsync(TUserId userAccountId, TUserId actioningUserId);

        Task<IUpdateResult<bool>> SetEmailAddressUnconfirmedAsync(TUserId userAccountId, TUserId actioningUserId);

        Task<IUpdateResult<string>> SetPhoneNumberAsync(TUserId userAccountId, string phoneNumber, TUserId actioningUserId);

        Task<IUpdateResult<bool>> SetPhoneNumberConfirmedAsync(TUserId userAccountId, TUserId actioningUserId);

        Task<IUpdateResult<bool>> SetPhoneNumberUnconfirmedAsync(TUserId userAccountId, TUserId actioningUserId);

        Task<IUpdateResult<string>> SetTimeZoneAsync(TUserId userAccountId, string timeZoneId, TUserId actioningUserId);

        Task<IUpdateResult<bool>> SetTwoFactorEnabledAsync(TUserId userAccountId, TUserId actioningUserId);

        Task<IUpdateResult<bool>> SetTwoFactorDisabledAsync(TUserId userAccountId, TUserId actioningUserId);

        Task<IUpdateResult<bool>> SetLockoutEnabledAsync(TUserId userAccountId, TUserId actioningUserId);

        Task<IUpdateResult<bool>> SetLockoutDisabledAsync(TUserId userAccountId, TUserId actioningUserId);

        Task<IUpdateResult<string>> SetLockoutEndAsync(TUserId userAccountId, DateTimeOffset lockoutEnd, TUserId actioningUserId);

        Task<IUpdateResult<short>> IncrementFailedAccessCountAsync(TUserId userAccountId, TUserId actioningUserId);

        Task<IUpdateResult<short>> ResetFailedAccessCountAsync(TUserId userAccountId, TUserId actioningUserId);

        Task<IUpdateResult<string>> SetLastLoginTimestampAsync(TUserId userAccountId, DateTimeOffset lastLoginTimestamp, TUserId actioningUserId);

        Task<IUpdateResult<string>> SetSecurityStampAsync(TUserId userAccountId, string securityStamp, TUserId actioningUserId);

        Task<IUpdateResult<string>> SetConcurrencyStampAsync(TUserId userAccountId, string concurrencyStamp, TUserId actioningUserId);

        Task<IUpdateResult<List<Guid>>> DeactivateAsync(IEnumerable<Guid> validatedUserAccountsToDeactivateIds, Guid actioningUserId);

        Task<IDeleteResult<List<Guid>>> DeleteAsync(IEnumerable<Guid> validatedUserAccountsToRemoveIds, Guid actioningUserId);
    }
}
