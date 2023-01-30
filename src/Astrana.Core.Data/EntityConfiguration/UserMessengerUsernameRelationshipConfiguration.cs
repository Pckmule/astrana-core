using Astrana.Core.Data.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Astrana.Core.Data.EntityConfiguration
{
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
                .WithMany(o => o.MessengerUsernames)
                .HasForeignKey(o => o.MessengerUsernameId);
        }
    }
}