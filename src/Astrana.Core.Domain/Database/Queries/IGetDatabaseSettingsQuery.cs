/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Database;

namespace Astrana.Core.Domain.Database.Queries
{
    public interface IGetDatabaseSettingsQuery
    {
        DatabaseSettings Execute(Guid actioningUserId);
    }
}