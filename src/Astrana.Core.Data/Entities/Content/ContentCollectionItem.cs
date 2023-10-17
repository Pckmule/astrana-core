/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using Astrana.Core.Domain.Models.Media.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("ContentCollectionItems", Schema = SchemaNames.Content)]
    public class ContentCollectionItem
    {
        [Key, Column(Order = 0)]
        public Guid ContentCollectionItemId { get; set; }

        [Column(Order = 1)]
        public ContentCollection ContentCollection { get; set; }

        [Column(Order = 2)]
        public Guid ContentCollectionId { get; set; }

        [Required]
        [Column(Order = 3)]
        public MediaType MediaType { get; set; }

        [Column(Order = 4)]
        public Link? Link { get; set; }

        [Column(Order = 4)]
        public Guid? LinkId { get; set; }

        [Column(Order = 5)]
        public Image? Image { get; set; }

        [Column(Order = 5)]
        public Guid? ImageId { get; set; }

        [Column(Order = 6)]
        public Video? Video { get; set; }

        [Column(Order = 6)]
        public Guid? VideoId { get; set; }

        [Column(Order = 7)]
        public Audio? Audio { get; set; }

        [Column(Order = 7)]
        public Guid? AudioId { get; set; }

        [Column(Order = 8)]
        public Image? Gif { get; set; }

        [Column(Order = 8)]
        public Guid? GifId { get; set; }
        
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
