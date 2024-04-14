/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ModelProperties = Astrana.Core.Domain.Models.ContentSafetyRatings.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("ContentSafetyRatings", Schema = SchemaNames.Content)]
    public class ContentSafetyRating
    {
        [Key, Column(Order = 0)]
        public Guid ContentSafetyRatingId { get; set; }
        
        public string Name { get; set; }

        [MinLength(ModelProperties.ContentSafetyRating.MinimumDescriptionLength)]
        public string Description { get; set; }
        
        public DateTimeOffset? DeactivatedTimestamp { get; set; }
        
        public string DeactivatedReason { get; set; } = null;
        
        public Guid? DeactivatedBy { get; set; }
        
        public Guid CreatedBy { get; set; }
        
        public Guid LastModifiedBy { get; set; }
        
        public DateTimeOffset CreatedTimestamp { get; set; }
        
        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
