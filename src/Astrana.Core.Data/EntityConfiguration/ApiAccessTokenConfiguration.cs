using Astrana.Core.Data.Entities.AccessManagement;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Astrana.Core.Data.EntityConfiguration
{
    public class ApiAccessTokenConfiguration : IEntityTypeConfiguration<ApiAccessToken>
    {
        public void Configure(EntityTypeBuilder<ApiAccessToken> entityTypeBuilder)
        {
            entityTypeBuilder.HasIndex(r => r.Token).IsUnique();
        }
    }
}
