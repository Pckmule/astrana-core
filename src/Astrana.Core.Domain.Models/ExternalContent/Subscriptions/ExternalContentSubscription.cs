/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.ExternalContent.Subscriptions.Constants;
using Astrana.Core.Domain.Models.ExternalContent.Subscriptions.DomainTransferObjects;
using Astrana.Core.Domain.Models.Images;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.ExternalContent.Subscriptions
{
    public sealed class ExternalContentSubscription : DomainEntity, IAuditable<Guid>, IDeactivatable<Guid>
    {
        public ExternalContentSubscription()
        {
            NameUnique = ModelProperties.ExternalContentSubscription.NameUnique;
            NameSingularForm = ModelProperties.ExternalContentSubscription.NameSingularForm;
            NamePluralForm = ModelProperties.ExternalContentSubscription.NamePluralForm;
        }

        public ExternalContentSubscription(ExternalContentSubscriptionDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                ExternalContentSubscriptionId = dto.Id.Value;

            if (dto.Url != null)
                Url = dto.Url;

            if (!string.IsNullOrEmpty(dto.Title))
                Title = dto.Title;

            if (!string.IsNullOrEmpty(dto.SubTitle))
                SubTitle = dto.SubTitle;

            if (!string.IsNullOrEmpty(dto.Description))
                Description = dto.Description;

            if (!string.IsNullOrEmpty(dto.Locale))
                Locale = dto.Locale;

            if (!string.IsNullOrEmpty(dto.Language))
                Language = dto.Language;

            if (!string.IsNullOrEmpty(dto.CharSet))
                CharSet = dto.CharSet;

            if (!string.IsNullOrEmpty(dto.AccessToken))
                AccessToken = dto.AccessToken;

            if (dto.IconImage != null)
                IconImage = new Image(dto.IconImage);

            if (dto.LogoImage != null)
                IconImage = new Image(dto.LogoImage);

            if (dto.CoverImage != null)
                IconImage = new Image(dto.CoverImage);

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

        public ExternalContentSubscription(ExternalContentSubscriptionToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            ExternalContentSubscriptionId = Guid.Empty;

            if (dto.Url != null)
                Url = dto.Url;

            if (!string.IsNullOrEmpty(dto.Title))
                Title = dto.Title;

            if (!string.IsNullOrEmpty(dto.Description))
                Description = dto.Description;

            if (!string.IsNullOrEmpty(dto.Locale))
                Locale = dto.Locale;

            if (!string.IsNullOrEmpty(dto.Language))
                Language = dto.Language;

            if (!string.IsNullOrEmpty(dto.CharSet))
                CharSet = dto.CharSet;

            if (!string.IsNullOrEmpty(dto.AccessToken))
                AccessToken = dto.AccessToken;

            if (dto.IconImage != null)
                IconImage = new Image(dto.IconImage);

            if (dto.LogoImage != null)
                LogoImage = new Image(dto.LogoImage);

            if (dto.CoverImage != null)
                CoverImage = new Image(dto.CoverImage);

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        [Required]
        [JsonIgnore]
        public Guid ExternalContentSubscriptionId
        {
            get => Id;
            set => Id = value;
        }
        
        [Required]
        [MinLength(ModelProperties.ExternalContentSubscription.MinimumUrlLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumUrlLength)]
        public Uri Url { get; set; }

        [Required]
        [MinLength(ModelProperties.ExternalContentSubscription.MinimumTitleLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumTitleLength)]
        public string? Title { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscription.MinimumSubTitleLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumSubTitleLength)]
        public string? SubTitle { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscription.MinimumDescriptionLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumDescriptionLength)]
        public string? Description { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscription.MinimumWebsiteUrlLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumWebsiteUrlLength)]
        public Uri? WebsiteUrl { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscription.MinimumCopyrightLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumCopyrightLength)]
        public string? Copyright { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscription.MinimumLocaleLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumLocaleLength)]
        public string? Locale { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscription.MinimumLanguageLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumLanguageLength)]
        public string? Language { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscription.MinimumCharSetLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumCharSetLength)]
        public string? CharSet { get; set; }

        [MinLength(ModelProperties.ExternalContentSubscription.MinimumAccessTokenLength)]
        [MaxLength(ModelProperties.ExternalContentSubscription.MaximumAccessTokenLength)]
        public string? AccessToken { get; set; }

        public Image? IconImage { get; set; }

        public Image? LogoImage { get; set; }

        public Image? CoverImage { get; set; }

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

        public override ExternalContentSubscriptionDto ToDomainTransferObject(bool includeId = true, bool includeAuditData = false)
        {
            return ToDomainTransferObject(includeId, includeAuditData, false);
        }

        public ExternalContentSubscriptionDto ToDomainTransferObject(bool includeId, bool includeAuditData, bool includeDeactivationData)
        {
            var dto = new ExternalContentSubscriptionDto
            {
                Url = Url,
                Title = Title,
                Description = Description,
                Locale = Locale,
                CharSet = CharSet,
                IconImage = IconImage?.ToDomainTransferObject(includeId, includeAuditData, includeDeactivationData),
                LogoImage = LogoImage?.ToDomainTransferObject(includeId, includeAuditData, includeDeactivationData),
                CoverImage = CoverImage?.ToDomainTransferObject(includeId, includeAuditData, includeDeactivationData),
                AccessToken = AccessToken
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