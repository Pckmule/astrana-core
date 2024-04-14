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
using Astrana.Core.Domain.Models.Peers.InputModels;
using Astrana.Core.Domain.Models.UserProfiles.Enums;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Utilities;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Peers
{
    public class PeerConnectionRequestReceived : DomainEntity, IPeerConnectionRequestReceived, IAuditable<Guid>, IDeactivatable<Guid>
    {
        private string _address = "";

        public PeerConnectionRequestReceived()
        {
            NameUnique = ModelProperties.PeerConnectionRequestReceived.NameUnique;
            NameSingularForm = ModelProperties.PeerConnectionRequestReceived.NameSingularForm;
            NamePluralForm = ModelProperties.PeerConnectionRequestReceived.NamePluralForm;
        }

        public PeerConnectionRequestReceived(PeerConnectionRequestReceivedInputModel dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                PeerConnectionRequestReceivedId = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.Address))
                Address = dto.Address;

            if (!string.IsNullOrEmpty(dto.FirstName))
                FirstName = dto.FirstName;

            if (!string.IsNullOrEmpty(dto.LastName))
                LastName = dto.LastName;

            if (dto.Age.HasValue)
                Age = dto.Age.Value;

            if (dto.Sex.HasValue)
                Sex = dto.Sex.Value;

            if (!string.IsNullOrEmpty(dto.Note))
                Note = dto.Note;

            if (!string.IsNullOrEmpty(dto.PeerPreviewAccessToken))
                PeerPreviewAccessToken = dto.PeerPreviewAccessToken;

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
        
        public PeerConnectionRequestReceived(PeerConnectionRequestReceivedToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            PeerConnectionRequestReceivedId = Guid.Empty;

            if (!string.IsNullOrEmpty(dto.Address))
                Address = dto.Address;

            if (dto.PeerSummary != null)
            {
                if (!string.IsNullOrEmpty(dto.PeerSummary.FirstName))
                    FirstName = dto.PeerSummary.FirstName;

                if (!string.IsNullOrEmpty(dto.PeerSummary.LastName))
                    LastName = dto.PeerSummary.LastName;

                if (dto.PeerSummary.Age.HasValue)
                    Age = dto.PeerSummary.Age.Value;

                if (dto.PeerSummary.Sex.HasValue)
                    Sex = dto.PeerSummary.Sex.Value;
            }

            if (!string.IsNullOrEmpty(dto.Note))
                Note = dto.Note;

            if (!string.IsNullOrEmpty(dto.PeerPreviewAccessToken))
                PeerPreviewAccessToken = dto.PeerPreviewAccessToken;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }
        
        [Required]
        [JsonIgnore]
        public Guid PeerConnectionRequestReceivedId
        {
            get => Id;
            set => Id = value;
        }

        /// <summary>
        /// The address of the Astrana instance requesting to connect.
        /// </summary> 
        /// <example>https://astrana.local</example>
        public string Address
        {
            get => _address;
            set => _address = value.AddHttpsScheme();
        }

        /// <summary>
        /// The first name of owner of the Astrana peer instance requesting to connect.
        /// </summary> 
        /// <example>John</example>
        public string FirstName { get; set; }

        /// <summary>
        /// The last name of owner of the Astrana peer instance requesting to connect.
        /// </summary> 
        /// <example>Smith</example>
        public string LastName { get; set; }

        public short Age { get; set; }

        public Sex Sex { get; set; }

        /// <summary>
        /// An optional note about the Astrana peer instance requesting to connect.
        /// </summary> 
        /// <example>Remember me? We met at Jane's birthday party.</example>
        public string Note { get; set; }

        /// <summary>
        /// A short lived access token for accessing preview information from the Astrana instance requesting to connect.
        /// </summary>
        public string PeerPreviewAccessToken { get; set; }

        /// <summary>
        /// The status of the connection request.
        /// </summary>
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

        public override PeerConnectionRequestReceivedDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public PeerConnectionRequestReceivedDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new PeerConnectionRequestReceivedDto
            {
                Address = Address,
                PeerSummary = new PeerSummaryDto
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    Age = Age,
                    Sex = Sex
                },
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