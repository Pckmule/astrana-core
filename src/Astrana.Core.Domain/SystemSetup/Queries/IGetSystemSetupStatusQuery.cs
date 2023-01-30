/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.SystemSetup.Enums;

namespace Astrana.Core.Domain.SystemSetup.Queries
{
    public interface IGetSystemSetupStatusQuery
    {
        Task<SystemSetupStatus> ExecuteAsync(Guid actioningUserId);
    }
}