using Astrana.Core.Constants;
using Astrana.Core.Data.Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DM = Astrana.Core.Domain.Models;

namespace Astrana.Core.Data.EntityConfiguration
{
    public class ReactionConfiguration : IEntityTypeConfiguration<Reaction>
    {
        public readonly List<DM.Reactions.Reaction> ReactionsToSeed = new();

        public ReactionConfiguration()
        {
            ReactionsToSeed.AddRange(DM.Reactions.Constants.DefaultReactions.List);
        }

        public void Configure(EntityTypeBuilder<Reaction> entityTypeBuilder)
        {
            entityTypeBuilder.HasIndex(p => p.NameTrxCode).IsUnique();

            entityTypeBuilder.HasData
            (
                GetReactionsToSeed()
            );
        }

        private IEnumerable<Reaction> GetReactionsToSeed()
        {
            var now = DateTime.UtcNow;
            var systemId = Guid.Parse(SystemUser.Id);

            return ReactionsToSeed.Select(s => new Reaction
            {
                Id = s.ReactionId,
                Name = s.Name,
                NameTrxCode = s.NameTrxCode,
                IconName = s.IconName,
                UnicodeIcon = s.UnicodeIcon,
                CreatedBy = systemId,
                CreatedTimestamp = now,
                LastModifiedBy = systemId,
                LastModifiedTimestamp = now

            }).ToArray();
        }
    }
}
