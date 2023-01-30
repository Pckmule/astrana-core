/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.System.Contracts;
using Astrana.Core.Domain.Models.UserAccounts.Constants;
using Astrana.Core.Domain.Models.UserAccounts.Contracts;
using Astrana.Core.Domain.Models.UserAccounts.Enums;
using Astrana.Core.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.UserAccounts
{
    public sealed class UserAccount : BaseDomainModel, IUserAccount, IEditableEntity<Guid>, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public UserAccount()
        {
            NameUnique = ModelProperties.UserAccount.NameUnique;
            NameSingularForm = ModelProperties.UserAccount.NameSingularForm;
            NamePluralForm = ModelProperties.UserAccount.NamePluralForm;
        }

        [Required]
        public Guid Id { get; set; }

        [Required]
        public UserAccountType Type { get; set; }

        [Required]
        [MinLength(ModelProperties.UserAccount.MinimumUsernameLength)]
        [MaxLength(ModelProperties.UserAccount.MaximumUsernameLength)]
        public string UserName { get; set; }

        public string NormalizedUserName => UserName.ToUpper();

        [Required]
        [EmailAddress]
        [MinLength(ModelProperties.UserAccount.MinimumEmailAddressLength)]
        [MaxLength(ModelProperties.UserAccount.MaximumEmailAddressLength)]
        public string EmailAddress { get; set; }

        public string NormalizedEmailAddress => EmailAddress.ToUpper();

        public bool IsEmailAddressConfirmed { get; set; }

        [DataType(DataType.Password)]
        [MinLength(ModelProperties.UserAccount.MinimumPasswordLength)]
        [MaxLength(ModelProperties.UserAccount.MaximumPasswordLength)]
        public string Password { get; set; }

        public string SecurityStamp { get; set; }

        public string ConcurrencyStamp { get; set; }

        [MinLength(ModelProperties.UserAccount.MinimumPhoneCountryCodeISOLength)]
        [MaxLength(ModelProperties.UserAccount.MaximumPhoneCountryCodeISOLength)]
        public string PhoneCountryCodeISO { get; set; }

        [Phone]
        [MinLength(ModelProperties.UserAccount.MinimumPhoneNumberLength)]
        [MaxLength(ModelProperties.UserAccount.MaximumPhoneNumberLength)]
        public string PhoneNumber { get; set; }

        public bool IsPhoneNumberConfirmed { get; set; }

        public bool IsTwoFactorEnabled { get; set; }

        public DateTimeOffset? LockoutEnd { get; set; }

        public bool IsLockoutEnabled { get; set; }

        public short FailedAccessCount { get; set; }

        public string TimeZone { get; set; }

        [Required]
        [MinLength(ModelProperties.UserAccount.MinimumCountryCodeLength)]
        [MaxLength(ModelProperties.UserAccount.MaximumCountryCodeLength)]
        public string CountryCode { get; set; }

        [Required]
        [MinLength(ModelProperties.UserAccount.MinimumLanguageCodeLength)]
        [MaxLength(ModelProperties.UserAccount.MaximumLanguageCodeLength)]
        public string LanguageCode { get; set; }

        public DateTimeOffset? LastLoginTimestamp { get; set; }

        [Required]
        public Guid CreatedBy { get; set; }

        [Required]
        public Guid LastModifiedBy { get; set; }

        [Required]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required]
        public DateTimeOffset LastModifiedTimestamp { get; set; }

        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string? DeactivatedReason { get; set; }

        public Guid? DeactivatedBy { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}