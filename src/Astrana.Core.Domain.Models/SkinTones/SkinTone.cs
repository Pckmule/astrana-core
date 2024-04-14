/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.SkinTones.Constants;
using Astrana.Core.Domain.Models.SkinTones.Contracts;
using Astrana.Core.Domain.Models.SkinTones.DomainTransferObjects;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.SkinTones
{
    public sealed class SkinTone : DomainEntity, ISkinTone, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public SkinTone()
        {
            NameUnique = ModelProperties.SkinTone.NameUnique;
            NameSingularForm = ModelProperties.SkinTone.NameSingularForm;
            NamePluralForm = ModelProperties.SkinTone.NamePluralForm;
        }

        public SkinTone(SkinToneDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                SkinToneId = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.NameTrxCode))
                NameTrxCode = dto.NameTrxCode;

            if (!string.IsNullOrEmpty(dto.ColorCode))
                ColorCode = dto.ColorCode;

            if (!string.IsNullOrEmpty(dto.Description))
                Description = dto.Description;

            if (!string.IsNullOrEmpty(dto.DescriptionTrxCode))
                DescriptionTrxCode = dto.DescriptionTrxCode;

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

        public SkinTone(SkinToneToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            SkinToneId = Guid.Empty;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.NameTrxCode))
                NameTrxCode = dto.NameTrxCode;

            if (!string.IsNullOrEmpty(dto.ColorCode))
                ColorCode = dto.ColorCode;

            if (!string.IsNullOrEmpty(dto.Description))
                Description = dto.Description;

            if (!string.IsNullOrEmpty(dto.DescriptionTrxCode))
                DescriptionTrxCode = dto.DescriptionTrxCode;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        [Required]
        [JsonIgnore]
        public Guid SkinToneId
        {
            get => Id;
            set => Id = value;
        }

        [Required]
        [MinLength(ModelProperties.SkinTone.MinimumNameLength)]
        [MaxLength(ModelProperties.SkinTone.MaximumNameLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.SkinTone.MinimumNameTrxCodeLength)]
        [MaxLength(ModelProperties.SkinTone.MaximumNameTrxCodeLength)]
        public string NameTrxCode { get; set; }

        [Required]
        [MinLength(ModelProperties.SkinTone.MinimumColorCodeLength)]
        [MaxLength(ModelProperties.SkinTone.MaximumColorCodeLength)]
        public string ColorCode { get; set; }

        [Required]
        [MinLength(ModelProperties.SkinTone.MinimumDescriptionLength)]
        [MaxLength(ModelProperties.SkinTone.MaximumDescriptionLength)]
        public string Description { get; set; }

        [Required]
        [MinLength(ModelProperties.SkinTone.MinimumDescriptionTrxCodeLength)]
        [MaxLength(ModelProperties.SkinTone.MaximumDescriptionTrxCodeLength)]
        public string DescriptionTrxCode { get; set; }

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

        public override SkinToneDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public SkinToneDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new SkinToneDto
            {
                Name = Name,
                NameTrxCode = NameTrxCode,
                ColorCode = ColorCode,
                Description = Description,
                DescriptionTrxCode = DescriptionTrxCode
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