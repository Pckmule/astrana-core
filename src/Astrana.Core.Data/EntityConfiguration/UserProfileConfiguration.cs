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
        public static ModelBuilder ConfigureUserProfile(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new UserProfileConfiguration());
        }
    }

    public class UserProfileConfiguration : IEntityTypeConfiguration<UserProfile>
    {
        public void Configure(EntityTypeBuilder<UserProfile> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.UserAccountId)
                .IsRequired()
                .HasColumnOrder(1);

            //entityTypeBuilder.Property(p => p.UserAccount)
            //    .HasColumnOrder(2);

            entityTypeBuilder.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.UserProfile.MaximumFirstNameLength)
                .HasColumnOrder(3);

            entityTypeBuilder.Property(p => p.MiddleNames)
                .HasMaxLength(DomainModelProperties.UserProfile.MaximumMiddleNamesLength)
                .HasColumnOrder(4);

            entityTypeBuilder.Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.UserProfile.MaximumLastNameLength)
                .HasColumnOrder(5);

            entityTypeBuilder.Property(p => p.DateOfBirth)
                .IsRequired()
                .HasColumnOrder(6);

            entityTypeBuilder.Property(p => p.Sex)
                .IsRequired()
                .HasColumnOrder(7);

            entityTypeBuilder.Property(p => p.Introduction)
                .HasMaxLength(DomainModelProperties.UserProfile.MaximumIntroductionLength)
                .HasColumnOrder(8);

            //entityTypeBuilder.Property(p => p.ProfilePicture)
            //    .HasColumnOrder(9);

            //entityTypeBuilder.Property(p => p.ProfilePicturesCollection)
            //    .HasColumnOrder(10);

            //entityTypeBuilder.Property(p => p.CoverPicture)
            //    .HasColumnOrder(11);

            //entityTypeBuilder.Property(p => p.CoverPicturesCollection)
            //    .HasColumnOrder(12);

            entityTypeBuilder.Property(p => p.CreatedBy).IsRequired().HasColumnOrder(99996);
            entityTypeBuilder.Property(p => p.LastModifiedBy).IsRequired().HasColumnOrder(99997);
            entityTypeBuilder.Property(p => p.CreatedTimestamp).IsRequired().HasColumnOrder(99998);
            entityTypeBuilder.Property(p => p.LastModifiedTimestamp).IsRequired().HasColumnOrder(99999);
        }
    }
}