/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Images.Constants;
using Astrana.Core.Domain.Models.Images.Contracts;
using Astrana.Core.Domain.Models.System.Contracts;
using Astrana.Core.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Images
{
    public sealed class Image : BaseDomainModel, IImage, IEditableEntity<Guid>, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public Image()
        {
            NameUnique = ModelProperties.Image.NameUnique;
            NameSingularForm = ModelProperties.Image.NameSingularForm;
            NamePluralForm = ModelProperties.Image.NamePluralForm;
        }

        [Required]
        public Guid Id { get; set; }

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