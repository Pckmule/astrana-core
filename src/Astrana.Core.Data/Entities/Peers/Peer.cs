/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Constants;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using DomainModelProperties = Astrana.Core.Domain.Models.Peers.Constants.ModelProperties;

#nullable disable

namespace Astrana.Core.Data.Entities.Peers
{
    [Table("Peers", Schema = SchemaNames.Default)]
    public class Peer : BaseDeactivatableEntity<Guid, Guid>
    {
        [Required]
        [MinLength(DomainModelProperties.Peer.MinimumFirstNameLength)]
        [MaxLength(DomainModelProperties.Peer.MaximumFirstNameLength)]
        [Column(Order = 1)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(DomainModelProperties.Peer.MinimumLastNameLength)]
        [MaxLength(DomainModelProperties.Peer.MaximumLastNameLength)]
        [Column(Order = 2)]
        public string LastName { get; set; }

        [Required]
        [MinLength(DomainModelProperties.Peer.MinimumAddressLength)]
        [MaxLength(DomainModelProperties.Peer.MaximumAddressLength)]
        [Column(Order = 3)]
        public string Address { get; set; }

        [MinLength(DomainModelProperties.Peer.MinimumNoteLength)]
        [MaxLength(DomainModelProperties.Peer.MaximumNoteLength)]
        [Column(Order = 4)]
        public string Note { get; set; }

        [MaxLength(DomainModelProperties.Peer.MaximumPeerAccessTokenLength)]
        [Column(Order = 5)]
        public string PeerAccessToken { get; set; }

        [Required]
        [Column(Order = 6)]
        public bool IsMuted { get; set; }
    }
}
