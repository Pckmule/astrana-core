using Astrana.Core.Data.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureUserAccountRoleRelationship(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserAccountRoleRelationshipConfiguration());

            return modelBuilder;
        }
    }

    public class UserAccountRoleRelationshipConfiguration : IEntityTypeConfiguration<UserAccountRoleRel>
    {
        public void Configure(EntityTypeBuilder<UserAccountRoleRel> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(o => new
            {
                o.UserAccountId, 
                o.UserRoleId
            });

            entityTypeBuilder
                .HasOne(o => o.UserAccount)
                .WithMany(o => o.UserAccountRoles)
                .HasForeignKey(o => o.UserAccountId);

            entityTypeBuilder
                .HasOne(o => o.UserRole)
                .WithMany(o => o.UserAccountRoles)
                .HasForeignKey(o => o.UserRoleId);
        }
    }
}