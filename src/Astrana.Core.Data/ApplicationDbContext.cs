/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

// ReSharper disable UnusedMember.Global

#pragma warning disable CS8618

using Astrana.Core.Data.Entities;
using Astrana.Core.Data.Entities.AccessManagement;
using Astrana.Core.Data.Entities.Configuration;
using Astrana.Core.Data.Entities.ContactInformation;
using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Entities.Identity;
using Astrana.Core.Data.Entities.Peers;
using Astrana.Core.Data.Entities.User;
using Astrana.Core.Data.Entities.Workflow;
using Astrana.Core.Data.EntityConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Astrana.Core.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public override int SaveChanges()
        {
            var entries = ChangeTracker.Entries().Where(e => (e.Entity is BaseEntity<Guid, Guid> || e.Entity is BaseEntity<long, Guid> || e.Entity is BaseEntity<int, Guid>) && (e.State == EntityState.Added || e.State == EntityState.Modified));

            foreach (var entityEntry in entries)
            {
                if (entityEntry.Entity is BaseEntity<Guid, Guid>)
                {
                    ((BaseEntity<Guid, Guid>)entityEntry.Entity).LastModifiedTimestamp = DateTime.UtcNow;

                    if (entityEntry.State == EntityState.Added)
                    {
                        ((BaseEntity<Guid, Guid>)entityEntry.Entity).CreatedTimestamp = DateTime.UtcNow;
                    }
                }
                else if (entityEntry.Entity is BaseEntity<long, Guid>)
                {
                    ((BaseEntity<long, Guid>)entityEntry.Entity).LastModifiedTimestamp = DateTime.UtcNow;

                    if (entityEntry.State == EntityState.Added)
                    {
                        ((BaseEntity<long, Guid>)entityEntry.Entity).CreatedTimestamp = DateTime.UtcNow;
                    }
                }
                else if (entityEntry.Entity is BaseEntity<int, Guid>)
                {
                    ((BaseEntity<int, Guid>)entityEntry.Entity).LastModifiedTimestamp = DateTime.UtcNow;

                    if (entityEntry.State == EntityState.Added)
                    {
                        ((BaseEntity<int, Guid>)entityEntry.Entity).CreatedTimestamp = DateTime.UtcNow;
                    }
                }
            }
            
            return base.SaveChanges();
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new SystemSettingConfiguration());
            
            modelBuilder.ApplyConfiguration(new LanguageConfiguration());
            modelBuilder.ApplyConfiguration(new CountryConfiguration());
            modelBuilder.ApplyConfiguration(new ReactionConfiguration());
            modelBuilder.ApplyConfiguration(new FeelingConfiguration());

            modelBuilder.ApplyConfiguration(new ApiAccessTokenConfiguration());
            
            modelBuilder.ApplyConfiguration(new UserAccountConfiguration());
            modelBuilder.ApplyConfiguration(new UserAccountRoleRelationshipConfiguration());
            modelBuilder.ApplyConfiguration(new UserEmailAddressRelationshipConfiguration());
            modelBuilder.ApplyConfiguration(new UserPhoneNumberRelationshipConfiguration());
            modelBuilder.ApplyConfiguration(new UserMessengerUsernameRelationshipConfiguration());

            modelBuilder.ApplyConfiguration(new PeerConnectionRequestReceivedConfiguration());
            modelBuilder.ApplyConfiguration(new PeerConnectionRequestSubmittedConfiguration());

            /////
            
            modelBuilder.Entity<PostAttachment>()
                .HasOne(l => l.Link)
                .WithMany()
                .HasForeignKey(u => u.LinkId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PostAttachment>()
                .HasOne(l => l.Image)
                .WithMany()
                .HasForeignKey(u => u.ImageId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PostAttachment>()
                .HasOne(l => l.ContentCollection)
                .WithMany()
                .HasForeignKey(u => u.ContentCollectionId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PostAttachment>()
                .HasOne(l => l.Video)
                .WithMany()
                .HasForeignKey(u => u.VideoId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<PostAttachment>()
                .HasOne(l => l.Audio)
                .WithMany()
                .HasForeignKey(u => u.AudioId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            /////

            modelBuilder.Entity<ContentCollectionItem>()
                .HasOne(l => l.Link)
                .WithMany()
                .HasForeignKey(u => u.LinkId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ContentCollectionItem>()
                .HasOne(l => l.Image)
                .WithMany()
                .HasForeignKey(u => u.ImageId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
            
            modelBuilder.Entity<ContentCollectionItem>()
                .HasOne(l => l.Video)
                .WithMany()
                .HasForeignKey(u => u.VideoId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ContentCollectionItem>()
                .HasOne(l => l.Audio)
                .WithMany()
                .HasForeignKey(u => u.AudioId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<ContentCollectionItem>()
                .HasOne(l => l.Gif)
                .WithMany()
                .HasForeignKey(u => u.GifId)
                .IsRequired(false)
                .OnDelete(DeleteBehavior.Restrict);
        }

        // Configuration Entities

        public DbSet<SystemSetting> Settings { get; set; }

        public DbSet<FeatureToggle> FeatureToggles { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }

        public DbSet<Reaction> Reactions { get; set; }

        public DbSet<Feeling> Feelings { get; set; }

        public DbSet<Audience> Audiences { get; set; }
        

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

        public DbSet<UserProfileDetail> UserProfileDetails { get; set; }

        public DbSet<UserEmailAddressRelationship> UserEmailAddresses { get; set; }


        // Content Entities
        public DbSet<NewContentWorkflowStage> NewContentWorkflowStages { get; set; }

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Link> Links { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Video> Videos { get; set; }

        public DbSet<Audio> Audios { get; set; }

        public DbSet<ContentCollection> ContentCollections { get; set; }

        public DbSet<ContentSafetyRating> ContentSafetyRatings { get; set; }
        
        public DbSet<ExternalContentSubscription> ExternalContentSubscriptions { get; set; }


        // Peers Entities

        public DbSet<PeerConnectionRequestReceived> PeerConnectionRequestsReceived { get; set; }

        public DbSet<PeerConnectionRequestSubmitted> PeerConnectionRequestsSubmitted { get; set; }

        public DbSet<Peer> Peers { get; set; }
    }
}
