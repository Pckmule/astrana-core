/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel.DataAnnotations;
using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.AudioClips.Constants;
using Astrana.Core.Domain.Models.AudioClips.Contracts;
using Astrana.Core.Domain.Models.AudioClips.DomainTransferObjects;
using Astrana.Core.Domain.Models.Files.DomainTransferObjects;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;

namespace Astrana.Core.Domain.Models.AudioClips
{
    public sealed class Audio : DomainEntity<Guid, AudioDto>, IAudio, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public Audio()
        {
            NameUnique = ModelProperties.Audio.NameUnique;
            NameSingularForm = ModelProperties.Audio.NameSingularForm;
            NamePluralForm = ModelProperties.Audio.NamePluralForm;
        }

        public Audio(AudioDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                AudioId = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.Location))
                Location = dto.Location;

            if (!string.IsNullOrEmpty(dto.Caption))
                Caption = dto.Caption;

            if (!string.IsNullOrEmpty(dto.Copyright))
                Copyright = dto.Copyright;

            if (dto.Size != null)
                Size = dto.Size;

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

        [Required]
        public Guid AudioId
        {
            get => Id;
            set => Id = value;
        }

        [Required]
        [MinLength(ModelProperties.Audio.MinimumLocationLength)]
        [MaxLength(ModelProperties.Audio.MaximumLocationLength)]
        public string Location { get; set; }
        
        [MinLength(ModelProperties.Audio.MinimumCaptionLength)]
        [MaxLength(ModelProperties.Audio.MaximumCaptionLength)]
        public string? Caption { get; set; }

        [MinLength(ModelProperties.Audio.MinimumCopyrightLength)]
        [MaxLength(ModelProperties.Audio.MaximumCopyrightLength)]
        public string? Copyright { get; set; }

        public FileSizeInfoDto? Size { get; set; }

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

        public override AudioDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public AudioDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new AudioDto
            {
                Location = Location,
                Caption = Caption,
                Copyright = Copyright,
                Size = Size
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