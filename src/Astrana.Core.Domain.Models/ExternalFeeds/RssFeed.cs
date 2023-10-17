/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.ExternalFeeds.Constants;
using Astrana.Core.Domain.Models.ExternalFeeds.Contracts;
using System.ComponentModel.DataAnnotations;
using Astrana.Core.Framework.Domain;
using Astrana.Core.Framework.Model.Validation;

namespace Astrana.Core.Domain.Models.ExternalFeeds
{
    public sealed class RssFeed : DomainEntity, IRssFeed
    {
        public RssFeed()
        {
            NameUnique = ModelProperties.RssFeed.NameUnique;
            NameSingularForm = ModelProperties.RssFeed.NameSingularForm;
            NamePluralForm = ModelProperties.RssFeed.NamePluralForm;
        }

        [Required]
        [MinLength(ModelProperties.RssFeed.MinimumPeerUuidLength)]
        [MaxLength(ModelProperties.RssFeed.MaximumPeerUuidLength)]
        public string PeerUuid { get; set; }

        [Required]
        [MinLength(ModelProperties.RssFeed.MinimumFullNameLength)]
        [MaxLength(ModelProperties.RssFeed.MaximumFullNameLength)]
        public string PeerName { get; set; }

        public string PeerPictureUrl { get; set; }

        [Required]
        public string ProfileUrl { get; set; }

        [Required]
        [MinLength(ModelProperties.RssFeed.MinimumTextLength)]
        [MaxLength(ModelProperties.RssFeed.MaximumTextLength)]
        public string Text { get; set; } = "";

        [Required]
        public DateTimeOffset CreatedTimestamp { get; set; }

        public override EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}