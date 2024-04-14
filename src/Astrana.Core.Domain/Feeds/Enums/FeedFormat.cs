/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Localization.Attributes;

namespace Astrana.Core.Domain.Feeds.Enums
{
    [TranslationCode("content_collection_type")]
    public enum FeedFormat
    {
        [TranslationCode("default")]
        Default = 0,

        [TranslationCode("rss")]
        Rss = 1,

        [TranslationCode("atom")]
        Atom = 2
    }
}
