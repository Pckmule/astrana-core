/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Feeds.Models;
using Astrana.Core.Domain.Feeds.Models.Rss;
using System.Xml;

namespace Astrana.Core.Domain.Feeds.Builders.Rss
{
    public interface IRssFeedBuilder
    {
        public RssFeedSummary BuildFeedSummary(Uri url, XmlDocument xmlDocument);

        public List<RssFeedItem> BuildFeedItems(Uri feedUrl, string feedContent, FeedSource? source = null);

        public RssFeedItem BuildRssFeedItem(XmlElement itemNode, FeedSource? source = null);
    }
}
