/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.IdentityAccessManagement.Exceptions;
using Astrana.Core.Domain.Models.MainFeed.Constants;
using Astrana.Core.Domain.Models.MainFeed.Contracts;
using Astrana.Core.Domain.Models.MainFeed.DomainTransferObjects;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Models.MainFeed
{
    // Aggregate Entity?
    public sealed class FeedContentItem : DomainEntity, IFeedContentItem
    {
        public FeedContentItem()
        {
            NameUnique = ModelProperties.FeedContentItem.NameUnique;
            NameSingularForm = ModelProperties.FeedContentItem.NameSingularForm;
            NamePluralForm = ModelProperties.FeedContentItem.NamePluralForm;
        }

        public FeedContentItem(FeedContentItemDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            if (dto.Id.HasValue)
                FeedContentItemId = dto.Id.Value;

            if (!string.IsNullOrEmpty(dto.PeerUuid))
                PeerUuid = dto.PeerUuid;

            if (!string.IsNullOrEmpty(dto.PeerName))
                PeerName = dto.PeerName;

            if (!string.IsNullOrEmpty(dto.PeerPictureUrl))
                PeerPictureUrl = dto.PeerPictureUrl;

            if (!string.IsNullOrEmpty(dto.ProfileUrl))
                ProfileUrl = dto.ProfileUrl;

            if (!string.IsNullOrEmpty(dto.Text))
                Text = dto.Text;

            if (dto.CreatedTimestamp.HasValue)
                CreatedTimestamp = dto.CreatedTimestamp.Value;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        public FeedContentItem(FeedContentItemToAddDto dto) : this()
        {
            if (dto == null)
                throw new ArgumentNullException(nameof(dto));

            FeedContentItemId = Guid.Empty;

            if (!string.IsNullOrEmpty(dto.PeerUuid))
                PeerUuid = dto.PeerUuid;

            if (!string.IsNullOrEmpty(dto.PeerName))
                PeerName = dto.PeerName;

            if (!string.IsNullOrEmpty(dto.PeerPictureUrl))
                PeerPictureUrl = dto.PeerPictureUrl;

            if (!string.IsNullOrEmpty(dto.ProfileUrl))
                ProfileUrl = dto.ProfileUrl;

            if (!string.IsNullOrEmpty(dto.Text))
                Text = dto.Text;

            if (dto.CreatedTimestamp.HasValue)
                CreatedTimestamp = dto.CreatedTimestamp.Value;

            var validationResult = Validate();

            if (!validationResult.IsSuccess)
                throw new InvalidDomainEntityStateException(validationResult.ValidatedEntityName, new Exception(validationResult.Message));
        }

        [Required]
        [JsonIgnore]
        public Guid FeedContentItemId
        {
            get => Id;
            set => Id = value;
        }

        [Required]
        [MinLength(ModelProperties.FeedContentItem.MinimumPeerUuidLength)]
        [MaxLength(ModelProperties.FeedContentItem.MaximumPeerUuidLength)]
        public string PeerUuid { get; set; }

        [Required]
        [MinLength(ModelProperties.FeedContentItem.MinimumFullNameLength)]
        [MaxLength(ModelProperties.FeedContentItem.MaximumFullNameLength)]
        public string PeerName { get; set; }

        public string PeerPictureUrl { get; set; }

        [Required]
        public string ProfileUrl { get; set; }

        [Required]
        [MinLength(ModelProperties.FeedContentItem.MinimumTextLength)]
        [MaxLength(ModelProperties.FeedContentItem.MaximumTextLength)]
        public string Text { get; set; } = "";

        [Required]
        public DateTimeOffset CreatedTimestamp { get; set; }

        public FeedContentItemDto ToDomainTransferObject(bool includeId, bool includeAuditData)
        {
            var dto = new FeedContentItemDto
            {
                PeerUuid = PeerUuid,
                PeerName = PeerName,
                PeerPictureUrl = PeerPictureUrl,
                ProfileUrl = ProfileUrl,
                CreatedTimestamp = CreatedTimestamp
            };

            if (includeId)
                dto.Id = Id;

            return dto;
        }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}