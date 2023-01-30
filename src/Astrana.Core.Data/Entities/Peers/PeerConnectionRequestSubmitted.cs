/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using Astrana.Core.Domain.Models.Peers.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.Peers.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Peers
{
    [Table("PeerConnectionRequestsSubmitted", Schema = SchemaNames.Default)]
    public class PeerConnectionRequestSubmitted : BaseDeactivatableEntity<Guid, Guid>
    {
        [Required]
        [MinLength(DomainModelProperties.PeerConnectionRequestReceived.MinimumFirstNameLength)]
        [MaxLength(DomainModelProperties.PeerConnectionRequestReceived.MaximumFirstNameLength)]
        [Column(Order = 1)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(DomainModelProperties.PeerConnectionRequestReceived.MinimumLastNameLength)]
        [MaxLength(DomainModelProperties.PeerConnectionRequestReceived.MaximumLastNameLength)]
        [Column(Order = 2)]
        public string LastName { get; set; }

        [Required]
        [MinLength(DomainModelProperties.PeerConnectionRequestReceived.MinimumAddressLength)]
        [MaxLength(DomainModelProperties.PeerConnectionRequestReceived.MaximumAddressLength)]
        [Column(Order = 3)]
        public string Address { get; set; }

        [MinLength(DomainModelProperties.PeerConnectionRequestReceived.MinimumNoteLength)]
        [MaxLength(DomainModelProperties.PeerConnectionRequestReceived.MaximumNoteLength)]
        [Column(Order = 4)]
        public string Note { get; set; }

        [MaxLength(DomainModelProperties.PeerConnectionRequestReceived.MaximumPeerPreviewAccessTokenLength)]
        [Column(Order = 5)]
        public string PeerPreviewAccessToken { get; set; }

        [Required]
        [Column(Order = 6)]
        public PeerConnectionRequestStatus Status { get; set; }
    }
}
