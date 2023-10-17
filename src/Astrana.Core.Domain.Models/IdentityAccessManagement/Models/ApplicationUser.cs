using Astrana.Core.Domain.Models.IdentityAccessManagement.Constants;
using Astrana.Core.Domain.Models.UserAccounts;
using Astrana.Core.Domain.Models.UserAccounts.Enums;
using Astrana.Core.Domain.Models.UserProfiles;
using Astrana.Core.Domain.Models.UserProfiles.Enums;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.IdentityAccessManagement.Models
{
    public sealed class ApplicationUser: DomainEntity
    {
        [JsonIgnore]
        private readonly UserAccount _userAccount;

        [JsonIgnore]
        private readonly UserProfile _userProfile;

        public ApplicationUser(UserAccount userAccount, UserProfile userProfile)
        {
            NameUnique = ModelProperties.ApplicationUser.NameUnique;
            NameSingularForm = ModelProperties.ApplicationUser.NameSingularForm;
            NamePluralForm = ModelProperties.ApplicationUser.NamePluralForm;

            _userAccount = userAccount ?? throw new ArgumentNullException(nameof(userAccount));
            _userProfile = userProfile ?? throw new ArgumentNullException(nameof(userProfile));
        }

        [Required]
        public Guid Id => _userAccount.UserAccountId;

        public Guid ProfileId => _userProfile.ProfileId;

        [Required]
        public UserAccountType Type => _userAccount.Type;

        [Required]
        [MinLength(ModelProperties.ApplicationUser.MinimumUsernameLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumUsernameLength)]
        public string UserName
        {
            get => _userAccount.UserName;
            set => _userAccount.UserName = value;
        }

        [Required]
        [EmailAddress]
        [MinLength(ModelProperties.ApplicationUser.MinimumEmailAddressLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumEmailAddressLength)]
        public string? EmailAddress
        {
            get => _userAccount.EmailAddress;
            set => _userAccount.EmailAddress = value;
        }

        [Phone]
        [MinLength(ModelProperties.ApplicationUser.MinimumPhoneNumberLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumPhoneNumberLength)]
        public string? PhoneNumber
        {
            get => _userAccount.PhoneNumber;
            set => _userAccount.PhoneNumber = value;
        }

        public bool IsPhoneNumberConfirmed
        {
            get => _userAccount.IsPhoneNumberConfirmed;
            set => _userAccount.IsPhoneNumberConfirmed = value;
        }

        public bool IsTwoFactorEnabled
        {
            get => _userAccount.IsTwoFactorEnabled;
            set => _userAccount.IsTwoFactorEnabled = value;
        }

        public DateTimeOffset? LockoutEnd
        {
            get => _userAccount.LockoutEnd;
            set => _userAccount.LockoutEnd = value;
        }

        public bool IsLockoutEnabled
        {
            get => _userAccount.IsLockoutEnabled;
            set => _userAccount.IsLockoutEnabled = value;
        }

        public short FailedAccessCount
        {
            get => _userAccount.FailedAccessCount;
            set => _userAccount.FailedAccessCount = value;
        }

        [Required]
        [MinLength(ModelProperties.ApplicationUser.MinimumCountryCodeLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumCountryCodeLength)]
        public string CountryCode
        {
            get => _userAccount.CountryCode;
            set => _userAccount.CountryCode = value;
        }

        [Required]
        [MinLength(ModelProperties.ApplicationUser.MinimumLanguageCodeLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumLanguageCodeLength)]
        public string LanguageCode
        {
            get => _userAccount.LanguageCode;
            set => _userAccount.LanguageCode = value;
        }

        [Required]
        public string TimeZone
        {
            get => _userAccount.TimeZone;
            set => _userAccount.TimeZone = value;
        }

        [Required]
        [MinLength(ModelProperties.ApplicationUser.MinimumFirstNameLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumFirstNameLength)]
        public string FirstName
        {
            get => _userProfile.FirstName;
            set => _userProfile.FirstName = value;
        }

        [MinLength(ModelProperties.ApplicationUser.MinimumMiddleNamesLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumMiddleNamesLength)]
        public string MiddleNames
        {
            get => _userProfile.MiddleNames;
            set => _userProfile.MiddleNames = value;
        }

        [MinLength(ModelProperties.ApplicationUser.MinimumLastNameLength)]
        [MaxLength(ModelProperties.ApplicationUser.MaximumLastNameLength)]
        public string? LastName
        {
            get => _userProfile.LastName;
            set => _userProfile.LastName = value;
        }

        [Required]
        [DataType(DataType.Date)]
        public DateTimeOffset DateOfBirth
        {
            get => _userProfile.DateOfBirth;
            set => _userProfile.DateOfBirth = value;
        }

        [Required]
        public Sex Sex
        {
            get => _userProfile.Sex;
            set => _userProfile.Sex = value;
        }

        public EntityValidationResult Validate()
        {
            var accountValidationResult = _userAccount.Validate();
            var profileValidationResult = _userProfile.Validate();

            var outcome = accountValidationResult.IsSuccess && profileValidationResult.IsSuccess ? ValidationOutcome.Passed : ValidationOutcome.Failed;

            var failureResults = new List<EntityValidationResult>();

            if (!accountValidationResult.IsSuccess)
                failureResults.AddRange(accountValidationResult.FailedValidations);

            if (!profileValidationResult.IsSuccess)
                failureResults.AddRange(profileValidationResult.FailedValidations);

            return new EntityValidationResult(nameof(ApplicationUser), ValidatedEntityType.DomainModel, failureResults, outcome: outcome);
        }
    }
}