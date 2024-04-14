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
        public static ModelBuilder ConfigureUserMessengerUsernameRelationship(this ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMessengerUsernameRelationshipConfiguration());

            return modelBuilder;
        }
    }

    public class UserMessengerUsernameRelationshipConfiguration : IEntityTypeConfiguration<UserMessengerUsernameRelationship>
    {
        public void Configure(EntityTypeBuilder<UserMessengerUsernameRelationship> entityTypeBuilder)
        {
            entityTypeBuilder.HasKey(o => new
            {
                o.UserAccountId, 
                o.MessengerUsernameId
            });

            entityTypeBuilder
                .HasOne(o => o.UserAccount)
                .WithMany(o => o.MessengerUsernames)
                .HasForeignKey(o => o.UserAccountId);

            entityTypeBuilder
                .HasOne(o => o.MessengerUsername)
                .WithMany(o => o.Relationships)
                .HasForeignKey(o => o.MessengerUsernameId);
        }
    }
}