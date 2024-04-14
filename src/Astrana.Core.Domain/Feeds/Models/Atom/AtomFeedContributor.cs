/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Astrana.Core.Domain.Feeds.Models.Atom
{
    public class AtomFeedContributor
    {
        [JsonConstructor]
        public AtomFeedContributor() { }

        public AtomFeedContributor(string name, Uri? websiteUrl = null, string? email = null) : this()
        {
            Name = name;
            WebsiteUrl = websiteUrl;
            Email = email;
        }

        [Required]
        public string Name { get; set; }

        public Uri? WebsiteUrl { get; set; }

        public string? Email { get; set; }
    }
}
