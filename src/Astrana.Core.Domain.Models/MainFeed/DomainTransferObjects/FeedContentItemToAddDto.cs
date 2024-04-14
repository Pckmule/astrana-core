/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Framework.Model;

namespace Astrana.Core.Domain.Models.MainFeed.DomainTransferObjects
{
    public sealed class FeedContentItemToAddDto : IDomainTransferObject
    {
        public string? PeerUuid { get; set; }

        public string? PeerName { get; set; }

        public string? PeerPictureUrl { get; set; }

        public string? ProfileUrl { get; set; }

        public string? Text { get; set; }

        public DateTimeOffset? CreatedTimestamp { get; set; }
    }
}