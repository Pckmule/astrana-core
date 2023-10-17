/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Videos.Constants;
using Astrana.Core.Domain.Models.Videos.Contracts;
using System.ComponentModel.DataAnnotations;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;

namespace Astrana.Core.Domain.Models.Videos
{
    public class VideoToAdd : DomainEntity, IVideoToAdd
    {
        public VideoToAdd()
        {
            NameUnique = ModelProperties.Video.NameUnique;
            NameSingularForm = ModelProperties.Video.NameSingularForm;
            NamePluralForm = ModelProperties.Video.NamePluralForm;
        }

        [Required]
        [MinLength(ModelProperties.Video.MinimumLocationLength)]
        [MaxLength(ModelProperties.Video.MaximumLocationLength)]
        public string Location { get; set; }

        [MinLength(ModelProperties.Video.MinimumCaptionLength)]
        [MaxLength(ModelProperties.Video.MaximumCaptionLength)]
        public string? Caption { get; set; }

        [MinLength(ModelProperties.Video.MinimumCopyrightLength)]
        [MaxLength(ModelProperties.Video.MaximumCopyrightLength)]
        public string? Copyright { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
