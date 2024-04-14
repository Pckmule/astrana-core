/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Images.DomainTransferObjects;
using Astrana.Core.Framework.Model.Validation;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Feeds.Models.Rss
{
    public class RssFeedItem
    {
        [JsonConstructor]
        public RssFeedItem() { }

        public RssFeedItem(string title, string content, Uri sourceUrl, string sourceName) : this()
        {
            Title = title;
            Content = content;

            Source = new FeedSource(sourceUrl, sourceName);
        }

        public string? Guid { get; set; }

        [Required]
        public string Title { get; set; }

        public string? Summary { get; set; }

        public string? Content { get; set; }

        public ImageDto? Image { get; set; }

        public ImageDto? Thumbnail { get; set; }

        public string? Rating { get; set; }

        public string? Copyright { get; set; }

        public List<RssFeedAuthor>? Authors { get; set; } = [];

        public List<string>? Categories { get; set; } = [];

        public List<RssFeedLink>? Links { get; set; } = [];

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
