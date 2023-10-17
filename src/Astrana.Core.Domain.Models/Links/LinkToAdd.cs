/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Links.Constants;
using Astrana.Core.Domain.Models.Links.Contracts;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Links
{
    public class LinkToAdd : DomainEntity, ILinkToAdd
    {
        public LinkToAdd()
        {
            NameUnique = ModelProperties.Link.NameUnique;
            NameSingularForm = ModelProperties.Link.NameSingularForm;
            NamePluralForm = ModelProperties.Link.NamePluralForm;
        }
        
        public Uri Url { get; set; }

        [Required]
        [MinLength(ModelProperties.Link.MinimumTitleLength)]
        [MaxLength(ModelProperties.Link.MaximumTitleLength)]
        public string? Title { get; set; }

        [Required]
        [MinLength(ModelProperties.Link.MinimumDescriptionLength)]
        [MaxLength(ModelProperties.Link.MaximumDescriptionLength)]
        public string? Description { get; set; }

        public string? Locale { get; set; }

        public string? CharSet { get; set; }

        public string? Robots { get; set; }

        public string? SiteName { get; set; }

        public Image? PreviewImage { get; set; }

        public Guid? PreviewImageId { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
