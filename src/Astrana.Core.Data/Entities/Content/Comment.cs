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

        [MinLength(DomainModelProperties.Comment.MinimumTextLength)]
        public string Text { get; set; }
        
        public Post TargetPost { get; set; }
        
        public long? TargetPostId { get; set; }
        
        public Comment TargetComment { get; set; }
        
        public Guid? TargetCommentId { get; set; }
        
        public Image TargetImage { get; set; }
        
        public Guid? TargetImageId { get; set; }
        
        public Video TargetVideo { get; set; }
        
        public Guid? TargetVideoId { get; set; }
        
        public AudioClip TargetAudio { get; set; }
        
        public Guid? TargetAudioId { get; set; }
        
        public Image TargetGif { get; set; }
        
        public Guid? TargetGifId { get; set; }
        
        public AudioClip TargetContentCollection { get; set; }
        
        public Guid? TargetContentCollectionId { get; set; }
        
        public Link TargetLink { get; set; }
        
        public Guid? TargetLinkId { get; set; }

        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string DeactivatedReason { get; set; } = null;

        public Guid? DeactivatedBy { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
