/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.PhoneNumberTypes.Constants;
using Astrana.Core.Domain.Models.PhoneNumberTypes.Contracts;
using Astrana.Core.Domain.Models.PhoneNumberTypes.DomainTransferObjects;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.PhoneNumberTypes
{
    public sealed class PhoneNumberType : DomainEntity<Guid, PhoneNumberTypeDto>, IPhoneNumberType, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public PhoneNumberType()
        {
            NameUnique = ModelProperties.PhoneNumberType.NameUnique;
            NameSingularForm = ModelProperties.PhoneNumberType.NameSingularForm;
            NamePluralForm = ModelProperties.PhoneNumberType.NamePluralForm;
        }

        public PhoneNumberType(PhoneNumberTypeDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                PhoneNumberTypeId = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.Code))
                Code = dto.Code;

            if (dto.DeactivatedTimestamp.HasValue)
                DeactivatedTimestamp = dto.DeactivatedTimestamp;

            if (dto.DeactivatedBy.HasValue)
                DeactivatedBy = dto.DeactivatedBy;

            if (!string.IsNullOrEmpty(dto.DeactivatedReason))
                DeactivatedReason = dto.DeactivatedReason;

            if (dto.CreatedBy.HasValue)
                CreatedBy = dto.CreatedBy.Value;

            if (dto.CreatedTimestamp.HasValue)
                CreatedTimestamp = dto.CreatedTimestamp.Value;

            if (dto.LastModifiedBy.HasValue)
                LastModifiedBy = dto.LastModifiedBy.Value;

            if (dto.LastModifiedTimestamp.HasValue)
                LastModifiedTimestamp = dto.LastModifiedTimestamp.Value;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }
        
        [Required]
        [JsonIgnore]
        public Guid PhoneNumberTypeId
        {
            get => Id;
            set => Id = value;
        }

        [Required]
        [MinLength(ModelProperties.PhoneNumberType.MinimumNameLength)]
        [MaxLength(ModelProperties.PhoneNumberType.MaximumNameLength)]
        public string Name { get; set; }
        
        [MinLength(ModelProperties.PhoneNumberType.MinimumCodeLength)]
        [MaxLength(ModelProperties.PhoneNumberType.MaximumCodeLength)]
        public string? Code { get; set; }

        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string? DeactivatedReason { get; set; }

        public Guid? DeactivatedBy { get; set; }

        [Required]
        public Guid CreatedBy { get; set; }

        [Required]
        public Guid LastModifiedBy { get; set; }

        [Required]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required]
        public DateTimeOffset LastModifiedTimestamp { get; set; }

        public override PhoneNumberTypeDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public PhoneNumberTypeDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new PhoneNumberTypeDto
            {
                Name = Name,
                Code = Code
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