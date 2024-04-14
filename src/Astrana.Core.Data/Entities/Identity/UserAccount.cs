/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using Astrana.Core.Data.Entities.User;
using Astrana.Core.Domain.Models.UserAccounts.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astrana.Core.Attributes;
using DomainModelProperties = Astrana.Core.Domain.Models.UserAccounts.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Identity
{
    [Table("UserAccounts", Schema = SchemaNames.IdentityAccessManagement)]
    public class UserAccount
    {
        [PersonalData]
        [Key, Column(Order = 0)]
        public Guid UserAccountId { get; set; }

        [ProtectedData]
        [PersonalData]
        public virtual UserAccountType Type { get; set; }

        [ProtectedData]
        [PersonalData]
        [MinLength(DomainModelProperties.UserAccount.MinimumUsernameLength)]
        public virtual string UserName { get; set; }

        public virtual string NormalizedUserName { get; set; }

        [ProtectedData]
        [PersonalData]
        [MinLength(DomainModelProperties.UserAccount.MinimumEmailAddressLength)]
        public virtual string EmailAddress { get; set; }
        
        public virtual string NormalizedEmailAddress { get; set; }

        [PersonalData]
        public virtual bool IsEmailAddressConfirmed { get; set; }
        
        public virtual string PasswordHash { get; set; }
        
        public virtual string PasswordSalt { get; set; }
        
        public virtual string SecurityStamp { get; set; }
        
        public virtual string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

        [ProtectedData]
        [PersonalData]
        public virtual string PhoneCountryCodeISO { get; set; }

        [ProtectedData]
        [PersonalData]
        [MinLength(DomainModelProperties.UserAccount.MinimumPhoneNumberLength)]
        public virtual string PhoneNumber { get; set; }

        [PersonalData]
        public virtual bool IsPhoneNumberConfirmed { get; set; }

        [PersonalData]
        public virtual bool IsTwoFactorEnabled { get; set; }
        
        public virtual DateTimeOffset? LockoutEnd { get; set; }
        
        public virtual bool IsLockoutEnabled { get; set; }
        
        public virtual short FailedAccessCount { get; set; }
        
        public string TimeZone { get; set; } = TimeZoneInfo.Local.StandardName;

        [PersonalData]
        [MinLength(DomainModelProperties.UserAccount.MinimumLanguageCodeLength)]
        public string LanguageCode { get; set; }

        [PersonalData]
        [MinLength(DomainModelProperties.UserAccount.MinimumCountryCodeLength)]
        public string CountryCode { get; set; }
        
        public DateTimeOffset LastLoginTimestamp { get; set; }
        
        public ICollection<UserAccountRoleRel> UserAccountRoles { get; set; } = new List<UserAccountRoleRel>();
        
        public ICollection<UserEmailAddressRelationship> EmailAddresses { get; set; } = new List<UserEmailAddressRelationship>();
        
        public ICollection<UserPhoneNumberRelationship> PhoneNumbers { get; set; } = new List<UserPhoneNumberRelationship>();
        
        public ICollection<UserMessengerUsernameRelationship> MessengerUsernames { get; set; } = new List<UserMessengerUsernameRelationship>();
        
        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string DeactivatedReason { get; set; } = null;

        public Guid? DeactivatedBy { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
