using Astrana.Core.Constants;
using Astrana.Core.Data.Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.EntityConfiguration
{
    public class FeelingConfiguration : IEntityTypeConfiguration<Feeling>
    {
        public readonly List<DM.Feelings.Feeling> ReactionsToSeed = new();

        public FeelingConfiguration()
        {
            ReactionsToSeed.AddRange(DM.Feelings.Constants.DefaultFeelings.List);
        }

        public void Configure(EntityTypeBuilder<Feeling> entityTypeBuilder)
        {
            entityTypeBuilder.HasIndex(p => p.NameTrxCode).IsUnique();

            entityTypeBuilder.HasData
            (
                GetFeelingsToSeed()
            );
        }

        private IEnumerable<Feeling> GetFeelingsToSeed()
        {
            var now = DateTime.UtcNow;
            var systemId = Guid.Parse(SystemUser.Id);

            return ReactionsToSeed.Select(s => new Feeling
            {
                FeelingId = s.FeelingId,
                Name = s.Name,
                NameTrxCode = s.NameTrxCode,
                IconName = s.IconName,
                UnicodeIcon = s.UnicodeIcon,
                ShortCode = s.ShortCode,
                CreatedBy = systemId,
                CreatedTimestamp = now,
                LastModifiedBy = systemId,
                LastModifiedTimestamp = now

            }).ToArray();
        }
    }
}
