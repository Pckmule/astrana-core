/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Astrana.Core.Data.EntityConfiguration
{
    public static partial class EntityConfigurationExtensions
    {
        public static ModelBuilder ConfigureUserEmailAddressRelationship(this ModelBuilder modelBuilder)
        {
            return modelBuilder.ApplyConfiguration(new UserEmailAddressRelationshipConfiguration());
        }
    }

    public class UserEmailAddressRelationshipConfiguration : IEntityTypeConfiguration<UserEmailAddressRelationship>
    {
        public void Configure(EntityTypeBuilder<UserEmailAddressRelationship> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(o => new 
            { 
                o.UserAccountId,
                o.EmailAddressId
            });

            entityTypeBuilder
                .HasOne(o => o.UserAccount)
                .WithMany(o => o.EmailAddresses)
                .HasForeignKey(o => o.UserAccountId);

            entityTypeBuilder
                .HasOne(o => o.EmailAddress)
                .WithMany(o => o.Relationships)
                .HasForeignKey(o => o.EmailAddressId);
        }
    }
}