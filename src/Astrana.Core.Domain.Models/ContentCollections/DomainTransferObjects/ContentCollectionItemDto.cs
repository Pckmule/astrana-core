/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.AudioClips.DomainTransferObjects;
using Astrana.Core.Domain.Models.Images.DomainTransferObjects;
using Astrana.Core.Domain.Models.Links.DomainTransferObjects;
using Astrana.Core.Domain.Models.Media.Enums;
using Astrana.Core.Domain.Models.Videos.DomainTransferObjects;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.ContentCollections.DomainTransferObjects
{
    public sealed class ContentCollectionItemDto : IDomainTransferObject
    {
        public Guid? Id { get; set; }

        public MediaType? MediaType { get; set; }

        public LinkDto? Link { get; set; }

        public Guid? LinkId { get; set; }

        public ImageDto? Image { get; set; }

        public Guid? ImageId { get; set; }

        public VideoDto? Video { get; set; }

        public Guid? VideoId { get; set; }

        public AudioDto? Audio { get; set; }

        public Guid? AudioId { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTimeOffset? CreatedTimestamp { get; set; }

        public DateTimeOffset? LastModifiedTimestamp { get; set; }

        public DateTimeOffset? DeactivatedTimestamp { get; set; }

        public string? DeactivatedReason { get; set; }

        public Guid? DeactivatedBy { get; set; }
    }
}