/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using System.Text.Json.Serialization;
using Astrana.Core.Domain.Feeds.Enums;

namespace Astrana.Core.Domain.Feeds.Models
{
    public class FeedContent
    {
        [JsonConstructor]
        public FeedContent() { }

        public FeedContent(FeedFormat feedFormat, string content)
        {
            Format = feedFormat;
            Content = content;
        }

        public FeedFormat Format { get; set; }

        public string Content { get; set; }
    }
}
