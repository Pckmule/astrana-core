/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Localization.Attributes;

namespace Astrana.Core.Domain.Models.Attachments.Enums
{
    [TranslationCode("attachment_type")]
    public enum AttachmentType
    {
        [TranslationCode("link")]
        Link = 1,

        [TranslationCode("image")]
        Image = 2,

        [TranslationCode("video")]
        Video = 3,

        [TranslationCode("audio")]
        Audio = 4,

        [TranslationCode("contentCollection")]
        ContentCollection = 5,

        [TranslationCode("set")]
        Set = 6,

        [TranslationCode("feeling")]
        Feeling = 7,

        [TranslationCode("location")]
        Location = 8,

        [TranslationCode("gif")]
        Gif = 9
    }
}
