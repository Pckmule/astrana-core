/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainModelProperties = Astrana.Core.Domain.Models.Languages.Constants.ModelProperties;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureLanguage(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new LanguageConfiguration());
        }
    }

    public class LanguageConfiguration : IEntityTypeConfiguration<Language>
    {
        public void Configure(EntityTypeBuilder<Language> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Language.MaximumNameLength)
                .HasColumnOrder(1);

            entityTypeBuilder.Property(p => p.NameTrxCode)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Language.MaximumNameTrxCodeLength)
                .HasColumnOrder(2);

            entityTypeBuilder.HasIndex(p => p.NameTrxCode).IsUnique();

            entityTypeBuilder.Property(p => p.TwoLetterCode)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Language.MaximumTwoLetterCodeLength)
                .HasColumnOrder(3);

            entityTypeBuilder.HasIndex(p => p.TwoLetterCode).IsUnique();

            entityTypeBuilder.Property(p => p.ThreeLetterCode)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.Language.MaximumThreeLetterCodeLength)
                .HasColumnOrder(4);

            entityTypeBuilder.HasIndex(p => p.ThreeLetterCode).IsUnique();

            entityTypeBuilder.Property(p => p.Direction)
                .IsRequired()
                .HasColumnOrder(5);

            // entityTypeBuilder.Property(p => p.Countries)
            //     .HasColumnOrder(6);

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
