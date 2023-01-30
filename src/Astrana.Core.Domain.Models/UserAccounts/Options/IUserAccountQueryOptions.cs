/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.UserAccounts.Enums;

namespace Astrana.Core.Domain.Models.UserAccounts.Options
{
    public interface IUserAccountQueryOptions
    {
        List<UserAccountType> AccountTypes { get; set; }

        List<string> Usernames { get; set; }
    }
}