using Astrana.Core.Constants;
using Astrana.Core.Data.Entities.Configuration;
using Astrana.Core.Domain.Models.System.Constants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DM = Astrana.Core.Domain.Models.SystemSettings;

namespace Astrana.Core.Data.EntityConfiguration
{
    public class SystemSettingCategoryConfiguration : IEntityTypeConfiguration<SystemSettingCategory>
    {
        private readonly List<DM.SystemSettingCategory> _settingsToSeed = new();

        public SystemSettingCategoryConfiguration()
        {
            SettingCategoryDefinitions.Register(_settingsToSeed);
            Domain.Models.IdentityAccessManagement.Constants.SettingCategoryDefinitions.Register(_settingsToSeed);
        }

        public void Configure(EntityTypeBuilder<SystemSettingCategory> entityTypeBuilder)
        {
            entityTypeBuilder.HasData
            (
                GetSettingsToSeed()
            );
        }

        private IEnumerable<SystemSettingCategory> GetSettingsToSeed()
        {
            var now = DateTime.UtcNow;
            var systemId = Guid.Parse(SystemUser.Id);

            return _settingsToSeed.Select(s => new SystemSettingCategory
            {
                Id = Guid.NewGuid(),
                Name = s.Name,
                Description = s.Description,
                CreatedBy = systemId,
                CreatedTimestamp = now,
                LastModifiedBy = systemId,
                LastModifiedTimestamp = now

            }).ToArray();
        }
    }
}
