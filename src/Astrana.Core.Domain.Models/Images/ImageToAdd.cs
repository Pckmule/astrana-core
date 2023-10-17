/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Images.Constants;
using Astrana.Core.Domain.Models.Images.Contracts;
using System.ComponentModel.DataAnnotations;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;

namespace Astrana.Core.Domain.Models.Images
{
    public class ImageToAdd : DomainEntity, IImageToAdd
    {
        public ImageToAdd()
        {
            NameUnique = ModelProperties.Image.NameUnique;
            NameSingularForm = ModelProperties.Image.NameSingularForm;
            NamePluralForm = ModelProperties.Image.NamePluralForm;
        }

        [Required]
        [MinLength(ModelProperties.Image.MinimumLocationLength)]
        [MaxLength(ModelProperties.Image.MaximumLocationLength)]
        public string Location { get; set; }

        [MinLength(ModelProperties.Image.MinimumCaptionLength)]
        [MaxLength(ModelProperties.Image.MaximumCaptionLength)]
        public string? Caption { get; set; }

        [MinLength(ModelProperties.Image.MinimumCopyrightLength)]
        [MaxLength(ModelProperties.Image.MaximumCopyrightLength)]
        public string? Copyright { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
