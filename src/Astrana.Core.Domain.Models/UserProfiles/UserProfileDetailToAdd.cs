/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Audiences;
using Astrana.Core.Domain.Models.UserProfiles.Constants;
using Astrana.Core.Domain.Models.UserProfiles.Contracts;
using System.ComponentModel.DataAnnotations;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;

namespace Astrana.Core.Domain.Models.UserProfiles
{
    public class UserProfileDetailToAdd : DomainEntity, IUserProfileDetailToAdd
    {
        public UserProfileDetailToAdd()
        {
            NameUnique = ModelProperties.UserProfile.NameUnique;
            NameSingularForm = ModelProperties.UserProfile.NameSingularForm;
            NamePluralForm = ModelProperties.UserProfile.NamePluralForm;
        }

        [Required]
        public Guid UserProfileId { get; set; }

        [MinLength(ModelProperties.UserProfileDetail.MinimumKeyLength)]
        [MaxLength(ModelProperties.UserProfileDetail.MaximumKeyLength)]
        public string Key { get; set; }

        [MinLength(ModelProperties.UserProfileDetail.MinimumIconNameLength)]
        [MaxLength(ModelProperties.UserProfileDetail.MaximumIconNameLength)]
        public string IconName { get; set; }

        [Required]
        [MinLength(ModelProperties.UserProfileDetail.MinimumLabelLength)]
        [MaxLength(ModelProperties.UserProfileDetail.MaximumLabelLength)]
        public string Label { get; set; }

        [Required]
        [MinLength(ModelProperties.UserProfileDetail.MinimumValueLength)]
        [MaxLength(ModelProperties.UserProfileDetail.MaximumValueLength)]
        public string Value { get; set; }

        public short DisplayOrder { get; set; }

        public List<Audience> Audiences { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
