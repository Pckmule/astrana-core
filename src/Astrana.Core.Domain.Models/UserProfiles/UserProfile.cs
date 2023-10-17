/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Attributes;
using Astrana.Core.Domain.Models.ContentCollections;
using Astrana.Core.Domain.Models.UserProfiles.Constants;
using Astrana.Core.Domain.Models.UserProfiles.Contracts;
using Astrana.Core.Domain.Models.UserProfiles.Enums;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.UserProfiles
{
    public sealed class UserProfile : DomainEntity, IUserProfile, IAuditable<Guid>
    {
        public UserProfile()
        {
            NameUnique = ModelProperties.UserProfile.NameUnique;
            NameSingularForm = ModelProperties.UserProfile.NameSingularForm;
            NamePluralForm = ModelProperties.UserProfile.NamePluralForm;
        }

        [Required]
        public Guid ProfileId
        {
            get => Id;
            set => Id = value;
        }

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
        public Sex Sex { get; set; }

        [MinLength(ModelProperties.UserProfile.MinimumIntroductionLength)]
        [MaxLength(ModelProperties.UserProfile.MaximumIntroductionLength)]
        public string Introduction { get; set; }
        
        public ContentCollection? ProfilePicturesCollection { get; set; }

        public ContentCollection? CoverPicturesCollection { get; set; }

        [Required]
        public Guid CreatedBy { get; set; }

        [Required]
        public Guid LastModifiedBy { get; set; }

        [Required]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required]
        public DateTimeOffset LastModifiedTimestamp { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}