/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Astrana.Core.Data.Entities.Content
{
    [Table("Links", Schema = SchemaNames.Content)]
    public class Link : BaseDeactivatableEntity<Guid, Guid>
    {
        [Required]
        [Column(Order = 1)]
        public string Address { get; set; }

        [MinLength(1)]
        [Column(Order = 2)]
        public string Text { get; set; }
    }
}
