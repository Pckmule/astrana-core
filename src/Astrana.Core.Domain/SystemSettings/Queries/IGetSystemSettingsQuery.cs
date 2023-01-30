/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.SystemSettings;
using Astrana.Core.Domain.Models.SystemSettings.Options;

namespace Astrana.Core.Domain.SystemSettings.Queries
{
    public interface IGetSystemSettingsQuery
    {
        Task<GetResult<SystemSettingQueryOptions<Guid, Guid>, SystemSetting, Guid, Guid>> ExecuteAsync(Guid actioningUserId, SystemSettingQueryOptions<Guid, Guid> options = null);
    }
}