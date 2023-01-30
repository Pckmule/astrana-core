/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Localization.Attributes;
using System.ComponentModel;

namespace Astrana.Core.Enums
{
    [Description("Language Direction")]
    [TranslationCode("language_direction")]
    public enum LanguageDirection
    {
        [Description("Left to Right")]
        [TranslationCode("left_to_right")]
        Ltr,

        [Description("Right to Left")]
        [TranslationCode("right_to_left")]
        Rtl
    }
}
