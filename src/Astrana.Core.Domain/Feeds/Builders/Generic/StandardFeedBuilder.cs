/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Feeds.Builders.Atom;
using Astrana.Core.Domain.Feeds.Builders.Rss;
using Astrana.Core.Domain.Feeds.Enums;
using Astrana.Core.Domain.Feeds.Models;
using Astrana.Core.Domain.Feeds.Models.Atom;
using Astrana.Core.Domain.Feeds.Models.Rss;
using Microsoft.Extensions.Logging;
using System.Xml;

namespace Astrana.Core.Domain.Feeds.Builders.Generic
{
    public class StandardFeedBuilder : IStandardFeedBuilder
    {
        private readonly ILogger<StandardFeedBuilder> _logger;

        private readonly IRssFeedBuilder _rssFeedBuilder;
        private readonly IAtomFeedBuilder _atomFeedBuilder;

        public StandardFeedBuilder(ILogger<StandardFeedBuilder> logger, IRssFeedBuilder rssFeedBuilder, IAtomFeedBuilder atomFeedBuilder)
        {
            _logger = logger;

            _rssFeedBuilder = rssFeedBuilder;
            _atomFeedBuilder = atomFeedBuilder;
        }

        public StandardFeedSummary BuildFeedSummary(Uri feedUrl, string feedContent, FeedFormat feedFormat)
        {
            if (feedUrl == null)
                throw new ArgumentNullException(nameof(feedUrl));

            if (string.IsNullOrWhiteSpace(feedContent))
                throw new ArgumentNullException(nameof(feedContent));

            var xmlDocument = new XmlDocument();
                xmlDocument.LoadXml(feedContent);

            var feedSummary = feedFormat switch
            {
                FeedFormat.Rss => new StandardFeedSummary(_rssFeedBuilder.BuildFeedSummary(feedUrl, xmlDocument)),
                FeedFormat.Atom => new StandardFeedSummary(_atomFeedBuilder.BuildFeedSummary(feedUrl, xmlDocument)),

                _ => throw new NotSupportedException("Feed format is not currently supported.")
            };

            return feedSummary;
        }

        public List<StandardFeedItem> BuildFeedItems(Uri feedUrl, string feedContent, FeedFormat feedFormat, FeedSource? source = null)
        {
            if (feedUrl == null)
                throw new ArgumentNullException(nameof(feedUrl));

            if (string.IsNullOrWhiteSpace(feedContent))
                throw new ArgumentNullException(nameof(feedContent));

            var feedItems = feedFormat switch
            {
                FeedFormat.Rss => _rssFeedBuilder.BuildFeedItems(feedUrl, feedContent, source).Select(item => new StandardFeedItem(item)).ToList(),
                FeedFormat.Atom => _atomFeedBuilder.BuildFeedItems(feedUrl, feedContent, source).Select(item => new StandardFeedItem(item)).ToList(),

                _ => throw new NotSupportedException("Feed format is not currently supported.")
            };

            return feedItems;
        }

        public StandardFeedItem BuildFeedItem(RssFeedItem rssFeedItem)
        {
            return new StandardFeedItem
            {
                Identifier = rssFeedItem.Guid,

                Title = rssFeedItem.Title,

                Summary = rssFeedItem.Summary,
                Content = rssFeedItem.Content,

                Rights = rssFeedItem.Copyright,

                Image = rssFeedItem.Image,
                Thumbnail = rssFeedItem.Thumbnail,

                ContentRating = rssFeedItem.Rating,

                Authors = rssFeedItem.Authors?.Select(o => new StandardFeedAuthor(o)).ToList(),
                Categories = rssFeedItem.Categories,
                Links = rssFeedItem.Links?.Select(o => new StandardFeedLink(o)).ToList(),

                Published = rssFeedItem.Published,
                LastUpdated = rssFeedItem.LastUpdated,

                Source = rssFeedItem.Source
            };
        }

        public StandardFeedItem BuildFeedItem(AtomFeedItem atomFeedItem)
        {
            return new StandardFeedItem
            {
                Identifier = atomFeedItem.Id,

                Title = atomFeedItem.Title,

                Summary = atomFeedItem.Summary,
                Content = atomFeedItem.Content,

                Rights = atomFeedItem.Rights,

                Image = atomFeedItem.Image,
                Thumbnail = atomFeedItem.Thumbnail,

                ContentRating = atomFeedItem.ContentRating,

                Authors = atomFeedItem.Contributors?.Select(o => new StandardFeedAuthor(o)).ToList(),
                Categories = atomFeedItem.Categories,
                Links = atomFeedItem.Links?.Select(o => new StandardFeedLink(o)).ToList(),

                Published = atomFeedItem.Published,
                LastUpdated = atomFeedItem.LastUpdated,

                Source = atomFeedItem.Source
            };
        }

        public StandardFeedItem ConvertFeedItems(List<RssFeedItem> rssFeedItem)
        {
            throw new NotImplementedException();
        }

        public StandardFeedItem ConvertFeedItems(List<AtomFeedItem> atomFeedItem)
        {
            throw new NotImplementedException();
        }
    }
}
