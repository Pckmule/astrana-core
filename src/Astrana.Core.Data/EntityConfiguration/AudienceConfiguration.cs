/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainModelProperties = Astrana.Core.Domain.Models.Audiences.Constants.ModelProperties;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureAudience(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new AudienceConfiguration());
        }
    }

    public class AudienceConfiguration : IEntityTypeConfiguration<Audience>
    {
        public void Configure(EntityTypeBuilder<Audience> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Audience.MaximumNameLength)
                .HasColumnOrder(1);

            entityTypeBuilder.HasIndex(entity => entity.Name).IsUnique();

            entityTypeBuilder.Property(p => p.NameTrxCode)
                .HasMaxLength(DomainModelProperties.Audience.MaximumNameTrxCodeLength)
                .HasColumnOrder(2);

            entityTypeBuilder.HasIndex(entity => entity.NameTrxCode).IsUnique();

            entityTypeBuilder.Property(p => p.Description)
                .HasMaxLength(DomainModelProperties.Audience.MaximumDescriptionLength)
                .HasColumnOrder(3);
            
            entityTypeBuilder.Property(p => p.DescriptionTrxCode)
                .HasMaxLength(DomainModelProperties.Audience.MaximumDescriptionTrxCodeLength)
                .HasColumnOrder(4);

            entityTypeBuilder.HasIndex(entity => entity.NameTrxCode).IsUnique();

            //entityTypeBuilder.Property(p => p.PeersIncluded)
            //    .HasColumnOrder(5);

            //entityTypeBuilder.Property(p => p.PeersExcluded)
            //    .HasColumnOrder(6);

            entityTypeBuilder.Property(p => p.MinimumAge)
                .HasColumnOrder(7);

            entityTypeBuilder.Property(p => p.MaximumAge)
                .HasColumnOrder(8);

            //entityTypeBuilder.Property(p => p.Countries)
            //    .HasColumnOrder(9);

            //entityTypeBuilder.Property(p => p.Tags)
            //    .HasColumnOrder(10);

            entityTypeBuilder.Property(p => p.IsUserDefined)
                .HasColumnOrder(11);

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
