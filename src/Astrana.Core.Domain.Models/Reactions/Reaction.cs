/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.Reactions.Constants;
using Astrana.Core.Domain.Models.Reactions.Contracts;
using Astrana.Core.Domain.Models.Reactions.DomainTransferObjects;
using Astrana.Core.Domain.Models.Reactions.DomainTransferObjects;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System;
using System.ComponentModel.DataAnnotations;
using System.Drawing;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Reactions
{
    public sealed class Reaction : DomainEntity, IReaction, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public Reaction()
        {
            NameUnique = ModelProperties.Reaction.NameUnique;
            NameSingularForm = ModelProperties.Reaction.NameSingularForm;
            NamePluralForm = ModelProperties.Reaction.NamePluralForm;
        }

        public Reaction(ReactionDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                ReactionId = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.NameTrxCode))
                NameTrxCode = dto.NameTrxCode;

            if (!string.IsNullOrEmpty(dto.IconName))
                IconName = dto.IconName;

            if (!string.IsNullOrEmpty(dto.UnicodeIcon))
                UnicodeIcon = dto.UnicodeIcon;

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

        public Reaction(ReactionToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            ReactionId = Guid.Empty;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.NameTrxCode))
                NameTrxCode = dto.NameTrxCode;

            if (!string.IsNullOrEmpty(dto.IconName))
                IconName = dto.IconName;

            if (!string.IsNullOrEmpty(dto.UnicodeIcon))
                UnicodeIcon = dto.UnicodeIcon;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        [Required]
        [JsonIgnore]
        public Guid ReactionId
        {
            get => Id;
            set => Id = value;
        }

        [Required]
        [MinLength(ModelProperties.Reaction.MinimumNameLength)]
        [MaxLength(ModelProperties.Reaction.MaximumNameLength)]
        public string Name { get; set; }

        [Required]
        [MinLength(ModelProperties.Reaction.MinimumNameTrxCodeLength)]
        [MaxLength(ModelProperties.Reaction.MaximumNameTrxCodeLength)]
        public string NameTrxCode { get; set; }
        
        [Required]
        [MinLength(ModelProperties.Reaction.MinimumIconNameLength)]
        [MaxLength(ModelProperties.Reaction.MaximumIconNameLength)]
        public string IconName { get; set; }

        [Required]
        [MinLength(ModelProperties.Reaction.MinimumUnicodeIconLength)]
        [MaxLength(ModelProperties.Reaction.MaximumUnicodeIconLength)]
        public string UnicodeIcon { get; set; }

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

        public override ReactionDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public ReactionDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new ReactionDto
            {
                Name = Name,
                NameTrxCode = NameTrxCode,
                IconName = IconName,
                UnicodeIcon = UnicodeIcon
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