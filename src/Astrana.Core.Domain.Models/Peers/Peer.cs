/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Peers.Constants;
using Astrana.Core.Domain.Models.Peers.Contracts;
using Astrana.Core.Domain.Models.System.Contracts;
using Astrana.Core.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Peers
{
    public class Peer : BaseDomainModel, IPeer, IEditableEntity<Guid>, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public Peer()
        {
            NameUnique = ModelProperties.Peer.NameUnique;
            NameSingularForm = ModelProperties.Peer.NameSingularForm;
            NamePluralForm = ModelProperties.Peer.NamePluralForm;
        }

        public Guid Id { get; set; }

        [Required]
        [MinLength(ModelProperties.Peer.MinimumFirstNameLength)]
        [MaxLength(ModelProperties.Peer.MaximumFirstNameLength)]
        public string FirstName { get; set; }

        [Required]
        [MinLength(ModelProperties.Peer.MinimumLastNameLength)]
        [MaxLength(ModelProperties.Peer.MaximumLastNameLength)]
        public string? LastName { get; set; }

        [Required]
        [MinLength(ModelProperties.Peer.MinimumAddressLength)]
        [MaxLength(ModelProperties.Peer.MaximumAddressLength)]
        public string Address { get; set; }
        
        [MinLength(ModelProperties.Peer.MinimumNoteLength)]
        [MaxLength(ModelProperties.Peer.MaximumNoteLength)]
        public string Note { get; set; }

        [MaxLength(ModelProperties.Peer.MaximumPeerAccessTokenLength)]
        public string PeerAccessToken { get; set; }

        [Required]
        public bool IsMuted { get; set; }

        [Required]
        public Guid CreatedBy { get; set; }

        [Required]
        public Guid LastModifiedBy { get; set; }

        [Required]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required]
        public DateTimeOffset LastModifiedTimestamp { get; set; }

        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string? DeactivatedReason { get; set; }

        public Guid? DeactivatedBy { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}