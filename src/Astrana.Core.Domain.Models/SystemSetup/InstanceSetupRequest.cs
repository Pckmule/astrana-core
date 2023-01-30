/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Attributes;
using Astrana.Core.Constants;
using Astrana.Core.Domain.Models.System.Constants;
using Astrana.Core.Domain.Models.UserProfiles.Enums;
using Astrana.Core.Validation;
using Astrana.Core.Validation.Attributes;
using System.ComponentModel.DataAnnotations;
using Astrana.Core.Domain.Models.SystemSetup.Constants;

namespace Astrana.Core.Domain.Models.SystemSetup
{
    public class InstanceSetupRequest : BaseDomainModel, IInstanceSetupRequest
    {
        [Required]
        [MinLength(ApplicationUser.MinimumUsernameLength)]
        [MaxLength(ApplicationUser.MaximumUsernameLength)]
        public string InstanceUsername { get; set; }

        [Required]
        [MinLength(ApplicationUser.MinimumEmailAddressLength)]
        [MaxLength(ApplicationUser.MaximumEmailAddressLength)]
        [EmailAddress]
        public string InstanceUserEmailAddress { get; set; }

        [Required]
        [MinLength(Idp.MinimumPasswordLength)]
        [MaxLength(Idp.MaximumPasswordLength)]
        [DataType(DataType.Password)]
        public string InstanceUserPassword { get; set; }

        [Required]
        [MinLength(ApplicationUser.MinimumFirstNameLength)]
        [MaxLength(ApplicationUser.MaximumFirstNameLength)]
        public string InstanceUserFirstName { get; set; }

        [MinLength(ApplicationUser.MinimumMiddleNamesLength)]
        [MaxLength(ApplicationUser.MaximumMiddleNamesLength)]
        public string? InstanceUserMiddleNames { get; set; }

        [MinLength(ApplicationUser.MinimumLastNameLength)]
        [MaxLength(ApplicationUser.MaximumLastNameLength)]
        public string? InstanceUserLastName { get; set; }

        [Required]
        [DateOfBirth]
        [DataType(DataType.Date)]
        [JsonDateTimeFormat("dd-MM-yyyy")]
        public DateTimeOffset InstanceUserDateOfBirth { get; set; }

        [RequiredEnum]
        public Gender InstanceUserGender { get; set; }

        [Required]
        [MinLength(ModelProperties.InstanceSetupRequest.MinimumPhoneCountryCodeISOLength)]
        [MaxLength(ModelProperties.InstanceSetupRequest.MaximumPhoneCountryCodeISOLength)]
        public string InstancePhoneCountryCodeISO { get; set; }

        [Required]
        [Phone]
        [MinLength(ModelProperties.InstanceSetupRequest.MinimumPhoneNumberLength)]
        [MaxLength(ModelProperties.InstanceSetupRequest.MaximumPhoneNumberLength)]
        public string InstancePhoneNumber { get; set; }

        [Required]
        [MinLength(ModelProperties.InstanceSetupRequest.MinimumLanguageCodeLength)]
        [MaxLength(ModelProperties.InstanceSetupRequest.MaximumLanguageCodeLength)]
        public string InstanceLanguageCode { get; set; }

        [Required]
        [MinLength(ModelProperties.InstanceSetupRequest.MinimumCountryCodeLength)]
        [MaxLength(ModelProperties.InstanceSetupRequest.MaximumCountryCodeLength)]
        public string InstanceCountryCode { get; set; }

        [Required]
        public string InstanceTimeZone { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
