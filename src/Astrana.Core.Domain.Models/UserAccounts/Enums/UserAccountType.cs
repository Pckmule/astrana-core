/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Localization.Attributes;

namespace Astrana.Core.Domain.Models.UserAccounts.Enums
{
    [TranslationCode("user_account_type")]
    public enum UserAccountType
    {
        [TranslationCode("instance")]
        Instance = 1,

        [TranslationCode("system")]
        System = 2,

        [TranslationCode("peer")]
        Peer = 3,

        [TranslationCode("guest")]
        Guest = 4
    }
}
