/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Localization.Attributes;

namespace Astrana.Core.Domain.Models.Media.Enums
{
    [TranslationCode("media_type")]
    public enum MediaType
    {
        [TranslationCode("link")]
        Link = 1,

        [TranslationCode("image")]
        Image = 2,

        [TranslationCode("video")]
        Video = 3,

        [TranslationCode("audio")]
        Audio = 4,

        [TranslationCode("gif")]
        // ReSharper disable once InconsistentNaming
        GIF = 5
    }
}
