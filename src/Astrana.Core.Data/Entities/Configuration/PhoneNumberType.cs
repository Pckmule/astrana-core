/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Attributes;
using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Astrana.Core.Data.Entities.Configuration
{
    [Table("PhoneNumberTypes", Schema = SchemaNames.Configuration)]
    public class PhoneNumberType : BaseDeactivatableEntity<Guid, Guid>
    {
        [PersonalData]
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        [Column(Order = 1)]
        public string Name { get; set; }

        [PersonalData]
        [Required]
        [MinLength(2)]
        [MaxLength(20)]
        [Column(Order = 2)]
        public string Code { get; set; }
    }
}
