/*
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at https://mozilla.org/MPL/2.0/.
*/

// ReSharper disable UnusedMember.Global

#pragma warning disable CS8618

using Astrana.Core.Data.Entities.AccessManagement;
using Astrana.Core.Data.Entities.Configuration;
using Astrana.Core.Data.Entities.ContactInformation;
using Astrana.Core.Data.Entities.Content;
using Astrana.Core.Data.Entities.Identity;
using Astrana.Core.Data.Entities.Peers;
using Astrana.Core.Data.Entities.User;
using Astrana.Core.Data.Entities.Workflow;
using Astrana.Core.Data.EntityConfiguration;
using Astrana.Core.Data.SeedData.Configuration;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using TimeZone = Astrana.Core.Data.Entities.Configuration.TimeZone;

namespace Astrana.Core.Data
{
    public sealed class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) { }

        public override async Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default)
        {
            SetAuditTimestamps();

            return await base.SaveChangesAsync(acceptAllChangesOnSuccess, cancellationToken);
        }

        public override int SaveChanges()
        {
            SetAuditTimestamps();

            return base.SaveChanges();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ConfigureEntities(modelBuilder);
            AddSeedData(modelBuilder);
        }

        private static void ConfigureEntities(ModelBuilder modelBuilder)
        {
            modelBuilder.ConfigureSystemSettingCategory();
            modelBuilder.ConfigureSystemSetting();

            modelBuilder.ConfigureTimeZone();
            modelBuilder.ConfigureLanguage();
            modelBuilder.ConfigureCountry();
            modelBuilder.ConfigureTopLevelDomain();
            modelBuilder.ConfigureAudience();

            modelBuilder.ConfigureNewContentWorkflowStage();
            modelBuilder.ConfigureNotification();

            modelBuilder.ConfigureApiAccessToken();

            modelBuilder.ConfigureEmailAddress();
            modelBuilder.ConfigurePhoneNumberType();
            modelBuilder.ConfigurePhoneNumber();
            modelBuilder.ConfigureMessengerUsername();

            modelBuilder.ConfigureUserAccount();
            modelBuilder.ConfigureUserAccountRoleRelationship();
            modelBuilder.ConfigureUserEmailAddressRelationship();
            modelBuilder.ConfigureUserPhoneNumberRelationship();
            modelBuilder.ConfigureUserMessengerUsernameRelationship();

            modelBuilder.ConfigureUserProfile();
            modelBuilder.ConfigureUserProfileDetail();

            modelBuilder.ConfigurePeer();
            modelBuilder.ConfigurePeerCircle();

            modelBuilder.ConfigurePeerConnectionRequestReceived();
            modelBuilder.ConfigurePeerConnectionRequestSubmitted();

            modelBuilder.ConfigureReactionTemplate();
            modelBuilder.ConfigureFeelingTemplate();

            modelBuilder.ConfigureContentSafetyRating();
            modelBuilder.ConfigureTag();

            modelBuilder.ConfigureImage();
            modelBuilder.ConfigureVideo();
            modelBuilder.ConfigureAudio();
            modelBuilder.ConfigureLink();
            modelBuilder.ConfigureFeeling();
            modelBuilder.ConfigureLocation();

            modelBuilder.ConfigureContentCollection();
            modelBuilder.ConfigureContentCollectionItem();
            
            modelBuilder.ConfigurePost();
            modelBuilder.ConfigurePostAttachment();

            modelBuilder.ConfigureReaction();
            modelBuilder.ConfigureComment();

            modelBuilder.ConfigureExternalContentSubscription();
            modelBuilder.ConfigureExternalContentSubscriptionContentItem();
        }

        private static void AddSeedData(ModelBuilder modelBuilder)
        {
            modelBuilder.AddSystemSettingCategoryData();
            modelBuilder.AddSystemSettingData();

            modelBuilder.AddSkinToneData();
            modelBuilder.AddTimeZoneData();
            modelBuilder.AddLanguageData();
            modelBuilder.AddCountryData();
            modelBuilder.AddTopLevelDomainData();
            
            modelBuilder.AddAudienceData();
        }

        private void SetAuditTimestamps()
        {
            var entries = ChangeTracker.Entries();

            foreach (var entityEntry in entries)
            {
                var entityType = entityEntry.Entity.GetType();
                var createdTimestampProperty = entityType.GetProperty("CreatedTimestamp", BindingFlags.Public | BindingFlags.Instance);
                var modifiedTimestampProperty = entityType.GetProperty("LastModifiedTimestamp", BindingFlags.Public | BindingFlags.Instance);

                if (modifiedTimestampProperty != null && modifiedTimestampProperty.CanWrite)
                    modifiedTimestampProperty.SetValue(entityEntry.Entity, DateTimeOffset.UtcNow, null);

                if (entityEntry.State != EntityState.Added)
                    continue;

                if (createdTimestampProperty != null && createdTimestampProperty.CanWrite)
                    createdTimestampProperty.SetValue(entityEntry.Entity, DateTimeOffset.UtcNow, null);
            }
        }

        // Configuration Entities

        public DbSet<SystemSettingCategory> SystemSettingsCategories { get; set; }

        public DbSet<SystemSetting> SystemSettings { get; set; }

        public DbSet<FeatureToggle> FeatureToggles { get; set; }

        public DbSet<TimeZone> TimeZones { get; set; }

        public DbSet<Country> Countries { get; set; }

        public DbSet<TopLevelDomain> TopLevelDomains { get; set; }

        public DbSet<Language> Languages { get; set; }

        public DbSet<SkinTone> SkinTones { get; set; }

        public DbSet<PhoneNumberType> PhoneNumberTypes { get; set; }

        public DbSet<ReactionTemplate> Reactions { get; set; }

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


        // Workflow Entities

        public DbSet<Notification> Notifications { get; set; }

        public DbSet<NewContentWorkflowStage> NewContentWorkflowStages { get; set; }


        // Content Entities

        public DbSet<Tag> Tags { get; set; }

        public DbSet<Post> Posts { get; set; }

        public DbSet<Comment> Comments { get; set; }

        public DbSet<Link> Links { get; set; }

        public DbSet<Image> Images { get; set; }

        public DbSet<Video> Videos { get; set; }

        public DbSet<AudioClip> Audios { get; set; }

        public DbSet<ContentCollection> ContentCollections { get; set; }

        public DbSet<ContentSafetyRating> ContentSafetyRatings { get; set; }

        public DbSet<ExternalContentSubscription> ExternalContentSubscriptions { get; set; }

        public DbSet<ExternalContentSubscriptionContentItem> ExternalContentSubscriptionContentItems { get; set; }


        // Peers Entities

        public DbSet<PeerConnectionRequestReceived> PeerConnectionRequestsReceived { get; set; }

        public DbSet<PeerConnectionRequestSubmitted> PeerConnectionRequestsSubmitted { get; set; }

        public DbSet<Peer> Peers { get; set; }
    }
}
