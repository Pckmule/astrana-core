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

namespace Astrana.Core.Data.Entities.Configuration
{
    [Table("FeelingTemplates", Schema = SchemaNames.Configuration)]
    public class FeelingTemplate
    {
        [Key, Column(Order = 0)]
        public Guid FeelingTemplateId { get; set; }

        [Required]
        [MinLength(ModelProperties.Feeling.MinimumNameLength)]
        [MaxLength(ModelProperties.Feeling.MaximumNameLength)]
        [Column(Order = 1)]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.Feeling.MinimumNameTrxCodeLength)]
        [MaxLength(ModelProperties.Feeling.MaximumNameTrxCodeLength)]
        [Column(Order = 2)]
        public string NameTrxCode { get; set; }

        [Required]
        [MinLength(ModelProperties.Feeling.MinimumIconNameLength)]
        [MaxLength(ModelProperties.Feeling.MaximumIconNameLength)]
        [Column(Order = 4)]
        public string IconName { get; set; }

        [Required]
        [MinLength(ModelProperties.Feeling.MinimumUnicodeIconLength)]
        [MaxLength(ModelProperties.Feeling.MaximumUnicodeIconLength)]
        [Column(Order = 4)]
        public string UnicodeIcon { get; set; }

        [Required]
        [MinLength(ModelProperties.Feeling.MinimumShortCodeLength)]
        [MaxLength(ModelProperties.Feeling.MaximumShortCodeLength)]
        [Column(Order = 5)]
        public string ShortCode { get; set; }
        
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
