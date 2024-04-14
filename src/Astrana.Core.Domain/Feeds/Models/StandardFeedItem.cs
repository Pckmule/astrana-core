/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Feeds.Models.Atom;
using Astrana.Core.Domain.Feeds.Models.Rss;
using Astrana.Core.Domain.Models.Images.DomainTransferObjects;
using Astrana.Core.Framework.Model;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Feeds.Models
{
    public class StandardFeedItem: IValidatable
    {
        [JsonConstructor]
        public StandardFeedItem() { }

        public StandardFeedItem(RssFeedItem rssFeedItem) : this()
        {
            Identifier = rssFeedItem.Guid;

            Title = rssFeedItem.Title;

            Summary = rssFeedItem.Summary;
            Rights = rssFeedItem.Copyright;

            Published = rssFeedItem.Published;
            LastUpdated = rssFeedItem.LastUpdated ?? rssFeedItem.Published;

            ContentRating = rssFeedItem.Rating;

            Image = rssFeedItem.Image;
            Thumbnail = rssFeedItem.Thumbnail;

            Authors = rssFeedItem.Authors?.Select(o => new StandardFeedAuthor(o)).ToList();
            Categories = rssFeedItem.Categories;
            Links = rssFeedItem.Links?.Select(l => new StandardFeedLink(l)).ToList();

            Source = rssFeedItem.Source;
        }

        public StandardFeedItem(AtomFeedItem atomFeedItem)
        {
            Identifier = atomFeedItem.Id;

            Title = atomFeedItem.Title;

            Summary = atomFeedItem.Summary;
            Content = atomFeedItem.Content;

            Rights = atomFeedItem.Rights;

            ContentRating = atomFeedItem.ContentRating;

            Image = atomFeedItem.Image;
            Thumbnail = atomFeedItem.Thumbnail;

            Authors = atomFeedItem.Contributors?.Select(o => new StandardFeedAuthor(o)).ToList();
            Categories = atomFeedItem.Categories;
            Links = atomFeedItem.Links?.Select(l => new StandardFeedLink(l)).ToList();

            Published = atomFeedItem.Published;
            LastUpdated = atomFeedItem.LastUpdated;

            Source = atomFeedItem.Source;
        }

        public StandardFeedItem(string title, string content, DateTimeOffset published, DateTimeOffset lastUpdated, Uri sourceUrl, string sourceName)
        {
            Title = title;
            Content = content;

            Published = published;
            LastUpdated = lastUpdated;

            Source = new FeedSource(sourceUrl, sourceName);
        }

        public string? Identifier { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Summary { get; set; }

        public string? Content { get; set; }

        public ImageDto? Image { get; set; }

        public ImageDto? Thumbnail { get; set; }

        public string? Rights { get; set; }

        public string? ContentRating { get; set; }

        public List<StandardFeedAuthor>? Authors { get; set; } = [];

        public List<string>? Categories { get; set; } = [];

        public List<StandardFeedLink>? Links { get; set; } = [];

        public DateTimeOffset? Published { get; set; }

        [Required]
        public DateTimeOffset? LastUpdated { get; set; }

        [Required]
        public FeedSource? Source { get; set; }

        [JsonIgnore]
        public bool IsValid => Validate().IsSuccess;

        public EntityValidationResult Validate()
        {
            return this.ValidateDomainModel();
        }
    }
}
