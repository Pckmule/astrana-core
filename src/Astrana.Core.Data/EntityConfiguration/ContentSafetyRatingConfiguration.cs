using Astrana.Core.Data.Entities.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainModelProperties = Astrana.Core.Domain.Models.ContentSafetyRatings.Constants.ModelProperties;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureContentSafetyRating(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new ContentSafetyRatingConfiguration());
        }
    }

    public class ContentSafetyRatingConfiguration : IEntityTypeConfiguration<ContentSafetyRating>
    {
        public void Configure(EntityTypeBuilder<ContentSafetyRating> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.ContentSafetyRating.MaximumNameLength)
                .HasColumnOrder(1);

            entityTypeBuilder.Property(p => p.Description)
                .HasMaxLength(DomainModelProperties.ContentSafetyRating.MaximumDescriptionLength)
                .HasColumnOrder(2);

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
