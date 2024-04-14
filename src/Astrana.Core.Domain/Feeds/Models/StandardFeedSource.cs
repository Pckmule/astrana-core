/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Feeds.Models
{
    public class FeedSource
    {
        [JsonConstructor]
        public FeedSource() { }

        public FeedSource(Uri url, string? name = null, string? iconUrl = null) : this()
        {
            Url = url;
            Name = name ?? "Unknown Source";
            IconUrl = iconUrl;
        }

        [Required]
        public Uri Url { get; set; }

        [Required]
        public string? Name { get; set; }

        public string? IconUrl { get; set; }
    }
}
