/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.Peers.Constants;
using Astrana.Core.Domain.Models.Peers.Contracts;
using Astrana.Core.Domain.Models.Peers.DomainTransferObjects;
using Astrana.Core.Domain.Models.Peers.Enums;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Attributes;
using Astrana.Core.Utilities;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Peers
{
    public class PeerConnectionRequestSubmitted : DomainEntity, IPeerConnectionRequestSubmitted, IAuditable<Guid>, IDeactivatable<Guid>
    {
        private string _address = "";

        public PeerConnectionRequestSubmitted()
        {
            NameUnique = ModelProperties.PeerConnectionRequestSubmitted.NameUnique;
            NameSingularForm = ModelProperties.PeerConnectionRequestSubmitted.NameSingularForm;
            NamePluralForm = ModelProperties.PeerConnectionRequestSubmitted.NamePluralForm;
        }

        public PeerConnectionRequestSubmitted(PeerConnectionRequestSubmittedDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                PeerConnectionRequestSubmittedId = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.FirstName))
                FirstName = dto.FirstName;

            if (!string.IsNullOrEmpty(dto.LastName))
                LastName = dto.LastName;

            if (!string.IsNullOrEmpty(dto.Address))
                Address = dto.Address;

            if (!string.IsNullOrEmpty(dto.Note))
                Note = dto.Note;

            if (!string.IsNullOrEmpty(dto.PeerPreviewAccessToken))
                PeerPreviewAccessToken = dto.PeerPreviewAccessToken;

            if (dto.Status.HasValue)
                Status = dto.Status.Value;

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

        public PeerConnectionRequestSubmitted(PeerConnectionRequestSubmittedToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            PeerConnectionRequestSubmittedId = Guid.Empty;

            if (!string.IsNullOrEmpty(dto.FirstName))
                FirstName = dto.FirstName;

            if (!string.IsNullOrEmpty(dto.LastName))
                LastName = dto.LastName;

            if (!string.IsNullOrEmpty(dto.Address))
                Address = dto.Address;

            if (!string.IsNullOrEmpty(dto.Note))
                Note = dto.Note;

            if (!string.IsNullOrEmpty(dto.PeerPreviewAccessToken))
                PeerPreviewAccessToken = dto.PeerPreviewAccessToken;

            if (dto.Status.HasValue)
                Status = dto.Status.Value;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        [Required]
        [JsonIgnore]
        public Guid PeerConnectionRequestSubmittedId
        {
            get => Id;
            set => Id = value;
        }

        /// <summary>
        /// The first name of owner of the Astrana peer instance submitting the connection request.
        /// </summary> 
        /// <example>John</example>
        [Required]
        [MinLength(ModelProperties.PeerConnectionRequestSubmitted.MinimumFirstNameLength)]
        [MaxLength(ModelProperties.PeerConnectionRequestSubmitted.MaximumFirstNameLength)]
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of owner of the Astrana peer instance submitting the connection request.
        /// </summary> 
        /// <example>Smith</example>
        [Required]
        [MinLength(ModelProperties.PeerConnectionRequestSubmitted.MinimumLastNameLength)]
        [MaxLength(ModelProperties.PeerConnectionRequestSubmitted.MaximumLastNameLength)]
        public string LastName { get; set; }

        /// <summary>
        /// The address of the Astrana instance to submit the request connection to.
        /// </summary> 
        /// <example>https://astrana.local</example>
        [Required]
        [MinLength(ModelProperties.PeerConnectionRequestSubmitted.MinimumAddressLength)]
        [MaxLength(ModelProperties.PeerConnectionRequestSubmitted.MaximumAddressLength)]
        [SecureWebAddress]
        public string Address
        {
            get => _address;
            set => _address = value.AddHttpsScheme();
        }

        /// <summary>
        /// An optional note about the Astrana peer instance submitting the connection request.
        /// </summary> 
        /// <example>Remember me? We met at Jane's birthday party.</example>
        [MinLength(ModelProperties.PeerConnectionRequestSubmitted.MinimumNoteLength)]
        [MaxLength(ModelProperties.PeerConnectionRequestSubmitted.MaximumNoteLength)]
        public string Note { get; set; }

        /// <summary>
        /// The short lived access token for accessing preview information from the Astrana instance submitting the connection request.
        /// </summary>
        [MaxLength(ModelProperties.PeerConnectionRequestSubmitted.MaximumPeerPreviewAccessTokenLength)]
        public string PeerPreviewAccessToken { get; set; }

        /// <summary>
        /// The status of the connection request.
        /// </summary>
        [Required]
        public PeerConnectionRequestStatus Status { get; set; }

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

        public override PeerConnectionRequestSubmittedDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public PeerConnectionRequestSubmittedDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new PeerConnectionRequestSubmittedDto
            {
                FirstName = FirstName,
                LastName = LastName,
                Address = Address,
                Note = Note,
                PeerPreviewAccessToken = PeerPreviewAccessToken,
                Status = Status
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