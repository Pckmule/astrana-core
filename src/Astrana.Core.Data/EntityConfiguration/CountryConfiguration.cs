using Astrana.Core.Constants;
using Astrana.Core.Data.Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.EntityConfiguration
{
    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public readonly List<DM.Countries.Country> SettingsToSeed = new();

        public CountryConfiguration()
        {
            SettingsToSeed.AddRange(DM.Countries.Constants.DefaultCountries.List);
        }

        public void Configure(EntityTypeBuilder<Country> entityTypeBuilder)
        {
            entityTypeBuilder.HasIndex(p => p.NameTrxCode).IsUnique();
            entityTypeBuilder.HasIndex(p => p.TwoLetterCode).IsUnique();
            entityTypeBuilder.HasIndex(p => p.ThreeLetterCode).IsUnique();

            entityTypeBuilder.HasData
            (
                GetCountriesToSeed()
            );
        }

        private IEnumerable<Country> GetCountriesToSeed()
        {
            var now = DateTime.UtcNow;
            var systemId = Guid.Parse(SystemUser.Id);

            return SettingsToSeed.Select(s => new Country
            {
                Id = s.CountryId,
                Name = s.Name,
                NameTrxCode = s.NameTrxCode,
                TwoLetterCode = s.TwoLetterCode,
                ThreeLetterCode = s.ThreeLetterCode,
                CreatedBy = systemId,
                CreatedTimestamp = now,
                LastModifiedBy = systemId,
                LastModifiedTimestamp = now

            }).ToArray();
        }
    }
}
