﻿/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Localization.Attributes;

namespace Astrana.Core.Domain.Models.ContentCollections.Enums
{
    [TranslationCode("content_collection_type")]
    public enum ContentCollectionType
    {
        [TranslationCode("generic")]
        Generic = 0,

        [TranslationCode("album")]
        Album = 1,

        [TranslationCode("pinboard")]
        Pinboard = 2
    }
}
