/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Feeds.Enums;
using Astrana.Core.Domain.Feeds.Models.Atom;
using Astrana.Core.Domain.Feeds.Models.Rss;
using Astrana.Core.Domain.Models.Images.DomainTransferObjects;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Feeds.Models
{
    public class StandardFeedSummary
    {
        [JsonConstructor]
        public StandardFeedSummary() { }

        public StandardFeedSummary(RssFeedSummary rssFeedSummary): this()
        {
            Url = rssFeedSummary.Url;

            Format = rssFeedSummary.Format;
            FormatVersion = rssFeedSummary.FormatVersion;

            Title = rssFeedSummary.Title;

            Summary = rssFeedSummary.Description;
            Copyright = rssFeedSummary.Copyright;

            Locale = rssFeedSummary.Locale;
            Language = rssFeedSummary.Language;
            CharSet = rssFeedSummary.CharSet;

            WebsiteUrl = rssFeedSummary.WebsiteUrl;

            IconImage = rssFeedSummary.IconImage;
            LogoImage = rssFeedSummary.Image;
            CoverImage = rssFeedSummary.CoverImage;

            Authors = rssFeedSummary.Authors?.Select(o => new StandardFeedAuthor(o)).ToList();

            Categories = rssFeedSummary.Categories;
            Links = rssFeedSummary.Links?.Select(o => new StandardFeedLink(o)).ToList() ?? [];

            TimeToLive = rssFeedSummary.TimeToLive;
            Generator = rssFeedSummary.Generator;
        }

        public StandardFeedSummary(AtomFeedSummary atomFeedSummary)
        {
            Url = atomFeedSummary.Url;

            Format = atomFeedSummary.Format;
            FormatVersion = atomFeedSummary.FormatVersion;

            Title = atomFeedSummary.Title;
            SubTitle = atomFeedSummary.SubTitle;

            Summary = atomFeedSummary.Summary;
            Copyright = atomFeedSummary.Rights;

            Locale = atomFeedSummary.Locale;
            Language = atomFeedSummary.Language;
            CharSet = atomFeedSummary.CharSet;

            WebsiteUrl = atomFeedSummary.WebsiteUrl;

            IconImage = atomFeedSummary.IconImage;
            LogoImage = atomFeedSummary.LogoImage;
            CoverImage = atomFeedSummary.CoverImage;

            Authors = atomFeedSummary.Authors?.Select(o => new StandardFeedAuthor(o)).ToList() ?? [];
            Contributors = atomFeedSummary.Contributors?.Select(o => new StandardFeedAuthor(o)).ToList() ?? [];

            Categories = atomFeedSummary.Categories;
            Links = atomFeedSummary.Links?.Select(o => new StandardFeedLink(o)).ToList() ?? [];

            TimeToLive = atomFeedSummary.TimeToLive;
            Generator = atomFeedSummary.Generator;
        }

        public StandardFeedSummary(Uri url, string title = "", string summary = "", ImageDto? iconImage = null)
        {
            Url = url;
            Title = title;
            Summary = summary;
            IconImage = iconImage;
        }

        public FeedFormat Format { get; set; }

        public string? FormatVersion { get; set; }

        [Required]
        public Uri Url { get; set; }

        [Required]
        public string? Title { get; set; }

        public string? SubTitle { get; set; }

        public string? Summary { get; set; }

        public string? Content { get; set; }

        public Uri? WebsiteUrl { get; set; }

        public string? Copyright { get; set; }

        public string? Locale { get; set; }

        public string? Language { get; set; }

        public string? CharSet { get; set; }

        public ImageDto? IconImage { get; set; }

        public ImageDto? LogoImage { get; set; }

        public ImageDto? CoverImage { get; set; }

        public List<StandardFeedAuthor>? Authors { get; set; } = new();

        public List<StandardFeedAuthor>? Contributors { get; set; } = new();

        public List<string>? Categories { get; set; } = new();

        public List<StandardFeedLink>? Links { get; set; } = new();

        public int? TimeToLive { get; set; }

        public string? Generator { get; set; }
    }
}
