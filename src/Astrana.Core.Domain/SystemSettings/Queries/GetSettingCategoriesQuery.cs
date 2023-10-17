/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Domain.Models.SystemSettings;
using Astrana.Core.Utilities;
using Microsoft.Extensions.Logging;

namespace Astrana.Core.Domain.SystemSettings.Queries
{
    public class GetSettingCategoriesQuery : IGetSettingCategoriesQuery
    {
        private readonly ILogger<GetSettingCategoriesQuery> _logger;

        public GetSettingCategoriesQuery(ILogger<GetSettingCategoriesQuery> logger)
        {
            _logger = logger;
        }

        public List<SystemSettingCategory> Execute(Guid actioningUserId)
        {
            var settingCategories = new List<SystemSettingCategory>();

            Models.System.Constants.SettingCategoryDefinitions.Register(settingCategories);
            Models.IdentityAccessManagement.Constants.SettingCategoryDefinitions.Register(settingCategories);

            _logger.LogTrace($"Executed {nameof(GetSystemSettingsQuery).SplitOnUpperCase()}");

            return settingCategories;
        }
    }
}