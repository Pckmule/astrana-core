/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.AudioClips.Constants;
using Astrana.Core.Domain.Models.AudioClips.Contracts;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.AudioClips
{
    public class AudioToAdd : DomainEntity, IAudioToAdd
    {
        public AudioToAdd()
        {
            NameUnique = ModelProperties.AudioClip.NameUnique;
            NameSingularForm = ModelProperties.AudioClip.NameSingularForm;
            NamePluralForm = ModelProperties.AudioClip.NamePluralForm;
        }

        [Required]
        [MinLength(ModelProperties.AudioClip.MinimumLocationLength)]
        [MaxLength(ModelProperties.AudioClip.MaximumLocationLength)]
        public string Location { get; set; }

        [MinLength(ModelProperties.AudioClip.MinimumCaptionLength)]
        [MaxLength(ModelProperties.AudioClip.MaximumCaptionLength)]
        public string? Caption { get; set; }

        [MinLength(ModelProperties.AudioClip.MinimumCopyrightLength)]
        [MaxLength(ModelProperties.AudioClip.MaximumCopyrightLength)]
        public string? Copyright { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
