/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Attributes;
using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Astrana.Core.Data.Entities.Identity
{
    [Table("UserRoles", Schema = SchemaNames.IdentityAccessManagement)]
    public class UserRole: BaseDeactivatableEntity<Guid, Guid>
    {
        [PersonalData]
        public override Guid Id { get; set; }

        [PersonalData]
        public virtual string Name { get; set; }

        public virtual string NormalizedUserName { get; set; }

        public virtual string ConcurrencyStamp { get; set; } = Guid.NewGuid().ToString();

        public ICollection<UserAccountRoleRel> UserAccountRoles { get; set; } = new List<UserAccountRoleRel>();
    }
}