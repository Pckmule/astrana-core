using Astrana.Core.Data.Entities.Peers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Astrana.Core.Data.EntityConfiguration
{
    public class PeerConnectionRequestReceivedConfiguration : IEntityTypeConfiguration<PeerConnectionRequestReceived>
    {
        public void Configure(EntityTypeBuilder<PeerConnectionRequestReceived> entityTypeBuilder)
        {
            entityTypeBuilder.HasIndex(p => p.Address).IsUnique();
        }
    }
}
