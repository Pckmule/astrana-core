/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.Posts.Constants;
using Astrana.Core.Domain.Models.Posts.Contracts;
using Astrana.Core.Domain.Models.Posts.DomainTransferObjects;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Posts
{
    public sealed class Post : DomainAggregateEntity<long, PostDto>, IPost, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public Post()
        {
            NameUnique = ModelProperties.Post.NameUnique;
            NameSingularForm = ModelProperties.Post.NameSingularForm;
            NamePluralForm = ModelProperties.Post.NamePluralForm;
        }

        public Post(PostDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                PostId = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.Text))
                Text = dto.Text;

            if (dto.Attachments != null && dto.Attachments.Any())
                Attachments = dto.Attachments.Select(postAttachmentDto => new PostAttachment(postAttachmentDto)).ToList();

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

        public Post(PostToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            PostId = 0;

            if (!string.IsNullOrEmpty(dto.Text))
                Text = dto.Text;

            if (dto.Attachments != null && dto.Attachments.Any())
                Attachments = dto.Attachments;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }
        
        [Required]
        [JsonIgnore]
        public long PostId
        {
            get => Id;
            set => Id = value;
        }

        //[RequiredOnCondition(nameof(Attachments), Condition.ItemCountLessThan, 1)]
        [MinLength(ModelProperties.Post.MinimumTextLength)]
        [MaxLength(ModelProperties.Post.MaximumTextLength)]
        public string Text { get; set; } = "";

        public List<PostAttachment>? Attachments { get; set; } = new();

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

        public override PostDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public PostDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new PostDto
            {
                Text = Text
            };

            if (Attachments is { Count: > 0 })
                dto.Attachments = Attachments.Select(o => o.ToDomainTransferObject(includeId, includeAuditData)).ToList();

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

        public static class Factory
        {
            public static Post CreateInstance()
            {
                return new Post();
            }

            public static Post CreateInstance(string text)
            {
                return new Post
                {
                    Text = text
                };
            }

            public static Post CreateInstance(string text, Guid createdBy, DateTimeOffset createdTimestamp)
            {
                return new Post
                {
                    Text = text,
                    CreatedBy = createdBy,
                    CreatedTimestamp = createdTimestamp,
                    LastModifiedBy = createdBy,
                    LastModifiedTimestamp = createdTimestamp
                };
            }

            public static Post CreateInstanceWithAttachments(string text, List<PostAttachment> attachments)
            {
                return new Post
                {
                    Text = text,
                    Attachments = attachments
                };
            }

            public static Post CreateInstanceWithAttachments(string text, List<PostAttachment> attachments, Guid createdBy, DateTimeOffset createdTimestamp)
            {
                return new Post
                {
                    Text = text,
                    Attachments = attachments,
                    CreatedBy = createdBy,
                    CreatedTimestamp = createdTimestamp
                };
            }
        }
    }
}