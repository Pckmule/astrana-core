/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainModelProperties = Astrana.Core.Domain.Models.TimeZones.Constants.ModelProperties;
using TimeZone = Astrana.Core.Data.Entities.Configuration.TimeZone;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureTimeZone(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new TimeZoneConfiguration());
        }
    }

    public class TimeZoneConfiguration : IEntityTypeConfiguration<TimeZone>
    {
        public void Configure(EntityTypeBuilder<TimeZone> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(nameof(TimeZone.CorrespondingUtcZone), nameof(TimeZone.Abbreviation), nameof(TimeZone.Name));

            entityTypeBuilder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.TimeZone.MaximumNameLength)
                .HasColumnOrder(1);

            entityTypeBuilder.Property(p => p.NameTrxCode)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.TimeZone.MaximumNameTrxCodeLength)
                .HasColumnOrder(2);

            entityTypeBuilder.Property(p => p.Abbreviation)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.TimeZone.MaximumAbbreviationLength)
                .HasColumnOrder(3);

            entityTypeBuilder.Property(p => p.CorrespondingUtcZone)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.TimeZone.MaximumCorrespondingUtcZoneLength)
                .HasColumnOrder(4);

            //entityTypeBuilder.Property(p => p.Countries)
            //    .HasColumnOrder(5);

            entityTypeBuilder.Property(p => p.DaylightSavingApplies)
                .IsRequired()
                .HasColumnOrder(6);

            entityTypeBuilder.Property(p => p.CreatedBy).IsRequired().HasColumnOrder(99996);
            entityTypeBuilder.Property(p => p.LastModifiedBy).IsRequired().HasColumnOrder(99997);
            entityTypeBuilder.Property(p => p.CreatedTimestamp).IsRequired().HasColumnOrder(99998);
            entityTypeBuilder.Property(p => p.LastModifiedTimestamp).IsRequired().HasColumnOrder(99999);
        }
    }
}
