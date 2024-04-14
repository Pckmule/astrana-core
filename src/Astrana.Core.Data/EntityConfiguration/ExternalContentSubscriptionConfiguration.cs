using Astrana.Core.Data.Entities.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureExternalContentSubscription(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExternalContentSubscription>().Property(p => p.DeactivatedTimestamp).HasColumnOrder(99993);
            modelBuilder.Entity<ExternalContentSubscription>().Property(p => p.DeactivatedReason).HasColumnOrder(99994);
            modelBuilder.Entity<ExternalContentSubscription>().Property(p => p.DeactivatedBy).HasColumnOrder(99995);

            modelBuilder.Entity<ExternalContentSubscription>().Property(p => p.CreatedBy).IsRequired().HasColumnOrder(99996);
            modelBuilder.Entity<ExternalContentSubscription>().Property(p => p.LastModifiedBy).IsRequired().HasColumnOrder(99997);
            modelBuilder.Entity<ExternalContentSubscription>().Property(p => p.CreatedTimestamp).IsRequired().HasColumnOrder(99998);
            modelBuilder.Entity<ExternalContentSubscription>().Property(p => p.LastModifiedTimestamp).IsRequired().HasColumnOrder(99999);

            modelBuilder.Entity<ExternalContentSubscription>().HasIndex(x => x.Url).IsUnique();

            modelBuilder.ApplyConfiguration(new ExternalContentSubscriptionConfiguration());

            return modelBuilder;
        }
    }

    public class ExternalContentSubscriptionConfiguration : IEntityTypeConfiguration<ExternalContentSubscription>
    {
        public void Configure(EntityTypeBuilder<ExternalContentSubscription> entityTypeBuilder) { }
    }
}
