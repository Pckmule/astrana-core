using Astrana.Core.Data.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureUserPhoneNumberRelationship(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserPhoneNumberRelationshipConfiguration());

            return modelBuilder;
        }
    }

    public class UserPhoneNumberRelationshipConfiguration : IEntityTypeConfiguration<UserPhoneNumberRelationship>
    {
        public void Configure(EntityTypeBuilder<UserPhoneNumberRelationship> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(o => new
            {
                o.UserAccountId,
                o.PhoneNumberId
            });

            entityTypeBuilder
                .HasOne(o => o.UserAccount)
                .WithMany(o => o.PhoneNumbers)
                .HasForeignKey(o => o.UserAccountId);

            entityTypeBuilder
                .HasOne(o => o.PhoneNumber)
                .WithMany(o => o.Relationships)
                .HasForeignKey(o => o.PhoneNumberId);
        }
    }
}