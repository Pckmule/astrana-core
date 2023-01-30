/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.MainFeed.Constants;
using Astrana.Core.Domain.Models.MainFeed.Contracts;
using Astrana.Core.Validation;
using System.ComponentModel.DataAnnotations;

namespace Astrana.Core.Domain.Models.MainFeed
{
    public sealed class FeedContentItem : BaseDomainModel, IFeedContentItem
    {
        public FeedContentItem()
        {
            NameUnique = ModelProperties.FeedContentItem.NameUnique;
            NameSingularForm = ModelProperties.FeedContentItem.NameSingularForm;
            NamePluralForm = ModelProperties.FeedContentItem.NamePluralForm;
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

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}