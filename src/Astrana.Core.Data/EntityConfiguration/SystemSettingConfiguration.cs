using Astrana.Core.Constants;
using Astrana.Core.Data.Entities.Configuration;
using Astrana.Core.Domain.Models.System.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DM = Astrana.Core.Domain.Models.SystemSettings;

namespace Astrana.Core.Data.EntityConfiguration
{
    public class SystemSettingConfiguration : IEntityTypeConfiguration<SystemSetting>
    {
        private readonly List<DM.SystemSetting> _settingsToSeed = new();

        public SystemSettingConfiguration()
        {
            SettingDefinitions.Register(_settingsToSeed);
            Domain.Models.IdentityAccessManagement.Constants.SettingDefinitions.Register(_settingsToSeed);
        }

        public void Configure(EntityTypeBuilder<SystemSetting> entityTypeBuilder)
        {
            entityTypeBuilder.HasData
            (
                GetSettingsToSeed()
            );
        }

        private IEnumerable<SystemSetting> GetSettingsToSeed()
        {
            var now = DateTime.UtcNow;
            var systemId = Guid.Parse(SystemUser.Id);

            return _settingsToSeed.Select(s => new SystemSetting
            {
                Id = Guid.NewGuid(),
                Name = s.Name,
                DataType = s.DataType,
                DefaultValue = s.DefaultValue,
                Value = s.Value,
                ShortDescription = s.ShortDescription,
                HelpText = s.HelpText,
                CreatedBy = systemId,
                CreatedTimestamp = now,
                LastModifiedBy = systemId,
                LastModifiedTimestamp = now

            }).ToArray();
        }
    }
}
