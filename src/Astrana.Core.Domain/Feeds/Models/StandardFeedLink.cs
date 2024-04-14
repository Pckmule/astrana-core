/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Feeds.Models.Atom;
using Astrana.Core.Domain.Feeds.Models.Rss;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Feeds.Models
{
    public class StandardFeedLink
    {
        [JsonConstructor]
        public StandardFeedLink() { }

        public StandardFeedLink(Uri href, string? text = null) : this()
        {
            Href = href;
            Text = text;
        }

        public StandardFeedLink(RssFeedLink rssFeedLink) : this()
        {
            Href = rssFeedLink.Href;
            Text = rssFeedLink.Text;
        }

        public StandardFeedLink(AtomFeedLink atomFeedLink) : this()
        {
            Href = atomFeedLink.Href;
            Text = atomFeedLink.Text;
        }

        [Required]
        public Uri Href { get; set; }

        public string? Text { get; set; }
    }
}
