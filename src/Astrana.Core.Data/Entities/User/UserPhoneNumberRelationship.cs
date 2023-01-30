/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using Astrana.Core.Data.Entities.ContactInformation;
using Astrana.Core.Data.Entities.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Astrana.Core.Data.Entities.User
{
    [Table("UserPhoneNumberRel", Schema = SchemaNames.User)]
    public class UserPhoneNumberRelationship : BaseRelationshipEntity<Guid>
    {
        [Required]
        [Column(Order = 1)]
        public Guid UserAccountId { get; set; }

        [Column(Order = 2)]
        public UserAccount UserAccount { get; set; }

        [Required]
        [Column(Order = 3)]
        public Guid PhoneNumberId { get; set; }

        [Column(Order = 4)]
        public PhoneNumber PhoneNumber { get; set; }
    }
}
