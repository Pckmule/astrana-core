/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Feeds.Enums;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Astrana.Core.Domain.Models.Images.DomainTransferObjects;

namespace Astrana.Core.Domain.Feeds.Models.Rss
{
    public class RssFeedSummary
    {
        [JsonConstructor]
        public RssFeedSummary()
        {
            Format = FeedFormat.Rss;
        }

        public RssFeedSummary(Uri url, string title, string description = "", ImageDto? iconImage = null): this()
        {
            Url = url;
            Title = title;

            Description = description;
            IconImage = iconImage;
        }

        public FeedFormat Format { get; private set; }

        public string? FormatVersion { get; set; }

        [Required]
        public Uri Url { get; set; }

        public string? Id { get; set; }

        [Required]
        public string? Title { get; set; }

        [Required]
        public string? Description { get; set; }

        public Uri? WebsiteUrl { get; set; }

        public string? Copyright { get; set; }

        public string? Rating { get; set; }

        public string? Locale { get; set; }

        public string? Language { get; set; }

        public string? CharSet { get; set; }

        public ImageDto? IconImage { get; set; }

        public ImageDto? Image { get; set; }

        public ImageDto? CoverImage { get; set; }

        public List<RssFeedAuthor>? Authors { get; set; } = new();

        public List<string>? Categories { get; set; } = new();

        public List<RssFeedLink>? Links { get; set; } = new();

        public int? TimeToLive { get; set; }

        public string? Generator { get; set; }

        public DateTimeOffset? Published { get; set; }
    }
}
