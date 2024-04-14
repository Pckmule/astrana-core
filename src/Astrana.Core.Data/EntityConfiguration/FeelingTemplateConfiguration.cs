using Astrana.Core.Data.Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainModelProperties = Astrana.Core.Domain.Models.Feelings.Constants.ModelProperties;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureFeelingTemplate(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new FeelingTemplateConfiguration());
        }
    }

    public class FeelingTemplateConfiguration : IEntityTypeConfiguration<FeelingTemplate>
    {
        public void Configure(EntityTypeBuilder<FeelingTemplate> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Feeling.MaximumNameLength)
                .HasColumnOrder(1);

            entityTypeBuilder.Property(p => p.NameTrxCode)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Feeling.MaximumNameTrxCodeLength)
                .HasColumnOrder(2);

            entityTypeBuilder.HasIndex(p => p.NameTrxCode).IsUnique();

            entityTypeBuilder.Property(p => p.IconName)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Feeling.MaximumIconNameLength)
                .HasColumnOrder(3);

            entityTypeBuilder.Property(p => p.UnicodeIcon)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Feeling.MaximumUnicodeIconLength)
                .HasColumnOrder(4);

            entityTypeBuilder.Property(p => p.ShortCode)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Feeling.MaximumShortCodeLength)
                .HasColumnOrder(5);

            entityTypeBuilder.Property(p => p.DeactivatedTimestamp).HasColumnOrder(99993);
            entityTypeBuilder.Property(p => p.DeactivatedReason).HasColumnOrder(99994);
            entityTypeBuilder.Property(p => p.DeactivatedBy).HasColumnOrder(99995);

            entityTypeBuilder.Property(p => p.CreatedBy).IsRequired().HasColumnOrder(99996);
            entityTypeBuilder.Property(p => p.LastModifiedBy).IsRequired().HasColumnOrder(99997);
            entityTypeBuilder.Property(p => p.CreatedTimestamp).IsRequired().HasColumnOrder(99998);
            entityTypeBuilder.Property(p => p.LastModifiedTimestamp).IsRequired().HasColumnOrder(99999);
        }
    }
}
