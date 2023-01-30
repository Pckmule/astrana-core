using Astrana.Core.Domain.Models.Results;
using Astrana.Core.Domain.Models.SystemSettings;

namespace Astrana.Core.Domain.SystemSettings.Commands.UpdateSystemSettingsCommand
{
    public interface IUpdateSystemSettingsCommand
    {
        Task<UpdateResult<List<SystemSetting>>> ExecuteAsync(IList<SystemSetting> systemSettingsToUpdate, Guid actioningUserId);
    }
}