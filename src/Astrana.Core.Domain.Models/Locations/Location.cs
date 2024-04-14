/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.Locations.Constants;
using Astrana.Core.Domain.Models.Locations.Contracts;
using Astrana.Core.Domain.Models.Locations.DomainTransferObjects;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Locations
{
    public class Location : DomainEntity<Guid, LocationDto>, ILocation, IAuditable<Guid>
    {
        public Location()
        {
            NameUnique = ModelProperties.Location.NameUnique;
            NameSingularForm = ModelProperties.Location.NameSingularForm;
            NamePluralForm = ModelProperties.Location.NamePluralForm;
        }

        public Location(LocationDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                Id = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

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

        public Location(LocationToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            LocationId = Guid.Empty;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        [ValidId]
        [JsonIgnore]
        public Guid LocationId
        {
            get => Id;
            set => Id = value;
        }
        
        [MaxLength(ModelProperties.Location.MaximumNameLength)]
        public string? Name { get; set; }

        [Required]
        public Guid CreatedBy { get; set; }

        [Required]
        public Guid LastModifiedBy { get; set; }

        [Required]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required]
        public DateTimeOffset LastModifiedTimestamp { get; set; }

        public override LocationDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            var dto = new LocationDto
            {
                Name = Name
            };

            if (includeId)
                dto.Id = LocationId;

            if (!includeAuditData) 
                return dto;

            dto.CreatedBy = CreatedBy;
            dto.CreatedTimestamp = CreatedTimestamp;
            dto.LastModifiedBy = LastModifiedBy;
            dto.LastModifiedTimestamp = LastModifiedTimestamp;

            return dto;
        }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
