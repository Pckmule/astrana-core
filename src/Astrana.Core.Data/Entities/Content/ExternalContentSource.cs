/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ModelProperties = Astrana.Core.Domain.Models.ExternalContent.ContentSources.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("ExternalContentSources", Schema = SchemaNames.Content)]
    public class ExternalContentSource
    {
        [Key, Column(Order = 0)]
        public Guid ExternalContentSourceId { get; set; }

        [Required]
        [MinLength(ModelProperties.ContentSource.MinimumUrlLength)]
        [MaxLength(ModelProperties.ContentSource.MaximumUrlLength)]
        [Column(Order = 1)]
        public Uri Url { get; set; }

        [Required]
        [MinLength(ModelProperties.ContentSource.MinimumNameLength)]
        [MaxLength(ModelProperties.ContentSource.MaximumNameLength)]
        [Column(Order = 2)]
        public string Name { get; set; }

        [MinLength(ModelProperties.ContentSource.MinimumIconUrlLength)]
        [MaxLength(ModelProperties.ContentSource.MaximumIconUrlLength)]
        [Column(Order = 3)]
        public string IconUrl { get; set; }
        
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
