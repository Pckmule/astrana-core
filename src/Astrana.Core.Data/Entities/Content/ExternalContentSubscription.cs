/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ModelProperties = Astrana.Core.Domain.Models.ExternalContentSubscriptions.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("ExternalContentSubscriptions", Schema = SchemaNames.Content)]
    public class ExternalContentSubscription : BaseDeactivatableEntity<Guid, Guid>
    {
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

        [Required]
        [MinLength(ModelProperties.ExternalContentSubscription.MinimumDescriptionLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumDescriptionLength)]
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
    }
}
