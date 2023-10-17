/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Localization.Attributes;

namespace Astrana.Core.Domain.Models.UserProfiles.Enums
{
    [TranslationCode("gender")]
    public enum Sex
    {
        [TranslationCode("not_set")]
        NotSet,

        [TranslationCode("gender_male")]
        Male,
        
        [TranslationCode("gender_female")]
        Female,
        
        [TranslationCode("other")]
        Other
    }
}
