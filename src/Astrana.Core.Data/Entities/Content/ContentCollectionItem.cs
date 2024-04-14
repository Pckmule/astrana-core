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
        
        public ContentCollection ContentCollection { get; set; }
        
        public Guid ContentCollectionId { get; set; }
        
        public MediaType MediaType { get; set; }
        
        public Link Link { get; set; }
        
        public Guid? LinkId { get; set; }

        public Image Image { get; set; }
        
        public Guid? ImageId { get; set; }
        
        public Video Video { get; set; }
        
        public Guid? VideoId { get; set; }
        
        public AudioClip Audio { get; set; }
        
        public Guid? AudioId { get; set; }
        
        public Image Gif { get; set; }
        
        public Guid? GifId { get; set; }
        
        public DateTimeOffset? DeactivatedTimestamp { get; set; }
        
        public string DeactivatedReason { get; set; } = null;
        
        public Guid? DeactivatedBy { get; set; }
        
        public Guid CreatedBy { get; set; }
        
        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
