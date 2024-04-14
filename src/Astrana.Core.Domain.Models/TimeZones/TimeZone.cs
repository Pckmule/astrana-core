/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.Countries;
using Astrana.Core.Domain.Models.Lookups.Attributes;
using Astrana.Core.Domain.Models.TimeZones.Constants;
using Astrana.Core.Domain.Models.TimeZones.Contracts;
using Astrana.Core.Domain.Models.TimeZones.DomainTransferObjects;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.TimeZones
{
    public sealed class TimeZone : DomainEntity, ITimeZone, IAuditable<Guid>
    {
        public const string FullNameTemplate = "(UTC {{utcZone}}) - {{name}}";

        public TimeZone()
        {
            NameUnique = ModelProperties.TimeZone.NameUnique;
            NameSingularForm = ModelProperties.TimeZone.NameSingularForm;
            NamePluralForm = ModelProperties.TimeZone.NamePluralForm;
        }

        public TimeZone(TimeZoneDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                TimeZoneId = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.NameTrxCode))
                NameTrxCode = dto.NameTrxCode;

            if (!string.IsNullOrEmpty(dto.Abbreviation))
                Abbreviation = dto.Abbreviation;

            if (!string.IsNullOrEmpty(dto.CorrespondingUtcZone))
                CorrespondingUtcZone = dto.CorrespondingUtcZone;

            if (dto.Countries != null)
                Countries = dto.Countries;

            if (dto.DaylightSavingApplies.HasValue)
                DaylightSavingApplies = dto.DaylightSavingApplies.Value;

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

        public TimeZone(TimeZoneToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            TimeZoneId = Guid.Empty;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.NameTrxCode))
                NameTrxCode = dto.NameTrxCode;

            if (!string.IsNullOrEmpty(dto.Abbreviation))
                Abbreviation = dto.Abbreviation;

            if (!string.IsNullOrEmpty(dto.CorrespondingUtcZone))
                CorrespondingUtcZone = dto.CorrespondingUtcZone;

            if (dto.Countries != null)
                Countries = dto.Countries;

            if (dto.DaylightSavingApplies.HasValue)
                DaylightSavingApplies = dto.DaylightSavingApplies.Value;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        [Required]
        [LookupOptionValue]
        [JsonIgnore]
        public Guid TimeZoneId
        {
            get => Id;
            set => Id = value;
        }

        [Required]
        [MinLength(ModelProperties.TimeZone.MinimumNameLength)]
        [MaxLength(ModelProperties.TimeZone.MaximumNameLength)]
        [LookupOptionLabel]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.TimeZone.MinimumNameTrxCodeLength)]
        [MaxLength(ModelProperties.TimeZone.MaximumNameTrxCodeLength)]
        [LookupOptionTranslationCode]
        public string NameTrxCode { get; set; }
        
        [Required]
        [MinLength(ModelProperties.TimeZone.MinimumAbbreviationLength)]
        [MaxLength(ModelProperties.TimeZone.MaximumAbbreviationLength)]
        public string Abbreviation { get; set; }

        [Required]
        [MinLength(ModelProperties.TimeZone.MinimumCorrespondingUtcZoneLength)]
        [MaxLength(ModelProperties.TimeZone.MaximumCorrespondingUtcZoneLength)]
        public string CorrespondingUtcZone { get; set; }

        public HashSet<Country> Countries { get; set; } = new();

        [Required]
        public bool DaylightSavingApplies { get; set; }

        [Required]
        public Guid CreatedBy { get; set; }

        [Required]
        public Guid LastModifiedBy { get; set; }

        [Required]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required]
        public DateTimeOffset LastModifiedTimestamp { get; set; }
        
        public TimeZoneDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            var dto = new TimeZoneDto
            {
                Name = Name
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

            return dto;
        }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}