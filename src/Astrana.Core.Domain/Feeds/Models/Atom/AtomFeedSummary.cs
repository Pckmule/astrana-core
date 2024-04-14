/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;
using Astrana.Core.Domain.Feeds.Enums;
using Astrana.Core.Domain.Models.Images.DomainTransferObjects;

namespace Astrana.Core.Domain.Feeds.Models.Atom
{
    public class AtomFeedSummary
    {
        [JsonConstructor]
        public AtomFeedSummary()
        {
            Format = FeedFormat.Atom;
        }

        public AtomFeedSummary(Uri url, string title, string summary, ImageDto? iconImage = null): this()
        {
            Url = url;
            Title = title;

            Summary = summary;
            IconImage = iconImage;
        }

        public FeedFormat Format { get; private set; }

        public string? FormatVersion { get; set; }

        [Required]
        public Uri Url { get; set; }

        public string? Id { get; set; }

        [Required]
        public string? Title { get; set; }

        public string? SubTitle { get; set; }

        public string? Summary { get; set; }

        public string? Content { get; set; }

        public Uri? WebsiteUrl { get; set; }

        public string? Rights { get; set; }

        public string? Locale { get; set; }

        public string? Language { get; set; }

        public string? CharSet { get; set; }

        public ImageDto? IconImage { get; set; }

        public ImageDto? LogoImage { get; set; }

        public ImageDto? CoverImage { get; set; }

        public List<AtomFeedAuthor>? Authors { get; set; } = new();

        public List<AtomFeedContributor>? Contributors { get; set; } = new();

        public List<string>? Categories { get; set; } = new();

        public List<AtomFeedLink>? Links { get; set; } = new();

        public int? TimeToLive { get; set; }

        public string? Generator { get; set; }

        public DateTimeOffset? Updated { get; set; }
    }
}
