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
    public class StandardFeedAuthor
    {
        [JsonConstructor]
        public StandardFeedAuthor() { }

        public StandardFeedAuthor(string name, Uri? websiteUrl = null, string? email = null) : this()
        {
            Name = name;
            WebsiteUrl = websiteUrl;
            Email = email;
        }

        public StandardFeedAuthor(RssFeedAuthor rssFeedAuthor) : this()
        {
            Name = rssFeedAuthor.Name;
            WebsiteUrl = rssFeedAuthor.WebsiteUrl;
        }

        public StandardFeedAuthor(AtomFeedAuthor atomFeedAuthor) : this()
        {
            Name = atomFeedAuthor.Name;
            WebsiteUrl = atomFeedAuthor.WebsiteUrl;
            Email = atomFeedAuthor.Email;
        }

        public StandardFeedAuthor(AtomFeedContributor atomFeedContributor) : this()
        {
            Name = atomFeedContributor.Name;
            WebsiteUrl = atomFeedContributor.WebsiteUrl;
            Email = atomFeedContributor.Email;
        }

        [Required]
        public string Name { get; set; }

        public Uri? WebsiteUrl { get; set; }

        public string? Email { get; set; }
    }
}
