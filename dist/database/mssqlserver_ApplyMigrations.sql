IF OBJECT_ID(N'[maintenance].[MigrationsHistory]') IS NULL
BEGIN
    IF SCHEMA_ID(N'maintenance') IS NULL EXEC(N'CREATE SCHEMA [maintenance];');
    CREATE TABLE [maintenance].[MigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK_MigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;
GO

BEGIN TRANSACTION;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    IF SCHEMA_ID(N'iam') IS NULL EXEC(N'CREATE SCHEMA [iam];');
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    IF SCHEMA_ID(N'config') IS NULL EXEC(N'CREATE SCHEMA [config];');
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    IF SCHEMA_ID(N'content') IS NULL EXEC(N'CREATE SCHEMA [content];');
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    IF SCHEMA_ID(N'contact') IS NULL EXEC(N'CREATE SCHEMA [contact];');
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    IF SCHEMA_ID(N'user') IS NULL EXEC(N'CREATE SCHEMA [user];');
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    IF SCHEMA_ID(N'workflow') IS NULL EXEC(N'CREATE SCHEMA [workflow];');
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [iam].[ApiAccessTokens] (
        [Id] uniqueidentifier NOT NULL,
        [Token] nvarchar(1000) NOT NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_ApiAccessTokens] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [content].[Audios] (
        [AudioId] uniqueidentifier NOT NULL,
        [Location] nvarchar(max) NOT NULL,
        [Caption] nvarchar(500) NULL,
        [Copyright] nvarchar(250) NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_Audios] PRIMARY KEY ([AudioId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [content].[ContentCollections] (
        [ContentCollectionId] uniqueidentifier NOT NULL,
        [Name] nvarchar(250) NULL,
        [CollectionType] int NOT NULL,
        [Caption] nvarchar(500) NULL,
        [Copyright] nvarchar(500) NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_ContentCollections] PRIMARY KEY ([ContentCollectionId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [content].[ContentSafetyRatings] (
        [Id] bigint NOT NULL IDENTITY,
        [Name] nvarchar(max) NOT NULL,
        [Description] nvarchar(500) NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_ContentSafetyRatings] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [contact].[EmailAddresses] (
        [Id] uniqueidentifier NOT NULL,
        [Address] nvarchar(100) NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_EmailAddresses] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [config].[FeatureToggles] (
        [Id] uniqueidentifier NOT NULL,
        [FeatureName] nvarchar(100) NOT NULL,
        [FeatureDescription] nvarchar(250) NULL,
        [IsFeatureDisabled] bit NOT NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_FeatureToggles] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [config].[Feelings] (
        [FeelingId] uniqueidentifier NOT NULL,
        [Name] nvarchar(50) NOT NULL,
        [NameTrxCode] nvarchar(100) NOT NULL,
        [IconName] nvarchar(30) NOT NULL,
        [UnicodeIcon] nvarchar(10) NOT NULL,
        [ShortCode] nvarchar(20) NOT NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_Feelings] PRIMARY KEY ([FeelingId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [content].[Images] (
        [ImageId] uniqueidentifier NOT NULL,
        [Location] nvarchar(2500) NOT NULL,
        [Caption] nvarchar(100) NULL,
        [Copyright] nvarchar(500) NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_Images] PRIMARY KEY ([ImageId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [contact].[InstantMessengerUsernames] (
        [Id] uniqueidentifier NOT NULL,
        [Username] nvarchar(100) NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_InstantMessengerUsernames] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [config].[Languages] (
        [Id] uniqueidentifier NOT NULL,
        [Name] nvarchar(25) NOT NULL,
        [NameTrxCode] nvarchar(100) NOT NULL,
        [Code] nvarchar(5) NOT NULL,
        [TwoLetterCode] nvarchar(2) NOT NULL,
        [ThreeLetterCode] nvarchar(3) NOT NULL,
        [Direction] int NOT NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_Languages] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [content].[Locations] (
        [LocationId] uniqueidentifier NOT NULL,
        [Name] nvarchar(max) NOT NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_Locations] PRIMARY KEY ([LocationId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [workflow].[NewContentWorkflowStage] (
        [NewContentWorkflowStageId] uniqueidentifier NOT NULL,
        [ContentEntityId] nvarchar(max) NOT NULL,
        [ContentEntityTypeId] nvarchar(max) NOT NULL,
        [Stage] int NOT NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_NewContentWorkflowStage] PRIMARY KEY ([NewContentWorkflowStageId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [workflow].[Notifications] (
        [NotificationId] uniqueidentifier NOT NULL,
        [Type] int NOT NULL,
        [Message] nvarchar(max) NOT NULL,
        [SourceType] int NOT NULL,
        [SourceId] nvarchar(max) NOT NULL,
        [IsRead] bit NOT NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_Notifications] PRIMARY KEY ([NotificationId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [dbo].[PeerConnectionRequestsReceived] (
        [Id] uniqueidentifier NOT NULL,
        [FirstName] nvarchar(100) NOT NULL,
        [LastName] nvarchar(100) NOT NULL,
        [Age] smallint NOT NULL,
        [Sex] int NOT NULL,
        [Address] nvarchar(500) NOT NULL,
        [Note] nvarchar(500) NULL,
        [PeerPreviewAccessToken] nvarchar(2000) NULL,
        [Status] int NOT NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_PeerConnectionRequestsReceived] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [dbo].[PeerConnectionRequestsSubmitted] (
        [Id] uniqueidentifier NOT NULL,
        [FirstName] nvarchar(100) NOT NULL,
        [LastName] nvarchar(100) NOT NULL,
        [Address] nvarchar(500) NOT NULL,
        [Note] nvarchar(500) NULL,
        [PeerPreviewAccessToken] nvarchar(2000) NULL,
        [Status] int NOT NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_PeerConnectionRequestsSubmitted] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [contact].[PhoneNumbers] (
        [Id] uniqueidentifier NOT NULL,
        [Address] nvarchar(100) NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_PhoneNumbers] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [config].[PhoneNumberTypes] (
        [Id] uniqueidentifier NOT NULL,
        [Name] nvarchar(20) NOT NULL,
        [Code] nvarchar(20) NOT NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_PhoneNumberTypes] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [content].[Posts] (
        [PostId] bigint NOT NULL IDENTITY,
        [Text] nvarchar(1000) NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_Posts] PRIMARY KEY ([PostId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [config].[Reactions] (
        [Id] uniqueidentifier NOT NULL,
        [Name] nvarchar(50) NOT NULL,
        [NameTrxCode] nvarchar(100) NOT NULL,
        [IconName] nvarchar(30) NOT NULL,
        [UnicodeIcon] nvarchar(10) NOT NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_Reactions] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [config].[SettingCategories] (
        [Id] uniqueidentifier NOT NULL,
        [Name] nvarchar(100) NOT NULL,
        [Description] nvarchar(500) NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_SettingCategories] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [iam].[UserAccounts] (
        [Id] uniqueidentifier NOT NULL,
        [Type] int NOT NULL,
        [UserName] nvarchar(100) NULL,
        [NormalizedUserName] nvarchar(max) NULL,
        [EmailAddress] nvarchar(250) NULL,
        [NormalizedEmailAddress] nvarchar(max) NULL,
        [IsEmailAddressConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [PasswordSalt] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneCountryCodeISO] nvarchar(5) NULL,
        [PhoneNumber] nvarchar(25) NULL,
        [IsPhoneNumberConfirmed] bit NOT NULL,
        [IsTwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [IsLockoutEnabled] bit NOT NULL,
        [FailedAccessCount] smallint NOT NULL,
        [TimeZone] nvarchar(max) NOT NULL,
        [LanguageCode] nvarchar(5) NOT NULL,
        [CountryCode] nvarchar(3) NOT NULL,
        [LastLoginTimestamp] datetimeoffset NOT NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_UserAccounts] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [iam].[UserRoles] (
        [Id] uniqueidentifier NOT NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        [Name] nvarchar(max) NULL,
        [NormalizedUserName] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_UserRoles] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [content].[Videos] (
        [VideoId] uniqueidentifier NOT NULL,
        [Location] nvarchar(max) NOT NULL,
        [Caption] nvarchar(500) NULL,
        [Copyright] nvarchar(250) NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_Videos] PRIMARY KEY ([VideoId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [content].[ExternalContentSubscriptions] (
        [Id] uniqueidentifier NOT NULL,
        [Url] nvarchar(500) NOT NULL,
        [Title] nvarchar(250) NOT NULL,
        [Description] nvarchar(500) NOT NULL,
        [Locale] nvarchar(max) NULL,
        [CharSet] nvarchar(max) NULL,
        [Robots] nvarchar(max) NULL,
        [SiteName] nvarchar(max) NULL,
        [PreviewImageId] uniqueidentifier NOT NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_ExternalContentSubscriptions] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_ExternalContentSubscriptions_Images_PreviewImageId] FOREIGN KEY ([PreviewImageId]) REFERENCES [content].[Images] ([ImageId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [content].[Links] (
        [LinkId] uniqueidentifier NOT NULL,
        [Url] nvarchar(500) NOT NULL,
        [Title] nvarchar(250) NOT NULL,
        [Description] nvarchar(500) NOT NULL,
        [Locale] nvarchar(max) NULL,
        [CharSet] nvarchar(max) NULL,
        [Robots] nvarchar(max) NULL,
        [SiteName] nvarchar(max) NULL,
        [PreviewImageId] uniqueidentifier NOT NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_Links] PRIMARY KEY ([LinkId]),
        CONSTRAINT [FK_Links_Images_PreviewImageId] FOREIGN KEY ([PreviewImageId]) REFERENCES [content].[Images] ([ImageId]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [config].[Settings] (
        [Id] uniqueidentifier NOT NULL,
        [Name] nvarchar(200) NOT NULL,
        [DataType] int NOT NULL,
        [ShortDescription] nvarchar(500) NULL,
        [HelpText] nvarchar(500) NULL,
        [DefaultValue] nvarchar(500) NOT NULL,
        [Value] nvarchar(500) NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        [SettingCategoryId] uniqueidentifier NULL,
        CONSTRAINT [PK_Settings] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Settings_SettingCategories_SettingCategoryId] FOREIGN KEY ([SettingCategoryId]) REFERENCES [config].[SettingCategories] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [user].[MessengerUsernameRel] (
        [UserAccountId] uniqueidentifier NOT NULL,
        [MessengerUsernameId] uniqueidentifier NOT NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_MessengerUsernameRel] PRIMARY KEY ([UserAccountId], [MessengerUsernameId]),
        CONSTRAINT [FK_MessengerUsernameRel_InstantMessengerUsernames_MessengerUsernameId] FOREIGN KEY ([MessengerUsernameId]) REFERENCES [contact].[InstantMessengerUsernames] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_MessengerUsernameRel_UserAccounts_UserAccountId] FOREIGN KEY ([UserAccountId]) REFERENCES [iam].[UserAccounts] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [user].[UserEmailAddressRel] (
        [UserAccountId] uniqueidentifier NOT NULL,
        [EmailAddressId] uniqueidentifier NOT NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_UserEmailAddressRel] PRIMARY KEY ([UserAccountId], [EmailAddressId]),
        CONSTRAINT [FK_UserEmailAddressRel_EmailAddresses_EmailAddressId] FOREIGN KEY ([EmailAddressId]) REFERENCES [contact].[EmailAddresses] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_UserEmailAddressRel_UserAccounts_UserAccountId] FOREIGN KEY ([UserAccountId]) REFERENCES [iam].[UserAccounts] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [user].[UserPhoneNumberRel] (
        [UserAccountId] uniqueidentifier NOT NULL,
        [PhoneNumberId] uniqueidentifier NOT NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_UserPhoneNumberRel] PRIMARY KEY ([UserAccountId], [PhoneNumberId]),
        CONSTRAINT [FK_UserPhoneNumberRel_PhoneNumbers_PhoneNumberId] FOREIGN KEY ([PhoneNumberId]) REFERENCES [contact].[PhoneNumbers] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_UserPhoneNumberRel_UserAccounts_UserAccountId] FOREIGN KEY ([UserAccountId]) REFERENCES [iam].[UserAccounts] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [user].[UserProfiles] (
        [Id] uniqueidentifier NOT NULL,
        [UserAccountId] uniqueidentifier NOT NULL,
        [FirstName] nvarchar(100) NOT NULL,
        [MiddleNames] nvarchar(300) NULL,
        [LastName] nvarchar(100) NULL,
        [DateOfBirth] datetimeoffset NOT NULL,
        [Sex] int NOT NULL,
        [Introduction] nvarchar(500) NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        [ProfilePictureImageId] uniqueidentifier NULL,
        [ProfilePicturesCollectionContentCollectionId] uniqueidentifier NULL,
        [CoverPictureImageId] uniqueidentifier NULL,
        [CoverPicturesCollectionContentCollectionId] uniqueidentifier NULL,
        CONSTRAINT [PK_UserProfiles] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_UserProfiles_ContentCollections_CoverPicturesCollectionContentCollectionId] FOREIGN KEY ([CoverPicturesCollectionContentCollectionId]) REFERENCES [content].[ContentCollections] ([ContentCollectionId]),
        CONSTRAINT [FK_UserProfiles_ContentCollections_ProfilePicturesCollectionContentCollectionId] FOREIGN KEY ([ProfilePicturesCollectionContentCollectionId]) REFERENCES [content].[ContentCollections] ([ContentCollectionId]),
        CONSTRAINT [FK_UserProfiles_Images_CoverPictureImageId] FOREIGN KEY ([CoverPictureImageId]) REFERENCES [content].[Images] ([ImageId]),
        CONSTRAINT [FK_UserProfiles_Images_ProfilePictureImageId] FOREIGN KEY ([ProfilePictureImageId]) REFERENCES [content].[Images] ([ImageId]),
        CONSTRAINT [FK_UserProfiles_UserAccounts_UserAccountId] FOREIGN KEY ([UserAccountId]) REFERENCES [iam].[UserAccounts] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [iam].[UserAccountRoleRel] (
        [UserAccountId] uniqueidentifier NOT NULL,
        [UserRoleId] uniqueidentifier NOT NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_UserAccountRoleRel] PRIMARY KEY ([UserAccountId], [UserRoleId]),
        CONSTRAINT [FK_UserAccountRoleRel_UserAccounts_UserAccountId] FOREIGN KEY ([UserAccountId]) REFERENCES [iam].[UserAccounts] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_UserAccountRoleRel_UserRoles_UserRoleId] FOREIGN KEY ([UserRoleId]) REFERENCES [iam].[UserRoles] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [content].[Comments] (
        [CommentId] uniqueidentifier NOT NULL,
        [Text] nvarchar(1000) NOT NULL,
        [TargetPostId] bigint NULL,
        [TargetCommentId] uniqueidentifier NULL,
        [TargetImageId] uniqueidentifier NULL,
        [TargetVideoId] uniqueidentifier NULL,
        [TargetAudioId] uniqueidentifier NULL,
        [TargetGifId] uniqueidentifier NULL,
        [TargetContentCollectionId] uniqueidentifier NULL,
        [TargetLinkId] uniqueidentifier NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        [TargeCommentCommentId] uniqueidentifier NULL,
        CONSTRAINT [PK_Comments] PRIMARY KEY ([CommentId]),
        CONSTRAINT [FK_Comments_Audios_TargetAudioId] FOREIGN KEY ([TargetAudioId]) REFERENCES [content].[Audios] ([AudioId]),
        CONSTRAINT [FK_Comments_Audios_TargetContentCollectionId] FOREIGN KEY ([TargetContentCollectionId]) REFERENCES [content].[Audios] ([AudioId]),
        CONSTRAINT [FK_Comments_Comments_TargeCommentCommentId] FOREIGN KEY ([TargeCommentCommentId]) REFERENCES [content].[Comments] ([CommentId]),
        CONSTRAINT [FK_Comments_Images_TargetGifId] FOREIGN KEY ([TargetGifId]) REFERENCES [content].[Images] ([ImageId]),
        CONSTRAINT [FK_Comments_Images_TargetImageId] FOREIGN KEY ([TargetImageId]) REFERENCES [content].[Images] ([ImageId]),
        CONSTRAINT [FK_Comments_Links_TargetLinkId] FOREIGN KEY ([TargetLinkId]) REFERENCES [content].[Links] ([LinkId]),
        CONSTRAINT [FK_Comments_Posts_TargetPostId] FOREIGN KEY ([TargetPostId]) REFERENCES [content].[Posts] ([PostId]),
        CONSTRAINT [FK_Comments_Videos_TargetVideoId] FOREIGN KEY ([TargetVideoId]) REFERENCES [content].[Videos] ([VideoId])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [content].[ContentCollectionItems] (
        [ContentCollectionItemId] uniqueidentifier NOT NULL,
        [ContentCollectionId] uniqueidentifier NOT NULL,
        [MediaType] int NOT NULL,
        [LinkId] uniqueidentifier NULL,
        [ImageId] uniqueidentifier NULL,
        [VideoId] uniqueidentifier NULL,
        [AudioId] uniqueidentifier NULL,
        [GifId] uniqueidentifier NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_ContentCollectionItems] PRIMARY KEY ([ContentCollectionItemId]),
        CONSTRAINT [FK_ContentCollectionItems_Audios_AudioId] FOREIGN KEY ([AudioId]) REFERENCES [content].[Audios] ([AudioId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_ContentCollectionItems_ContentCollections_ContentCollectionId] FOREIGN KEY ([ContentCollectionId]) REFERENCES [content].[ContentCollections] ([ContentCollectionId]) ON DELETE CASCADE,
        CONSTRAINT [FK_ContentCollectionItems_Images_GifId] FOREIGN KEY ([GifId]) REFERENCES [content].[Images] ([ImageId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_ContentCollectionItems_Images_ImageId] FOREIGN KEY ([ImageId]) REFERENCES [content].[Images] ([ImageId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_ContentCollectionItems_Links_LinkId] FOREIGN KEY ([LinkId]) REFERENCES [content].[Links] ([LinkId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_ContentCollectionItems_Videos_VideoId] FOREIGN KEY ([VideoId]) REFERENCES [content].[Videos] ([VideoId]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [content].[PostAttachments] (
        [Id] uniqueidentifier NOT NULL,
        [Title] nvarchar(250) NULL,
        [Caption] nvarchar(250) NULL,
        [Type] int NOT NULL,
        [LinkId] uniqueidentifier NULL,
        [ImageId] uniqueidentifier NULL,
        [GifId] uniqueidentifier NULL,
        [AudioId] uniqueidentifier NULL,
        [VideoId] uniqueidentifier NULL,
        [ContentCollectionId] uniqueidentifier NULL,
        [LocationId] uniqueidentifier NULL,
        [FeelingId] uniqueidentifier NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        [PostId] bigint NULL,
        CONSTRAINT [PK_PostAttachments] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_PostAttachments_Audios_AudioId] FOREIGN KEY ([AudioId]) REFERENCES [content].[Audios] ([AudioId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_PostAttachments_ContentCollections_ContentCollectionId] FOREIGN KEY ([ContentCollectionId]) REFERENCES [content].[ContentCollections] ([ContentCollectionId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_PostAttachments_Feelings_FeelingId] FOREIGN KEY ([FeelingId]) REFERENCES [config].[Feelings] ([FeelingId]),
        CONSTRAINT [FK_PostAttachments_Images_GifId] FOREIGN KEY ([GifId]) REFERENCES [content].[Images] ([ImageId]),
        CONSTRAINT [FK_PostAttachments_Images_ImageId] FOREIGN KEY ([ImageId]) REFERENCES [content].[Images] ([ImageId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_PostAttachments_Links_LinkId] FOREIGN KEY ([LinkId]) REFERENCES [content].[Links] ([LinkId]) ON DELETE NO ACTION,
        CONSTRAINT [FK_PostAttachments_Locations_LocationId] FOREIGN KEY ([LocationId]) REFERENCES [content].[Locations] ([LocationId]),
        CONSTRAINT [FK_PostAttachments_Posts_PostId] FOREIGN KEY ([PostId]) REFERENCES [content].[Posts] ([PostId]),
        CONSTRAINT [FK_PostAttachments_Videos_VideoId] FOREIGN KEY ([VideoId]) REFERENCES [content].[Videos] ([VideoId]) ON DELETE NO ACTION
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [user].[UserProfileDetails] (
        [Id] uniqueidentifier NOT NULL,
        [UserProfileId] uniqueidentifier NOT NULL,
        [Key] nvarchar(100) NOT NULL,
        [Label] nvarchar(100) NULL,
        [Value] nvarchar(100) NOT NULL,
        [IconName] nvarchar(100) NOT NULL,
        [DisplayOrder] smallint NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_UserProfileDetails] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_UserProfileDetails_UserProfiles_UserProfileId] FOREIGN KEY ([UserProfileId]) REFERENCES [user].[UserProfiles] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [config].[Audiences] (
        [Id] uniqueidentifier NOT NULL,
        [Name] nvarchar(30) NOT NULL,
        [Description] nvarchar(250) NOT NULL,
        [MinimumAge] smallint NULL,
        [MaximumAge] smallint NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        [UserProfileDetailId] uniqueidentifier NULL,
        CONSTRAINT [PK_Audiences] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Audiences_UserProfileDetails_UserProfileDetailId] FOREIGN KEY ([UserProfileDetailId]) REFERENCES [user].[UserProfileDetails] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [config].[Countries] (
        [Id] bigint NOT NULL IDENTITY,
        [Name] nvarchar(100) NOT NULL,
        [NameTrxCode] nvarchar(100) NOT NULL,
        [TwoLetterCode] nvarchar(2) NOT NULL,
        [ThreeLetterCode] nvarchar(3) NOT NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        [AudienceId] uniqueidentifier NULL,
        [LanguageId] uniqueidentifier NULL,
        CONSTRAINT [PK_Countries] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Countries_Audiences_AudienceId] FOREIGN KEY ([AudienceId]) REFERENCES [config].[Audiences] ([Id]),
        CONSTRAINT [FK_Countries_Languages_LanguageId] FOREIGN KEY ([LanguageId]) REFERENCES [config].[Languages] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [dbo].[Peers] (
        [PeerId] uniqueidentifier NOT NULL,
        [VirtualProfileId] uniqueidentifier NOT NULL,
        [FirstName] nvarchar(100) NOT NULL,
        [LastName] nvarchar(100) NOT NULL,
        [Age] smallint NOT NULL,
        [Sex] int NOT NULL,
        [Address] nvarchar(500) NOT NULL,
        [Note] nvarchar(500) NULL,
        [PeerAccessToken] nvarchar(2000) NULL,
        [IsMuted] bit NOT NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        [AudienceId] uniqueidentifier NULL,
        [AudienceId1] uniqueidentifier NULL,
        CONSTRAINT [PK_Peers] PRIMARY KEY ([PeerId]),
        CONSTRAINT [FK_Peers_Audiences_AudienceId] FOREIGN KEY ([AudienceId]) REFERENCES [config].[Audiences] ([Id]),
        CONSTRAINT [FK_Peers_Audiences_AudienceId1] FOREIGN KEY ([AudienceId1]) REFERENCES [config].[Audiences] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE TABLE [content].[Tags] (
        [Id] uniqueidentifier NOT NULL,
        [Text] nvarchar(50) NOT NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        [AudienceId] uniqueidentifier NULL,
        CONSTRAINT [PK_Tags] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Tags_Audiences_AudienceId] FOREIGN KEY ([AudienceId]) REFERENCES [config].[Audiences] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AudienceId', N'CreatedBy', N'CreatedTimestamp', N'DeactivatedBy', N'DeactivatedReason', N'DeactivatedTimestamp', N'LanguageId', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'NameTrxCode', N'ThreeLetterCode', N'TwoLetterCode') AND [object_id] = OBJECT_ID(N'[config].[Countries]'))
        SET IDENTITY_INSERT [config].[Countries] ON;
    EXEC(N'INSERT INTO [config].[Countries] ([Id], [AudienceId], [CreatedBy], [CreatedTimestamp], [DeactivatedBy], [DeactivatedReason], [DeactivatedTimestamp], [LanguageId], [LastModifiedBy], [LastModifiedTimestamp], [Name], [NameTrxCode], [ThreeLetterCode], [TwoLetterCode])
    VALUES (CAST(1 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', N''Australia'', N''country_name_au'', N''AUS'', N''AU''),
    (CAST(2 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', N''Brazil'', N''country_name_br'', N''BRA'', N''BR''),
    (CAST(3 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', N''China'', N''country_name_cn'', N''CHN'', N''CN''),
    (CAST(4 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', N''France'', N''country_name_fr'', N''FRA'', N''FR''),
    (CAST(5 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', N''India'', N''country_name_in'', N''IND'', N''IN''),
    (CAST(6 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', N''Israel'', N''country_name_il'', N''ILR'', N''IL''),
    (CAST(7 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', N''Russia'', N''country_name_ru'', N''RUS'', N''RU''),
    (CAST(8 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', N''South Africa'', N''country_name_za'', N''ZAF'', N''ZA''),
    (CAST(9 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', N''Spain'', N''country_name_es'', N''ESP'', N''ES''),
    (CAST(10 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', N''United Kingdom'', N''country_name_gb'', N''GBR'', N''GB''),
    (CAST(11 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0721576+00:00'', N''United States'', N''country_name_us'', N''USA'', N''US'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AudienceId', N'CreatedBy', N'CreatedTimestamp', N'DeactivatedBy', N'DeactivatedReason', N'DeactivatedTimestamp', N'LanguageId', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'NameTrxCode', N'ThreeLetterCode', N'TwoLetterCode') AND [object_id] = OBJECT_ID(N'[config].[Countries]'))
        SET IDENTITY_INSERT [config].[Countries] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'FeelingId', N'CreatedBy', N'CreatedTimestamp', N'DeactivatedBy', N'DeactivatedReason', N'DeactivatedTimestamp', N'IconName', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'NameTrxCode', N'ShortCode', N'UnicodeIcon') AND [object_id] = OBJECT_ID(N'[config].[Feelings]'))
        SET IDENTITY_INSERT [config].[Feelings] ON;
    EXEC(N'INSERT INTO [config].[Feelings] ([FeelingId], [CreatedBy], [CreatedTimestamp], [DeactivatedBy], [DeactivatedReason], [DeactivatedTimestamp], [IconName], [LastModifiedBy], [LastModifiedTimestamp], [Name], [NameTrxCode], [ShortCode], [UnicodeIcon])
    VALUES (''01b66f2b-4b7b-4a74-8d18-be58ae22d8b0'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''naked'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Naked'', N''feeling_name_naked'', N'''', N''''),
    (''06cebd48-11f9-4de3-95f2-988ecf8f62da'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''small'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Small'', N''feeling_name_small'', N'''', N''''),
    (''0835db0e-c840-420c-8b0e-3946e3552d39'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''tired'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Tired'', N''feeling_name_tired'', N'''', N''''),
    (''085f8e49-f1de-47cf-8400-928a9989fa82'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''awful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Awful'', N''feeling_name_awful'', N'''', N''''),
    (''089e0745-555b-4b19-97b7-14a368859463'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''fine'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Fine'', N''feeling_name_fine'', N'''', N''''),
    (''08a1e6b3-b6ce-4d1d-8c3a-723ec08259f7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''rich'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Rich'', N''feeling_name_rich'', N'''', N''🤑''),
    (''09e29c18-4c5e-4942-9e9f-16745212f944'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''furious'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Furious'', N''feeling_name_furious'', N'''', N''''),
    (''0a713e6b-168c-4abf-bc97-4b895f60a59a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''relieved'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Relieved'', N''feeling_name_relieved'', N'''', N''''),
    (''0b86a3e9-984d-4cd6-bca0-4610554b7783'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''challenged'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Challenged'', N''feeling_name_challenged'', N'''', N''''),
    (''0bc32c85-d444-45bb-aae4-cc867a21a265'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''strong'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Strong'', N''feeling_name_strong'', N'''', N''''),
    (''0d10f8f7-92aa-476f-80d2-84fbfbc34d5d'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''surprised'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Surprised'', N''feeling_name_surprised'', N'''', N''''),
    (''0d31c472-8066-46a9-9852-e4f7b9841b95'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''wanted'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Wanted'', N''feeling_name_wanted'', N'''', N''''),
    (''0f0c175a-2eaf-41f1-847c-7972afcaf21d'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''angry'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Angry'', N''feeling_name_angry'', N'''', N''😠''),
    (''11487fd4-19eb-44ef-a09c-d5a66ec0501d'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''betrayed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Betrayed'', N''feeling_name_betrayed'', N'''', N''''),
    (''12c5f412-cfa9-43b6-948a-37f0e6da619a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''silly'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Silly'', N''feeling_name_silly'', N'''', N''😜''),
    (''15f04112-4485-4ba7-a1fd-2bfd40cf9a45'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''weird'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Weird'', N''feeling_name_weird'', N'''', N''''),
    (''169e7e39-3876-4dd0-bee4-8803f56fa45a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''fed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Fed'', N''feeling_name_fed'', N'''', N''''),
    (''1711c6f4-2f8f-4e5c-a6d6-4894599decc7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''bored'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Bored'', N''feeling_name_bored'', N'''', N''''),
    (''18a5a73b-5fb5-407f-97bc-d841e2c8327c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''crazy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Crazy'', N''feeling_name_crazy'', N'''', N''🤪''),
    (''1c1fe790-a818-46f7-a9a9-0d8ba1e6e8b1'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''loved'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Loved'', N''feeling_name_loved'', N'''', N''🥰''),
    (''2035c5cc-a84f-4ace-ac48-c6d733669fe9'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''whole'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Whole'', N''feeling_name_whole'', N'''', N''''),
    (''20d101b6-ed88-4c83-83fc-255ef986eca7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''motivated'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Motivated'', N''feeling_name_motivated'', N'''', N''''),
    (''21d86c77-7274-45a8-ac5f-9fb54909bceb'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''lonely'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Lonely'', N''feeling_name_lonely'', N'''', N''''),
    (''21deef8b-e58e-4147-b428-d0d89f97f474'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''hopeful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Hopeful'', N''feeling_name_hopeful'', N'''', N''''),
    (''22ec7eb7-f978-45a8-bbea-430b0223b45f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''happy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Happy'', N''feeling_name_happy'', N'''', N''😀''),
    (''25580ac9-ac15-44f0-9d4c-02d47e7a4465'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''thirsty'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Thirsty'', N''feeling_name_thirsty'', N'''', N''''),
    (''258bd346-8eb2-4e69-9c58-b1e634e199d7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''incomplete'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Incomplete'', N''feeling_name_incomplete'', N'''', N''''),
    (''270ca4a8-aa6a-43f8-a259-ee6289fef0f9'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''joyful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Joyful'', N''feeling_name_joyful'', N'''', N''''),
    (''286f8a5c-3fc6-4119-a91f-aab1a01e4092'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''accomplished'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Accomplished'', N''feeling_name_accomplished'', N'''', N''''),
    (''29786506-faf2-4daa-870b-f51fd3375974'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''stupid'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Stupid'', N''feeling_name_stupid'', N'''', N''''),
    (''2a70a02e-72fa-4c8f-931f-8dd754f4658f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''blessed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Blessed'', N''feeling_name_blessed'', N'''', N''😇''),
    (''2ad24e05-342b-4376-8e99-c7b3446af623'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''OK'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Ok'', N''feeling_name_OK'', N'''', N''👌''),
    (''2afae378-15eb-4b05-a2ed-072e47f45deb'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''lovely'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Lovely'', N''feeling_name_lovely'', N'''', N''🥰''),
    (''2d30270e-3301-44fb-a88d-fbef30b824c3'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''down'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Down'', N''feeling_name_down'', N'''', N''''),
    (''2d88e6c5-1d06-4359-bebb-a32fd631c41f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''busy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Busy'', N''feeling_name_busy'', N'''', N''''),
    (''2de5f4fd-2cf4-47da-b806-3c4f301ab37d'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''unwanted'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Unwanted'', N''feeling_name_unwanted'', N'''', N''''),
    (''2e8c5ed0-ba28-4e62-b974-1024a3ea69d4'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''blissful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Blissful'', N''feeling_name_blissful'', N'''', N''😊''),
    (''2ebb0d9c-c162-414a-9814-809ad5949f1f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''trapped'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Trapped'', N''feeling_name_trapped'', N'''', N''''),
    (''3008926d-905d-4668-9a20-ed7ce2e3d34c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''full'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Full'', N''feeling_name_full'', N'''', N''''),
    (''341ff8ed-a2f9-4516-9814-f8f6431800d2'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''positive'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Positive'', N''feeling_name_positive'', N'''', N''''),
    (''342e8658-f1ae-4a61-a9aa-a6a73875043a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''secure'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Secure'', N''feeling_name_secure'', N'''', N''''),
    (''36ec237c-c783-476c-be20-799cc9a03b53'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''useless'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Useless'', N''feeling_name_useless'', N'''', N'''');
    INSERT INTO [config].[Feelings] ([FeelingId], [CreatedBy], [CreatedTimestamp], [DeactivatedBy], [DeactivatedReason], [DeactivatedTimestamp], [IconName], [LastModifiedBy], [LastModifiedTimestamp], [Name], [NameTrxCode], [ShortCode], [UnicodeIcon])
    VALUES (''3735f359-42df-4ef8-ba8a-c73aed43d234'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''dirty'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Dirty'', N''feeling_name_dirty'', N'''', N''''),
    (''3749d11e-1cdd-4d0b-a6ef-91f0f09a4e34'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''aggravated'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Aggravated'', N''feeling_name_aggravated'', N'''', N''''),
    (''3776e481-4376-491b-85d2-bfe7086ff064'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''perplexed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Perplexed'', N''feeling_name_perplexed'', N'''', N''''),
    (''38a47e9c-2d45-42bb-b848-72a76eae306a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''yucky'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Yucky'', N''feeling_name_yucky'', N'''', N''''),
    (''3d1b4093-ecb8-436d-b51e-c5df414aa6c1'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''exhausted'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Exhausted'', N''feeling_name_exhausted'', N'''', N''''),
    (''3e2ad446-e3f1-4f74-af02-08a984f693b4'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''funny'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Funny'', N''feeling_name_funny'', N'''', N''''),
    (''3f4f04b5-fdb0-4f8c-91cc-cca8c8e958b5'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''warm'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Warm'', N''feeling_name_warm'', N'''', N''''),
    (''3fe02e4c-3720-459d-aa4d-223d4d6c6acf'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''better'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Better'', N''feeling_name_better'', N'''', N''''),
    (''4211daa8-db4c-465d-ab12-87cd1015d7b7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''good'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Good'', N''feeling_name_good'', N'''', N''''),
    (''4382acb9-0923-450b-8caf-85e45dff3dfe'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''heartbroken'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Heartbroken'', N''feeling_name_heartbroken'', N'''', N''''),
    (''43bcd595-1d81-47aa-87b4-c322ab9a70bd'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''fantastic'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Fantastic'', N''feeling_name_fantastic'', N'''', N''''),
    (''43ca7765-8d3d-4c1b-993c-450bcfffe794'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''regret'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Regret'', N''feeling_name_regret'', N'''', N''''),
    (''4417c6f7-ad96-4d71-b501-3e6b8c405ce0'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''disappointed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Disappointed'', N''feeling_name_disappointed'', N'''', N''''),
    (''459d37e8-6508-42b0-b6c4-e24d070594b3'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''depressed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Depressed'', N''feeling_name_depressed'', N'''', N''''),
    (''4753eb30-333c-457e-a031-827404bf6017'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''asleep'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Asleep'', N''feeling_name_asleep'', N'''', N''''),
    (''47ef1ee4-bb3e-47f0-bad6-a63aebca9a18'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''rough'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Rough'', N''feeling_name_rough'', N'''', N''''),
    (''49fa74a2-6c99-464d-849a-40cf5788ebb5'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''wonderful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Wonderful'', N''feeling_name_wonderful'', N'''', N''''),
    (''4a7119bc-dc90-49f0-baba-c3d5325cbeab'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''dumb'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Dumb'', N''feeling_name_dumb'', N'''', N''''),
    (''4aa801e0-398d-45d8-beb6-2ae230ff3515'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''welcome'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Welcome'', N''feeling_name_welcome'', N'''', N''''),
    (''4abd4e0f-60aa-49fe-a561-19989e67d531'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''sleepy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Sleepy'', N''feeling_name_sleepy'', N'''', N''''),
    (''4cc2b430-3eae-443f-a2e6-7238d5833cb1'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''festive'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Festive'', N''feeling_name_festive'', N'''', N''''),
    (''4f364fad-3cc9-4fb5-b4af-2852a9b2b0a7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''hung-over'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Hung-Over'', N''feeling_name_hung-over'', N'''', N''''),
    (''506177e4-f1f7-4cf4-a7f4-f8086c588527'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''stressed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Stressed'', N''feeling_name_stressed'', N'''', N''''),
    (''507ac941-b95e-4ce0-8dcc-084594f920ed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''alone'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Alone'', N''feeling_name_alone'', N'''', N''''),
    (''5370b78e-f56e-496d-9145-b4689a7cdd39'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''qualified'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Qualified'', N''feeling_name_qualified'', N'''', N''''),
    (''549adcbb-0d08-4f03-b130-f577f5214c32'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''cute'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Cute'', N''feeling_name_cute'', N'''', N''''),
    (''5551516b-6d56-4c7d-b4ba-f538dc8d4969'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''nostalgic'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Nostalgic'', N''feeling_name_nostalgic'', N'''', N''''),
    (''55575b4d-f47b-432c-bfaf-b20de84fef3f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''privileged'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Privileged'', N''feeling_name_privileged'', N'''', N''''),
    (''55b30db6-58fa-491a-88e7-9b3e8d8d450b'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''jealous'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Jealous'', N''feeling_name_jealous'', N'''', N''''),
    (''560f56e8-4d2f-4f0b-9ef1-f9e0393c7c15'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''ignored'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Ignored'', N''feeling_name_ignored'', N'''', N''''),
    (''56553d4e-2ed0-4b18-943c-6989f70eb272'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''confident'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Confident'', N''feeling_name_confident'', N'''', N''😏''),
    (''56d916cf-e5d3-4dd7-87a6-b104f3640bb0'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''inspired'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Inspired'', N''feeling_name_inspired'', N'''', N''''),
    (''56eb7564-5512-4f4f-aae3-02e8811fda86'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''alive'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Alive'', N''feeling_name_alive'', N'''', N''''),
    (''57c5fe52-98f8-4b6d-9161-046929f3ae45'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''fresh'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Fresh'', N''feeling_name_fresh'', N'''', N''''),
    (''5d618942-c7a5-41e7-8a2e-bfba3e3cbb30'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''awesome'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Awesome'', N''feeling_name_awesome'', N'''', N''''),
    (''5e00fb4e-a6d5-4045-8cbb-b8d6eb71e320'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''lucky'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Lucky'', N''feeling_name_lucky'', N'''', N''''),
    (''5e2ace5e-a088-468f-97f2-689dcd6462c6'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''safe'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Safe'', N''feeling_name_safe'', N'''', N''''),
    (''5efb0f46-78cd-4de6-a62b-4ebeea22db5a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''human'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Human'', N''feeling_name_human'', N'''', N''''),
    (''5fddd3e4-013a-40b8-9dae-8309c7d6e67f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''bad'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Bad'', N''feeling_name_bad'', N'''', N''''),
    (''61855962-05a8-42ae-ad06-8162ccac9bff'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''worried'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Worried'', N''feeling_name_worried'', N'''', N''''),
    (''61fd3dd1-6016-47a8-9035-6d41af3310bf'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''sad'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Sad'', N''feeling_name_sad'', N'''', N''🙁''),
    (''6266d214-eb1f-40ef-858e-6fd3da399f3a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''pumped'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Pumped'', N''feeling_name_pumped'', N'''', N'''');
    INSERT INTO [config].[Feelings] ([FeelingId], [CreatedBy], [CreatedTimestamp], [DeactivatedBy], [DeactivatedReason], [DeactivatedTimestamp], [IconName], [LastModifiedBy], [LastModifiedTimestamp], [Name], [NameTrxCode], [ShortCode], [UnicodeIcon])
    VALUES (''64c9586c-8051-4913-b571-761257838996'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''beautiful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Beautiful'', N''feeling_name_beautiful'', N'''', N''''),
    (''667ff54f-9340-434d-a4c6-9bbed5905a9c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''amazing'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Amazing'', N''feeling_name_amazing'', N'''', N''''),
    (''6946c406-0933-4bee-af0e-81023a23777e'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''cheated'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Cheated'', N''feeling_name_cheated'', N'''', N''''),
    (''6ab8514a-8716-4738-b261-060337351d7a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''drunk'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Drunk'', N''feeling_name_drunk'', N'''', N''''),
    (''6e2843b1-7171-42f0-880b-e75c22a9d67c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''irritated'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Irritated'', N''feeling_name_irritated'', N'''', N''''),
    (''6ee7460a-4e8f-40b3-9804-c7fe1def1ccd'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''thoughtful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Thoughtful'', N''feeling_name_thoughtful'', N'''', N''🤔''),
    (''6f9a077e-bb63-4d55-83e8-01e9db27e111'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''appreciated'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Appreciated'', N''feeling_name_appreciated'', N'''', N''''),
    (''6fafd74d-960a-426a-b102-b4e95f471471'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''blah'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Blah'', N''feeling_name_blah'', N'''', N''''),
    (''73bfd593-8751-4edf-9d31-6493578adf4b'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''cool'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Cool'', N''feeling_name_cool'', N'''', N''''),
    (''747d34cd-1410-4eaa-8a0b-d320103c8847'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''guilty'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Guilty'', N''feeling_name_guilty'', N'''', N''''),
    (''7505690f-560c-4075-9c6d-4b68ca5d19d1'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''old'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Old'', N''feeling_name_old'', N'''', N''''),
    (''76e12e0e-ba88-4883-8347-ceca3350b94a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''amazed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Amazed'', N''feeling_name_amazed'', N'''', N''''),
    (''76eeda28-92da-4251-ad3b-1e3b815bf791'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''thankful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Thankful'', N''feeling_name_thankful'', N'''', N''😄''),
    (''792ee121-3056-488d-b0c7-e20c16edff06'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''determined'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Determined'', N''feeling_name_determined'', N'''', N''''),
    (''7a098711-e106-4efd-847f-9bf8a0f92228'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''afraid'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Afraid'', N''feeling_name_afraid'', N'''', N''😨''),
    (''7a2b8075-b084-4f72-b5ec-395cd8fe7143'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''healthy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Healthy'', N''feeling_name_healthy'', N'''', N''😊''),
    (''7a8c6fb1-6f9d-4dc3-aee4-21d1742097a9'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''goofy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Goofy'', N''feeling_name_goofy'', N'''', N''🤪''),
    (''7ac2a4b5-dbbe-4e9e-9235-be478d212f7b'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''invisible'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Invisible'', N''feeling_name_invisible'', N'''', N''🫥''),
    (''7b2fb415-dd97-4b3a-bab7-7cd2bb99cf9f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''generous'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Generous'', N''feeling_name_generous'', N'''', N''''),
    (''7b5f058e-f4f3-4691-83de-cb11e54b93db'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''broke'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Broke'', N''feeling_name_broke'', N'''', N''''),
    (''7b643a51-f1e9-4ae5-8044-d0ce1e80493f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''smart'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Smart'', N''feeling_name_smart'', N'''', N''''),
    (''7bfecbab-6e86-4299-aef5-44764c326451'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''peaceful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Peaceful'', N''feeling_name_peaceful'', N'''', N''''),
    (''80c0c798-a922-4622-8695-84c805ac26f8'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''different'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Different'', N''feeling_name_different'', N'''', N''''),
    (''83625c00-ad6d-4c15-a22c-3b8f7703a98a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''ready'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Ready'', N''feeling_name_ready'', N'''', N''''),
    (''83b37224-3ca6-4c3f-bc57-16eb3acbc438'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''fabulous'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Fabulous'', N''feeling_name_fabulous'', N'''', N''''),
    (''84f8bcd6-0af8-4408-aef8-68688dd2c9ea'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''miserable'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Miserable'', N''feeling_name_miserable'', N'''', N''''),
    (''871f0510-050b-44c4-b036-1cf3f647e212'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''sarcastic'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Sarcastic'', N''feeling_name_sarcastic'', N'''', N''''),
    (''8b0bc9f1-ae35-4f91-bdfe-bd9ed80fbae8'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''light'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Light'', N''feeling_name_light'', N'''', N''''),
    (''8ba88719-5e45-456d-b665-f1aa465b86a1'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''overwhelmed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Overwhelmed'', N''feeling_name_overwhelmed'', N'''', N''''),
    (''8c28d339-5bd8-4045-8328-53d8cb0b2e6d'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''worthless'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Worthless'', N''feeling_name_worthless'', N'''', N''''),
    (''8c4798f4-e5e0-4e00-90e8-67e648f7ef1e'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''sore'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Sore'', N''feeling_name_sore'', N'''', N''''),
    (''9052e1dc-e3fb-418b-a0c4-6540eb7f4526'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''free'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Free'', N''feeling_name_free'', N'''', N''''),
    (''90590143-24b1-4b47-8e8d-4df7d3248dd5'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''pained'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Pained'', N''feeling_name_pained'', N'''', N''''),
    (''9086907d-86ac-4c68-840a-8ae96047be52'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''energised'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Energised'', N''feeling_name_energised'', N'''', N''''),
    (''92eda17b-27b7-4f19-a3ba-24b3029ce343'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''relaxed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Relaxed'', N''feeling_name_relaxed'', N'''', N''''),
    (''968bbaf2-525e-47ca-b4cc-39d2ffeae64c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''drained'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Drained'', N''feeling_name_drained'', N'''', N''''),
    (''98d28a53-6b61-4a8f-9a0d-54669c70e632'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''frustrated'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Frustrated'', N''feeling_name_frustrated'', N'''', N''''),
    (''98f5cf81-1d49-4e3d-a84e-355e04eb590f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''optimistic'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Optimistic'', N''feeling_name_optimistic'', N'''', N''''),
    (''9a4e1558-7eb0-4268-9277-3c2f455f0b36'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''super'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Super'', N''feeling_name_super'', N'''', N''''),
    (''9c3b4d27-3c9d-4fd7-a579-6db0e48acfe7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''unloved'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Unloved'', N''feeling_name_unloved'', N'''', N''''),
    (''9daabddd-93ff-4d18-bac3-d5756481ec94'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''mischievous'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Mischievous'', N''feeling_name_mischievous'', N'''', N''''),
    (''9fae2b63-b4fa-4e3a-946f-0e8c092665b8'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''nervous'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Nervous'', N''feeling_name_nervous'', N'''', N'''');
    INSERT INTO [config].[Feelings] ([FeelingId], [CreatedBy], [CreatedTimestamp], [DeactivatedBy], [DeactivatedReason], [DeactivatedTimestamp], [IconName], [LastModifiedBy], [LastModifiedTimestamp], [Name], [NameTrxCode], [ShortCode], [UnicodeIcon])
    VALUES (''a21cbe42-419c-4fc7-abbc-9681b79d992c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''jolly'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Jolly'', N''feeling_name_jolly'', N'''', N''''),
    (''a44fff61-19a0-4442-a072-eefa342612fc'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''annoyed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Annoyed'', N''feeling_name_annoyed'', N'''', N''😒''),
    (''a500ed74-7fc7-49ba-871c-a787afa90b93'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''professional'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Professional'', N''feeling_name_professional'', N'''', N''''),
    (''a618dd24-ac56-445d-975a-05b77c81b18d'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''terrible'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Terrible'', N''feeling_name_terrible'', N'''', N''''),
    (''a758024a-537e-472e-9e03-44d71d40e3e6'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''mad'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Mad'', N''feeling_name_mad'', N'''', N''''),
    (''a7f8979d-15bc-4302-9314-14bca1417db9'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''honoured'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Honoured'', N''feeling_name_honoured'', N'''', N''''),
    (''a98532db-59ce-45ec-a5f1-0e83b3c57ff4'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''broken'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Broken'', N''feeling_name_broken'', N'''', N''''),
    (''a9ee29c0-ac38-4757-a812-013b9cfb1e9b'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''normal'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Normal'', N''feeling_name_normal'', N'''', N''''),
    (''aa80381a-5daa-400b-ae88-b7bf4d1c2cbe'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''pretty'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Pretty'', N''feeling_name_pretty'', N'''', N''''),
    (''abe6dc76-373f-44b7-8ae4-021506946865'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''rested'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Rested'', N''feeling_name_rested'', N'''', N''''),
    (''ae4237bc-0c25-4463-a66a-a7bcf3eac9dd'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''unimportant'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Unimportant'', N''feeling_name_unimportant'', N'''', N''''),
    (''b099afcf-28a8-4af4-ba7d-86d01bab625b'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''great'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Great'', N''feeling_name_great'', N'''', N''''),
    (''b3c8a7b6-ef78-40e6-b37e-27a73305e83d'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''confused'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Confused'', N''feeling_name_confused'', N'''', N''😕''),
    (''b40a7618-a1e1-4a68-ae1a-44689268536d'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''hurt'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Hurt'', N''feeling_name_hurt'', N'''', N''''),
    (''b4a8a25f-af15-4f93-a24e-d9c93bdec717'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''numb'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Numb'', N''feeling_name_numb'', N'''', N''''),
    (''b4f0e6cb-8634-406d-960e-9197a4152269'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''sick'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Sick'', N''feeling_name_sick'', N'''', N''🤢''),
    (''b50da74e-8549-4a46-988e-346abc1304e8'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''satisfied'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Satisfied'', N''feeling_name_satisfied'', N'''', N''''),
    (''b595d289-6ebc-4220-840c-4da8372d510b'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''weak'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Weak'', N''feeling_name_weak'', N'''', N''''),
    (''bc07b2cc-f28d-4bd1-87a6-90f9ca44e9b4'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''upset'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Upset'', N''feeling_name_upset'', N'''', N''''),
    (''bc5470ff-4557-45b1-8d34-c8dc429900ac'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''emotional'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Emotional'', N''feeling_name_emotional'', N'''', N''''),
    (''bc85a26a-17c9-4507-9f92-873727c64aad'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''insecure'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Insecure'', N''feeling_name_insecure'', N'''', N''''),
    (''bd9955c5-1c92-4d7c-97d2-94c2c899333f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''shy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Shy'', N''feeling_name_shy'', N'''', N''''),
    (''beb1cf32-06f1-43d8-b964-8128a6e7184b'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''calm'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Calm'', N''feeling_name_calm'', N'''', N''''),
    (''c01dbeba-eb1e-4c4d-98f2-33d38e42491a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''evil'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Evil'', N''feeling_name_evil'', N'''', N''''),
    (''c2927ec9-7da9-45f4-bc06-242e3f86000b'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''lost'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Lost'', N''feeling_name_lost'', N'''', N''''),
    (''c3520b20-bff0-4396-967c-8cc517baac45'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''mighty'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Mighty'', N''feeling_name_mighty'', N'''', N''''),
    (''c5562569-4a6c-4210-b590-957dfbd9ef18'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''in love'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''In Love'', N''feeling_name_in_love'', N'''', N''🥰''),
    (''c58ed281-ef78-4e42-b6e8-34642ef3d35c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''deep'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Deep'', N''feeling_name_deep'', N'''', N''''),
    (''c5b2a468-fb53-40db-9d31-4cec23169802'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''chill'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Chill'', N''feeling_name_chill'', N'''', N''''),
    (''c622f8f7-2f6f-4d1d-b75f-fd063a4ecb8f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''worse'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Worse'', N''feeling_name_worse'', N'''', N''''),
    (''c81ca42f-0a5a-4c93-96ad-472698fad740'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''blue'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Blue'', N''feeling_name_blue'', N'''', N''''),
    (''c9b1b2cd-a22a-4a63-9f9d-271aba6c9cd5'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''impatient'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Impatient'', N''feeling_name_impatient'', N'''', N''''),
    (''ca3f3e75-1886-4d47-8bb3-97f052548044'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''ashamed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Ashamed'', N''feeling_name_ashamed'', N'''', N''''),
    (''cc6019e2-388c-4285-818e-fbbf94eaaa95'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''proud'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Proud'', N''feeling_name_proud'', N'''', N''''),
    (''d33120f1-9eeb-41e5-b9f5-e0031086d31f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''uncomfortable'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Uncomfortable'', N''feeling_name_uncomfortable'', N'''', N''''),
    (''d4bc2297-b513-4c11-969d-8531f172273e'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''cold'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Cold'', N''feeling_name_cold'', N'''', N''''),
    (''d655b8d5-61ba-45af-87a4-2eb75147bf14'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''concerned'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Concerned'', N''feeling_name_concerned'', N'''', N''''),
    (''d6ba723f-ffef-4d7a-9ed3-841b7414b31d'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''hopeless'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Hopeless'', N''feeling_name_hopeless'', N'''', N''''),
    (''d729dae1-2182-46ae-97bf-a905022ec66e'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''helpless'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Helpless'', N''feeling_name_helpless'', N'''', N''''),
    (''d84a641e-f545-48a9-9f58-fff81a27a940'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''kind'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Kind'', N''feeling_name_kind'', N'''', N''''),
    (''d8ef5370-d9e4-4ecb-85fc-afc06b79f61c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''special'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Special'', N''feeling_name_special'', N'''', N''''),
    (''d97fcbb8-1c9a-462c-afca-d72d941ac112'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''missing'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Missing'', N''feeling_name_missing'', N'''', N'''');
    INSERT INTO [config].[Feelings] ([FeelingId], [CreatedBy], [CreatedTimestamp], [DeactivatedBy], [DeactivatedReason], [DeactivatedTimestamp], [IconName], [LastModifiedBy], [LastModifiedTimestamp], [Name], [NameTrxCode], [ShortCode], [UnicodeIcon])
    VALUES (''d9ddf404-f94d-47fa-84d9-d42f7ce73e79'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''strange'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Strange'', N''feeling_name_strange'', N'''', N''''),
    (''db53e247-6177-4ce0-9bec-ab539f6f8911'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''important'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Important'', N''feeling_name_important'', N'''', N''''),
    (''db672a0e-ea69-4b0b-aaf4-f76bdbeb1212'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''amused'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Amused'', N''feeling_name_amused'', N'''', N''''),
    (''dbef69d7-a94d-4cf2-b3dc-acc44f230e87'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''lazy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Lazy'', N''feeling_name_lazy'', N'''', N''''),
    (''dc232b77-6429-4fe1-aa15-1f355acd7356'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''excited'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Excited'', N''feeling_name_excited'', N'''', N''🤩''),
    (''ddf5749e-0c73-4f5b-bdb9-bb6e987d95e0'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''crappy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Crappy'', N''feeling_name_crappy'', N'''', N''''),
    (''de601109-9446-47d9-bad7-064b507e0c36'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''low'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Low'', N''feeling_name_low'', N'''', N''''),
    (''dfa932af-72c2-4b3e-a738-893b36c5b212'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''comfortable'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Comfortable'', N''feeling_name_comfortable'', N'''', N''''),
    (''e126fe88-cfd7-43cf-9cd8-def88a016bb5'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''embarrassed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Embarrassed'', N''feeling_name_embarrassed'', N'''', N''''),
    (''e24313a6-7ac1-48d4-ab26-dd6d017060ce'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''offended'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Offended'', N''feeling_name_offended'', N'''', N''''),
    (''e456cff0-2f89-466f-a349-1a13f207bfa9'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''well'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Well'', N''feeling_name_well'', N'''', N''''),
    (''ee65a1e3-cea2-40c0-8097-aa9bc0a2d459'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''meh'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Meh'', N''feeling_name_meh'', N'''', N''😐️''),
    (''ee666880-cb69-4fce-bdfc-82cae967f42a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''horrible'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Horrible'', N''feeling_name_horrible'', N'''', N''''),
    (''ef5fbeed-f6b3-44d6-82bf-76367a431e72'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''delighted'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Delighted'', N''feeling_name_delighted'', N'''', N''''),
    (''ef9fa565-8a6c-4dda-94d8-958968e70430'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''awkward'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Awkward'', N''feeling_name_awkward'', N'''', N''''),
    (''efde344f-a550-4002-b667-dae5c099d0e4'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''anxious'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Anxious'', N''feeling_name_anxious'', N'''', N''''),
    (''f2126556-74e6-4596-819f-44285d383704'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''hyper'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Hyper'', N''feeling_name_hyper'', N'''', N''''),
    (''f300c8f4-0a5d-44a4-8330-7e374f0dceae'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''hungry'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Hungry'', N''feeling_name_hungry'', N'''', N''''),
    (''f6864247-c3c7-4d8a-8472-5735919c188f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''nice'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Nice'', N''feeling_name_nice'', N'''', N''''),
    (''f737417d-7dfb-462e-bc05-3f6bf0c9f6be'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''perfect'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Perfect'', N''feeling_name_perfect'', N'''', N''''),
    (''f7fea281-a22b-46cc-83b6-01546ff72ff1'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''glad'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Glad'', N''feeling_name_glad'', N'''', N''''),
    (''f8849493-75da-4531-8acd-144388cecc10'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''puzzled'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Puzzled'', N''feeling_name_puzzled'', N'''', N''''),
    (''fad3b6b9-79d7-4670-a53f-d270bcb4b4e8'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''threatened'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Threatened'', N''feeling_name_threatened'', N'''', N''''),
    (''fb75cb85-35bb-4b67-b632-6dcf7803833f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''curious'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Curious'', N''feeling_name_curious'', N'''', N''''),
    (''fbc32171-c668-4ba6-985a-aca9b102b8e7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''scared'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Scared'', N''feeling_name_scared'', N'''', N''''),
    (''fcabecdb-c0ef-43c4-86df-b49348a7608d'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''nauseous'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Nauseous'', N''feeling_name_nauseous'', N'''', N''''),
    (''fd2ee5d0-8c7d-42f6-b7bb-62591e267b5f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''grateful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Grateful'', N''feeling_name_grateful'', N'''', N''😄''),
    (''fdd430dd-3526-4330-8d96-10b3580f37f2'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''sorry'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Sorry'', N''feeling_name_sorry'', N'''', N''''),
    (''ff6639bf-0b56-4718-a651-04c80a7fb78f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''stuck'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Stuck'', N''feeling_name_stuck'', N'''', N''''),
    (''ffadf5fd-6ad3-44ec-9319-82f4fa03fc51'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', NULL, NULL, NULL, N''refreshed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0725822+00:00'', N''Refreshed'', N''feeling_name_refreshed'', N'''', N'''')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'FeelingId', N'CreatedBy', N'CreatedTimestamp', N'DeactivatedBy', N'DeactivatedReason', N'DeactivatedTimestamp', N'IconName', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'NameTrxCode', N'ShortCode', N'UnicodeIcon') AND [object_id] = OBJECT_ID(N'[config].[Feelings]'))
        SET IDENTITY_INSERT [config].[Feelings] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'CreatedBy', N'CreatedTimestamp', N'DeactivatedBy', N'DeactivatedReason', N'DeactivatedTimestamp', N'Direction', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'NameTrxCode', N'ThreeLetterCode', N'TwoLetterCode') AND [object_id] = OBJECT_ID(N'[config].[Languages]'))
        SET IDENTITY_INSERT [config].[Languages] ON;
    EXEC(N'INSERT INTO [config].[Languages] ([Id], [Code], [CreatedBy], [CreatedTimestamp], [DeactivatedBy], [DeactivatedReason], [DeactivatedTimestamp], [Direction], [LastModifiedBy], [LastModifiedTimestamp], [Name], [NameTrxCode], [ThreeLetterCode], [TwoLetterCode])
    VALUES (''03464df6-855b-49ab-9698-3e64f64e870d'', N''RU'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', NULL, NULL, NULL, 0, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', N''Russian'', N''language_name_ru'', N''RUS'', N''RU''),
    (''156ae770-ad39-4c17-bade-660dc0025e36'', N''ES'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', NULL, NULL, NULL, 0, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', N''Spanish'', N''language_name_es'', N''ESP'', N''ES''),
    (''2653f2af-a65a-427f-a8e6-cac9c69eafe1'', N''FR'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', NULL, NULL, NULL, 0, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', N''French'', N''language_name_fr'', N''FRA'', N''FR''),
    (''746ebb01-ba2a-48ca-9434-dcbe4f7ac8dd'', N''HE'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', NULL, NULL, NULL, 1, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', N''Hebrew'', N''language_name_he'', N''HEB'', N''HE''),
    (''8a364f1e-cec7-4077-85ad-9fe5eb2bf9c5'', N''HI'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', NULL, NULL, NULL, 0, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', N''Hindi'', N''language_name_hi'', N''HIN'', N''HI''),
    (''e31dd6df-cd8a-4c1b-b624-ff3c6d2ef708'', N''ZU'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', NULL, NULL, NULL, 0, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', N''Zulu'', N''language_name_zu'', N''ZUL'', N''ZU''),
    (''e8e900e1-e289-444c-9e2d-90003082ab11'', N''AF'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', NULL, NULL, NULL, 0, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', N''Afrikaans'', N''language_name_af'', N''AFR'', N''AF''),
    (''f964ab12-705b-435b-b85c-a6cfbc412557'', N''EN'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', NULL, NULL, NULL, 0, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', N''English'', N''language_name_en'', N''ENG'', N''EN''),
    (''fd8853fc-e007-43c3-826d-21e110e059d0'', N''ZH'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', NULL, NULL, NULL, 0, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0718447+00:00'', N''Chinese'', N''language_name_zh'', N''ZHO'', N''ZH'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'CreatedBy', N'CreatedTimestamp', N'DeactivatedBy', N'DeactivatedReason', N'DeactivatedTimestamp', N'Direction', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'NameTrxCode', N'ThreeLetterCode', N'TwoLetterCode') AND [object_id] = OBJECT_ID(N'[config].[Languages]'))
        SET IDENTITY_INSERT [config].[Languages] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'CreatedTimestamp', N'DeactivatedBy', N'DeactivatedReason', N'DeactivatedTimestamp', N'IconName', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'NameTrxCode', N'UnicodeIcon') AND [object_id] = OBJECT_ID(N'[config].[Reactions]'))
        SET IDENTITY_INSERT [config].[Reactions] ON;
    EXEC(N'INSERT INTO [config].[Reactions] ([Id], [CreatedBy], [CreatedTimestamp], [DeactivatedBy], [DeactivatedReason], [DeactivatedTimestamp], [IconName], [LastModifiedBy], [LastModifiedTimestamp], [Name], [NameTrxCode], [UnicodeIcon])
    VALUES (''114bc279-2776-4cdc-ae97-8852e09fda90'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0724044+00:00'', NULL, NULL, NULL, N''like'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0724044+00:00'', N''Like'', N''reaction_name_like'', N''1''),
    (''13d6b990-8524-4d92-a8a0-2742df55a536'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0724044+00:00'', NULL, NULL, NULL, N''laugh'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0724044+00:00'', N''Haha'', N''reaction_name_laugh'', N''1''),
    (''72aa1e46-d975-4c65-baf2-1439b25d1911'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0724044+00:00'', NULL, NULL, NULL, N''sad'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0724044+00:00'', N''Sad'', N''reaction_name_sad'', N''1''),
    (''80d391f0-e0bd-446c-823f-752bfdbc3de2'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0724044+00:00'', NULL, NULL, NULL, N''wow'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0724044+00:00'', N''Wow'', N''reaction_name_wow'', N''1''),
    (''ad042441-a5b5-44e2-aaf4-e42c4db5f383'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0724044+00:00'', NULL, NULL, NULL, N''angry'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0724044+00:00'', N''Angry'', N''reaction_name_angry'', N''1''),
    (''c51d0ebf-0966-41f4-9a64-f49435e37ee4'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0724044+00:00'', NULL, NULL, NULL, N''love'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0724044+00:00'', N''Love'', N''reaction_name_love'', N''1''),
    (''f10d52ad-bc3c-4d16-a38b-e55f84b1c8f2'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0724044+00:00'', NULL, NULL, NULL, N''care'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0724044+00:00'', N''Care'', N''reaction_name_care'', N''1''),
    (''fe9c122c-f0a1-4110-b867-fde63f1c41a6'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0724044+00:00'', NULL, NULL, NULL, N''dislike'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0724044+00:00'', N''Dislike'', N''reaction_name_dislike'', N''1'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'CreatedTimestamp', N'DeactivatedBy', N'DeactivatedReason', N'DeactivatedTimestamp', N'IconName', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'NameTrxCode', N'UnicodeIcon') AND [object_id] = OBJECT_ID(N'[config].[Reactions]'))
        SET IDENTITY_INSERT [config].[Reactions] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'CreatedTimestamp', N'DataType', N'DefaultValue', N'HelpText', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'SettingCategoryId', N'ShortDescription', N'Value') AND [object_id] = OBJECT_ID(N'[config].[Settings]'))
        SET IDENTITY_INSERT [config].[Settings] ON;
    EXEC(N'INSERT INTO [config].[Settings] ([Id], [CreatedBy], [CreatedTimestamp], [DataType], [DefaultValue], [HelpText], [LastModifiedBy], [LastModifiedTimestamp], [Name], [SettingCategoryId], [ShortDescription], [Value])
    VALUES (''0acde490-17b5-43c8-844f-a0b7b494089b'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0712550+00:00'', 4, N'''', NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0712550+00:00'', N''Idp Issuer Signing Key Secret'', NULL, N''The secret used for generating the Idp Issuer Signing Key for the Astrana instance.'', N''69473DFCE4E2D15A343495F3612FBD2C69473DFCE4E2D15A343495F3612FBD2C''),
    (''313bcfb2-cf23-4316-a24a-b020531be4d9'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0712550+00:00'', 1, N''0'', NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0712550+00:00'', N''Multi-factor Authentication'', NULL, N''Turn multi-factor authentication on/off.'', NULL),
    (''8ef7c23f-ce15-4de5-8673-2d077e2f7b1e'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0712550+00:00'', 4, N'''', NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0712550+00:00'', N''Host Port Number'', NULL, N''The host port number of the Astrana instance.'', NULL),
    (''acda9dbe-e82a-4632-aafb-e21ae02e4799'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0712550+00:00'', 4, N''EN'', NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0712550+00:00'', N''Language Code'', NULL, N''The language code of the Astrana instance user.'', NULL),
    (''aebcaf94-ab22-48c3-a697-3bacf3077fe7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0712550+00:00'', 4, N''AUS Eastern Standard Time'', NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0712550+00:00'', N''Time Zone'', NULL, N''The time zone of the Astrana instance user.'', NULL),
    (''b530c184-2b0f-4d38-9a61-f27156ba1ee0'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0712550+00:00'', 4, N''AU'', NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0712550+00:00'', N''Regional Format'', NULL, N''Formats for dates, times and numbers.'', NULL),
    (''bc5333a0-eeb3-4197-bfe9-043ffb605b81'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0712550+00:00'', 4, N''localhost'', NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0712550+00:00'', N''Host Name'', NULL, N''The address of the Astrana instance.'', NULL),
    (''dc890d67-d438-4267-8a0b-26b6aa492852'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0712550+00:00'', 21, N'''', NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-10-20T05:10:48.0712550+00:00'', N''Default Skin Tone'', NULL, N''The secret used for generating the Idp Issuer Signing Key for the Astrana instance.'', N''69473DFCE4E2D15A343495F3612FBD2C69473DFCE4E2D15A343495F3612FBD2C'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'CreatedTimestamp', N'DataType', N'DefaultValue', N'HelpText', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'SettingCategoryId', N'ShortDescription', N'Value') AND [object_id] = OBJECT_ID(N'[config].[Settings]'))
        SET IDENTITY_INSERT [config].[Settings] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_ApiAccessTokens_Token] ON [iam].[ApiAccessTokens] ([Token]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Audiences_Name] ON [config].[Audiences] ([Name]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_Audiences_UserProfileDetailId] ON [config].[Audiences] ([UserProfileDetailId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_Comments_TargeCommentCommentId] ON [content].[Comments] ([TargeCommentCommentId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_Comments_TargetAudioId] ON [content].[Comments] ([TargetAudioId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_Comments_TargetContentCollectionId] ON [content].[Comments] ([TargetContentCollectionId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_Comments_TargetGifId] ON [content].[Comments] ([TargetGifId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_Comments_TargetImageId] ON [content].[Comments] ([TargetImageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_Comments_TargetLinkId] ON [content].[Comments] ([TargetLinkId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_Comments_TargetPostId] ON [content].[Comments] ([TargetPostId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_Comments_TargetVideoId] ON [content].[Comments] ([TargetVideoId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_ContentCollectionItems_AudioId] ON [content].[ContentCollectionItems] ([AudioId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_ContentCollectionItems_ContentCollectionId] ON [content].[ContentCollectionItems] ([ContentCollectionId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_ContentCollectionItems_GifId] ON [content].[ContentCollectionItems] ([GifId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_ContentCollectionItems_ImageId] ON [content].[ContentCollectionItems] ([ImageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_ContentCollectionItems_LinkId] ON [content].[ContentCollectionItems] ([LinkId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_ContentCollectionItems_VideoId] ON [content].[ContentCollectionItems] ([VideoId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_Countries_AudienceId] ON [config].[Countries] ([AudienceId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_Countries_LanguageId] ON [config].[Countries] ([LanguageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Countries_NameTrxCode] ON [config].[Countries] ([NameTrxCode]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Countries_ThreeLetterCode] ON [config].[Countries] ([ThreeLetterCode]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Countries_TwoLetterCode] ON [config].[Countries] ([TwoLetterCode]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_ExternalContentSubscriptions_PreviewImageId] ON [content].[ExternalContentSubscriptions] ([PreviewImageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_FeatureToggles_FeatureName] ON [config].[FeatureToggles] ([FeatureName]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Feelings_NameTrxCode] ON [config].[Feelings] ([NameTrxCode]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Languages_Code] ON [config].[Languages] ([Code]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Languages_NameTrxCode] ON [config].[Languages] ([NameTrxCode]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Languages_ThreeLetterCode] ON [config].[Languages] ([ThreeLetterCode]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Languages_TwoLetterCode] ON [config].[Languages] ([TwoLetterCode]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_Links_PreviewImageId] ON [content].[Links] ([PreviewImageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_MessengerUsernameRel_MessengerUsernameId] ON [user].[MessengerUsernameRel] ([MessengerUsernameId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_PeerConnectionRequestsReceived_Address] ON [dbo].[PeerConnectionRequestsReceived] ([Address]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_PeerConnectionRequestsSubmitted_Address] ON [dbo].[PeerConnectionRequestsSubmitted] ([Address]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_Peers_AudienceId] ON [dbo].[Peers] ([AudienceId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_Peers_AudienceId1] ON [dbo].[Peers] ([AudienceId1]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_PostAttachments_AudioId] ON [content].[PostAttachments] ([AudioId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_PostAttachments_ContentCollectionId] ON [content].[PostAttachments] ([ContentCollectionId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_PostAttachments_FeelingId] ON [content].[PostAttachments] ([FeelingId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_PostAttachments_GifId] ON [content].[PostAttachments] ([GifId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_PostAttachments_ImageId] ON [content].[PostAttachments] ([ImageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_PostAttachments_LinkId] ON [content].[PostAttachments] ([LinkId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_PostAttachments_LocationId] ON [content].[PostAttachments] ([LocationId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_PostAttachments_PostId] ON [content].[PostAttachments] ([PostId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_PostAttachments_VideoId] ON [content].[PostAttachments] ([VideoId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Reactions_NameTrxCode] ON [config].[Reactions] ([NameTrxCode]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_Settings_SettingCategoryId] ON [config].[Settings] ([SettingCategoryId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_Tags_AudienceId] ON [content].[Tags] ([AudienceId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_UserAccountRoleRel_UserRoleId] ON [iam].[UserAccountRoleRel] ([UserRoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [IX_UserAccounts_EmailAddress] ON [iam].[UserAccounts] ([EmailAddress]) WHERE [EmailAddress] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [IX_UserAccounts_PhoneNumber] ON [iam].[UserAccounts] ([PhoneNumber]) WHERE [PhoneNumber] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [IX_UserAccounts_UserName] ON [iam].[UserAccounts] ([UserName]) WHERE [UserName] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_UserEmailAddressRel_EmailAddressId] ON [user].[UserEmailAddressRel] ([EmailAddressId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_UserPhoneNumberRel_PhoneNumberId] ON [user].[UserPhoneNumberRel] ([PhoneNumberId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_UserProfileDetails_UserProfileId] ON [user].[UserProfileDetails] ([UserProfileId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_UserProfiles_CoverPictureImageId] ON [user].[UserProfiles] ([CoverPictureImageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_UserProfiles_CoverPicturesCollectionContentCollectionId] ON [user].[UserProfiles] ([CoverPicturesCollectionContentCollectionId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_UserProfiles_ProfilePictureImageId] ON [user].[UserProfiles] ([ProfilePictureImageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_UserProfiles_ProfilePicturesCollectionContentCollectionId] ON [user].[UserProfiles] ([ProfilePicturesCollectionContentCollectionId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    CREATE INDEX [IX_UserProfiles_UserAccountId] ON [user].[UserProfiles] ([UserAccountId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20231020051048_InitialSchema')
BEGIN
    INSERT INTO [maintenance].[MigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20231020051048_InitialSchema', N'7.0.10');
END;
GO

COMMIT;
GO

