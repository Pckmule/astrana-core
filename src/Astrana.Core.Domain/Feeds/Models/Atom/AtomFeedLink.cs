/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Feeds.Models.Atom
{
    public class AtomFeedLink
    {
        [JsonConstructor]
        public AtomFeedLink() { }

        public AtomFeedLink(string href, string? text = null, string? rel = null) : this()
        {
            Href = new Uri(href);
            Text = text;
            Rel = rel;
        }

        public AtomFeedLink(Uri href, string? text = null, string? rel = null) : this()
        {
            Href = href;
            Text = text;
            Rel = rel;
        }

        [Required]
        public Uri Href { get; set; }

        public string? Text { get; set; }

        public string? Rel { get; set; }
    }
}
