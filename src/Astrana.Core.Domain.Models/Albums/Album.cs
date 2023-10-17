/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.Albums.Constants;
using Astrana.Core.Domain.Models.Albums.Contracts;
using Astrana.Core.Domain.Models.Albums.DomainTransferObjects;
using Astrana.Core.Domain.Models.ContentCollections;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Albums
{
    public sealed class Album : DomainEntity, IAlbum, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public Album()
        {
            NameUnique = ModelProperties.Album.NameUnique;
            NameSingularForm = ModelProperties.Album.NameSingularForm;
            NamePluralForm = ModelProperties.Album.NamePluralForm;
        }
        
        public Album(AlbumDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                AlbumId = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.Caption))
                Caption = dto.Caption;

            if (!string.IsNullOrEmpty(dto.Copyright))
                Copyright = dto.Copyright;

            if (dto.Items != null && Items.Count > 0)
                Items = dto.Items.Select(albumItemDto => new AlbumItem(albumItemDto)).ToList();

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

        public Album(AddAlbumDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            AlbumId = Guid.Empty;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.Caption))
                Caption = dto.Caption;

            if (!string.IsNullOrEmpty(dto.Copyright))
                Copyright = dto.Copyright;

            if (dto.Items != null && dto.Items.Count > 0)
                Items = dto.Items.Select(albumItemDto => new AlbumItem(albumItemDto)).ToList();
            
            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        public Album(ContentCollection contentCollection) : this()
        {
            if (contentCollection == null)
                throw new ArgumentNullException(nameof(contentCollection));
            
            AlbumId = contentCollection.Id;
            Name = contentCollection.Name;

            if (contentCollection.ContentItems != null && contentCollection.ContentItems.Count > 0)
                Items = contentCollection.ContentItems.Select(contentCollectionItem => new AlbumItem(contentCollectionItem)).ToList();

            CreatedBy = contentCollection.CreatedBy;
            CreatedTimestamp = contentCollection.CreatedTimestamp;
            LastModifiedBy = contentCollection.LastModifiedBy;
            LastModifiedTimestamp = contentCollection.LastModifiedTimestamp;
            
            DeactivatedTimestamp = contentCollection.DeactivatedTimestamp;
            DeactivatedBy = contentCollection.DeactivatedBy;
            DeactivatedReason = contentCollection.DeactivatedReason;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        [Required]
        public Guid AlbumId
        {
            get => Id;
            set => Id = value;
        }

        public string Name { get; set; }

        public string Caption { get; set; }

        public string Copyright { get; set; }

        public List<AlbumItem> Items { get; set; }

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

        public override AlbumDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public AlbumDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new AlbumDto
            {
                Name = Name,
                Caption = Caption,
                Copyright = Copyright
            };

            if (Items is { Count: > 0 })
                dto.Items = Items.Select(o => o.ToDomainTransferObject(includeId, includeAuditData)).ToList();

            if (includeId)
                dto.Id = AlbumId;

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