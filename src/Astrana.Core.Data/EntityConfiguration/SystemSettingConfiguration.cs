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
        public static ModelBuilder ConfigureSystemSetting(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new SystemSettingConfiguration());
        }
    }

    public class SystemSettingConfiguration : IEntityTypeConfiguration<SystemSetting>
    {
        public void Configure(EntityTypeBuilder<SystemSetting> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Name)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.SystemSetting.MaximumNameLength)
                .HasColumnOrder(1);

            entityTypeBuilder.Property(p => p.NameTrxCode)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.SystemSetting.MaximumNameTrxCodeLength)
                .HasColumnOrder(2);

            entityTypeBuilder.HasIndex(p => p.NameTrxCode).IsUnique();

            entityTypeBuilder.Property(p => p.DataType)
                .IsRequired()
                .HasColumnOrder(3);

            entityTypeBuilder.Property(p => p.ShortDescription)
                .HasMaxLength(DomainModelProperties.SystemSetting.MaximumShortDescriptionLength)
                .HasColumnOrder(4);

            entityTypeBuilder.Property(p => p.HelpText)
                .HasMaxLength(DomainModelProperties.SystemSetting.MaximumHelpTextLength)
                .HasColumnOrder(5);

            entityTypeBuilder.Property(p => p.HelpTextTrxCode)
                .HasMaxLength(DomainModelProperties.SystemSetting.MaximumHelpTextTrxCodeLength)
                .HasColumnOrder(6);

            entityTypeBuilder.Property(p => p.DefaultValue)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.SystemSetting.MaximumDefaultValueLength)
                .HasColumnOrder(7);

            entityTypeBuilder.Property(p => p.Value)
                .HasMaxLength(DomainModelProperties.SystemSetting.MaximumValueLength)
                .HasColumnOrder(8);

            entityTypeBuilder.Property(p => p.ValueChoicesLookupName)
                .HasMaxLength(DomainModelProperties.SystemSetting.MaximumValueOptionsLookupNameLength)
                .HasColumnOrder(9);

            entityTypeBuilder.Property(p => p.MaximumValues)
                .HasColumnOrder(10);

            entityTypeBuilder.Property(p => p.MinimumValues)
                .HasColumnOrder(11);

            entityTypeBuilder.Property(p => p.MaximumValueLength)
                .HasColumnOrder(12);

            entityTypeBuilder.Property(p => p.MinimumValueLength)
                .HasColumnOrder(13);

            //entityTypeBuilder.Property(p => p.SettingCategory)
            //    .HasColumnOrder(14);

            entityTypeBuilder.Property(p => p.SettingCategoryId)
                .HasColumnOrder(15);

            entityTypeBuilder.Property(p => p.UserMaySet)
                .HasColumnOrder(16);

            entityTypeBuilder.Property(p => p.CreatedBy).IsRequired().HasColumnOrder(99996);
            entityTypeBuilder.Property(p => p.LastModifiedBy).IsRequired().HasColumnOrder(99997);
            entityTypeBuilder.Property(p => p.CreatedTimestamp).IsRequired().HasColumnOrder(99998);
            entityTypeBuilder.Property(p => p.LastModifiedTimestamp).IsRequired().HasColumnOrder(99999);
        }
    }
}
