/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.ExternalContent.ContentAuthors;
using Astrana.Core.Domain.Models.ExternalContent.ContentItems.Constants;
using Astrana.Core.Domain.Models.ExternalContent.ContentItems.DomainTransferObjects;
using Astrana.Core.Domain.Models.ExternalContent.ContentLinks;
using Astrana.Core.Domain.Models.ExternalContent.ContentSources;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.ExternalContent.ContentItems
{
    public sealed class ExternalContentSubscriptionContentItem : DomainEntity, IAuditable<Guid>
    {
        public ExternalContentSubscriptionContentItem()
        {
            NameUnique = ModelProperties.ExternalContentSubscriptionContentItem.NameUnique;
            NameSingularForm = ModelProperties.ExternalContentSubscriptionContentItem.NameSingularForm;
            NamePluralForm = ModelProperties.ExternalContentSubscriptionContentItem.NamePluralForm;
        }

        public ExternalContentSubscriptionContentItem(ExternalContentSubscriptionContentItemDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                ExternalContentSubscriptionContentItemId = dto.Id.Value;

            if (dto.Url != null)
                Url = dto.Url;

            if (!string.IsNullOrEmpty(dto.Title))
                Title = dto.Title;

            if (!string.IsNullOrEmpty(dto.Summary))
                Summary = dto.Summary;

            if (!string.IsNullOrEmpty(dto.Content))
                Content = dto.Content;

            if (!string.IsNullOrEmpty(dto.Rights))
                Rights = dto.Rights;

            if (!string.IsNullOrEmpty(dto.ContentRating))
                ContentRating = dto.ContentRating;

            if (dto.Published != null)
                Published = dto.Published;

            if (dto.LastUpdated != null)
                LastUpdated = dto.LastUpdated;

            if (dto.Thumbnail != null)
                Thumbnail = new Image(dto.Thumbnail);

            if (dto.Image != null)
                Image = new Image(dto.Image);

            if (dto.Authors is { Count: > 0 })
                Authors = dto.Authors.Select(contentAuthorDto => new ContentAuthor(contentAuthorDto)).ToList();

            if (dto.Categories is { Count: > 0 })
                Categories = dto.Categories;

            if (dto.Links is { Count: > 0 })
                Links = dto.Links.Select(contentLinkDto => new ContentLink(contentLinkDto)).ToList();

            if (dto.Source != null)
                Source = dto.Source;

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

        public ExternalContentSubscriptionContentItem(ExternalContentSubscriptionContentItemToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            ExternalContentSubscriptionContentItemId = Guid.Empty;

            if (dto.Url != null)
                Url = dto.Url;

            if (!string.IsNullOrEmpty(dto.Title))
                Title = dto.Title;

            if (!string.IsNullOrEmpty(dto.Summary))
                Summary = dto.Summary;

            if (!string.IsNullOrEmpty(dto.Content))
                Content = dto.Content;

            if (!string.IsNullOrEmpty(dto.Rights))
                Rights = dto.Rights;

            if (!string.IsNullOrEmpty(dto.ContentRating))
                ContentRating = dto.ContentRating;

            if (dto.Published != null)
                Published = dto.Published;

            if (dto.LastUpdated != null)
                LastUpdated = dto.LastUpdated;

            if (dto.Thumbnail != null)
                Thumbnail = new Image(dto.Thumbnail);

            if (dto.Image != null)
                Image = new Image(dto.Image);

            if (dto.Authors is { Count: > 0 })
                Authors = dto.Authors.Select(contentAuthorDto => new ContentAuthor(contentAuthorDto)).ToList();

            if (dto.Categories is { Count: > 0 })
                Categories = dto.Categories;

            if (dto.Links is { Count: > 0 })
                Links = dto.Links.Select(contentLinkDto => new ContentLink(contentLinkDto)).ToList();

            if (dto.Source != null)
                Source = dto.Source;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        [Required]
        [JsonIgnore]
        public Guid ExternalContentSubscriptionContentItemId
        {
            get => Id;
            set => Id = value;
        }

        [Required]
        [MinLength(ModelProperties.ExternalContentSubscriptionContentItem.MinimumUrlLength)]
        [MaxLength(ModelProperties.ExternalContentSubscriptionContentItem.MaximumUrlLength)]
        public Uri Url { get; set; }

        [Required]
        [MinLength(ModelProperties.ExternalContentSubscriptionContentItem.MinimumTitleLength)]
        [MaxLength(ModelProperties.ExternalContentSubscriptionContentItem.MaximumTitleLength)]
        public string? Title { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscriptionContentItem.MinimumSummaryLength)]
        [MaxLength(ModelProperties.ExternalContentSubscriptionContentItem.MaximumSummaryLength)]
        public string? Summary { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscriptionContentItem.MinimumContentLength)]
        [MaxLength(ModelProperties.ExternalContentSubscriptionContentItem.MaximumContentLength)]
        public string? Content { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscriptionContentItem.MinimumRightsLength)]
        [MaxLength(ModelProperties.ExternalContentSubscriptionContentItem.MaximumRightsLength)]
        public string? Rights { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscriptionContentItem.MinimumContentRatingLength)]
        [MaxLength(ModelProperties.ExternalContentSubscriptionContentItem.MaximumContentRatingLength)]
        public string? ContentRating { get; set; }

        [Required]
        public DateTimeOffset Published { get; set; }

        [Required]
        public DateTimeOffset LastUpdated { get; set; }

        [Required]
        public ContentSource Source { get; set; }

        public Image? Thumbnail { get; set; }

        public Image? Image { get; set; }

        public List<ContentAuthor>? Authors { get; set; }

        public List<string>? Categories { get; set; }

        public List<ContentLink>? Links { get; set; }

        [Required]
        public Guid CreatedBy { get; set; }

        [Required]
        public Guid LastModifiedBy { get; set; }

        [Required]
        public DateTimeOffset CreatedTimestamp { get; set; }

        [Required]
        public DateTimeOffset LastModifiedTimestamp { get; set; }

        public override ExternalContentSubscriptionContentItemDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public ExternalContentSubscriptionContentItemDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new ExternalContentSubscriptionContentItemDto
            {
                Url = Url,

                Title = Title,

                Summary = Summary,
                Content = Content,

                Rights = Rights,
                ContentRating = ContentRating,

                Published = Published,
                LastUpdated = LastUpdated,
                
                Thumbnail = Thumbnail?.ToDomainTransferObject(includeId, includeAuditData, includeDeactivationData),
                Image = Image?.ToDomainTransferObject(includeId, includeAuditData, includeDeactivationData),

                Source = Source
            };

            if (Authors is { Count: > 0 })
                dto.Authors = Authors.Select(o => o.ToDomainTransferObject(includeId, includeAuditData)).ToList();

            if (Categories is { Count: > 0 })
                dto.Categories = Categories;

            if (Links is { Count: > 0 })
                dto.Links = Links.Select(o => o.ToDomainTransferObject(includeId, includeAuditData)).ToList();

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

            return dto;
        }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}