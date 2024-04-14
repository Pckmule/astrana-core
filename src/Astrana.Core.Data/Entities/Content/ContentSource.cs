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
    [Table("ContentSources", Schema = SchemaNames.Content)]
    public class ContentSource
    {
        [Key, Column(Order = 0)]
        public Guid ContentSourceId { get; set; }

        [MinLength(ModelProperties.ContentSource.MinimumUrlLength)]
        [MaxLength(ModelProperties.ContentSource.MaximumUrlLength)]
        public Uri Url { get; set; }

        [MinLength(ModelProperties.ContentSource.MinimumNameLength)]
        [MaxLength(ModelProperties.ContentSource.MaximumNameLength)]
        public string Name { get; set; }

        [MinLength(ModelProperties.ContentSource.MinimumIconUrlLength)]
        [MaxLength(ModelProperties.ContentSource.MinimumIconUrlLength)]
        public string IconUrl { get; set; }
        
        public Guid CreatedBy { get; set; }
        
        public Guid LastModifiedBy { get; set; }
        
        public DateTimeOffset CreatedTimestamp { get; set; }
        
        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
