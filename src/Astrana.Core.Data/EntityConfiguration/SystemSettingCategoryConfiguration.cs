/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainModelProperties = Astrana.Core.Domain.Models.SystemSettings.Constants.ModelProperties;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureSystemSettingCategory(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new SystemSettingCategoryConfiguration());
        }
    }

    public sealed class SystemSettingCategoryConfiguration : IEntityTypeConfiguration<SystemSettingCategory>
    {
        public void Configure(EntityTypeBuilder<SystemSettingCategory> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.SystemSettingCategory.MaximumNameLength)
                .HasColumnOrder(1);

            entityTypeBuilder.Property(p => p.NameTrxCode)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.SystemSettingCategory.MaximumNameTrxCodeLength)
                .HasColumnOrder(2);

            entityTypeBuilder.HasIndex(p => p.NameTrxCode).IsUnique();

            entityTypeBuilder.Property(p => p.Description)
                .HasMaxLength(DomainModelProperties.SystemSettingCategory.MaximumDescriptionLength)
                .HasColumnOrder(3);

            entityTypeBuilder.Property(p => p.DescriptionTrxCode)
                .HasMaxLength(DomainModelProperties.SystemSettingCategory.MaximumDescriptionTrxCodeLength)
                .HasColumnOrder(4);

            entityTypeBuilder.HasIndex(p => p.DescriptionTrxCode).IsUnique();

            //entityTypeBuilder.Property(p => p.Settings)
            //    .HasColumnOrder(5);

            entityTypeBuilder.Property(p => p.CreatedBy).IsRequired().HasColumnOrder(99996);
            entityTypeBuilder.Property(p => p.LastModifiedBy).IsRequired().HasColumnOrder(99997);
            entityTypeBuilder.Property(p => p.CreatedTimestamp).IsRequired().HasColumnOrder(99998);
            entityTypeBuilder.Property(p => p.LastModifiedTimestamp).IsRequired().HasColumnOrder(99999);
        }
    }
}
