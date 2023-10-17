/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Localization.Attributes;

namespace Astrana.Core.Domain.Models.NewContentWorkflowStages.Enums
{
    [TranslationCode("new_content_stage")]
    public enum NewContentStage
    {
        [TranslationCode("default")]
        Default = 0,

        [TranslationCode("new")]
        New = 1,

        [TranslationCode("processing")]
        Processing = 2,

        [TranslationCode("completed")]
        Completed = 3,

        [TranslationCode("discarded")]
        Discarded = 4
    }
}
