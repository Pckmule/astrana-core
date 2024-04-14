/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ModelProperties = Astrana.Core.Domain.Models.Feelings.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("Feelings", Schema = SchemaNames.Content)]
    public class Feeling
    {
        [Key, Column(Order = 0)]
        public Guid FeelingId { get; set; }
        
        [MinLength(ModelProperties.Feeling.MinimumNameLength)]
        public string Name { get; set; }
        
        [MinLength(ModelProperties.Feeling.MinimumNameTrxCodeLength)]
        public string NameTrxCode { get; set; }
        
        [MinLength(ModelProperties.Feeling.MinimumIconNameLength)]
        public string IconName { get; set; }
        
        [MinLength(ModelProperties.Feeling.MinimumUnicodeIconLength)]
        public string UnicodeIcon { get; set; }
        
        [MinLength(ModelProperties.Feeling.MinimumShortCodeLength)]
        public string ShortCode { get; set; }
        
        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string DeactivatedReason { get; set; } = null;

        public Guid? DeactivatedBy { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
