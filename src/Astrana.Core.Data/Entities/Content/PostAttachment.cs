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
    [Table("PostAttachments", Schema = SchemaNames.Content)]
    public class PostAttachment : BaseDeactivatableEntity<Guid, Guid>
    {
        [Required]
        [Column(Order = 1)]
        public string Address { get; set; }

        [Required]
        [MinLength(1)]
        [MaxLength(250)]
        [Column(Order = 2)]
        public string Title { get; set; }

        [MaxLength(250)]
        [Column(Order = 3)]
        public string Caption { get; set; }
    }
}
