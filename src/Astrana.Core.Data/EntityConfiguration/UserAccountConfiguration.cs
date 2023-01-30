using Astrana.Core.Data.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Astrana.Core.Data.EntityConfiguration
{
    public class UserAccountConfiguration : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> entityTypeBuilder)
        {
            entityTypeBuilder.HasIndex(p => p.UserName).IsUnique();
            entityTypeBuilder.HasIndex(r => r.EmailAddress).IsUnique();
            entityTypeBuilder.HasIndex(r => r.PhoneNumber).IsUnique();
        }
    }
}