/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using Astrana.Core.Domain.Models.ContentCollections.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.ContentCollections.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("ContentCollections", Schema = SchemaNames.Content)]
    public class ContentCollection
    {
        [Key, Column(Order = 0)]
        public Guid ContentCollectionId { get; set; }

        [Column(Order = 1)]
        [MinLength(DomainModelProperties.ContentCollection.MinimumTitleLength)]
        [MaxLength(DomainModelProperties.ContentCollection.MaximumTitleLength)]
        public string Name { get; set; }

        [Column(Order = 2)]
        public ContentCollectionType CollectionType { get; set; }

        [Column(Order = 3)]
        [MinLength(DomainModelProperties.ContentCollection.MinimumCaptionLength)]
        [MaxLength(DomainModelProperties.ContentCollection.MaximumCaptionLength)]
        public string Caption { get; set; }

        [Column(Order = 4)]
        [MinLength(DomainModelProperties.ContentCollection.MinimumCopyrightLength)]
        [MaxLength(DomainModelProperties.ContentCollection.MaximumCopyrightLength)]
        public string Copyright { get; set; }

        [Column(Order = 5)]
        public ICollection<ContentCollectionItem> ContentCollectionItems { get; set; } = new List<ContentCollectionItem>();

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
