/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Domain.Models.Links.Constants;
using Astrana.Core.Domain.Models.Links.Contracts;
using Astrana.Core.Domain.Models.Links.DomainTransferObjects;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.Links
{
    public sealed class Link : DomainEntity<Guid, LinkDto>, ILink, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public Link()
        {
            NameUnique = ModelProperties.Link.NameUnique;
            NameSingularForm = ModelProperties.Link.NameSingularForm;
            NamePluralForm = ModelProperties.Link.NamePluralForm;
        }

        public Link(LinkDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                LinkId = dto.Id.Value;

            if (dto.Url != null)
                Url = dto.Url;

            if (!string.IsNullOrEmpty(dto.Title))
                Title = dto.Title;

            if (!string.IsNullOrEmpty(dto.Description))
                Description = dto.Description;

            if (!string.IsNullOrEmpty(dto.Caption))
                Caption = dto.Caption;

            if (!string.IsNullOrEmpty(dto.Locale))
                Locale = dto.Locale;

            if (!string.IsNullOrEmpty(dto.CharSet))
                CharSet = dto.CharSet;

            if (!string.IsNullOrEmpty(dto.Robots))
                Robots = dto.Robots;

            if (!string.IsNullOrEmpty(dto.SiteName))
                SiteName = dto.SiteName;

            if (dto.PreviewImage != null)
                PreviewImage = new Image(dto.PreviewImage);

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
        [Range(ModelProperties.Link.IdMinLength, ModelProperties.Link.IdMaxLength)]
        public Guid LinkId
        {
            get => Id; 
            set => Id = value;
        }

        [Required]
        [MinLength(ModelProperties.Link.MinimumUrlLength)]
        [MaxLength(ModelProperties.Link.MaximumUrlLength)]
        public Uri Url { get; set; }

        [Required]
        [MinLength(ModelProperties.Link.MinimumTitleLength)]
        [MaxLength(ModelProperties.Link.MaximumTitleLength)]
        public string Title { get; set; }

        [Required]
        [MinLength(ModelProperties.Link.MinimumDescriptionLength)]
        [MaxLength(ModelProperties.Link.MaximumDescriptionLength)]
        public string? Description { get; set; }

        public string? Caption { get; set; }

        public string? Locale { get; set; }

        public string? CharSet { get; set; }

        public string? Robots { get; set; }

        public string? SiteName { get; set; }

        public Image? PreviewImage { get; set; }

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

        public override LinkDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public LinkDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new LinkDto
            {
                Url = Url,
                Title = Title,
                Description = Description,
                Caption = Caption,
                Locale = Locale,
                CharSet = CharSet,
                Robots = Robots,
                SiteName = SiteName,
                PreviewImage = PreviewImage.ToDomainTransferObject(includeId, includeAuditData, includeDeactivationData)
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