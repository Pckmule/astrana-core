/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.Countries.Constants;
using Astrana.Core.Domain.Models.Countries.Contracts;
using Astrana.Core.Domain.Models.Countries.DomainTransferObjects;
using Astrana.Core.Domain.Models.Lookups.Attributes;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Countries
{
    // Reference Data?
    public class Country : DomainEntity<long, CountryDto>, ICountry, IAuditable<Guid>, IDeactivatable<Guid>
    {
        private string _twoLetterCode;
        private string _threeLetterCode;

        public Country()
        {
            NameUnique = ModelProperties.Country.NameUnique;
            NameSingularForm = ModelProperties.Country.NameSingularForm;
            NamePluralForm = ModelProperties.Country.NamePluralForm;
        }

        public Country(CountryDto dto): this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                CountryId = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.NameTrxCode))
                NameTrxCode = dto.NameTrxCode;

            if (!string.IsNullOrEmpty(dto.TwoLetterCode))
                TwoLetterCode = dto.TwoLetterCode;

            if (!string.IsNullOrEmpty(dto.ThreeLetterCode))
                ThreeLetterCode = dto.ThreeLetterCode;

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

        public Country(CountryToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            CountryId = 0;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.NameTrxCode))
                NameTrxCode = dto.NameTrxCode;

            if (!string.IsNullOrEmpty(dto.TwoLetterCode))
                TwoLetterCode = dto.TwoLetterCode;

            if (!string.IsNullOrEmpty(dto.ThreeLetterCode))
                ThreeLetterCode = dto.ThreeLetterCode;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        [Required]
        [JsonIgnore]
        public long CountryId
        {
            get => Id;
            set => Id = value;
        }

        [Required]
        [MinLength(ModelProperties.Country.MinimumNameLength)]
        [MaxLength(ModelProperties.Country.MaximumNameLength)]
        [LookupOptionLabel]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.Country.MinimumNameTrxCodeLength)]
        [MaxLength(ModelProperties.Country.MaximumNameTrxCodeLength)]
        [LookupOptionTranslationCode]
        public string NameTrxCode { get; set; }

        [Required]
        [MinLength(ModelProperties.Country.MinimumTwoLetterCodeLength)]
        [MaxLength(ModelProperties.Country.MaximumTwoLetterCodeLength)]
        [LookupOptionValue]
        public string TwoLetterCode
        {
            get => _twoLetterCode;
            set => _twoLetterCode = value.ToUpperInvariant();
        }

        [MinLength(ModelProperties.Country.MinimumThreeLetterCodeLength)]
        [MaxLength(ModelProperties.Country.MaximumThreeLetterCodeLength)]
        public string ThreeLetterCode
        {
            get => _threeLetterCode;
            set => _threeLetterCode = value.ToUpperInvariant();
        }

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

        public override CountryDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public CountryDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new CountryDto
            {
                Name = Name,
                NameTrxCode = NameTrxCode,
                TwoLetterCode = TwoLetterCode,
                ThreeLetterCode = ThreeLetterCode
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