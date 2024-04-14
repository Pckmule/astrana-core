/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.Results.Contracts;
using Astrana.Core.Domain.Models.SystemSettings;
using Astrana.Core.Domain.Models.SystemSettings.Contracts;
using Astrana.Core.Domain.Models.SystemSettings.Options;


namespace Astrana.Core.Data.Repositories.SystemSettings
{
    public interface ISystemSettingRepository<TUserId> where TUserId : struct
    {
        Task<ICountResult> GetSystemSettingCategoriesCountAsync(SystemSettingCategoryQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<SystemSettingCategory>> GetSystemSettingCategoriesAsync(SystemSettingCategoryQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<ICountResult> GetSystemSettingsCountAsync(SystemSettingQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<IGetResult<SystemSetting>> GetSystemSettingsAsync(SystemSettingQueryOptions<Guid, TUserId>? queryOptions = null);

        Task<SystemSetting?> GetSystemSettingByNameAsync(string settingName);

        Task<IUpdateResult<List<SystemSetting>>> UpdateAsync(IEnumerable<ISystemSetting> requestedUpdates, TUserId actioningUserId, bool returnRecords = true);
    }
}
