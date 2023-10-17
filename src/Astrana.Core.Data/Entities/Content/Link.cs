/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ModelProperties = Astrana.Core.Domain.Models.Links.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("Links", Schema = SchemaNames.Content)]
    public class Link
    {
        [Key, Column(Order = 0)]
        public virtual Guid LinkId { get; set; }

        [Required]
        [MinLength(ModelProperties.Link.MinimumUrlLength)]
        [MaxLength(ModelProperties.Link.MaximumUrlLength)]
        [Column(Order = 1)]
        public Uri Url { get; set; }

        [Required]
        [MinLength(ModelProperties.Link.MinimumTitleLength)]
        [MaxLength(ModelProperties.Link.MaximumTitleLength)]
        [Column(Order = 2)]
        public string Title { get; set; }

        [Required]
        [MinLength(ModelProperties.Link.MinimumDescriptionLength)]
        [MaxLength(ModelProperties.Link.MaximumDescriptionLength)]
        [Column(Order = 3)]
        public string Description { get; set; }

        [Column(Order = 4)]
        public string Locale { get; set; }

        [Column(Order = 5)]
        public string CharSet { get; set; }

        [Column(Order = 6)]
        public string Robots { get; set; }

        [Column(Order = 7)]
        public string SiteName { get; set; }

        [Column(Order = 8)]
        public Image PreviewImage { get; set; }

        [Column(Order = 9)]
        public Guid PreviewImageId { get; set; }


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
