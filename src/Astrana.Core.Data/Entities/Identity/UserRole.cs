/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astrana.Core.Attributes;

#nullable disable

namespace Astrana.Core.Data.Entities.Identity
{
    [Table("UserRoles", Schema = SchemaNames.IdentityAccessManagement)]
    public class UserRole
    {
        [PersonalData]
        [Key, Column(Order = 0)]
        public Guid UserRoleId { get; set; }

        [PersonalData]
        public virtual string Name { get; set; }

        public virtual string NormalizedUserName { get; set; }

        public virtual string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

        public ICollection<UserAccountRoleRel> UserAccountRoles { get; set; } = new List<UserAccountRoleRel>();
        
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
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required, Column(Order = 99999)]
        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}