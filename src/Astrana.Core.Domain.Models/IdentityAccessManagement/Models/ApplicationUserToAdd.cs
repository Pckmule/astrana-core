using Astrana.Core.Attributes;
using Astrana.Core.Domain.Models.IdentityAccessManagement.Constants;
using Astrana.Core.Domain.Models.UserAccounts.Enums;
using Astrana.Core.Domain.Models.UserProfiles.Enums;
using System.ComponentModel.DataAnnotations;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;

namespace Astrana.Core.Domain.Models.IdentityAccessManagement.Models
{
    public sealed class ApplicationUserToAdd : DomainEntity
    {
        public ApplicationUserToAdd()
        {
            NameUnique = ModelProperties.ApplicationUser.NameUnique;
            NameSingularForm = ModelProperties.ApplicationUser.NameSingularForm;
            NamePluralForm = ModelProperties.ApplicationUser.NamePluralForm;
        }

        [Required]
        public UserAccountType Type { get; set; }

        [Required]
        [MinLength(ModelProperties.ApplicationUser.MinimumUsernameLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumUsernameLength)]
        public string UserName { get; set; }

        [Required]
        [MinLength(Core.Constants.Idp.MinimumPasswordLength)]
        [MaxLength(Core.Constants.Idp.MaximumPasswordLength)]
        public string Password { get; set; }
        
        [Required]
        [EmailAddress]
        [MinLength(ModelProperties.ApplicationUser.MinimumEmailAddressLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumEmailAddressLength)]
        public string EmailAddress { get; set; }

        [MinLength(ModelProperties.ApplicationUser.MinimumPhoneCountryCodeISOLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumPhoneCountryCodeISOLength)]
        public string PhoneCountryCodeISO { get; set; }

        [Phone]
        [MinLength(ModelProperties.ApplicationUser.MinimumPhoneNumberLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumPhoneNumberLength)]
        public string PhoneNumber { get; set; }

        [Required]
        [MinLength(ModelProperties.ApplicationUser.MinimumCountryCodeLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumCountryCodeLength)]
        public string CountryCode { get; set; } = Core.Constants.Internationalization.DefaultCountryTwoLetterCode;

        [Required]
        [MinLength(ModelProperties.ApplicationUser.MinimumLanguageCodeLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumLanguageCodeLength)]
        public string LanguageCode { get; set; } = Core.Constants.Internationalization.DefaultLanguageTwoLetterCode;

        [Required]
        public string TimeZone { get; set; }

        [Required]
        [MinLength(ModelProperties.ApplicationUser.MinimumFirstNameLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumFirstNameLength)]
        public string FirstName { get; set; }

        [MinLength(ModelProperties.ApplicationUser.MinimumMiddleNamesLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumMiddleNamesLength)]
        public string? MiddleNames { get; set; }

        [MinLength(ModelProperties.ApplicationUser.MinimumLastNameLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumLastNameLength)]
        public string? LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        [JsonDateTimeFormat("dd-MM-yyyy")]
        public DateTimeOffset DateOfBirth { get; set; }

        [Required]
        public Sex Sex { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}