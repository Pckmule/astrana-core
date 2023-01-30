/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Localization.Attributes;
using System.ComponentModel;

namespace Astrana.Core.Enums
{
    [Description("Content Format")]
    [TranslationCode("content_format")]
    public enum ContentFormat
    {
        [Description("Default")]
        [TranslationCode("default")]
        Default,

        [Description("Markdown")]
        [TranslationCode("markdown")]
        Markdown,

        [Description("Html")]
        [TranslationCode("html")]
        Html,

        [Description("Plain Text")]
        [TranslationCode("plain_text")]
        PlainText
    }
}
