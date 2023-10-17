/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.Comments.Constants;
using Astrana.Core.Domain.Models.Comments.Contracts;
using Astrana.Core.Domain.Models.Comments.DomainTransferObjects;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Comments
{
    public sealed class Comment : DomainEntity<Guid, CommentDto>, IComment, IAuditable<Guid>
    {
        public Comment()
        {
            NameUnique = ModelProperties.Comment.NameUnique;
            NameSingularForm = ModelProperties.Comment.NameSingularForm;
            NamePluralForm = ModelProperties.Comment.NamePluralForm;
        }

        public Comment(CommentDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                CommentId = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.Text))
                Text = dto.Text;

            if (!string.IsNullOrEmpty(dto.ContentId))
                ContentId = dto.ContentId;

            if (dto.PeerId.HasValue)
                PeerId = dto.PeerId.Value;
            
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
        public Guid CommentId
        {
            get => Id; 
            set => Id = value;
        }

        [Required]
        [MinLength(ModelProperties.Comment.MinimumTextLength)]
        [MaxLength(ModelProperties.Comment.MaximumTextLength)]
        public string Text { get; set; }

        [Required]
        public string ContentId { get; set; }
        
        [Required]
        public Guid PeerId { get; set; }

        [Required]
        public Guid CreatedBy { get; set; }

        [Required]
        public Guid LastModifiedBy { get; set; }

        [Required]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required]
        public DateTimeOffset LastModifiedTimestamp { get; set; }
        
        public override CommentDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            var dto = new CommentDto
            {
                Text = Text,
            };

            if (includeId)
                dto.Id = Id;

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