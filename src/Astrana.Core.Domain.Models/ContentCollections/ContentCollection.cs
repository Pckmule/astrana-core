/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.ContentCollections.Constants;
using Astrana.Core.Domain.Models.ContentCollections.Contracts;
using Astrana.Core.Domain.Models.ContentCollections.DomainTransferObjects;
using Astrana.Core.Domain.Models.ContentCollections.Enums;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.ContentCollections
{
    public sealed class ContentCollection : DomainEntity, IContentCollection, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public ContentCollection()
        {
            NameUnique = ModelProperties.ContentCollection.NameUnique;
            NameSingularForm = ModelProperties.ContentCollection.NameSingularForm;
            NamePluralForm = ModelProperties.ContentCollection.NamePluralForm;
        }
        
        public ContentCollection(ContentCollectionDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                ContentCollectionId = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.Caption))
                Caption = dto.Caption;

            if (!string.IsNullOrEmpty(dto.Copyright))
                Copyright = dto.Copyright;

            if (dto.CollectionType.HasValue)
                CollectionType = dto.CollectionType.Value;

            if (dto.ContentItems != null && ContentItems.Count > 0)
                ContentItems = dto.ContentItems.Select(collectionItemDto => new ContentCollectionItem(collectionItemDto)).ToList();

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

        public ContentCollection(AddContentCollectionDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            ContentCollectionId = Guid.Empty;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.Caption))
                Caption = dto.Caption;

            if (!string.IsNullOrEmpty(dto.Copyright))
                Copyright = dto.Copyright;

            if (dto.CollectionType.HasValue)
                CollectionType = dto.CollectionType.Value;

            if (dto.ContentItems != null && dto.ContentItems.Count > 0)
                ContentItems = dto.ContentItems.Select(collectionItemDto => new ContentCollectionItem(collectionItemDto)).ToList();
            
            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        [Required]
        public Guid ContentCollectionId
        {
            get => Id;
            set => Id = value;
        }

        public string Name { get; set; }

        public string Caption { get; set; }

        public string Copyright { get; set; }

        public ContentCollectionType CollectionType { get; set; }

        public List<ContentCollectionItem> ContentItems { get; set; }

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

        public override ContentCollectionDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public ContentCollectionDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new ContentCollectionDto
            {
                Name = Name,
                Caption = Caption,
                Copyright = Copyright
            };

            if (ContentItems is { Count: > 0 })
                dto.ContentItems = ContentItems.Select(o => o.ToDomainTransferObject(includeId, includeAuditData)).ToList();

            if (includeId)
                dto.Id = ContentCollectionId;

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