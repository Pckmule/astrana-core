/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using Astrana.Core.Domain.Models.Peers.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Astrana.Core.Domain.Models.UserProfiles.Enums;
using DomainModelProperties = Astrana.Core.Domain.Models.Peers.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Peers
{
    [Table("PeerConnectionRequestsReceived", Schema = SchemaNames.Default)]
    public class PeerConnectionRequestReceived
    {
        [Key, Column(Order = 0)]
        public Guid PeerConnectionRequestReceivedId { get; set; }
        
        [MinLength(DomainModelProperties.PeerConnectionRequestReceived.MinimumFirstNameLength)]
        public string FirstName { get; set; }
        
        [MinLength(DomainModelProperties.PeerConnectionRequestReceived.MinimumLastNameLength)]
        public string LastName { get; set; }

        public short Age { get; set; }

        public Sex Sex { get; set; }

        [MinLength(DomainModelProperties.PeerConnectionRequestReceived.MinimumAddressLength)]
        public string Address { get; set; }

        [MinLength(DomainModelProperties.PeerConnectionRequestReceived.MinimumNoteLength)]
        public string Note { get; set; }

        [MinLength(DomainModelProperties.PeerConnectionRequestReceived.MinimumPeerPreviewAccessTokenLength)]
        public string PeerPreviewAccessToken { get; set; }

        public PeerConnectionRequestStatus Status { get; set; }
        
        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string DeactivatedReason { get; set; } = null;

        public Guid? DeactivatedBy { get; set; }

        public Guid CreatedBy { get; set; }

        public Guid LastModifiedBy { get; set; }

        public DateTimeOffset CreatedTimestamp { get; set; }

        public DateTimeOffset LastModifiedTimestamp { get; set; }
    }
}
