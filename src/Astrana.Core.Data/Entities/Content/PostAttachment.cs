/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using Astrana.Core.Domain.Models.Attachments.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Astrana.Core.Data.Entities.Content
{
    [Table("PostAttachments", Schema = SchemaNames.Content)]
    public class PostAttachment
    {
        [Key, Column(Order = 0)]
        public Guid PostAttachmentId { get; set; }

        public string? Title { get; set; }

        public string? Caption { get; set; }

        public AttachmentType Type { get; set; }

        public Link Link { get; set; }

        public Guid? LinkId { get; set; }

        public Image Image { get; set; }

        public Guid? ImageId { get; set; }

        public AudioClip AudioClip { get; set; }

        public Guid? AudioClipId { get; set; }

        public Video Video { get; set; }
        
        public Guid? VideoId { get; set; }

        public ContentCollection ContentCollection { get; set; }

        public Guid? ContentCollectionId { get; set; }

        public Image Gif { get; set; }

        public Guid? GifId { get; set; }

        public Feeling Feeling { get; set; }

        public Guid? FeelingId { get; set; }

        public Location Location { get; set; }

        public Guid? LocationId { get; set; }
        
        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string? DeactivatedReason { get; set; } = null;

        public Guid? DeactivatedBy { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
