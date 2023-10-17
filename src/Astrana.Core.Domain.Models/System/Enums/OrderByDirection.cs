/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Localization.Attributes;

namespace Astrana.Core.Domain.Models.System.Enums
{
    [TranslationCode("sort_direction")]
    public enum OrderByDirection
    {
        [TranslationCode("default")]
        Default = 0,

        [TranslationCode("sort_ascending")]
        Ascending = 1,
        
        [TranslationCode("sort_descending")]
        Descending = 2
    }
}
