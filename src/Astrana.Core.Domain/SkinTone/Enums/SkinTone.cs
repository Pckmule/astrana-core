/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Localization.Attributes;
using System.ComponentModel;

namespace Astrana.Core.Domain.SkinTone.Enums
{
    /// <summary>
    /// Human Skin Tones based on the Fitzpatrick scale.
    /// </summary>
    [Description("Skin Tone")]
    [TranslationCode("skin_tone")]
    public enum SkinTone
    {
        [Description("Default")]
        [TranslationCode("default")]
        Default,

        [Description("Light")]
        [TranslationCode("skin_tone_light")]
        Light,

        [Description("Medium Light")]
        [TranslationCode("skin_tone_medium_light")]
        MediumLight,

        [Description("Medium")]
        [TranslationCode("skin_tone_medium")]
        Medium,

        [Description("Medium Dark")]
        [TranslationCode("skin_tone_medium_dark")]
        MediumDark,

        [Description("Dark")]
        [TranslationCode("skin_tone_dark")]
        Dark
    }
}
