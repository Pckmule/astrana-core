/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.Comments.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("Comments", Schema = SchemaNames.Content)]
    public class Comment
    {
        [Key, Column(Order = 0)]
        public Guid CommentId { get; set; }

        [Required]
        [MinLength(DomainModelProperties.Comment.MinimumTextLength)]
        [MaxLength(DomainModelProperties.Comment.MaximumTextLength)]
        [Column(Order = 1)]
        public string Text { get; set; }

        [Column(Order = 2)]
        public Post? TargetPost { get; set; }

        [Column(Order = 2)]
        public long? TargetPostId { get; set; }

        [Column(Order = 3)]
        public Comment? TargeComment { get; set; }

        [Column(Order = 3)]
        public Guid? TargetCommentId { get; set; }

        [Column(Order = 4)]
        public Image? TargetImage { get; set; }

        [Column(Order = 4)]
        public Guid? TargetImageId { get; set; }

        [Column(Order = 5)]
        public Video? TargetVideo { get; set; }

        [Column(Order = 5)]
        public Guid? TargetVideoId { get; set; }

        [Column(Order = 6)]
        public Audio? TargetAudio { get; set; }

        [Column(Order = 6)]
        public Guid? TargetAudioId { get; set; }

        [Column(Order = 7)]
        public Image? TargetGif { get; set; }

        [Column(Order = 7)]
        public Guid? TargetGifId { get; set; }

        [Column(Order = 8)]
        public Audio? TargetContentCollection { get; set; }

        [Column(Order = 8)]
        public Guid? TargetContentCollectionId { get; set; }
        
        [Column(Order = 9)]
        public Link? TargetLink { get; set; }

        [Column(Order = 9)]
        public Guid? TargetLinkId { get; set; }

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
