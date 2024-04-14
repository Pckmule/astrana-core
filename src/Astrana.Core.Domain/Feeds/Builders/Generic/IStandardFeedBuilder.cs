/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Feeds.Enums;
using Astrana.Core.Domain.Feeds.Models;
using Astrana.Core.Domain.Feeds.Models.Atom;
using Astrana.Core.Domain.Feeds.Models.Rss;

namespace Astrana.Core.Domain.Feeds.Builders.Generic
{
    public interface IStandardFeedBuilder
    {
        public StandardFeedSummary BuildFeedSummary(Uri feedUrl, string feedContent, FeedFormat feedFormat);

        public List<StandardFeedItem> BuildFeedItems(Uri feedUrl, string feedContent, FeedFormat feedFormat, FeedSource? source = null);

        public StandardFeedItem BuildFeedItem(RssFeedItem rssFeedItem);

        public StandardFeedItem BuildFeedItem(AtomFeedItem atomFeedItem);

        public StandardFeedItem ConvertFeedItems(List<RssFeedItem> rssFeedItem);

        public StandardFeedItem ConvertFeedItems(List<AtomFeedItem> atomFeedItem);
    }
}
