/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.UserAccounts.Enums;

namespace Astrana.Core.Domain.Models.UserAccounts.Contracts
{
    public interface IUserAccount
    {
        Guid UserAccountId { get; set; }

        UserAccountType Type { get; set; }

        string UserName { get; set; }

        string NormalizedUserName { get; }

        string EmailAddress { get; set; }

        string NormalizedEmailAddress { get; }

        bool IsEmailAddressConfirmed { get; set; }

        string Password { get; set; }

        string SecurityStamp { get; set; }

        string ConcurrencyStamp { get; set; }

        string PhoneCountryCodeISO { get; set; }

        string PhoneNumber { get; set; }

        bool IsPhoneNumberConfirmed { get; set; }

        bool IsTwoFactorEnabled { get; set; }

        DateTimeOffset? LockoutEnd { get; set; }

        bool IsLockoutEnabled { get; set; }

        short FailedAccessCount { get; set; }

        string TimeZone { get; set; }

        string LanguageCode { get; set; }

        string CountryCode { get; set; }

        DateTimeOffset? LastLoginTimestamp { get; set; }
    }
}
