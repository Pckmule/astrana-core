/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.Links.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("Links", Schema = SchemaNames.Content)]
    public class Link
    {
        [Key, Column(Order = 0)]
        public virtual Guid LinkId { get; set; }

        [MinLength(DomainModelProperties.Link.MinimumUrlLength)]
        public Uri Url { get; set; }

        [MinLength(DomainModelProperties.Link.MinimumTitleLength)]
        public string Title { get; set; }

        [MinLength(DomainModelProperties.Link.MinimumDescriptionLength)]
        public string Description { get; set; }

        public string Locale { get; set; }

        public string CharSet { get; set; }

        public string Robots { get; set; }

        public string SiteName { get; set; }

        public Image PreviewImage { get; set; }

        public Guid PreviewImageId { get; set; }
        
        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string DeactivatedReason { get; set; } = null;

        public Guid? DeactivatedBy { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
