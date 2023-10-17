/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.Peers.Constants;
using Astrana.Core.Domain.Models.Peers.Contracts;
using Astrana.Core.Domain.Models.Peers.DomainTransferObjects;
using Astrana.Core.Domain.Models.UserProfiles.Enums;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Peers
{
    public class Peer : DomainEntity<Guid, PeerDto>, IPeer, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public Peer()
        {
            NameUnique = ModelProperties.Peer.NameUnique;
            NameSingularForm = ModelProperties.Peer.NameSingularForm;
            NamePluralForm = ModelProperties.Peer.NamePluralForm;
        }

        public Peer(PeerDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                PeerId = dto.Id.Value;

            if (dto.ProfileId.HasValue)
                VirtualProfileId = dto.ProfileId.Value;

            if (!string.IsNullOrEmpty(dto.FirstName))
                FirstName = dto.FirstName;

            if (!string.IsNullOrEmpty(dto.LastName))
                LastName = dto.LastName;

            if (!string.IsNullOrEmpty(dto.Address))
                Address = dto.Address;

            if (dto.Age.HasValue)
                Age = dto.Age.Value;

            if (dto.Gender.HasValue)
                Sex = dto.Gender.Value;

            if (!string.IsNullOrEmpty(dto.Note))
                Note = dto.Note;

            if (!string.IsNullOrEmpty(dto.PeerAccessToken))
                PeerAccessToken = dto.PeerAccessToken;

            if (dto.IsMuted.HasValue)
                IsMuted = dto.IsMuted.Value;

            if (dto.CreatedBy.HasValue)
                CreatedBy = dto.CreatedBy.Value;

            if (dto.CreatedTimestamp.HasValue)
                CreatedTimestamp = dto.CreatedTimestamp.Value;

            if (dto.LastModifiedBy.HasValue)
                LastModifiedBy = dto.LastModifiedBy.Value;

            if (dto.LastModifiedTimestamp.HasValue)
                LastModifiedTimestamp = dto.LastModifiedTimestamp.Value;

            if (dto.DeactivatedTimestamp.HasValue)
                DeactivatedTimestamp = dto.DeactivatedTimestamp;

            if (dto.DeactivatedBy.HasValue)
                DeactivatedBy = dto.DeactivatedBy;

            if (!string.IsNullOrEmpty(dto.DeactivatedReason))
                DeactivatedReason = dto.DeactivatedReason;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        public Guid PeerId { get; set; }

        public Guid VirtualProfileId { get; set; }

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

        public short Age { get; set; }

        public Sex Sex { get; set; }

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
        
        public override PeerDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public PeerDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new PeerDto
            {
                ProfileId = VirtualProfileId,

                FirstName = FirstName,
                LastName = LastName,
                Address = Address,
                Note = Note,
                PeerAccessToken = PeerAccessToken,
                IsMuted = IsMuted
            };

            if (includeId)
                dto.Id = Id;

            if (includeAuditData)
            {
                dto.CreatedBy = CreatedBy;
                dto.CreatedTimestamp = CreatedTimestamp;
                dto.LastModifiedBy = LastModifiedBy;
                dto.LastModifiedTimestamp = LastModifiedTimestamp;
            }

            if (!includeDeactivationData)
                return dto;

            dto.DeactivatedTimestamp = DeactivatedTimestamp;
            dto.DeactivatedBy = DeactivatedBy;
            dto.DeactivatedReason = DeactivatedReason;

            return dto;
        }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}