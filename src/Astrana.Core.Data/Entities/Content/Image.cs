/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.Images.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("Images", Schema = SchemaNames.Content)]
    public class Image
    {
        [Key, Column(Order = 0)]
        public Guid ImageId { get; set; }
        
        [MinLength(DomainModelProperties.Image.MinimumLocationLength)]
        public string Location { get; set; }

        [MinLength(DomainModelProperties.Image.MinimumCaptionLength)]
        public string Caption { get; set; }

        [MinLength(DomainModelProperties.Image.MinimumCopyrightLength)]
        public string Copyright { get; set; }
        
        public DateTimeOffset? DeactivatedTimestamp { get; set; }
        
        public string? DeactivatedReason { get; set; } = null;
        
        public Guid? DeactivatedBy { get; set; }
        
        public Guid CreatedBy { get; set; }
        
        public Guid LastModifiedBy { get; set; }
        
        public DateTimeOffset CreatedTimestamp { get; set; } = DateTimeOffset.UtcNow;
        
        public DateTimeOffset LastModifiedTimestamp { get; set; } = DateTimeOffset.UtcNow;
    }
}
