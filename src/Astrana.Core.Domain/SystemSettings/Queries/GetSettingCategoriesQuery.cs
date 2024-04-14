/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.SystemSettings;
using Astrana.Core.Domain.Models.SystemSettings;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.SystemSettings.Queries
{
    public class GetSettingCategoriesQuery : IGetSettingCategoriesQuery
    {
        private readonly ILogger<GetSettingCategoriesQuery> _logger;

        private readonly ISystemSettingRepository<Guid> _systemSettingRepository;

        public GetSettingCategoriesQuery(ILogger<GetSettingCategoriesQuery> logger, ISystemSettingRepository<Guid> systemSettingRepository)
        {
            _logger = logger;

            _systemSettingRepository = systemSettingRepository;
        }

        public async Task<List<SystemSettingCategory>> ExecuteAsync(Guid actioningUserId)
        {
            var result = await _systemSettingRepository.GetSystemSettingCategoriesAsync();

            _logger.LogTrace($"Executed {nameof(GetSettingCategoriesQuery).SplitOnUpperCase()}");

            return result.Data;
        }
    }
}