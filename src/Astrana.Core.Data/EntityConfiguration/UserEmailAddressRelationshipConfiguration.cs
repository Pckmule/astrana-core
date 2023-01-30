using Astrana.Core.Data.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Astrana.Core.Data.EntityConfiguration
{
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
                .WithMany(o => o.EmailAddresses)
                .HasForeignKey(o => o.EmailAddressId);
        }
    }
}