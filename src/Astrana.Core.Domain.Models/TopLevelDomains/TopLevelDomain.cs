/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.Countries;
using Astrana.Core.Domain.Models.TopLevelDomains.Constants;
using Astrana.Core.Domain.Models.TopLevelDomains.Contracts;
using Astrana.Core.Domain.Models.TopLevelDomains.DomainTransferObjects;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.TopLevelDomains
{
    public sealed class TopLevelDomain : DomainEntity, ITopLevelDomain, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public TopLevelDomain()
        {
            NameUnique = ModelProperties.TopLevelDomain.NameUnique;
            NameSingularForm = ModelProperties.TopLevelDomain.NameSingularForm;
            NamePluralForm = ModelProperties.TopLevelDomain.NamePluralForm;
        }

        public TopLevelDomain(TopLevelDomainDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                TopLevelDomainId = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.Domain))
                Domain = dto.Domain;

            if (dto.Country != null)
                Country = dto.Country;

            if (dto.IsImplemented.HasValue)
                IsImplemented = dto.IsImplemented.Value;

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

        public TopLevelDomain(TopLevelDomainToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            TopLevelDomainId = Guid.Empty;

            if (!string.IsNullOrEmpty(dto.Domain))
                Domain = dto.Domain;

            if (dto.Country != null)
                Country = dto.Country;

            if (dto.IsImplemented.HasValue)
                IsImplemented = dto.IsImplemented.Value;
            
            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        [Required]
        [JsonIgnore]
        public Guid TopLevelDomainId
        {
            get => Id;
            set => Id = value;
        }

        [Required]
        [MinLength(ModelProperties.TopLevelDomain.MinimumDomainLength)]
        [MaxLength(ModelProperties.TopLevelDomain.MaximumDomainLength)]
        public string Domain { get; set; }

        [Required]
        public Country Country { get; set; }

        [Required]
        public bool IsImplemented { get; set; }

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

        public override TopLevelDomainDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public TopLevelDomainDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new TopLevelDomainDto
            {
                Domain = Domain
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