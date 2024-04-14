/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ModelProperties = Astrana.Core.Domain.Models.ExternalContent.ContentItems.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("ExternalContentSubscriptionContentItems", Schema = SchemaNames.Content)]
    public class ExternalContentSubscriptionContentItem
    {
        [Key, Column(Order = 0)]
        public Guid ExternalContentSubscriptionContentItemId { get; set; }

        [Required]
        [MinLength(ModelProperties.ExternalContentSubscriptionContentItem.MinimumUrlLength)]
        [MaxLength(ModelProperties.ExternalContentSubscriptionContentItem.MaximumUrlLength)]
        [Column(Order = 1)]
        public Uri Url { get; set; }

        [Required]
        [MinLength(ModelProperties.ExternalContentSubscriptionContentItem.MinimumTitleLength)]
        [MaxLength(ModelProperties.ExternalContentSubscriptionContentItem.MaximumTitleLength)]
        [Column(Order = 2)]
        public string Title { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscriptionContentItem.MinimumSummaryLength)]
        [MaxLength(ModelProperties.ExternalContentSubscriptionContentItem.MaximumSummaryLength)]
        [Column(Order = 3)]
        public string Summary { get; set; }
        
        [MinLength(ModelProperties.ExternalContentSubscriptionContentItem.MinimumContentLength)]
        [MaxLength(ModelProperties.ExternalContentSubscriptionContentItem.MaximumContentLength)]
        [Column(Order = 4)]
        public string Content { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscriptionContentItem.MinimumRightsLength)]
        [MaxLength(ModelProperties.ExternalContentSubscriptionContentItem.MaximumRightsLength)]
        [Column(Order = 5)]
        public string Rights { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscriptionContentItem.MinimumContentRatingLength)]
        [MaxLength(ModelProperties.ExternalContentSubscriptionContentItem.MaximumContentRatingLength)]
        [Column(Order = 6)]
        public string ContentRating { get; set; }

        [Required]
        [Column(Order = 7)]
        public DateTimeOffset Published { get; set; }

        [Required]
        [Column(Order = 8)]
        public DateTimeOffset LastUpdated { get; set; }

        [Required]
        [Column(Order = 9)]
        public ExternalContentSource Source { get; set; }

        [Column(Order = 9)]
        public Guid? SourceId { get; set; }

        [Column(Order = 10)]
        public Image Thumbnail { get; set; }

        [Column(Order = 10)]
        public Guid? ThumbnailId { get; set; }

        [Column(Order = 11)]
        public Image Image { get; set; }

        [Column(Order = 11)]
        public Guid? ImageId { get; set; }

        [Column(Order = 12)]
        public ICollection<ExternalContentAuthor> Authors { get; set; }

        [Column(Order = 13)]
        public ICollection<string> Categories { get; set; }

        [Column(Order = 14)]
        public ICollection<ExternalContentLink> Links { get; set; }

        [Required, Column(Order = 99996)]
        public Guid CreatedBy { get; set; }

        [Required, Column(Order = 99997)]
        public Guid LastModifiedBy { get; set; }

        [Required, Column(Order = 99998)]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required, Column(Order = 99999)]
        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
