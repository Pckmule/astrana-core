/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ModelProperties = Astrana.Core.Domain.Models.ExternalContent.Subscriptions.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("ExternalContentSubscriptions", Schema = SchemaNames.Content)]
    public class ExternalContentSubscription
    {
        [Key, Column(Order = 0)]
        public Guid ExternalContentSubscriptionId { get; set; }

        [Required]
        [MinLength(ModelProperties.ExternalContentSubscription.MinimumUrlLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumUrlLength)]
        [Column(Order = 1)]
        public Uri Url { get; set; }

        [Required]
        [MinLength(ModelProperties.ExternalContentSubscription.MinimumTitleLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumTitleLength)]
        [Column(Order = 2)]
        public string Title { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscription.MinimumSubTitleLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumSubTitleLength)]
        [Column(Order = 3)]
        public string SubTitle { get; set; }
        
        [MinLength(ModelProperties.ExternalContentSubscription.MinimumDescriptionLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumDescriptionLength)]
        [Column(Order = 4)]
        public string Description { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscription.MinimumWebsiteUrlLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumWebsiteUrlLength)]
        [Column(Order = 5)]
        public Uri WebsiteUrl { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscription.MinimumCopyrightLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumCopyrightLength)]
        [Column(Order = 6)]
        public string Copyright { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscription.MinimumLocaleLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumLocaleLength)]
        [Column(Order = 7)]
        public string Locale { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscription.MinimumLanguageLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumLanguageLength)]
        [Column(Order = 8)]
        public string Language { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscription.MinimumAccessTokenLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumAccessTokenLength)]
        [Column(Order = 9)]
        public string AccessToken { get; set; }

        [Column(Order = 10)]
        public Image IconImage { get; set; }

        [Column(Order = 10)]
        public Guid? IconImageId { get; set; }

        [Column(Order = 11)]
        public Image LogoImage { get; set; }

        [Column(Order = 11)]
        public Guid? LogoImageId { get; set; }

        [Column(Order = 12)]
        public Image CoverImage { get; set; }

        [Column(Order = 12)]
        public Guid? CoverImageId { get; set; }

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
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required, Column(Order = 99999)]
        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
