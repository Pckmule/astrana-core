/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Attributes;
using Astrana.Core.Data.Constants;
using Astrana.Core.Data.Entities.User;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.MessengerUsernames.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.ContactInformation
{
    [Table("InstantMessengerUsernames", Schema = SchemaNames.ContactInformation)]
    public class MessengerUsername
    {
        [Key, Column(Order = 0)]
        public Guid MessengerUsernameId { get; set; }

        [PersonalData]
        [MinLength(DomainModelProperties.MessengerUsername.MinimumNameLength)]
        public string Username { get; set; }

        public ICollection<UserMessengerUsernameRelationship> Relationships { get; set; } = new List<UserMessengerUsernameRelationship>();
        
        public DateTimeOffset? DeactivatedTimestamp { get; set; }
        
        public string DeactivatedReason { get; set; } = null;
        
        public Guid? DeactivatedBy { get; set; }
        
        public Guid CreatedBy { get; set; }
        
        public Guid LastModifiedBy { get; set; }
        
        public DateTimeOffset CreatedTimestamp { get; set; }
        
        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
