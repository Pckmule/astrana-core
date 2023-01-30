/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Attributes;
using Astrana.Core.Data.Constants;
using Astrana.Core.Data.Entities.User;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

#nullable disable

namespace Astrana.Core.Data.Entities.ContactInformation
{
    [Table("EmailAddresses", Schema = SchemaNames.ContactInformation)]
    public class EmailAddress : BaseDeactivatableEntity<Guid, Guid>
    {
        [PersonalData]
        [MaxLength(100)]
        [Column(Order = 1)]
        public string Address { get; set; }

        [Column(Order = 2)]
        public ICollection<UserEmailAddressRelationship> EmailAddresses { get; set; } = new List<UserEmailAddressRelationship>();
    }
}
