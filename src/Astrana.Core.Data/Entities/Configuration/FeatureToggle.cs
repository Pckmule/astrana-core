/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Index = Microsoft.EntityFrameworkCore.IndexAttribute;

#nullable disable

namespace Astrana.Core.Data.Entities.Configuration
{
    [Table("FeatureToggles", Schema = SchemaNames.Configuration)]
    [Index(nameof(FeatureName), IsUnique = true)]
    public class FeatureToggle
    {
        [Key, Column(Order = 0)]
        public Guid FeatureToggleId { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        [Column(Order = 1)]
        public string FeatureName { get; set; }

        [MaxLength(250)]
        [Column(Order = 2)]
        public string FeatureDescription { get; set; }

        [Required]
        [Column(Order = 3)]
        public bool IsFeatureDisabled { get; set; }
        
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
