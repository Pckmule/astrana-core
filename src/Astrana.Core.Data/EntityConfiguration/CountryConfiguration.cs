/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainModelProperties = Astrana.Core.Domain.Models.Countries.Constants.ModelProperties;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureCountry(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new CountryConfiguration());
        }
    }

    public class CountryConfiguration : IEntityTypeConfiguration<Country>
    {
        public void Configure(EntityTypeBuilder<Country> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Country.MaximumNameLength)
                .HasColumnOrder(1);

            entityTypeBuilder.Property(p => p.NameTrxCode)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Country.MaximumNameTrxCodeLength)
                .HasColumnOrder(2);

            entityTypeBuilder.HasIndex(x => x.NameTrxCode).IsUnique();

            entityTypeBuilder.Property(p => p.OfficialName)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Country.MaximumOfficialNameLength)
                .HasColumnOrder(3);

            entityTypeBuilder.Property(p => p.OfficialNameTrxCode)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Country.MaximumOfficialNameTrxCodeLength)
                .HasColumnOrder(4);

            entityTypeBuilder.HasIndex(x => x.OfficialNameTrxCode).IsUnique();

            entityTypeBuilder.Property(p => p.TwoLetterCode)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Country.MaximumTwoLetterCodeLength)
                .HasColumnOrder(5);

            entityTypeBuilder.HasIndex(x => x.TwoLetterCode).IsUnique();

            entityTypeBuilder.Property(p => p.ThreeLetterCode)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Country.MaximumThreeLetterCodeLength)
                .HasColumnOrder(6);

            entityTypeBuilder.HasIndex(x => x.ThreeLetterCode).IsUnique();

            entityTypeBuilder.Property(p => p.NumberCode)
                .HasColumnOrder(7);

            entityTypeBuilder.HasIndex(x => x.NumberCode).IsUnique();

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
