/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Content;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainModelProperties = Astrana.Core.Domain.Models.Locations.Constants.ModelProperties;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureLocation(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new LocationConfiguration());
        }
    }

    public class LocationConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Location.MaximumNameLength)
                .HasColumnOrder(1);

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
