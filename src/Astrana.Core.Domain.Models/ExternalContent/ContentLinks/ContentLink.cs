using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.ExternalContent.ContentLinks.Contracts;
using Astrana.Core.Domain.Models.ExternalContent.ContentLinks.DomainTransferObjects;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using ModelProperties = Astrana.Core.Domain.Models.ExternalContent.ContentLinks.Constants.ModelProperties;

namespace Astrana.Core.Domain.Models.ExternalContent.ContentLinks
{
    public sealed class ContentLink : DomainEntity, IContentLink, IAuditable<Guid>
    {
        public ContentLink()
        {
            NameUnique = ModelProperties.ContentLink.NameUnique;
            NameSingularForm = ModelProperties.ContentLink.NameSingularForm;
            NamePluralForm = ModelProperties.ContentLink.NamePluralForm;
        }

        public ContentLink(ContentLinkDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                ContentLinkId = dto.Id.Value;

            if (dto.Url != null && !string.IsNullOrEmpty(dto.Url?.ToString()))
                Url = dto.Url;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.IconUrl))
                IconUrl = dto.IconUrl;

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
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName,
                    new Exception(validationResult.Message));
        }

        public ContentLink(AddContentLinkDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            ContentLinkId = Guid.Empty;

            if (dto.Url != null && !string.IsNullOrEmpty(dto.Url?.ToString()))
                Url = dto.Url;

            if (!string.IsNullOrEmpty(dto.Name))
                Name = dto.Name;

            if (!string.IsNullOrEmpty(dto.IconUrl))
                IconUrl = dto.IconUrl;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName,
                    new Exception(validationResult.Message));
        }

        [Required]
        [JsonIgnore]
        public Guid ContentLinkId
        {
            get => Id;
            set => Id = value;
        }

        public Uri Url { get; set; }

        public string Name { get; set; }

        public string IconUrl { get; set; }

        [Required] public Guid CreatedBy { get; set; }

        [Required] public Guid LastModifiedBy { get; set; }

        [Required] public DateTimeOffset CreatedTimestamp { get; set; }

        [Required] public DateTimeOffset LastModifiedTimestamp { get; set; }

        public override ContentLinkDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            var dto = new ContentLinkDto
            {
                Url = Url,
                Name = Name,
                IconUrl = IconUrl
            };

            if (includeId)
                dto.Id = ContentLinkId;

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
