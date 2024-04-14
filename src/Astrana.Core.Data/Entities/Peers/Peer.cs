/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using Astrana.Core.Domain.Models.UserProfiles.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.Peers.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Peers
{
    [Table("Peers", Schema = SchemaNames.Default)]
    public class Peer
    {
        [Key, Column(Order = 0)]
        public Guid PeerId { get; set; }

        public Guid VirtualProfileId { get; set; }

        [MinLength(DomainModelProperties.Peer.MinimumFirstNameLength)]
        public string FirstName { get; set; }

        [MinLength(DomainModelProperties.Peer.MinimumLastNameLength)]
        public string LastName { get; set; }

        public short Age { get; set; }

        public Sex Sex { get; set; }

        [MinLength(DomainModelProperties.Peer.MinimumAddressLength)]
        public string Address { get; set; }

        [MinLength(DomainModelProperties.Peer.MinimumNoteLength)]
        public string Note { get; set; }

        [MinLength(DomainModelProperties.Peer.MinimumPeerAccessTokenLength)]
        public string PeerAccessToken { get; set; }

        public bool IsMuted { get; set; }
        
        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string DeactivatedReason { get; set; } = null;

        public Guid? DeactivatedBy { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
