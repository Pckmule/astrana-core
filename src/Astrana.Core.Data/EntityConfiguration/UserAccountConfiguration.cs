/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using DomainModelProperties = Astrana.Core.Domain.Models.UserAccounts.Constants.ModelProperties;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureUserAccount(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new UserAccountConfiguration());
        }
    }

    public class UserAccountConfiguration : IEntityTypeConfiguration<UserAccount>
    {
        public void Configure(EntityTypeBuilder<UserAccount> entityTypeBuilder)
        {
            entityTypeBuilder.Property(p => p.Type)
                .IsRequired()
                .HasColumnOrder(1);

            entityTypeBuilder.Property(p => p.UserName)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.UserAccount.MaximumUsernameLength)
                .HasColumnOrder(2);

            entityTypeBuilder.HasIndex(p => p.UserName).IsUnique();

            entityTypeBuilder.Property(p => p.NormalizedUserName)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.UserAccount.MaximumUsernameLength)
                .HasColumnOrder(3);

            entityTypeBuilder.Property(p => p.EmailAddress)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.UserAccount.MaximumEmailAddressLength)
                .HasColumnOrder(4);

            entityTypeBuilder.HasIndex(r => r.EmailAddress).IsUnique();

            entityTypeBuilder.Property(p => p.NormalizedEmailAddress)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.UserAccount.MaximumEmailAddressLength)
                .HasColumnOrder(5);

            entityTypeBuilder.Property(p => p.IsEmailAddressConfirmed)
                .HasColumnOrder(6);

            entityTypeBuilder.Property(p => p.PasswordHash)
                .IsRequired()
                .HasColumnOrder(7);

            entityTypeBuilder.Property(p => p.PasswordSalt)
                .IsRequired()
                .HasColumnOrder(8);

            entityTypeBuilder.Property(p => p.SecurityStamp)
                .HasColumnOrder(9);

            entityTypeBuilder.Property(p => p.ConcurrencyStamp)
                .HasColumnOrder(10);

            entityTypeBuilder.Property(p => p.PhoneNumber)
                .HasMaxLength(DomainModelProperties.UserAccount.MaximumPhoneNumberLength)
                .HasColumnOrder(11);

            entityTypeBuilder.HasIndex(r => r.PhoneNumber).IsUnique();

            entityTypeBuilder.Property(p => p.PhoneCountryCodeISO)
                .HasMaxLength(DomainModelProperties.UserAccount.MaximumPhoneCountryCodeISOLength)
                .HasColumnOrder(12);

            entityTypeBuilder.Property(p => p.IsPhoneNumberConfirmed)
                .HasColumnOrder(13);
            
            entityTypeBuilder.Property(p => p.IsTwoFactorEnabled)
                .HasColumnOrder(14);

            entityTypeBuilder.Property(p => p.LockoutEnd)
                .HasColumnOrder(15);

            entityTypeBuilder.Property(p => p.IsLockoutEnabled)
                .HasColumnOrder(16);

            entityTypeBuilder.Property(p => p.FailedAccessCount)
                .HasColumnOrder(17);

            entityTypeBuilder.Property(p => p.TimeZone)
                .IsRequired()
                .HasColumnOrder(18);

            entityTypeBuilder.Property(p => p.LanguageCode)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.UserAccount.MaximumLanguageCodeLength)
                .HasColumnOrder(19);

            entityTypeBuilder.Property(p => p.CountryCode)
                .IsRequired()
                .HasMaxLength(DomainModelProperties.UserAccount.MinimumCountryCodeLength)
                .HasColumnOrder(20);

            entityTypeBuilder.Property(p => p.LastLoginTimestamp)
                .HasColumnOrder(21);

            // entityTypeBuilder.Property(p => p.UserAccountRoles)
            //     .HasColumnOrder(22);

            //entityTypeBuilder.Property(p => p.EmailAddresses)
            //    .HasColumnOrder(23);

            // entityTypeBuilder.Property(p => p.PhoneNumbers)
            //    .HasColumnOrder(24);

            // entityTypeBuilder.Property(p => p.MessengerUsernames)
            //    .HasColumnOrder(25);

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