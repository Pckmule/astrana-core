/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.NewContentWorkflowStages.Constants;
using Astrana.Core.Domain.Models.NewContentWorkflowStages.Contracts;
using Astrana.Core.Domain.Models.NewContentWorkflowStages.DomainTransferObjects;
using Astrana.Core.Domain.Models.NewContentWorkflowStages.Enums;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.NewContentWorkflowStages
{
    public sealed class NewContentWorkflowStage : DomainEntity<Guid, NewContentWorkflowStageDto>, INewContentWorkflowStage, IAuditable<Guid>
    {
        public NewContentWorkflowStage()
        {
            NameUnique = ModelProperties.NewContentWorkflowStage.NameUnique;
            NameSingularForm = ModelProperties.NewContentWorkflowStage.NameSingularForm;
            NamePluralForm = ModelProperties.NewContentWorkflowStage.NamePluralForm;
        }

        public NewContentWorkflowStage(NewContentWorkflowStageDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                NewContentWorkflowStageId = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.ContentEntityId))
                ContentEntityId = dto.ContentEntityId;

            if (!string.IsNullOrEmpty(dto.ContentEntityTypeId))
                ContentEntityTypeId = dto.ContentEntityTypeId;

            if (dto.Stage.HasValue)
                Stage = dto.Stage.Value;
            
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
        
        public NewContentWorkflowStage(NewContentWorkflowStageToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            NewContentWorkflowStageId = Guid.Empty;

            if (!string.IsNullOrEmpty(dto.ContentEntityId))
                ContentEntityId = dto.ContentEntityId;

            if (!string.IsNullOrEmpty(dto.ContentEntityTypeId))
                ContentEntityTypeId = dto.ContentEntityTypeId;

            if (dto.Stage.HasValue)
                Stage = dto.Stage.Value;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }
        
        [Required]
        [JsonIgnore]
        public Guid NewContentWorkflowStageId
        {
            get => Id; 
            set => Id = value;
        }

        [Required]
        public string ContentEntityId { get; set; }

        [Required]
        public string ContentEntityTypeId { get; set; }

        [Required]
        public NewContentStage Stage { get; set; }

        [Required]
        public Guid CreatedBy { get; set; }

        [Required]
        public Guid LastModifiedBy { get; set; }

        [Required]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required]
        public DateTimeOffset LastModifiedTimestamp { get; set; }
        
        public NewContentWorkflowStageDto ToDomainTransferObject(bool includeId, bool includeAuditData)
        {
            var dto = new NewContentWorkflowStageDto
            {
                ContentEntityId = ContentEntityId,
                ContentEntityTypeId = ContentEntityTypeId,
                Stage = Stage
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