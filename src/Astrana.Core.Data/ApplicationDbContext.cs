/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

using Astrana.Core.Data.Entities.AccessManagement;
using Astrana.Core.Data.Entities.Configuration;
using Astrana.Core.Data.Entities.ContactInformation;
using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Entities.Identity;
using Astrana.Core.Data.Entities.Peers;
using Astrana.Core.Data.Entities.User;
using Astrana.Core.Data.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Astrana.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SystemSettingConfiguration());
            
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());

            modelBuilder.ApplyConfiguration(new ApiAccessTokenConfiguration());
            
            modelBuilder.ApplyConfiguration(new UserAccountConfiguration());
            modelBuilder.ApplyConfiguration(new UserAccountRoleRelationshipConfiguration());
            modelBuilder.ApplyConfiguration(new UserEmailAddressRelationshipConfiguration());
            modelBuilder.ApplyConfiguration(new UserPhoneNumberRelationshipConfiguration());
            modelBuilder.ApplyConfiguration(new UserMessengerUsernameRelationshipConfiguration());

            modelBuilder.ApplyConfiguration(new PeerConnectionRequestReceivedConfiguration());
            modelBuilder.ApplyConfiguration(new PeerConnectionRequestSubmittedConfiguration());
        }

        // Configuration Entities

        public DbSet<SystemSetting> Settings { get; set; }

        public DbSet<FeatureToggle> FeatureToggles { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }


        // Contact Information Entities

        public DbSet<EmailAddress> EmailAddresses { get; set; }

        public DbSet<PhoneNumber> PhoneNumbers { get; set; }
        
        public DbSet<MessengerUsername> MessengerUsernames { get; set; }


        // Identity and Access Management Entities

        public DbSet<ApiAccessToken> ApiAccessTokens { get; set; }

        public DbSet<UserAccount> UserAccounts { get; set; }

        public DbSet<UserRole> Roles { get; set; }


        // User Data Entities

        public DbSet<UserProfile> UserProfiles { get; set; }

        public DbSet<UserEmailAddressRelationship> UserEmailAddresses { get; set; }


        // Content Entities

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Post> Posts { get; set; }
        
        public DbSet<Link> Links { get; set; }
        
        public DbSet<Image> Images { get; set; }
        
        public DbSet<Video> Videos { get; set; }

        public DbSet<Album> Albums { get; set; }

        public DbSet<ContentSafetyRating> ContentSafetyRatings { get; set; }


        // Peers Entities

        public DbSet<PeerConnectionRequestReceived> PeerConnectionRequestsReceived { get; set; }

        public DbSet<PeerConnectionRequestSubmitted> PeerConnectionRequestsSubmitted { get; set; }

        public DbSet<Peer> Peers { get; set; }
    }
}
