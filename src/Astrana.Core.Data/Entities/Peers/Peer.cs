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

        [Required]
        [Column(Order = 1)]
        public Guid VirtualProfileId { get; set; }

        [Required]
        [MinLength(DomainModelProperties.Peer.MinimumFirstNameLength)]
        [MaxLength(DomainModelProperties.Peer.MaximumFirstNameLength)]
        [Column(Order = 2)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(DomainModelProperties.Peer.MinimumLastNameLength)]
        [MaxLength(DomainModelProperties.Peer.MaximumLastNameLength)]
        [Column(Order = 3)]
        public string LastName { get; set; }

        [Required]
        [Column(Order = 4)]
        public short Age { get; set; }

        [Required]
        [Column(Order = 5)]
        public Sex Sex { get; set; }

        [Required]
        [MinLength(DomainModelProperties.Peer.MinimumAddressLength)]
        [MaxLength(DomainModelProperties.Peer.MaximumAddressLength)]
        [Column(Order = 6)]
        public string Address { get; set; }

        [MinLength(DomainModelProperties.Peer.MinimumNoteLength)]
        [MaxLength(DomainModelProperties.Peer.MaximumNoteLength)]
        [Column(Order = 7)]
        public string Note { get; set; }

        [MaxLength(DomainModelProperties.Peer.MaximumPeerAccessTokenLength)]
        [Column(Order = 8)]
        public string PeerAccessToken { get; set; }

        [Required]
        [Column(Order = 9)]
        public bool IsMuted { get; set; }

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
        public DateTimeOffset CreatedTimestamp { get; set; } = DateTimeOffset.UtcNow;

        [Required, Column(Order = 99999)]
        public DateTimeOffset LastModifiedTimestamp { get; set; } = DateTimeOffset.UtcNow;
    }
}
