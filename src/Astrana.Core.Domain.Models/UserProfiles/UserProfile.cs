/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Attributes;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.System.Contracts;
using Astrana.Core.Domain.Models.UserProfiles.Constants;
using Astrana.Core.Domain.Models.UserProfiles.Contracts;
using Astrana.Core.Domain.Models.UserProfiles.Enums;
using Astrana.Core.Validation;
using Astrana.Core.Validation.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.UserProfiles
{
    public sealed class UserProfile : BaseDomainModel, IUserProfile, IEditableEntity<Guid>, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public UserProfile()
        {
            NameUnique = ModelProperties.UserProfile.NameUnique;
            NameSingularForm = ModelProperties.UserProfile.NameSingularForm;
            NamePluralForm = ModelProperties.UserProfile.NamePluralForm;
        }

        [Required]
        public Guid Id { get; set; }

        [Required]
        public Guid UserAccountId { get; set; }

        [Required]
        [MinLength(ModelProperties.UserProfile.MinimumFirstNameLength)]
        [MaxLength(ModelProperties.UserProfile.MaximumFirstNameLength)]
        public string FirstName { get; set; }

        [MinLength(ModelProperties.UserProfile.MinimumMiddleNamesLength)]
        [MaxLength(ModelProperties.UserProfile.MaximumMiddleNamesLength)]
        public string MiddleNames { get; set; }

        [Required]
        [MinLength(ModelProperties.UserProfile.MinimumLastNameLength)]
        [MaxLength(ModelProperties.UserProfile.MaximumLastNameLength)]
        public string LastName { get; set; }

        public string FullName => (FirstName + " " + LastName).Trim();

        [Required]
        [DateOfBirth]
        [JsonDateTimeFormat("dd-MM-yyyy")]
        public DateTimeOffset DateOfBirth { get; set; }

        [RequiredEnum]
        public Gender Gender { get; set; }

        [MinLength(ModelProperties.UserProfile.MinimumIntroductionLength)]
        [MaxLength(ModelProperties.UserProfile.MaximumIntroductionLength)]
        public string Introduction { get; set; }

        public Image? ProfilePicture { get; set; }

        public Image? CoverPicture { get; set; }

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