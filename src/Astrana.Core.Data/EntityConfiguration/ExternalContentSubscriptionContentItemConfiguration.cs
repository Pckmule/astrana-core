using Astrana.Core.Data.Entities.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureExternalContentSubscriptionContentItem(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExternalContentSubscriptionContentItem>().Property(p => p.CreatedBy).IsRequired().HasColumnOrder(99996);
            modelBuilder.Entity<ExternalContentSubscriptionContentItem>().Property(p => p.LastModifiedBy).IsRequired().HasColumnOrder(99997);
            modelBuilder.Entity<ExternalContentSubscriptionContentItem>().Property(p => p.CreatedTimestamp).IsRequired().HasColumnOrder(99998);
            modelBuilder.Entity<ExternalContentSubscriptionContentItem>().Property(p => p.LastModifiedTimestamp).IsRequired().HasColumnOrder(99999);

            modelBuilder.Entity<ExternalContentSubscriptionContentItem>().HasIndex(x => x.Url).IsUnique();

            modelBuilder.ApplyConfiguration(new ExternalContentSubscriptionContentItemConfiguration());

            return modelBuilder;
        }
    }

    public class ExternalContentSubscriptionContentItemConfiguration : IEntityTypeConfiguration<ExternalContentSubscriptionContentItem>
    {
        public void Configure(EntityTypeBuilder<ExternalContentSubscriptionContentItem> entityTypeBuilder) { }
    }
}
