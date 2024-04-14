/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Astrana.Core.Data.Entities.Configuration
{
    [Table("SkinTones", Schema = SchemaNames.Configuration)]
    public class SkinTone
    {
        [Key, Column(Order = 0)]
        public Guid SkinToneId { get; set; }

        [Required]
        [Column(Order = 1)]
        public string Name { get; set; }

        [Required]
        [Column(Order = 2)]
        public string NameTrxCode { get; set; }

        [Required]
        [Column(Order = 3)]
        [MaxLength(20)]
        public string ColorCode { get; set; }
        
        public string Description { get; set; }
        
        public string DescriptionTrxCode { get; set; }
        
        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }
        
        public DateTimeOffset CreatedTimestamp { get; set; }
        
        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}