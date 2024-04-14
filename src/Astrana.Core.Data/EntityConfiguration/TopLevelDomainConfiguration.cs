/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainModelProperties = Astrana.Core.Domain.Models.TopLevelDomains.Constants.ModelProperties;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureTopLevelDomain(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new TopLevelDomainConfiguration());
        }
    }

    public class TopLevelDomainConfiguration : IEntityTypeConfiguration<TopLevelDomain>
    {
        public void Configure(EntityTypeBuilder<TopLevelDomain> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Domain)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.TopLevelDomain.MaximumDomainLength)
                .HasColumnOrder(1);

            entityTypeBuilder.HasIndex(p => p.Domain).IsUnique();

            //entityTypeBuilder.Property(p => p.Country)
            //    .IsRequired()
            //    .HasColumnOrder(2);

            entityTypeBuilder.Property(p => p.IsImplemented)
                .IsRequired()
                .HasColumnOrder(3);

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
