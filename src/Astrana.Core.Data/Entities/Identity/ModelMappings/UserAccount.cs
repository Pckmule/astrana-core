/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using UserAccountDataEntity = Astrana.Core.Data.Entities.Identity.UserAccount;
using UserAccountDomainEntity = Astrana.Core.Domain.Models.UserAccounts.UserAccount;

namespace Astrana.Core.Data.Entities.Identity.ModelMappings
{
    public static class UserAccount
    {
        public static UserAccountDomainEntity MapToDomainModel(UserAccountDataEntity userAccountDataEntity)
        {
            var domainModel = new UserAccountDomainEntity
            {
                UserAccountId = userAccountDataEntity.UserAccountId,

                Type = userAccountDataEntity.Type,

                UserName = userAccountDataEntity.UserName,

                EmailAddress = userAccountDataEntity.EmailAddress,
                IsEmailAddressConfirmed = userAccountDataEntity.IsEmailAddressConfirmed,
                
                PhoneCountryCodeISO = userAccountDataEntity.PhoneCountryCodeISO,
                PhoneNumber = userAccountDataEntity.PhoneNumber,
                IsPhoneNumberConfirmed = userAccountDataEntity.IsPhoneNumberConfirmed,

                LanguageCode = userAccountDataEntity.LanguageCode,
                CountryCode = userAccountDataEntity.CountryCode,
                TimeZone = userAccountDataEntity.TimeZone,

                IsLockoutEnabled = userAccountDataEntity.IsLockoutEnabled,
                LockoutEnd = userAccountDataEntity.LockoutEnd,
                FailedAccessCount = userAccountDataEntity.FailedAccessCount,

                IsTwoFactorEnabled = userAccountDataEntity.IsTwoFactorEnabled,

                SecurityStamp = userAccountDataEntity.SecurityStamp,
                ConcurrencyStamp = userAccountDataEntity.ConcurrencyStamp,
                
                LastLoginTimestamp = userAccountDataEntity.LastLoginTimestamp,
                
                DeactivatedReason = userAccountDataEntity.DeactivatedReason,
                DeactivatedBy = userAccountDataEntity.DeactivatedBy,
                DeactivatedTimestamp = userAccountDataEntity.DeactivatedTimestamp,

                CreatedBy = userAccountDataEntity.CreatedBy,
                CreatedTimestamp = userAccountDataEntity.CreatedTimestamp,

                LastModifiedBy = userAccountDataEntity.LastModifiedBy,
                LastModifiedTimestamp = userAccountDataEntity.LastModifiedTimestamp
            };

            return domainModel;
        }
    }
}
