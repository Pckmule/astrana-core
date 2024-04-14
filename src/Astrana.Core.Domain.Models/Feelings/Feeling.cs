/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.Feelings.Constants;
using Astrana.Core.Domain.Models.Feelings.Contracts;
using Astrana.Core.Domain.Models.Feelings.DomainTransferObjects;
using Astrana.Core.Domain.Models.Lookups.Attributes;
using Astrana.Core.Domain.Models.Feelings.DomainTransferObjects;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Feelings
{
    // Reference Data?
    public sealed class Feeling : DomainEntity, IFeeling, IAuditable<Guid>, IDeactivatable<Guid>
    {
        [JsonConstructor]
        public Feeling()
        {
            NameUnique = ModelProperties.Feeling.NameUnique;
            NameSingularForm = ModelProperties.Feeling.NameSingularForm;
            NamePluralForm = ModelProperties.Feeling.NamePluralForm;
        }

        public Feeling(FeelingDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                FeelingId = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.NameTrxCode))
                NameTrxCode = dto.NameTrxCode;

            if (!string.IsNullOrEmpty(dto.IconName))
                IconName = dto.IconName;

            if (!string.IsNullOrEmpty(dto.UnicodeIcon))
                UnicodeIcon = dto.UnicodeIcon;

            if (!string.IsNullOrEmpty(dto.ShortCode))
                ShortCode = dto.ShortCode;
            
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
        
        public Feeling(FeelingToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            FeelingId = Guid.Empty;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.NameTrxCode))
                NameTrxCode = dto.NameTrxCode;

            if (!string.IsNullOrEmpty(dto.IconName))
                IconName = dto.IconName;

            if (!string.IsNullOrEmpty(dto.UnicodeIcon))
                UnicodeIcon = dto.UnicodeIcon;

            if (!string.IsNullOrEmpty(dto.ShortCode))
                ShortCode = dto.ShortCode;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        public Feeling(Guid id, string name, string nameTrxCode, string iconName, string unicodeIcon, string shortCode) : this()
        {
            FeelingId = id;
            Name = name;
            NameTrxCode = nameTrxCode;
            IconName = iconName;
            UnicodeIcon = unicodeIcon;
            ShortCode = shortCode;
        }

        [Required]
        [LookupOptionValue]
        [JsonIgnore]
        public Guid FeelingId
        {
            get => Id;
            set => Id = value;
        }

        [Required]
        [MinLength(ModelProperties.Feeling.MinimumNameLength)]
        [MaxLength(ModelProperties.Feeling.MaximumNameLength)]
        [LookupOptionLabel]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.Feeling.MinimumNameTrxCodeLength)]
        [MaxLength(ModelProperties.Feeling.MaximumNameTrxCodeLength)]
        [LookupOptionTranslationCode]
        public string NameTrxCode { get; set; }

        [Required]
        [MinLength(ModelProperties.Feeling.MinimumIconNameLength)]
        [MaxLength(ModelProperties.Feeling.MaximumIconNameLength)]
        [LookupOptionIconName]
        public string IconName { get; set; }

        [Required]
        [MinLength(ModelProperties.Feeling.MinimumUnicodeIconLength)]
        [MaxLength(ModelProperties.Feeling.MaximumUnicodeIconLength)]
        public string UnicodeIcon { get; set; }

        [Required]
        [MinLength(ModelProperties.Feeling.MinimumShortCodeLength)]
        [MaxLength(ModelProperties.Feeling.MaximumShortCodeLength)]
        public string ShortCode { get; set; }

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

        public override FeelingDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public FeelingDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new FeelingDto
            {
                Name = Name,
                NameTrxCode = NameTrxCode,
                IconName = IconName,
                UnicodeIcon = UnicodeIcon,
                ShortCode = ShortCode,

                CreatedBy = CreatedBy,
                LastModifiedBy = LastModifiedBy,
                CreatedTimestamp = CreatedTimestamp,
                LastModifiedTimestamp = LastModifiedTimestamp
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