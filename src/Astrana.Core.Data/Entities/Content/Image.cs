/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.Images.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("Images", Schema = SchemaNames.Content)]
    public class Image : BaseDeactivatableEntity<Guid, Guid>
    {
        [Required]
        [MinLength(DomainModelProperties.Image.MinimumLocationLength)]
        [MaxLength(DomainModelProperties.Image.MaximumLocationLength)]
        [Column(Order = 1)]
        public string Location { get; set; }

        [MinLength(DomainModelProperties.Image.MinimumCaptionLength)]
        [MaxLength(DomainModelProperties.Image.MaximumCaptionLength)]
        [Column(Order = 2)]
        public string Caption { get; set; }

        [MinLength(DomainModelProperties.Image.MinimumCopyrightLength)]
        [MaxLength(DomainModelProperties.Image.MaximumCopyrightLength)]
        [Column(Order = 3)]
        public string Copyright { get; set; }
    }
}
