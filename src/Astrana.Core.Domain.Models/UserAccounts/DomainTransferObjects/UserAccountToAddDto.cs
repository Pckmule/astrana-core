/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.UserAccounts.Enums;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.UserAccounts.DomainTransferObjects
{
    public sealed class UserAccountToAddDto : IDomainTransferObject
    {
        public UserAccountType? Type { get; set; }

        public string? UserName { get; set; }

        public string? NormalizedUserName { get; set; }

        public string? EmailAddress { get; set; }

        public string? NormalizedEmailAddress { get; set; }

        public bool? IsEmailAddressConfirmed { get; set; }

        public string? Password { get; set; }

        public string? PhoneCountryCodeISO { get; set; }

        public string? PhoneNumber { get; set; }

        public bool? IsPhoneNumberConfirmed { get; set; }
        
        public bool? IsTwoFactorEnabled { get; set; }

        public DateTimeOffset? LockoutEnd { get; set; }

        public bool? IsLockoutEnabled { get; set; }

        public short? FailedAccessCount { get; set; }

        public string? TimeZone { get; set; }

        public string? CountryCode { get; set; }

        public string? LanguageCode { get; set; }
    }
}