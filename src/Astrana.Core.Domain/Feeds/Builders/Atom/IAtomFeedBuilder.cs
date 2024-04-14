/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Feeds.Models;
using Astrana.Core.Domain.Feeds.Models.Atom;
using System.Xml;

namespace Astrana.Core.Domain.Feeds.Builders.Atom
{
    public interface IAtomFeedBuilder
    {
        public AtomFeedSummary BuildFeedSummary(Uri url, XmlDocument xmlDocument);

        public List<AtomFeedItem> BuildFeedItems(Uri feedUrl, string feedContent, FeedSource? source = null);

        public AtomFeedItem BuildAtomFeedItem(XmlElement itemNode, FeedSource? source = null);
    }
}
