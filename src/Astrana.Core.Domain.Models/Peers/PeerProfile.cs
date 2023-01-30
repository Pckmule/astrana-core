/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Attributes;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Peers.Constants;
using Astrana.Core.Domain.Models.Peers.Contracts;
using Astrana.Core.Domain.Models.UserProfiles.Enums;
using Astrana.Core.Validation;
using Astrana.Core.Validation.Attributes;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Peers
{
    public sealed class PeerProfile : BaseDomainModel, IPeerProfile
    {
        public PeerProfile()
        {
            NameUnique = ModelProperties.PeerProfile.NameUnique;
            NameSingularForm = ModelProperties.PeerProfile.NameSingularForm;
            NamePluralForm = ModelProperties.PeerProfile.NamePluralForm;
        }

        [Required]
        [MinLengthWhenSet(ModelProperties.PeerProfile.MinimumFirstNameLength)]
        [MaxLengthWhenSet(ModelProperties.PeerProfile.MaximumFirstNameLength)]
        public string FirstName { get; set; }

        [MinLengthWhenSet(ModelProperties.PeerProfile.MinimumMiddleNamesLength)]
        [MaxLengthWhenSet(ModelProperties.PeerProfile.MaximumMiddleNamesLength)]
        public string MiddleNames { get; set; }

        [Required]
        [MinLengthWhenSet(ModelProperties.PeerProfile.MinimumLastNameLength)]
        [MaxLengthWhenSet(ModelProperties.PeerProfile.MaximumLastNameLength)]
        public string LastName { get; set; }

        [Required]
        [DateOfBirth]
        [JsonDateTimeFormat("dd-MM-yyyy")]
        public DateTimeOffset DateOfBirth { get; set; }

        [Required]
        public Gender Gender { get; set; }

        [MinLengthWhenSet(ModelProperties.PeerProfile.MinimumIntroductionLength)]
        [MaxLengthWhenSet(ModelProperties.PeerProfile.MaximumIntroductionLength)]
        public string Introduction { get; set; }

        public Image? ProfilePicture { get; set; }

        public Image? CoverPicture { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}