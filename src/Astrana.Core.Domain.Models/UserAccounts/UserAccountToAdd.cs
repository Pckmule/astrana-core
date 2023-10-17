/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.UserAccounts.Constants;
using Astrana.Core.Domain.Models.UserAccounts.Contracts;
using Astrana.Core.Domain.Models.UserAccounts.Enums;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using Astrana.Core.Framework.Model.Validation.Attributes;

namespace Astrana.Core.Domain.Models.UserAccounts
{
    public class UserAccountToAdd : DomainEntity, IUserAccountToAdd
    {
        public UserAccountToAdd()
        {
            NameUnique = ModelProperties.UserAccount.NameUnique;
            NameSingularForm = ModelProperties.UserAccount.NameSingularForm;
            NamePluralForm = ModelProperties.UserAccount.NamePluralForm;
        }

        [RequiredEnum]
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
        [MinLength(ModelProperties.UserAccount.MinimumLanguageCodeLength)]
        [MaxLength(ModelProperties.UserAccount.MaximumLanguageCodeLength)]
        public string LanguageCode { get; set; } = Core.Constants.Internationalization.DefaultLanguageTwoLetterCode;

        [Required]
        [MinLength(ModelProperties.UserAccount.MinimumCountryCodeLength)]
        [MaxLength(ModelProperties.UserAccount.MaximumCountryCodeLength)]
        public string CountryCode { get; set; } = Core.Constants.Internationalization.DefaultCountryTwoLetterCode;

        public DateTimeOffset? LastLoginTimestamp { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
