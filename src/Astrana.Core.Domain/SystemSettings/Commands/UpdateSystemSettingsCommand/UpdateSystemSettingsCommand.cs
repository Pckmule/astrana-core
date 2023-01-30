/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Repositories.SystemSettings;
using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.Results.Enums;
using Astrana.Core.Domain.Models.System.Enums;
using Astrana.Core.Domain.Models.SystemSettings;
using Astrana.Core.Domain.Models.SystemSettings.Constants;
using Microsoft.Extensions.Logging;
using MRB = Astrana.Core.Domain.ResultMessageBuilder;

namespace Astrana.Core.Domain.SystemSettings.Commands.UpdateSystemSettingsCommand
{
    public class UpdateSystemSettingsCommand : IUpdateSystemSettingsCommand
    {
        private readonly ILogger<UpdateSystemSettingsCommand> _logger;
        private readonly ISystemSettingRepository<Guid> _systemSettingRepository;

        public UpdateSystemSettingsCommand(ILogger<UpdateSystemSettingsCommand> logger, ISystemSettingRepository<Guid> systemSettingRepository)
        {
            _logger = logger;
            _systemSettingRepository = systemSettingRepository;
        }

        public async Task<UpdateResult<List<SystemSetting>>> ExecuteAsync(IList<SystemSetting> systemSettingsToUpdate, Guid actioningUserId)
        {
            if (!systemSettingsToUpdate.Any())
            {
                var message = MRB.NoneProvidedMessage(CrudAction.Update, ModelProperties.SystemSetting.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<SystemSetting>>(new List<SystemSetting>(), 0, message);
            }

            var validatedSystemSettingsToUpdate = systemSettingsToUpdate.Where(o => o.IsValid).ToList();
            if (!validatedSystemSettingsToUpdate.Any())
            {
                var message = MRB.NoneValidMessage(CrudAction.Update, ModelProperties.SystemSetting.NamePluralForm);

                _logger.LogWarning(message);

                return new UpdateFailResult<List<SystemSetting>>(new List<SystemSetting>(), 0, message);
            }

            var result = await _systemSettingRepository.UpdateAsync(validatedSystemSettingsToUpdate, actioningUserId);

            if (result.Outcome == ResultOutcome.Success)
                return new UpdateSuccessResult<List<SystemSetting>>(result.Data, result.Count, MRB.UpdateSuccessResultMessage(ModelProperties.SystemSetting.NameSingularForm, ModelProperties.SystemSetting.NamePluralForm, result.Count));
            
            return new UpdateFailResult<List<SystemSetting>>(result.Data, 0, result.Message, result.ResultCode);
        }
    }
}