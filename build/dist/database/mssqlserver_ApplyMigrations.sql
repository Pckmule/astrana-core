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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    IF SCHEMA_ID(N'content') IS NULL EXEC(N'CREATE SCHEMA [content];');
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    IF SCHEMA_ID(N'iam') IS NULL EXEC(N'CREATE SCHEMA [iam];');
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    IF SCHEMA_ID(N'config') IS NULL EXEC(N'CREATE SCHEMA [config];');
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    IF SCHEMA_ID(N'contact') IS NULL EXEC(N'CREATE SCHEMA [contact];');
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    IF SCHEMA_ID(N'user') IS NULL EXEC(N'CREATE SCHEMA [user];');
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE TABLE [content].[Albums] (
        [Id] uniqueidentifier NOT NULL,
        [Title] nvarchar(250) NOT NULL,
        [Caption] nvarchar(500) NULL,
        [Copyright] nvarchar(500) NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_Albums] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE TABLE [config].[Feelings] (
        [Id] uniqueidentifier NOT NULL,
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
        CONSTRAINT [PK_Feelings] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE TABLE [dbo].[PeerConnectionRequestsReceived] (
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
        CONSTRAINT [PK_PeerConnectionRequestsReceived] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE TABLE [content].[Posts] (
        [Id] bigint NOT NULL IDENTITY,
        [Text] nvarchar(1000) NOT NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        CONSTRAINT [PK_Posts] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE TABLE [content].[Videos] (
        [Id] uniqueidentifier NOT NULL,
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
        CONSTRAINT [PK_Videos] PRIMARY KEY ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE TABLE [content].[Images] (
        [Id] uniqueidentifier NOT NULL,
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
        [AlbumId] uniqueidentifier NULL,
        CONSTRAINT [PK_Images] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Images_Albums_AlbumId] FOREIGN KEY ([AlbumId]) REFERENCES [content].[Albums] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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
        CONSTRAINT [FK_ExternalContentSubscriptions_Images_PreviewImageId] FOREIGN KEY ([PreviewImageId]) REFERENCES [content].[Images] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE TABLE [content].[Links] (
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
        CONSTRAINT [PK_Links] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Links_Images_PreviewImageId] FOREIGN KEY ([PreviewImageId]) REFERENCES [content].[Images] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE TABLE [user].[UserProfiles] (
        [Id] uniqueidentifier NOT NULL,
        [UserAccountId] uniqueidentifier NOT NULL,
        [FirstName] nvarchar(100) NOT NULL,
        [MiddleNames] nvarchar(300) NULL,
        [LastName] nvarchar(100) NULL,
        [DateOfBirth] datetimeoffset NOT NULL,
        [Gender] int NOT NULL,
        [Introduction] nvarchar(100) NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        [ProfilePictureId] uniqueidentifier NULL,
        [CoverPictureId] uniqueidentifier NULL,
        CONSTRAINT [PK_UserProfiles] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_UserProfiles_Images_CoverPictureId] FOREIGN KEY ([CoverPictureId]) REFERENCES [content].[Images] ([Id]),
        CONSTRAINT [FK_UserProfiles_Images_ProfilePictureId] FOREIGN KEY ([ProfilePictureId]) REFERENCES [content].[Images] ([Id]),
        CONSTRAINT [FK_UserProfiles_UserAccounts_UserAccountId] FOREIGN KEY ([UserAccountId]) REFERENCES [iam].[UserAccounts] ([Id]) ON DELETE CASCADE
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE TABLE [content].[PostAttachments] (
        [Id] uniqueidentifier NOT NULL,
        [Title] nvarchar(250) NULL,
        [Caption] nvarchar(250) NULL,
        [Type] int NOT NULL,
        [DeactivatedTimestamp] datetimeoffset NULL,
        [DeactivatedReason] nvarchar(max) NULL,
        [DeactivatedBy] uniqueidentifier NULL,
        [CreatedBy] uniqueidentifier NOT NULL,
        [LastModifiedBy] uniqueidentifier NOT NULL,
        [CreatedTimestamp] datetimeoffset NOT NULL,
        [LastModifiedTimestamp] datetimeoffset NOT NULL,
        [LinkId] uniqueidentifier NULL,
        [ImageId] uniqueidentifier NULL,
        [AudioId] uniqueidentifier NULL,
        [VideoId] uniqueidentifier NULL,
        [AlbumId] uniqueidentifier NULL,
        [LocationId] uniqueidentifier NULL,
        [FeelingId] uniqueidentifier NULL,
        [PostId] bigint NULL,
        CONSTRAINT [PK_PostAttachments] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_PostAttachments_Albums_AlbumId] FOREIGN KEY ([AlbumId]) REFERENCES [content].[Albums] ([Id]),
        CONSTRAINT [FK_PostAttachments_Albums_LocationId] FOREIGN KEY ([LocationId]) REFERENCES [content].[Albums] ([Id]),
        CONSTRAINT [FK_PostAttachments_Feelings_FeelingId] FOREIGN KEY ([FeelingId]) REFERENCES [config].[Feelings] ([Id]),
        CONSTRAINT [FK_PostAttachments_Links_AudioId] FOREIGN KEY ([AudioId]) REFERENCES [content].[Links] ([Id]),
        CONSTRAINT [FK_PostAttachments_Links_ImageId] FOREIGN KEY ([ImageId]) REFERENCES [content].[Links] ([Id]),
        CONSTRAINT [FK_PostAttachments_Links_LinkId] FOREIGN KEY ([LinkId]) REFERENCES [content].[Links] ([Id]),
        CONSTRAINT [FK_PostAttachments_Links_VideoId] FOREIGN KEY ([VideoId]) REFERENCES [content].[Links] ([Id]),
        CONSTRAINT [FK_PostAttachments_Posts_PostId] FOREIGN KEY ([PostId]) REFERENCES [content].[Posts] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE TABLE [dbo].[Peers] (
        [Id] uniqueidentifier NOT NULL,
        [FirstName] nvarchar(100) NOT NULL,
        [LastName] nvarchar(100) NOT NULL,
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
        CONSTRAINT [PK_Peers] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_Peers_Audiences_AudienceId] FOREIGN KEY ([AudienceId]) REFERENCES [config].[Audiences] ([Id]),
        CONSTRAINT [FK_Peers_Audiences_AudienceId1] FOREIGN KEY ([AudienceId1]) REFERENCES [config].[Audiences] ([Id])
    );
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
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

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AudienceId', N'CreatedBy', N'CreatedTimestamp', N'DeactivatedBy', N'DeactivatedReason', N'DeactivatedTimestamp', N'LanguageId', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'NameTrxCode', N'ThreeLetterCode', N'TwoLetterCode') AND [object_id] = OBJECT_ID(N'[config].[Countries]'))
        SET IDENTITY_INSERT [config].[Countries] ON;
    EXEC(N'INSERT INTO [config].[Countries] ([Id], [AudienceId], [CreatedBy], [CreatedTimestamp], [DeactivatedBy], [DeactivatedReason], [DeactivatedTimestamp], [LanguageId], [LastModifiedBy], [LastModifiedTimestamp], [Name], [NameTrxCode], [ThreeLetterCode], [TwoLetterCode])
    VALUES (CAST(1 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', N''Australia'', N''country_name_au'', N''AUS'', N''AU''),
    (CAST(2 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', N''Brazil'', N''country_name_br'', N''BRA'', N''BR''),
    (CAST(3 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', N''China'', N''country_name_cn'', N''CHN'', N''CN''),
    (CAST(4 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', N''France'', N''country_name_fr'', N''FRA'', N''FR''),
    (CAST(5 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', N''India'', N''country_name_in'', N''IND'', N''IN''),
    (CAST(6 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', N''Israel'', N''country_name_il'', N''ILR'', N''IL''),
    (CAST(7 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', N''Russia'', N''country_name_ru'', N''RUS'', N''RU''),
    (CAST(8 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', N''South Africa'', N''country_name_za'', N''ZAF'', N''ZA''),
    (CAST(9 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', N''Spain'', N''country_name_es'', N''ESP'', N''ES''),
    (CAST(10 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', N''United Kingdom'', N''country_name_gb'', N''GBR'', N''GB''),
    (CAST(11 AS bigint), NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', NULL, NULL, NULL, NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7081659+00:00'', N''United States'', N''country_name_us'', N''USA'', N''US'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'AudienceId', N'CreatedBy', N'CreatedTimestamp', N'DeactivatedBy', N'DeactivatedReason', N'DeactivatedTimestamp', N'LanguageId', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'NameTrxCode', N'ThreeLetterCode', N'TwoLetterCode') AND [object_id] = OBJECT_ID(N'[config].[Countries]'))
        SET IDENTITY_INSERT [config].[Countries] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'CreatedTimestamp', N'DeactivatedBy', N'DeactivatedReason', N'DeactivatedTimestamp', N'IconName', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'NameTrxCode', N'ShortCode', N'UnicodeIcon') AND [object_id] = OBJECT_ID(N'[config].[Feelings]'))
        SET IDENTITY_INSERT [config].[Feelings] ON;
    EXEC(N'INSERT INTO [config].[Feelings] ([Id], [CreatedBy], [CreatedTimestamp], [DeactivatedBy], [DeactivatedReason], [DeactivatedTimestamp], [IconName], [LastModifiedBy], [LastModifiedTimestamp], [Name], [NameTrxCode], [ShortCode], [UnicodeIcon])
    VALUES (''001e0dce-1e11-4e38-b3bd-1afc5a9b0faa'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''sarcastic'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Sarcastic'', N''feeling_name_sarcastic'', N'''', N''''),
    (''002c01e1-7c76-4a54-8910-b208fa07d402'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''dumb'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Dumb'', N''feeling_name_dumb'', N'''', N''''),
    (''008bc9e8-1f38-4151-b313-068050229801'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''hopeless'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Hopeless'', N''feeling_name_hopeless'', N'''', N''''),
    (''031c8b9f-62e9-4e62-94da-757b7f1cb83c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''bad'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Bad'', N''feeling_name_bad'', N'''', N''''),
    (''03ea9121-6ced-465c-82bc-32f778d15a0a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''amazing'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Amazing'', N''feeling_name_amazing'', N'''', N''''),
    (''07081859-8d1f-4fe3-9be1-daad4378caec'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''emotional'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Emotional'', N''feeling_name_emotional'', N'''', N''''),
    (''07108366-332a-478e-ab33-f5557b5973d1'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''smart'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Smart'', N''feeling_name_smart'', N'''', N''''),
    (''081a9e44-c9d0-462e-a79b-de551fce19ac'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''calm'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Calm'', N''feeling_name_calm'', N'''', N''''),
    (''0aaa0919-bfa1-4ec6-8b72-0a11291fe727'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''offended'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Offended'', N''feeling_name_offended'', N'''', N''''),
    (''0cf34476-900d-434c-a795-7c58b299b8bb'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''beautiful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Beautiful'', N''feeling_name_beautiful'', N'''', N''''),
    (''0e480745-1f04-4ce7-b54f-56a922ebea0a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''wanted'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Wanted'', N''feeling_name_wanted'', N'''', N''''),
    (''0ff0f00f-8eb6-4554-9943-e0f7faabb3e7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''fine'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Fine'', N''feeling_name_fine'', N'''', N''''),
    (''109d3ce3-4d12-4be4-bd05-c3ad6f234910'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''in love'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''In Love'', N''feeling_name_in_love'', N'''', N''🥰''),
    (''118e93ea-ac47-4c4c-b77d-7956dd70e8f3'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''terrible'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Terrible'', N''feeling_name_terrible'', N'''', N''''),
    (''11ed9fdb-da5c-4381-badb-279352fb0424'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''mischievous'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Mischievous'', N''feeling_name_mischievous'', N'''', N''''),
    (''146eedab-955e-4dd3-85b5-2f9eb1819aba'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''optimistic'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Optimistic'', N''feeling_name_optimistic'', N'''', N''''),
    (''17c3f560-aaca-4f20-8f1f-6627868f53aa'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''unloved'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Unloved'', N''feeling_name_unloved'', N'''', N''''),
    (''18c2b7c9-85d2-460d-9730-98b8f79f5f13'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''shy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Shy'', N''feeling_name_shy'', N'''', N''''),
    (''1a929d51-3f5d-4019-93c8-2fe15dad1f01'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''guilty'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Guilty'', N''feeling_name_guilty'', N'''', N''''),
    (''1bab9eaa-76da-44b2-88f1-c8ad771dfb94'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''stupid'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Stupid'', N''feeling_name_stupid'', N'''', N''''),
    (''1c098dea-1b9d-4f9b-ab7a-ad1e63690f40'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''welcome'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Welcome'', N''feeling_name_welcome'', N'''', N''''),
    (''1c4c7f89-c6fd-4b40-9f28-c05775bd8ea3'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''surprised'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Surprised'', N''feeling_name_surprised'', N'''', N''''),
    (''1d466b1e-e132-41a3-9942-cdb31ac38356'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''hung-over'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Hung-Over'', N''feeling_name_hung-over'', N'''', N''''),
    (''1f6d1b08-fe53-478d-ad59-8ef2d60d5b68'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''thoughtful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Thoughtful'', N''feeling_name_thoughtful'', N'''', N''🤔''),
    (''201d0440-42f1-42e6-b3b1-24ea5bcfa124'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''disappointed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Disappointed'', N''feeling_name_disappointed'', N'''', N''''),
    (''2426250c-cadb-4182-8044-15be7f13b2b9'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''nauseous'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Nauseous'', N''feeling_name_nauseous'', N'''', N''''),
    (''24fab593-3d37-4636-bb67-ff69eb9c45c9'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''safe'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Safe'', N''feeling_name_safe'', N'''', N''''),
    (''2777d3f7-9fed-4ab0-a19d-4a8a44f1890c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''lucky'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Lucky'', N''feeling_name_lucky'', N'''', N''''),
    (''2b405cd9-17fa-48e7-b56e-9876cd1c0c30'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''broke'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Broke'', N''feeling_name_broke'', N'''', N''''),
    (''2d226fcb-f63a-473c-83e2-ab35e83e7aed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''perplexed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Perplexed'', N''feeling_name_perplexed'', N'''', N''''),
    (''2d3d8ae6-676c-4aaa-be39-4c875834cbb4'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''angry'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Angry'', N''feeling_name_angry'', N'''', N''😠''),
    (''2e18c6f5-21b5-4a12-af98-2b96c61e88ba'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''free'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Free'', N''feeling_name_free'', N'''', N''''),
    (''34ad7181-01d4-43e1-8a11-b228a31f310d'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''motivated'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Motivated'', N''feeling_name_motivated'', N'''', N''''),
    (''35447768-d122-47c7-8890-4a11780897d3'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''human'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Human'', N''feeling_name_human'', N'''', N''''),
    (''36d40d63-584a-403c-a99a-7c96b3e32421'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''weird'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Weird'', N''feeling_name_weird'', N'''', N''''),
    (''37082b96-a841-4e54-87e1-50df86af0f6d'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''broken'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Broken'', N''feeling_name_broken'', N'''', N''''),
    (''3b6661c5-a6e3-41dc-993d-6fbbf48d5cf7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''proud'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Proud'', N''feeling_name_proud'', N'''', N''''),
    (''3cc834da-1ed2-4518-b08f-6d23b1869da4'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''yucky'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Yucky'', N''feeling_name_yucky'', N'''', N''''),
    (''3ccdc146-d69f-4012-ba1b-1e990931489b'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''silly'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Silly'', N''feeling_name_silly'', N'''', N''😜''),
    (''42dfd1e6-eb53-43b9-87e4-8b994c83a7b3'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''ashamed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Ashamed'', N''feeling_name_ashamed'', N'''', N''''),
    (''44cd536b-f906-4808-8f3c-30857b184fed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''cool'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Cool'', N''feeling_name_cool'', N'''', N''''),
    (''4516ea61-61bc-4b18-8b00-09e0a69525da'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''uncomfortable'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Uncomfortable'', N''feeling_name_uncomfortable'', N'''', N'''');
    INSERT INTO [config].[Feelings] ([Id], [CreatedBy], [CreatedTimestamp], [DeactivatedBy], [DeactivatedReason], [DeactivatedTimestamp], [IconName], [LastModifiedBy], [LastModifiedTimestamp], [Name], [NameTrxCode], [ShortCode], [UnicodeIcon])
    VALUES (''465d1c4d-8c66-4e51-9031-1842092b5a8f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''relaxed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Relaxed'', N''feeling_name_relaxed'', N'''', N''''),
    (''47eefbc6-7741-42eb-a8dd-ed42f72852f7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''fresh'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Fresh'', N''feeling_name_fresh'', N'''', N''''),
    (''4945f667-c287-4675-a01e-463e02567931'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''stressed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Stressed'', N''feeling_name_stressed'', N'''', N''''),
    (''4958cc4b-53bf-4b8b-ba40-a8e4577fc550'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''cold'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Cold'', N''feeling_name_cold'', N'''', N''''),
    (''495d011e-cf77-42db-b8f2-c410d80eddee'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''aggravated'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Aggravated'', N''feeling_name_aggravated'', N'''', N''''),
    (''4a1c9b60-1434-4d88-a6c8-e0eb3bc1e6d8'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''confused'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Confused'', N''feeling_name_confused'', N'''', N''😕''),
    (''4a8c46b4-fd0d-4183-a03c-05067ded1f86'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''thankful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Thankful'', N''feeling_name_thankful'', N'''', N''😄''),
    (''4aa8a7fa-c5f3-46ea-b30b-9a0005cc635d'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''alone'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Alone'', N''feeling_name_alone'', N'''', N''''),
    (''4aba110c-8ec0-4aef-8197-bb2da88beb80'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''lovely'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Lovely'', N''feeling_name_lovely'', N'''', N''🥰''),
    (''4bd09590-ec5d-42ad-a635-2d529afcaed7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''hopeful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Hopeful'', N''feeling_name_hopeful'', N'''', N''''),
    (''4be02498-d819-4cd8-b2b8-e5dbe9582f71'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''busy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Busy'', N''feeling_name_busy'', N'''', N''''),
    (''4c2bf692-42f9-4aa9-8dc8-0c485697ef52'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''generous'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Generous'', N''feeling_name_generous'', N'''', N''''),
    (''4dbc20e7-8169-4f31-8a3a-aeae3c6198a1'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''lazy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Lazy'', N''feeling_name_lazy'', N'''', N''''),
    (''4eae9899-a46e-4b36-94e9-8d1ae18600a7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''lonely'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Lonely'', N''feeling_name_lonely'', N'''', N''''),
    (''52112e22-fc1f-431c-b600-19f6fce86974'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''miserable'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Miserable'', N''feeling_name_miserable'', N'''', N''''),
    (''55ac4b0d-1bb8-4fe4-8df6-83991c626dfb'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''betrayed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Betrayed'', N''feeling_name_betrayed'', N'''', N''''),
    (''55d3d4b1-3920-462b-88e9-a245432d560f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''hyper'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Hyper'', N''feeling_name_hyper'', N'''', N''''),
    (''561d3f12-39a7-46bb-87b7-2ac7b53e3d35'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''privileged'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Privileged'', N''feeling_name_privileged'', N'''', N''''),
    (''567d49b2-3b22-48a2-9c23-a9b84c14df42'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''deep'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Deep'', N''feeling_name_deep'', N'''', N''''),
    (''585a2751-c596-4b1f-a3ee-2cd9708b9211'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''numb'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Numb'', N''feeling_name_numb'', N'''', N''''),
    (''587e57af-8ba6-4447-971a-9f53822dd7b4'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''determined'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Determined'', N''feeling_name_determined'', N'''', N''''),
    (''59535e31-7371-4e0d-9975-35907e75e9da'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''annoyed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Annoyed'', N''feeling_name_annoyed'', N'''', N''😒''),
    (''5a63e42c-72f5-4fff-96f3-1698675486bd'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''inspired'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Inspired'', N''feeling_name_inspired'', N'''', N''''),
    (''5a784144-f0d3-4b63-a536-f988db07ae6f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''small'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Small'', N''feeling_name_small'', N'''', N''''),
    (''5ca22e25-f5d2-4bdc-829d-148f1d140117'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''irritated'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Irritated'', N''feeling_name_irritated'', N'''', N''''),
    (''5d177056-94a9-46d0-b190-90569ccd97f4'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''qualified'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Qualified'', N''feeling_name_qualified'', N'''', N''''),
    (''5e8b54b2-456a-4065-bed8-f58bfb1eec7a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''sick'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Sick'', N''feeling_name_sick'', N'''', N''🤢''),
    (''604a3c8c-5206-4f49-93a9-77dd41819a6b'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''missing'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Missing'', N''feeling_name_missing'', N'''', N''''),
    (''60a59533-31fa-49f8-a12a-4643c2e44941'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''worse'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Worse'', N''feeling_name_worse'', N'''', N''''),
    (''60cab0a6-fa16-44df-9c4f-5aedbe9fd950'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''nervous'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Nervous'', N''feeling_name_nervous'', N'''', N''''),
    (''61d7ee2c-5d60-4293-ad93-a8a69254f363'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''puzzled'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Puzzled'', N''feeling_name_puzzled'', N'''', N''''),
    (''61ecce6f-6432-4583-82a4-e58a2ddee41e'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''crazy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Crazy'', N''feeling_name_crazy'', N'''', N''🤪''),
    (''62f630a9-76b2-4edf-b80a-453322ac21d3'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''threatened'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Threatened'', N''feeling_name_threatened'', N'''', N''''),
    (''63e8b3cc-f823-4f4f-9759-713151850277'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''funny'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Funny'', N''feeling_name_funny'', N'''', N''''),
    (''67955d20-752c-450b-8733-8720f1dde81e'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''honoured'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Honoured'', N''feeling_name_honoured'', N'''', N''''),
    (''688962b6-8297-4a17-aef8-3e42ebbe1e16'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''delighted'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Delighted'', N''feeling_name_delighted'', N'''', N''''),
    (''69089470-fadc-4d03-b05f-f8552b83d750'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''refreshed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Refreshed'', N''feeling_name_refreshed'', N'''', N''''),
    (''6b648de9-504a-4d1c-a3e6-e8efed360a26'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''tired'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Tired'', N''feeling_name_tired'', N'''', N''''),
    (''6daacd98-a4ae-474e-9676-b1927571b2e1'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''sleepy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Sleepy'', N''feeling_name_sleepy'', N'''', N''''),
    (''6fb59cb5-c455-4b59-9fd9-7132c775e01e'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''cute'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Cute'', N''feeling_name_cute'', N'''', N''''),
    (''74b91dbb-e19e-4cb5-b292-c184555ed4ed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''healthy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Healthy'', N''feeling_name_healthy'', N'''', N''😊''),
    (''767c72a1-0645-4be9-8d02-e4914cdaddda'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''blissful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Blissful'', N''feeling_name_blissful'', N'''', N''😊'');
    INSERT INTO [config].[Feelings] ([Id], [CreatedBy], [CreatedTimestamp], [DeactivatedBy], [DeactivatedReason], [DeactivatedTimestamp], [IconName], [LastModifiedBy], [LastModifiedTimestamp], [Name], [NameTrxCode], [ShortCode], [UnicodeIcon])
    VALUES (''76ee3c20-9fcb-4069-910a-eda0015388b7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''better'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Better'', N''feeling_name_better'', N'''', N''''),
    (''779e6529-862c-414e-964c-65c7fe07e897'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''invisible'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Invisible'', N''feeling_name_invisible'', N'''', N''🫥''),
    (''780e05e2-fa18-45e2-ba19-6b294005536d'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''lost'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Lost'', N''feeling_name_lost'', N'''', N''''),
    (''78511245-1bb2-45f6-addc-f68347773dd7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''old'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Old'', N''feeling_name_old'', N'''', N''''),
    (''7a1d0a59-bf51-425e-aeec-2e1891667363'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''appreciated'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Appreciated'', N''feeling_name_appreciated'', N'''', N''''),
    (''7a59598c-7bf4-4afa-9fa7-9ca01d4e63e3'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''helpless'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Helpless'', N''feeling_name_helpless'', N'''', N''''),
    (''7abe1d98-f9e4-427f-8c96-03360f3d278e'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''whole'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Whole'', N''feeling_name_whole'', N'''', N''''),
    (''7c5a2d78-21b3-4b6c-b2c4-6b477bb84ac6'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''ready'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Ready'', N''feeling_name_ready'', N'''', N''''),
    (''7ca553e0-fa6d-4ea6-88ec-35936652fa17'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''strong'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Strong'', N''feeling_name_strong'', N'''', N''''),
    (''7e7d9aec-84d0-4af5-853f-26e0ab4254c7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''pained'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Pained'', N''feeling_name_pained'', N'''', N''''),
    (''7f4bf02e-84f2-4641-a56d-db234b5723a8'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''embarrassed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Embarrassed'', N''feeling_name_embarrassed'', N'''', N''''),
    (''7fb854b6-9cb6-459e-b2f2-2ceec59740cd'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''blah'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Blah'', N''feeling_name_blah'', N'''', N''''),
    (''819601f3-ded0-4f95-869c-0da9ebb7a294'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''positive'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Positive'', N''feeling_name_positive'', N'''', N''''),
    (''81f27658-7f20-4644-b249-898b6c2660f2'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''happy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Happy'', N''feeling_name_happy'', N'''', N''😀''),
    (''83fa4719-adde-437c-afb5-a17566471fcf'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''drunk'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Drunk'', N''feeling_name_drunk'', N'''', N''''),
    (''84756744-adda-4475-80bb-1bfa3602bd65'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''fabulous'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Fabulous'', N''feeling_name_fabulous'', N'''', N''''),
    (''852cb32e-3f2d-4738-958d-4fd21d0d3b0e'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''trapped'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Trapped'', N''feeling_name_trapped'', N'''', N''''),
    (''8814f188-2d18-45c3-af53-10eb5f20fd1f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''nice'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Nice'', N''feeling_name_nice'', N'''', N''''),
    (''8a24dcb2-e724-45f9-884b-0a2436aec8c0'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''well'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Well'', N''feeling_name_well'', N'''', N''''),
    (''8a65b2bd-a332-4eba-aeff-42f5c408dbc2'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''unwanted'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Unwanted'', N''feeling_name_unwanted'', N'''', N''''),
    (''8beeb64e-e21a-4301-adef-5fc35a5b8f2f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''heartbroken'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Heartbroken'', N''feeling_name_heartbroken'', N'''', N''''),
    (''8cfbaf87-fd9a-4e8e-abe3-39bc41e47f5b'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''naked'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Naked'', N''feeling_name_naked'', N'''', N''''),
    (''8d492939-d824-4d68-b1b6-17e06b0e53f3'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''overwhelmed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Overwhelmed'', N''feeling_name_overwhelmed'', N'''', N''''),
    (''8efac35f-0ffe-499b-be26-fe4cbef6b535'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''impatient'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Impatient'', N''feeling_name_impatient'', N'''', N''''),
    (''8fe82d95-c2bc-4867-9293-d4cda5f95683'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''different'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Different'', N''feeling_name_different'', N'''', N''''),
    (''90132a22-1398-4260-aa9d-0a230ee70346'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''grateful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Grateful'', N''feeling_name_grateful'', N'''', N''😄''),
    (''90706a92-6321-49de-b871-a0fd209d51f1'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''horrible'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Horrible'', N''feeling_name_horrible'', N'''', N''''),
    (''90e30eac-218d-4d7d-9828-19655c355c44'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''amazed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Amazed'', N''feeling_name_amazed'', N'''', N''''),
    (''92614582-8de3-4a79-b430-57b8cb667bcf'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''pretty'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Pretty'', N''feeling_name_pretty'', N'''', N''''),
    (''942b4c87-56d2-4039-b885-10cc1271bb54'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''excited'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Excited'', N''feeling_name_excited'', N'''', N''🤩''),
    (''95e4281b-e2ac-4b57-af5c-10b1624f263c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''fantastic'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Fantastic'', N''feeling_name_fantastic'', N'''', N''''),
    (''9b8b604c-2752-4670-bd2e-b1b6a884e233'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''joyful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Joyful'', N''feeling_name_joyful'', N'''', N''''),
    (''9ef38a0b-7eec-4796-a601-74bb0e72fa0e'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''glad'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Glad'', N''feeling_name_glad'', N'''', N''''),
    (''9facef77-7089-459c-b2a6-1b6917b82d1d'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''important'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Important'', N''feeling_name_important'', N'''', N''''),
    (''9fff6311-8227-4f60-97ba-5766555ca1a3'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''confident'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Confident'', N''feeling_name_confident'', N'''', N''😏''),
    (''a0dab67b-96da-449a-a8b4-e1bde86a0b09'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''peaceful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Peaceful'', N''feeling_name_peaceful'', N'''', N''''),
    (''a57f0ba7-e11d-414b-b8d7-25cfffe28466'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''anxious'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Anxious'', N''feeling_name_anxious'', N'''', N''''),
    (''a6c3b267-9c62-429b-9229-e1bc5365a36d'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''blue'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Blue'', N''feeling_name_blue'', N'''', N''''),
    (''a85697ca-5359-4ded-bd2a-584e63f0b477'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''unimportant'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Unimportant'', N''feeling_name_unimportant'', N'''', N''''),
    (''a8b021a7-449f-4af5-896f-a5dd49d5cc5c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''useless'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Useless'', N''feeling_name_useless'', N'''', N''''),
    (''aa901412-ee19-4047-8509-e755fc4f91b5'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''rich'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Rich'', N''feeling_name_rich'', N'''', N''🤑''),
    (''ac489d9f-e708-41ea-86e5-611da85f69a6'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''super'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Super'', N''feeling_name_super'', N'''', N'''');
    INSERT INTO [config].[Feelings] ([Id], [CreatedBy], [CreatedTimestamp], [DeactivatedBy], [DeactivatedReason], [DeactivatedTimestamp], [IconName], [LastModifiedBy], [LastModifiedTimestamp], [Name], [NameTrxCode], [ShortCode], [UnicodeIcon])
    VALUES (''ad322d06-4f34-4faf-9cee-6ee8031e28ce'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''worthless'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Worthless'', N''feeling_name_worthless'', N'''', N''''),
    (''adc16370-b5b8-42e9-ab1b-3ef378d2ac1f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''challenged'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Challenged'', N''feeling_name_challenged'', N'''', N''''),
    (''af38d7f5-4d57-44d9-9feb-5bfe94079f68'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''accomplished'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Accomplished'', N''feeling_name_accomplished'', N'''', N''''),
    (''af402672-936b-47b0-86fc-283227d17bb0'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''amused'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Amused'', N''feeling_name_amused'', N'''', N''''),
    (''b061525a-3ad9-461b-8893-98f7b6526854'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''awesome'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Awesome'', N''feeling_name_awesome'', N'''', N''''),
    (''b426fa1e-d4ae-4c6c-996e-19bcdc52a07a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''weak'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Weak'', N''feeling_name_weak'', N'''', N''''),
    (''b494c04d-c757-4911-838d-e2ce70061170'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''depressed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Depressed'', N''feeling_name_depressed'', N'''', N''''),
    (''b6a8ee7a-bf40-4755-a6b5-f8298eef7539'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''scared'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Scared'', N''feeling_name_scared'', N'''', N''''),
    (''b6a9cc40-d1a8-4c48-8fe8-271b4f89bce2'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''comfortable'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Comfortable'', N''feeling_name_comfortable'', N'''', N''''),
    (''b7fe943b-564b-45c1-89c3-9cee3d515b70'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''thirsty'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Thirsty'', N''feeling_name_thirsty'', N'''', N''''),
    (''ba60f4ba-936d-4632-8668-037a4b3dc22c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''great'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Great'', N''feeling_name_great'', N'''', N''''),
    (''bb7c7372-1ab9-4732-9c56-8918e8d50b7e'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''cheated'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Cheated'', N''feeling_name_cheated'', N'''', N''''),
    (''bc5dc43e-dfae-4176-9da4-7a1441ce3948'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''exhausted'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Exhausted'', N''feeling_name_exhausted'', N'''', N''''),
    (''c336c2d2-3993-49a5-b9b5-1f4b32b09d8c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''blessed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Blessed'', N''feeling_name_blessed'', N'''', N''😇''),
    (''c4704f0b-d3cc-4d06-8ff0-ea1507b4b6a9'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''curious'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Curious'', N''feeling_name_curious'', N'''', N''''),
    (''c485e40a-3f95-4889-aa51-61a5ab8f9ec7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''down'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Down'', N''feeling_name_down'', N'''', N''''),
    (''c5457ef0-6e9b-4a35-b309-d7525ecd954a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''low'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Low'', N''feeling_name_low'', N'''', N''''),
    (''c76bbfb3-1db1-40d1-ba7c-2b1f96140206'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''meh'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Meh'', N''feeling_name_meh'', N'''', N''😐️''),
    (''c9e795c4-9141-4a27-bb10-63c2e9f11422'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''sorry'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Sorry'', N''feeling_name_sorry'', N'''', N''''),
    (''ca1062bc-7c7b-44bb-a49b-b8f961ae69f4'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''evil'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Evil'', N''feeling_name_evil'', N'''', N''''),
    (''ca67a29a-61b9-48c2-bbeb-205f0786d069'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''jolly'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Jolly'', N''feeling_name_jolly'', N'''', N''''),
    (''cc5362f4-d2f5-41a6-877c-59ec3643e79f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''jealous'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Jealous'', N''feeling_name_jealous'', N'''', N''''),
    (''cd65e0be-3231-4061-878a-5e60b7f29a95'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''professional'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Professional'', N''feeling_name_professional'', N'''', N''''),
    (''cd773328-26fa-4bf2-a843-1c8ec5ed75e5'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''mighty'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Mighty'', N''feeling_name_mighty'', N'''', N''''),
    (''cd90d680-7010-449b-b63f-b3c427ee2b51'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''furious'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Furious'', N''feeling_name_furious'', N'''', N''''),
    (''cde653e8-1c92-4755-8aed-9e772a2a6bdf'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''strange'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Strange'', N''feeling_name_strange'', N'''', N''''),
    (''ce5d5d48-cef1-48d6-8e6a-145f6cbdee9f'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''nostalgic'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Nostalgic'', N''feeling_name_nostalgic'', N'''', N''''),
    (''cfe60d5d-c0c8-45b5-b8a8-9723eb2ce458'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''awkward'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Awkward'', N''feeling_name_awkward'', N'''', N''''),
    (''d05e9885-5889-4c5a-bde1-2ef616918b82'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''festive'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Festive'', N''feeling_name_festive'', N'''', N''''),
    (''d18a9acc-9402-4454-a51a-8b354cc2b753'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''asleep'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Asleep'', N''feeling_name_asleep'', N'''', N''''),
    (''d47a1e2c-d66b-4a1b-adb9-7058d206c742'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''awful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Awful'', N''feeling_name_awful'', N'''', N''''),
    (''d7345ba1-9261-4361-b5da-5e1136c660c3'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''special'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Special'', N''feeling_name_special'', N'''', N''''),
    (''d752be3b-10f2-4e8d-9228-24f9fa494e6a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''wonderful'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Wonderful'', N''feeling_name_wonderful'', N'''', N''''),
    (''d7e83040-5b97-4201-857a-d636cc2d2075'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''worried'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Worried'', N''feeling_name_worried'', N'''', N''''),
    (''d8bdafb5-409e-41f9-a3d1-e35b0b18f2d4'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''goofy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Goofy'', N''feeling_name_goofy'', N'''', N''🤪''),
    (''d9016c13-0b52-431d-86df-1790a6c1293a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''crappy'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Crappy'', N''feeling_name_crappy'', N'''', N''''),
    (''d9775df7-f58f-49d9-a787-53985b7cee09'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''mad'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Mad'', N''feeling_name_mad'', N'''', N''''),
    (''d9acbdab-90b3-4a75-bc13-bfc09be8cfa1'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''drained'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Drained'', N''feeling_name_drained'', N'''', N''''),
    (''dab27278-3bf7-4069-bfd6-0934827140a5'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''dirty'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Dirty'', N''feeling_name_dirty'', N'''', N''''),
    (''db814413-4661-42aa-8ee6-27911db079d5'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''OK'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Ok'', N''feeling_name_OK'', N'''', N''👌''),
    (''db89dfd3-7a1c-4e1e-a7cf-da730825155b'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''concerned'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Concerned'', N''feeling_name_concerned'', N'''', N''''),
    (''dbed40f6-1272-468f-94c9-2622a0cb6395'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''ignored'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Ignored'', N''feeling_name_ignored'', N'''', N'''');
    INSERT INTO [config].[Feelings] ([Id], [CreatedBy], [CreatedTimestamp], [DeactivatedBy], [DeactivatedReason], [DeactivatedTimestamp], [IconName], [LastModifiedBy], [LastModifiedTimestamp], [Name], [NameTrxCode], [ShortCode], [UnicodeIcon])
    VALUES (''dc0b9342-d53b-4067-a5c8-08cbf2b95e29'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''hungry'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Hungry'', N''feeling_name_hungry'', N'''', N''''),
    (''ded3eaa0-da87-420d-8579-584293ac2804'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''normal'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Normal'', N''feeling_name_normal'', N'''', N''''),
    (''e0ba4bc4-6b7a-402c-ac0b-166db8af9625'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''rough'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Rough'', N''feeling_name_rough'', N'''', N''''),
    (''e146bc6f-8eae-437b-877a-2ab311f22292'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''upset'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Upset'', N''feeling_name_upset'', N'''', N''''),
    (''e4b61d04-6069-4c54-9f03-b1cf6dbe422e'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''insecure'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Insecure'', N''feeling_name_insecure'', N'''', N''''),
    (''e5850bf7-72a3-442e-8272-9f905d60c609'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''pumped'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Pumped'', N''feeling_name_pumped'', N'''', N''''),
    (''e6ddd1f9-c08c-4c4f-ab81-71214b1c2a47'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''sore'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Sore'', N''feeling_name_sore'', N'''', N''''),
    (''e705ccc2-eb3b-43f2-b0f7-1c5f5565b0eb'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''secure'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Secure'', N''feeling_name_secure'', N'''', N''''),
    (''e7b3149f-44a3-4737-a2fd-c987bed2c5b7'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''perfect'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Perfect'', N''feeling_name_perfect'', N'''', N''''),
    (''e90c6019-d563-4ab6-baa9-6543db76de54'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''light'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Light'', N''feeling_name_light'', N'''', N''''),
    (''e91875c5-435b-488b-9d76-bf04a3eebded'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''loved'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Loved'', N''feeling_name_loved'', N'''', N''🥰''),
    (''eb379dd3-bac0-4e7e-bf7d-a119882d3c41'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''stuck'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Stuck'', N''feeling_name_stuck'', N'''', N''''),
    (''eb9772c6-36f5-4642-9de1-5c987d860f55'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''satisfied'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Satisfied'', N''feeling_name_satisfied'', N'''', N''''),
    (''eb9da444-2bf0-4103-91c8-ca6813dc93da'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''frustrated'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Frustrated'', N''feeling_name_frustrated'', N'''', N''''),
    (''ed4eaf9d-184a-4ea9-9e7f-13eb6506eeea'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''alive'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Alive'', N''feeling_name_alive'', N'''', N''''),
    (''ef6e5830-e59e-4758-9e81-547acca52695'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''chill'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Chill'', N''feeling_name_chill'', N'''', N''''),
    (''f197a60d-55bb-47e1-a50b-91e4d58ff664'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''relieved'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Relieved'', N''feeling_name_relieved'', N'''', N''''),
    (''f1f83d04-d200-48ca-902f-8af1829bc775'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''energised'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Energised'', N''feeling_name_energised'', N'''', N''''),
    (''f3fc295f-f472-40f2-a437-e532968699be'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''fed'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Fed'', N''feeling_name_fed'', N'''', N''''),
    (''f4d7bc21-c086-4f35-b1ef-02202ac29456'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''regret'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Regret'', N''feeling_name_regret'', N'''', N''''),
    (''f5259dee-2c7f-4d85-a28d-d62536ce871c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''rested'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Rested'', N''feeling_name_rested'', N'''', N''''),
    (''f6692f5c-329b-4b42-8622-07b37149f5a2'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''hurt'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Hurt'', N''feeling_name_hurt'', N'''', N''''),
    (''f699eb29-fd6c-41c5-8055-0962995878cc'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''afraid'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Afraid'', N''feeling_name_afraid'', N'''', N''😨''),
    (''f6abff76-62cf-46f4-9de0-abd1177629d3'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''kind'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Kind'', N''feeling_name_kind'', N'''', N''''),
    (''f84711f0-d5bc-4fd8-a356-d27bc89992da'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''full'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Full'', N''feeling_name_full'', N'''', N''''),
    (''f925f045-9c83-4231-9540-0464445ba009'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''good'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Good'', N''feeling_name_good'', N'''', N''''),
    (''f9cae348-7f62-4e9d-b432-9421de2b25c4'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''bored'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Bored'', N''feeling_name_bored'', N'''', N''''),
    (''fb3835bb-52b2-463c-9a7f-2e4e4f492f1a'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''warm'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Warm'', N''feeling_name_warm'', N'''', N''''),
    (''fe71598d-16c1-4f02-8997-36de0d3e09e6'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''sad'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Sad'', N''feeling_name_sad'', N'''', N''🙁''),
    (''fefb4716-1ad1-4952-bd1b-07522102ab1c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', NULL, NULL, NULL, N''incomplete'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7083649+00:00'', N''Incomplete'', N''feeling_name_incomplete'', N'''', N'''')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'CreatedTimestamp', N'DeactivatedBy', N'DeactivatedReason', N'DeactivatedTimestamp', N'IconName', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'NameTrxCode', N'ShortCode', N'UnicodeIcon') AND [object_id] = OBJECT_ID(N'[config].[Feelings]'))
        SET IDENTITY_INSERT [config].[Feelings] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'CreatedBy', N'CreatedTimestamp', N'DeactivatedBy', N'DeactivatedReason', N'DeactivatedTimestamp', N'Direction', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'NameTrxCode', N'ThreeLetterCode', N'TwoLetterCode') AND [object_id] = OBJECT_ID(N'[config].[Languages]'))
        SET IDENTITY_INSERT [config].[Languages] ON;
    EXEC(N'INSERT INTO [config].[Languages] ([Id], [Code], [CreatedBy], [CreatedTimestamp], [DeactivatedBy], [DeactivatedReason], [DeactivatedTimestamp], [Direction], [LastModifiedBy], [LastModifiedTimestamp], [Name], [NameTrxCode], [ThreeLetterCode], [TwoLetterCode])
    VALUES (''013f3fbd-bacd-4d95-a3f7-586b12380ca8'', N''HE'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', NULL, NULL, NULL, 1, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', N''Hebrew'', N''language_name_he'', N''HEB'', N''HE''),
    (''46183d43-ab89-4b57-9940-9e8442a861a1'', N''HI'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', NULL, NULL, NULL, 0, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', N''Hindi'', N''language_name_hi'', N''HIN'', N''HI''),
    (''519fe5d2-3451-4bd4-98d6-3a3eddc617ff'', N''FR'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', NULL, NULL, NULL, 0, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', N''French'', N''language_name_fr'', N''FRA'', N''FR''),
    (''70d7f822-1bb5-4fe8-a7f9-194bbb11460d'', N''ES'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', NULL, NULL, NULL, 0, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', N''Spanish'', N''language_name_es'', N''ESP'', N''ES''),
    (''91924c6f-428d-4bee-8b52-8cc0422fe8e0'', N''ZH'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', NULL, NULL, NULL, 0, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', N''Chinese'', N''language_name_zh'', N''ZHO'', N''ZH''),
    (''9a66cc69-5465-4458-b133-7105bb516845'', N''EN'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', NULL, NULL, NULL, 0, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', N''English'', N''language_name_en'', N''ENG'', N''EN''),
    (''bb826a8d-935d-4ba7-9e05-17c3b1af70ec'', N''RU'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', NULL, NULL, NULL, 0, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', N''Russian'', N''language_name_ru'', N''RUS'', N''RU''),
    (''c9d508af-3512-4763-ae76-a92425960aa8'', N''AF'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', NULL, NULL, NULL, 0, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', N''Afrikaans'', N''language_name_af'', N''AFR'', N''AF''),
    (''d487137e-fcd8-43ef-b699-99abcddfc4cd'', N''ZU'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', NULL, NULL, NULL, 0, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7080388+00:00'', N''Zulu'', N''language_name_zu'', N''ZUL'', N''ZU'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'Code', N'CreatedBy', N'CreatedTimestamp', N'DeactivatedBy', N'DeactivatedReason', N'DeactivatedTimestamp', N'Direction', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'NameTrxCode', N'ThreeLetterCode', N'TwoLetterCode') AND [object_id] = OBJECT_ID(N'[config].[Languages]'))
        SET IDENTITY_INSERT [config].[Languages] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'CreatedTimestamp', N'DeactivatedBy', N'DeactivatedReason', N'DeactivatedTimestamp', N'IconName', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'NameTrxCode', N'UnicodeIcon') AND [object_id] = OBJECT_ID(N'[config].[Reactions]'))
        SET IDENTITY_INSERT [config].[Reactions] ON;
    EXEC(N'INSERT INTO [config].[Reactions] ([Id], [CreatedBy], [CreatedTimestamp], [DeactivatedBy], [DeactivatedReason], [DeactivatedTimestamp], [IconName], [LastModifiedBy], [LastModifiedTimestamp], [Name], [NameTrxCode], [UnicodeIcon])
    VALUES (''093feba5-b77d-4dcb-8cd9-4679514e6ee6'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7082636+00:00'', NULL, NULL, NULL, N''care'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7082636+00:00'', N''Care'', N''reaction_name_care'', N''1''),
    (''2f3b43d6-3a4f-4369-81a3-232e4baede4c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7082636+00:00'', NULL, NULL, NULL, N''love'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7082636+00:00'', N''Love'', N''reaction_name_love'', N''1''),
    (''334b31fb-0156-4d5f-bcd1-87b1efc62870'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7082636+00:00'', NULL, NULL, NULL, N''laugh'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7082636+00:00'', N''Haha'', N''reaction_name_laugh'', N''1''),
    (''4882ddfe-450f-4330-aa41-2a11cdc75a5c'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7082636+00:00'', NULL, NULL, NULL, N''angry'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7082636+00:00'', N''Angry'', N''reaction_name_angry'', N''1''),
    (''4ec50995-f0a3-4c86-887d-bbaa87963646'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7082636+00:00'', NULL, NULL, NULL, N''like'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7082636+00:00'', N''Like'', N''reaction_name_like'', N''1''),
    (''abf139f7-7d25-412b-b6dc-b2463cb74fda'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7082636+00:00'', NULL, NULL, NULL, N''dislike'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7082636+00:00'', N''Dislike'', N''reaction_name_dislike'', N''1''),
    (''c55ef250-a77f-4105-b829-1f236b1d4142'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7082636+00:00'', NULL, NULL, NULL, N''wow'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7082636+00:00'', N''Wow'', N''reaction_name_wow'', N''1''),
    (''ca1ace5a-50bc-40a9-8856-ceedfea43e72'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7082636+00:00'', NULL, NULL, NULL, N''sad'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7082636+00:00'', N''Sad'', N''reaction_name_sad'', N''1'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'CreatedTimestamp', N'DeactivatedBy', N'DeactivatedReason', N'DeactivatedTimestamp', N'IconName', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'NameTrxCode', N'UnicodeIcon') AND [object_id] = OBJECT_ID(N'[config].[Reactions]'))
        SET IDENTITY_INSERT [config].[Reactions] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'CreatedTimestamp', N'DataType', N'DefaultValue', N'HelpText', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'SettingCategoryId', N'ShortDescription', N'Value') AND [object_id] = OBJECT_ID(N'[config].[Settings]'))
        SET IDENTITY_INSERT [config].[Settings] ON;
    EXEC(N'INSERT INTO [config].[Settings] ([Id], [CreatedBy], [CreatedTimestamp], [DataType], [DefaultValue], [HelpText], [LastModifiedBy], [LastModifiedTimestamp], [Name], [SettingCategoryId], [ShortDescription], [Value])
    VALUES (''0a54a98b-52b9-4299-a822-8062e238f886'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7077711+00:00'', 21, N'''', NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7077711+00:00'', N''Default Skin Tone'', NULL, N''The secret used for generating the Idp Issuer Signing Key for the Astrana instance.'', N''69473DFCE4E2D15A343495F3612FBD2C69473DFCE4E2D15A343495F3612FBD2C''),
    (''2f75a306-f7d5-4bbc-9ae8-735fc05ca39d'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7077711+00:00'', 4, N''localhost'', NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7077711+00:00'', N''Host Name'', NULL, N''The address of the Astrana instance.'', NULL),
    (''47b7c31b-e01e-4991-9aa8-1783ef161b32'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7077711+00:00'', 4, N''AU'', NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7077711+00:00'', N''Regional Format'', NULL, N''Formats for dates, times and numbers.'', NULL),
    (''5f413c0a-cd3a-4496-8699-d46dec6ac713'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7077711+00:00'', 4, N'''', NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7077711+00:00'', N''Host Port Number'', NULL, N''The host port number of the Astrana instance.'', NULL),
    (''6e5c62af-781c-4e5b-9b27-f0ad7c6849e9'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7077711+00:00'', 4, N''AUS Eastern Standard Time'', NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7077711+00:00'', N''Time Zone'', NULL, N''The time zone of the Astrana instance user.'', NULL),
    (''76f86b75-e3be-436f-a527-88e76515e7bd'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7077711+00:00'', 1, N''0'', NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7077711+00:00'', N''Multi-factor Authentication'', NULL, N''Turn multi-factor authentication on/off.'', NULL),
    (''879237cd-4cd3-4b47-9750-bcbd43a692bd'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7077711+00:00'', 4, N''EN'', NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7077711+00:00'', N''Language Code'', NULL, N''The language code of the Astrana instance user.'', NULL),
    (''e601aadc-e92b-4957-b4bf-f963daaccce6'', ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7077711+00:00'', 4, N'''', NULL, ''0334ca45-b161-432c-ad23-ed7b7f0a74ab'', ''2023-07-16T06:36:28.7077711+00:00'', N''Idp Issuer Signing Key Secret'', NULL, N''The secret used for generating the Idp Issuer Signing Key for the Astrana instance.'', N''69473DFCE4E2D15A343495F3612FBD2C69473DFCE4E2D15A343495F3612FBD2C'')');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Id', N'CreatedBy', N'CreatedTimestamp', N'DataType', N'DefaultValue', N'HelpText', N'LastModifiedBy', N'LastModifiedTimestamp', N'Name', N'SettingCategoryId', N'ShortDescription', N'Value') AND [object_id] = OBJECT_ID(N'[config].[Settings]'))
        SET IDENTITY_INSERT [config].[Settings] OFF;
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_ApiAccessTokens_Token] ON [iam].[ApiAccessTokens] ([Token]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Audiences_Name] ON [config].[Audiences] ([Name]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_Audiences_UserProfileDetailId] ON [config].[Audiences] ([UserProfileDetailId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_Countries_AudienceId] ON [config].[Countries] ([AudienceId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_Countries_LanguageId] ON [config].[Countries] ([LanguageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Countries_NameTrxCode] ON [config].[Countries] ([NameTrxCode]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Countries_ThreeLetterCode] ON [config].[Countries] ([ThreeLetterCode]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Countries_TwoLetterCode] ON [config].[Countries] ([TwoLetterCode]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_ExternalContentSubscriptions_PreviewImageId] ON [content].[ExternalContentSubscriptions] ([PreviewImageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_FeatureToggles_FeatureName] ON [config].[FeatureToggles] ([FeatureName]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Feelings_NameTrxCode] ON [config].[Feelings] ([NameTrxCode]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_Images_AlbumId] ON [content].[Images] ([AlbumId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Languages_Code] ON [config].[Languages] ([Code]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Languages_NameTrxCode] ON [config].[Languages] ([NameTrxCode]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Languages_ThreeLetterCode] ON [config].[Languages] ([ThreeLetterCode]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Languages_TwoLetterCode] ON [config].[Languages] ([TwoLetterCode]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_Links_PreviewImageId] ON [content].[Links] ([PreviewImageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_MessengerUsernameRel_MessengerUsernameId] ON [user].[MessengerUsernameRel] ([MessengerUsernameId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_PeerConnectionRequestsReceived_Address] ON [dbo].[PeerConnectionRequestsReceived] ([Address]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_PeerConnectionRequestsSubmitted_Address] ON [dbo].[PeerConnectionRequestsSubmitted] ([Address]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_Peers_AudienceId] ON [dbo].[Peers] ([AudienceId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_Peers_AudienceId1] ON [dbo].[Peers] ([AudienceId1]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_PostAttachments_AlbumId] ON [content].[PostAttachments] ([AlbumId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_PostAttachments_AudioId] ON [content].[PostAttachments] ([AudioId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_PostAttachments_FeelingId] ON [content].[PostAttachments] ([FeelingId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_PostAttachments_ImageId] ON [content].[PostAttachments] ([ImageId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_PostAttachments_LinkId] ON [content].[PostAttachments] ([LinkId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_PostAttachments_LocationId] ON [content].[PostAttachments] ([LocationId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_PostAttachments_PostId] ON [content].[PostAttachments] ([PostId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_PostAttachments_VideoId] ON [content].[PostAttachments] ([VideoId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE UNIQUE INDEX [IX_Reactions_NameTrxCode] ON [config].[Reactions] ([NameTrxCode]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_Settings_SettingCategoryId] ON [config].[Settings] ([SettingCategoryId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_Tags_AudienceId] ON [content].[Tags] ([AudienceId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_UserAccountRoleRel_UserRoleId] ON [iam].[UserAccountRoleRel] ([UserRoleId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [IX_UserAccounts_EmailAddress] ON [iam].[UserAccounts] ([EmailAddress]) WHERE [EmailAddress] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [IX_UserAccounts_PhoneNumber] ON [iam].[UserAccounts] ([PhoneNumber]) WHERE [PhoneNumber] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    EXEC(N'CREATE UNIQUE INDEX [IX_UserAccounts_UserName] ON [iam].[UserAccounts] ([UserName]) WHERE [UserName] IS NOT NULL');
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_UserEmailAddressRel_EmailAddressId] ON [user].[UserEmailAddressRel] ([EmailAddressId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_UserPhoneNumberRel_PhoneNumberId] ON [user].[UserPhoneNumberRel] ([PhoneNumberId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_UserProfileDetails_UserProfileId] ON [user].[UserProfileDetails] ([UserProfileId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_UserProfiles_CoverPictureId] ON [user].[UserProfiles] ([CoverPictureId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_UserProfiles_ProfilePictureId] ON [user].[UserProfiles] ([ProfilePictureId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    CREATE INDEX [IX_UserProfiles_UserAccountId] ON [user].[UserProfiles] ([UserAccountId]);
END;
GO

IF NOT EXISTS(SELECT * FROM [maintenance].[MigrationsHistory] WHERE [MigrationId] = N'20230716063628_InitialSchema')
BEGIN
    INSERT INTO [maintenance].[MigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20230716063628_InitialSchema', N'7.0.10');
END;
GO

COMMIT;
GO

