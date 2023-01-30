using Astrana.Core.Data.Entities.Peers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Astrana.Core.Data.EntityConfiguration
{
    public class PeerConnectionRequestSubmittedConfiguration : IEntityTypeConfiguration<PeerConnectionRequestSubmitted>
    {
        public void Configure(EntityTypeBuilder<PeerConnectionRequestSubmitted> entityTypeBuilder)
        {
            entityTypeBuilder.HasIndex(p => p.Address).IsUnique();
        }
    }
}
