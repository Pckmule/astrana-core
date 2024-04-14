/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.ExternalContent.ContentAuthors.DomainTransferObjects;
using Astrana.Core.Domain.Models.ExternalContent.ContentLinks.DomainTransferObjects;
using Astrana.Core.Domain.Models.ExternalContent.ContentSources;
using Astrana.Core.Domain.Models.Images.DomainTransferObjects;
using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.ExternalContent.ContentItems.DomainTransferObjects
{
    public sealed class ExternalContentSubscriptionContentItemDto : IDomainTransferObject
    {
        public Guid? Id { get; set; }

        public Uri? Url { get; set; }

        public string? Title { get; set; }

        public string? Summary { get; set; }

        public string? Content { get; set; }

        public string? Rights { get; set; }

        public string? ContentRating { get; set; }

        public DateTimeOffset Published { get; set; }

        public DateTimeOffset LastUpdated { get; set; }

        public ImageDto? Thumbnail { get; set; }

        public ImageDto? Image { get; set; }

        public List<ContentAuthorDto>? Authors { get; set; }

        public List<string>? Categories { get; set; }

        public List<ContentLinkDto>? Links { get; set; }

        public ContentSource Source { get; set; }

        public Guid? CreatedBy { get; set; }

        public Guid? LastModifiedBy { get; set; }

        public DateTimeOffset? CreatedTimestamp { get; set; }

        public DateTimeOffset? LastModifiedTimestamp { get; set; }
    }
}