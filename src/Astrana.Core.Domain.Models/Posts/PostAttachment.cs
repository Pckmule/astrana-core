/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.Attachments.Enums;
using Astrana.Core.Domain.Models.AudioClips;
using Astrana.Core.Domain.Models.ContentCollections;
using Astrana.Core.Domain.Models.Feelings;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Links;
using Astrana.Core.Domain.Models.Posts.Constants;
using Astrana.Core.Domain.Models.Posts.Contracts;
using Astrana.Core.Domain.Models.Posts.DomainTransferObjects;
using Astrana.Core.Domain.Models.Videos;
using Astrana.Core.Extensions;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using Astrana.Core.Framework.Model.Validation.Attributes;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.Posts
{
    public class PostAttachment : DomainEntity<Guid, PostAttachmentDto>, IPostAttachment, IAuditable<Guid>
    {
        public PostAttachment()
        {
            NameUnique = ModelProperties.PostAttachment.NameUnique;
            NameSingularForm = ModelProperties.PostAttachment.NameSingularForm;
            NamePluralForm = ModelProperties.PostAttachment.NamePluralForm;
        }

        public PostAttachment(PostAttachmentDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                Id = dto.Id.Value;

            if (dto.Type.HasValue)
                Type = dto.Type.Value;

            if (dto.Link != null)
                Link = new Link(dto.Link);

            if (dto.LinkId.HasValue && !dto.LinkId.Value.IsEmpty())
                LinkId = dto.LinkId;

            if (dto.Image != null)
                Image = new Image(dto.Image);

            if (dto.ImageId.HasValue && !dto.ImageId.Value.IsEmpty())
                ImageId = dto.ImageId;

            if (dto.Video != null)
                Video = new Video(dto.Video);

            if (dto.VideoId.HasValue && !dto.VideoId.Value.IsEmpty())
                VideoId = dto.VideoId;

            if (dto.Audio != null)
                Audio = new Audio(dto.Audio);

            if (dto.AudioId.HasValue && !dto.AudioId.Value.IsEmpty())
                AudioId = dto.AudioId;

            if (dto.ContentCollection != null)
                ContentCollection = new ContentCollection(dto.ContentCollection);

            if (dto.ContentCollectionId.HasValue && !dto.ContentCollectionId.Value.IsEmpty())
                ContentCollectionId = dto.ContentCollectionId;

            if (dto.Feeling != null)
                Feeling = new Feeling(dto.Feeling);

            if (dto.FeelingId.HasValue && !dto.FeelingId.Value.IsEmpty())
                FeelingId = dto.FeelingId;

            if (dto.Gif != null)
                Gif = new Image(dto.Gif);

            if (dto.GifId.HasValue && !dto.GifId.Value.IsEmpty())
                GifId = dto.GifId;
            
            if (!string.IsNullOrEmpty(dto.Title))
                Title = dto.Title;

            if (!string.IsNullOrEmpty(dto.Caption))
                Caption = dto.Caption;

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

        [ValidId]
        public Guid PostAttachmentId
        {
            get => Id;
            set => Id = value;
        }

        [Required]
        public AttachmentType Type { get; set; }
        
        public Link? Link { get; set; }
        
        public Guid? LinkId { get; set; }

        public Image? Image { get; set; }

        public Guid? ImageId { get; set; }

        public Video? Video { get; set; }

        public Guid? VideoId { get; set; }

        public Audio? Audio { get; set; }

        public Guid? AudioId { get; set; }

        public ContentCollection? ContentCollection { get; set; }
        
        public Guid? ContentCollectionId { get; set; }

        [JsonIgnore]
        public Feeling? Feeling { get; set; }

        public Guid? FeelingId { get; set; }

        public Image? Gif { get; set; }
        
        public Guid? GifId { get; set; }

        [MaxLength(ModelProperties.PostAttachment.MaximumTitleLength)]
        public string? Title { get; set; }

        [MaxLength(ModelProperties.PostAttachment.MaximumCaptionLength)]
        public string? Caption { get; set; }
        
        [Required]
        public Guid CreatedBy { get; set; }

        [Required]
        public Guid LastModifiedBy { get; set; }

        [Required]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required]
        public DateTimeOffset LastModifiedTimestamp { get; set; }

        public override PostAttachmentDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            var dto = new PostAttachmentDto
            {
                Type = Type,

                Link = Link == null ? null : Link.ToDomainTransferObject(includeId, includeAuditData),
                Image = Image == null ? null : Image.ToDomainTransferObject(includeId, includeAuditData),
                Video = Video == null ? null : Video.ToDomainTransferObject(includeId, includeAuditData),
                Audio = Audio == null ? null : Audio.ToDomainTransferObject(includeId, includeAuditData),
                ContentCollection = ContentCollection == null ? null : ContentCollection.ToDomainTransferObject(includeId, includeAuditData),
                Feeling = Feeling == null ? null : Feeling.ToDomainTransferObject(includeId, includeAuditData),
                Gif = Gif == null ? null : Gif.ToDomainTransferObject(includeId, includeAuditData),

                LinkId = LinkId,
                ImageId = ImageId,
                VideoId = VideoId,
                AudioId = AudioId,
                ContentCollectionId = ContentCollectionId,
                FeelingId = FeelingId,
                GifId = GifId,

                Title = Title,
                Caption = Caption
            };

            if (includeId)
                dto.Id = PostAttachmentId;

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
