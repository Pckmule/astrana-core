/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Attributes;
using Astrana.Core.Data.Constants;
using Astrana.Core.Data.Entities.User;
using Astrana.Core.Domain.Models.UserAccounts.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.UserAccounts.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Identity
{
    [Table("UserAccounts", Schema = SchemaNames.IdentityAccessManagement)]
    public class UserAccount: BaseDeactivatableEntity<Guid, Guid>
    {
        [PersonalData]
        public override Guid Id { get; set; }

        [ProtectedData]
        [PersonalData]
        [Column(Order = 1)]
        public virtual UserAccountType Type { get; set; }

        [ProtectedData]
        [PersonalData]
        [Column(Order = 2)]
        [MinLength(DomainModelProperties.UserAccount.MinimumUsernameLength)]
        [MaxLength(DomainModelProperties.UserAccount.MaximumUsernameLength)]
        public virtual string UserName { get; set; }

        [Column(Order = 3)]
        public virtual string NormalizedUserName { get; set; }

        [ProtectedData]
        [PersonalData]
        [Column(Order = 4)]
        [MinLength(DomainModelProperties.UserAccount.MinimumEmailAddressLength)]
        [MaxLength(DomainModelProperties.UserAccount.MaximumEmailAddressLength)]
        public virtual string EmailAddress { get; set; }

        [Column(Order = 5)]
        public virtual string NormalizedEmailAddress { get; set; }

        [PersonalData]
        [Column(Order = 6)]
        public virtual bool IsEmailAddressConfirmed { get; set; }

        [Column(Order = 7)]
        public virtual string PasswordHash { get; set; }

        [Column(Order = 8)]
        public virtual string PasswordSalt { get; set; }

        [Column(Order = 9)]
        public virtual string SecurityStamp { get; set; }

        [Column(Order = 10)]
        public virtual string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

        [ProtectedData]
        [PersonalData]
        [MaxLength(5)]
        [Column(Order = 11)]
        public virtual string PhoneCountryCodeISO { get; set; }

        [ProtectedData]
        [PersonalData]
        [Column(Order = 12)]
        [MinLength(DomainModelProperties.UserAccount.MinimumPhoneNumberLength)]
        [MaxLength(DomainModelProperties.UserAccount.MaximumPhoneNumberLength)]
        public virtual string PhoneNumber { get; set; }

        [PersonalData]
        [Column(Order = 13)]
        public virtual bool IsPhoneNumberConfirmed { get; set; }

        [PersonalData]
        [Column(Order = 14)]
        public virtual bool IsTwoFactorEnabled { get; set; }

        [Column(Order = 15)]
        public virtual DateTimeOffset? LockoutEnd { get; set; }

        [Column(Order = 16)]
        public virtual bool IsLockoutEnabled { get; set; }

        [Column(Order = 17)]
        public virtual short FailedAccessCount { get; set; }

        [Required]
        [Column(Order = 18)]
        public string TimeZone { get; set; } = TimeZoneInfo.Local.StandardName;

        [PersonalData]
        [Required]
        [MinLength(DomainModelProperties.UserAccount.MinimumLanguageCodeLength)]
        [MaxLength(DomainModelProperties.UserAccount.MaximumLanguageCodeLength)]
        [Column(Order = 19)]
        public string LanguageCode { get; set; }

        [PersonalData]
        [Required]
        [MinLength(DomainModelProperties.UserAccount.MinimumCountryCodeLength)]
        [MaxLength(DomainModelProperties.UserAccount.MaximumCountryCodeLength)]
        [Column(Order = 20)]
        public string CountryCode { get; set; }

        [Column(Order = 21)]
        public DateTimeOffset LastLoginTimestamp { get; set; }

        [Column(Order = 22)]
        public ICollection<UserAccountRoleRel> UserAccountRoles { get; set; } = new List<UserAccountRoleRel>();

        [Column(Order = 23)]
        public ICollection<UserEmailAddressRelationship> EmailAddresses { get; set; } = new List<UserEmailAddressRelationship>();

        [Column(Order = 24)]
        public ICollection<UserPhoneNumberRelationship> PhoneNumbers { get; set; } = new List<UserPhoneNumberRelationship>();

        [Column(Order = 25)]
        public ICollection<UserMessengerUsernameRelationship> MessengerUsernames { get; set; } = new List<UserMessengerUsernameRelationship>();
    }
}
