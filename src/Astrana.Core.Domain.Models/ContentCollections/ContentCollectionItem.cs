/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.AudioClips;
using Astrana.Core.Domain.Models.ContentCollections.Constants;
using Astrana.Core.Domain.Models.ContentCollections.Contracts;
using Astrana.Core.Domain.Models.ContentCollections.DomainTransferObjects;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Links;
using Astrana.Core.Domain.Models.Media.Enums;
using Astrana.Core.Domain.Models.Videos;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.ContentCollections
{
    public sealed class ContentCollectionItem : DomainEntity, IContentCollectionItem, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public ContentCollectionItem()
        {
            NameUnique = ModelProperties.ContentCollectionItem.NameUnique;
            NameSingularForm = ModelProperties.ContentCollectionItem.NameSingularForm;
            NamePluralForm = ModelProperties.ContentCollectionItem.NamePluralForm;
        }
        
        public ContentCollectionItem(ContentCollectionItemDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                ContentCollectionItemId = dto.Id.Value;

            if (dto.MediaType.HasValue)
                MediaType = dto.MediaType.Value;

            if (dto.LinkId.HasValue)
                LinkId = dto.LinkId.Value;

            if (dto.Link != null)
                Link = new Link(dto.Link);

            if (dto.ImageId.HasValue)
                ImageId = dto.ImageId.Value;
            
            if (dto.Image != null)
                Image = new Image(dto.Image);

            if (dto.VideoId.HasValue)
                VideoId = dto.VideoId.Value;

            if (dto.Video != null)
                Video = new Video(dto.Video);

            if (dto.AudioId.HasValue)
                AudioId = dto.AudioId.Value;

            if (dto.Audio != null)
                Audio = new AudioClip(dto.Audio);
            
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
        public Guid ContentCollectionItemId { get; set; }

        public MediaType MediaType { get; set; }

        public Link? Link { get; set; }

        public Guid? LinkId { get; set; }

        public Image? Image { get; set; }

        public Guid? ImageId { get; set; }

        public Video? Video { get; set; }

        public Guid? VideoId { get; set; }

        public AudioClip? Audio { get; set; }

        public Guid? AudioId { get; set; }

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

        public override ContentCollectionItemDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public ContentCollectionItemDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new ContentCollectionItemDto
            {
                MediaType = MediaType,

                ImageId = ImageId,
                Image = Image == null ? null : Image.ToDomainTransferObject(includeId, includeAuditData, includeDeactivationData),

                VideoId = VideoId,
                Video = Video == null ? null : Video.ToDomainTransferObject(includeId, includeAuditData, includeDeactivationData),

                AudioId = AudioId,
                Audio = Audio == null ? null : Audio.ToDomainTransferObject(includeId, includeAuditData, includeDeactivationData),
                
                LinkId = LinkId,
                Link = Link == null ? null : Link.ToDomainTransferObject(includeId, includeAuditData, includeDeactivationData)
            };

            if (includeId)
                dto.Id = ContentCollectionItemId;

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