/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Feeds.Models.Rss
{
    public class RssFeedAuthor
    {
        [JsonConstructor]
        public RssFeedAuthor() { }

        public RssFeedAuthor(string name, Uri? websiteUrl = null) : this()
        {
            Name = name;
            WebsiteUrl = websiteUrl;
        }

        [Required]
        public string Name { get; set; }

        public Uri? WebsiteUrl { get; set; }
    }
}
