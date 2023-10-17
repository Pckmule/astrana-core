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
            NameUnique = ModelProperties.Audio.NameUnique;
            NameSingularForm = ModelProperties.Audio.NameSingularForm;
            NamePluralForm = ModelProperties.Audio.NamePluralForm;
        }

        [Required]
        [MinLength(ModelProperties.Audio.MinimumLocationLength)]
        [MaxLength(ModelProperties.Audio.MaximumLocationLength)]
        public string Location { get; set; }

        [MinLength(ModelProperties.Audio.MinimumCaptionLength)]
        [MaxLength(ModelProperties.Audio.MaximumCaptionLength)]
        public string? Caption { get; set; }

        [MinLength(ModelProperties.Audio.MinimumCopyrightLength)]
        [MaxLength(ModelProperties.Audio.MaximumCopyrightLength)]
        public string? Copyright { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
