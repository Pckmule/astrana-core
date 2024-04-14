/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.SystemSettings;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.SystemSettings;
using Astrana.Core.Domain.Models.SystemSettings.Options;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.SystemSettings.Queries
{
    public class GetSystemSettingsQuery : IGetSystemSettingsQuery
    {
        private readonly ILogger<GetSystemSettingsQuery> _logger;
        private readonly ISystemSettingRepository<Guid> _systemSettingRepository;

        public GetSystemSettingsQuery(ILogger<GetSystemSettingsQuery> logger, ISystemSettingRepository<Guid> systemSettingRepository)
        {
            _logger = logger;
            _systemSettingRepository = systemSettingRepository;
        }

        public async Task<GetResult<SystemSettingQueryOptions<Guid, Guid>, SystemSetting, Guid, Guid>> ExecuteAsync(Guid actioningUserId, SystemSettingQueryOptions<Guid, Guid>? options = null)
        {
            options ??= new SystemSettingQueryOptions<Guid, Guid>();

            if (actioningUserId == Constants.AnonymousUser.IdGuid)
            {
                options.IncludeUserSettable = false;
                options.IncludeSystemSettable = false;
            }
            else if (actioningUserId == Constants.SystemUser.IdGuid)
            {
                options.IncludeUserSettable = true;
                options.IncludeSystemSettable = true;
            }
            else
            {
                options.IncludeUserSettable = true;
                options.IncludeSystemSettable = false;
            }

            var result = await _systemSettingRepository.GetSystemSettingsAsync(options);

            _logger.LogTrace($"Executed {nameof(GetSystemSettingsQuery).SplitOnUpperCase()}");

            return new GetResult<SystemSettingQueryOptions<Guid, Guid>, SystemSetting, Guid, Guid>(result.Data, options, result.ResultSetCount, result.Message);
        }
    }
}