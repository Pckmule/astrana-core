/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using Astrana.Core.Data.Entities.Configuration;
using Astrana.Core.Domain.Models.Attachments.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("PostAttachments", Schema = SchemaNames.Content)]
    public class PostAttachment : BaseDeactivatableEntity<Guid, Guid>
    {
        [MaxLength(250)]
        [Column(Order = 1)]
        public string Title { get; set; }

        [MaxLength(250)]
        [Column(Order = 2)]
        public string Caption { get; set; }

        [Required]
        [Column(Order = 3)]
        public AttachmentType Type { get; set; }

        [Column(Order = 4)]
        public Link Link { get; set; }

        [Column(Order = 4)]
        public Guid? LinkId { get; set; }

        [Column(Order = 5)]
        public Image Image { get; set; }

        [Column(Order = 5)]
        public Guid? ImageId { get; set; }

        [Column(Order = 6)]
        public Image Gif { get; set; }

        [Column(Order = 6)]
        public Guid? GifId { get; set; }

        [Column(Order = 7)]
        public Audio Audio { get; set; }

        [Column(Order = 7)]
        public Guid? AudioId { get; set; }

        [Column(Order = 8)]
        public Video Video { get; set; }
        
        [Column(Order = 8)]
        public Guid? VideoId { get; set; }

        [Column(Order = 9)]
        public ContentCollection ContentCollection { get; set; }

        [Column(Order = 9)]
        public Guid? ContentCollectionId { get; set; }

        [Column(Order = 10)]
        public Location Location { get; set; }

        [Column(Order = 10)]
        public Guid? LocationId { get; set; }

        [Column(Order = 11)]
        public Feeling Feeling { get; set; }

        [Column(Order = 11)]
        public Guid? FeelingId { get; set; }
    }
}
