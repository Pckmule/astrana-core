/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainModelProperties = Astrana.Core.Domain.Models.UserProfiles.Constants.ModelProperties;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureUserProfileDetail(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new UserProfileDetailConfiguration());
        }
    }

    public class UserProfileDetailConfiguration : IEntityTypeConfiguration<UserProfileDetail>
    {
        public void Configure(EntityTypeBuilder<UserProfileDetail> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.UserProfileId)
                .IsRequired()
                .HasColumnOrder(1);

            //entityTypeBuilder.Property(p => p.UserProfile)
            //    .HasColumnOrder(2);

            entityTypeBuilder.Property(p => p.Key)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.UserProfileDetail.MaximumKeyLength)
                .HasColumnOrder(3);

            entityTypeBuilder.Property(p => p.Label)
                .HasMaxLength(DomainModelProperties.UserProfileDetail.MaximumLabelLength)
                .HasColumnOrder(4);

            entityTypeBuilder.Property(p => p.Value)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.UserProfileDetail.MaximumValueLength)
                .HasColumnOrder(5);

            entityTypeBuilder.Property(p => p.IconName)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.UserProfileDetail.MaximumIconNameLength)
                .HasColumnOrder(6);

            entityTypeBuilder.Property(p => p.DisplayOrder)
                .IsRequired()
                .HasColumnOrder(7);

            //entityTypeBuilder.Property(p => p.Audiences)
            //    .HasColumnOrder(8);

            entityTypeBuilder.Property(p => p.CreatedBy).IsRequired().HasColumnOrder(99996);
            entityTypeBuilder.Property(p => p.LastModifiedBy).IsRequired().HasColumnOrder(99997);
            entityTypeBuilder.Property(p => p.CreatedTimestamp).IsRequired().HasColumnOrder(99998);
            entityTypeBuilder.Property(p => p.LastModifiedTimestamp).IsRequired().HasColumnOrder(99999);
        }
    }
}