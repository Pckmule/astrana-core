/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Astrana.Core.Data.Entities.Identity
{
    [Table("UserAccountRoleRel", Schema = SchemaNames.IdentityAccessManagement)]
    public class UserAccountRoleRel : BaseRelationshipEntity<Guid>
    {
        [Required]
        [Column(Order = 1)]
        public Guid UserAccountId { get; set; }

        [Column(Order = 2)]
        public UserAccount UserAccount { get; set; }

        [Required]
        [Column(Order = 3)]
        public Guid UserRoleId { get; set; }

        [Column(Order = 4)]
        public UserRole UserRole { get; set; }
    }
}
