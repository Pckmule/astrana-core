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
    public class Image
    {
        [Key, Column(Order = 0)]
        public Guid ImageId { get; set; }

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


        [Column(Order = 99993)]
        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        [Column(Order = 99994)]
        public string? DeactivatedReason { get; set; } = null;

        [Column(Order = 99995)]
        public Guid? DeactivatedBy { get; set; }

        [Required, Column(Order = 99996)]
        public Guid CreatedBy { get; set; }

        [Required, Column(Order = 99997)]
        public Guid LastModifiedBy { get; set; }

        [Required, Column(Order = 99998)]
        public DateTimeOffset CreatedTimestamp { get; set; } = DateTimeOffset.UtcNow;

        [Required, Column(Order = 99999)]
        public DateTimeOffset LastModifiedTimestamp { get; set; } = DateTimeOffset.UtcNow;
    }
}
