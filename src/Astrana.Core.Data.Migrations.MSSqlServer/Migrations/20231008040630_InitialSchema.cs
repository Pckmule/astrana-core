using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Astrana.Core.Data.Migrations.MSSqlServer.Migrations
{
    /// <inheritdoc />
    public partial class InitialSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "iam");

            migrationBuilder.EnsureSchema(
                name: "config");

            migrationBuilder.EnsureSchema(
                name: "content");

            migrationBuilder.EnsureSchema(
                name: "contact");

            migrationBuilder.EnsureSchema(
                name: "user");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "ApiAccessTokens",
                schema: "iam",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Token = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiAccessTokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Audios",
                schema: "content",
                columns: table => new
                {
                    AudioId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Copyright = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audios", x => x.AudioId);
                });

            migrationBuilder.CreateTable(
                name: "ContentCollections",
                schema: "content",
                columns: table => new
                {
                    ContentCollectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Caption = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Copyright = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentCollections", x => x.ContentCollectionId);
                });

            migrationBuilder.CreateTable(
                name: "ContentSafetyRatings",
                schema: "content",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentSafetyRatings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EmailAddresses",
                schema: "contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EmailAddresses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "FeatureToggles",
                schema: "config",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FeatureName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    FeatureDescription = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    IsFeatureDisabled = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FeatureToggles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Feelings",
                schema: "config",
                columns: table => new
                {
                    FeelingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameTrxCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IconName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UnicodeIcon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    ShortCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feelings", x => x.FeelingId);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                schema: "content",
                columns: table => new
                {
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Copyright = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.ImageId);
                });

            migrationBuilder.CreateTable(
                name: "InstantMessengerUsernames",
                schema: "contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstantMessengerUsernames", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                schema: "config",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: false),
                    NameTrxCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    TwoLetterCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ThreeLetterCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Direction = table.Column<int>(type: "int", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                schema: "content",
                columns: table => new
                {
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Locations", x => x.LocationId);
                });

            migrationBuilder.CreateTable(
                name: "PeerConnectionRequestsReceived",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PeerPreviewAccessToken = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeerConnectionRequestsReceived", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PeerConnectionRequestsSubmitted",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PeerPreviewAccessToken = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PeerConnectionRequestsSubmitted", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                schema: "contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumbers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumberTypes",
                schema: "config",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Code = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhoneNumberTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                schema: "content",
                columns: table => new
                {
                    PostId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.PostId);
                });

            migrationBuilder.CreateTable(
                name: "Reactions",
                schema: "config",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    NameTrxCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IconName = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    UnicodeIcon = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Reactions", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SettingCategories",
                schema: "config",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                schema: "iam",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    NormalizedEmailAddress = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsEmailAddressConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneCountryCodeISO = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    IsPhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    IsTwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsLockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    FailedAccessCount = table.Column<short>(type: "smallint", nullable: false),
                    TimeZone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    LastLoginTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "iam",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                schema: "content",
                columns: table => new
                {
                    VideoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    Copyright = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.VideoId);
                });

            migrationBuilder.CreateTable(
                name: "ExternalContentSubscriptions",
                schema: "content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Locale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharSet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Robots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviewImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalContentSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExternalContentSubscriptions_Images_PreviewImageId",
                        column: x => x.PreviewImageId,
                        principalSchema: "content",
                        principalTable: "Images",
                        principalColumn: "ImageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                schema: "content",
                columns: table => new
                {
                    LinkId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Url = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Locale = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CharSet = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Robots = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SiteName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviewImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.LinkId);
                    table.ForeignKey(
                        name: "FK_Links_Images_PreviewImageId",
                        column: x => x.PreviewImageId,
                        principalSchema: "content",
                        principalTable: "Images",
                        principalColumn: "ImageId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                schema: "config",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    DataType = table.Column<int>(type: "int", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    HelpText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DefaultValue = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    SettingCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Settings_SettingCategories_SettingCategoryId",
                        column: x => x.SettingCategoryId,
                        principalSchema: "config",
                        principalTable: "SettingCategories",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "MessengerUsernameRel",
                schema: "user",
                columns: table => new
                {
                    UserAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MessengerUsernameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessengerUsernameRel", x => new { x.UserAccountId, x.MessengerUsernameId });
                    table.ForeignKey(
                        name: "FK_MessengerUsernameRel_InstantMessengerUsernames_MessengerUsernameId",
                        column: x => x.MessengerUsernameId,
                        principalSchema: "contact",
                        principalTable: "InstantMessengerUsernames",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MessengerUsernameRel_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalSchema: "iam",
                        principalTable: "UserAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserEmailAddressRel",
                schema: "user",
                columns: table => new
                {
                    UserAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    EmailAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEmailAddressRel", x => new { x.UserAccountId, x.EmailAddressId });
                    table.ForeignKey(
                        name: "FK_UserEmailAddressRel_EmailAddresses_EmailAddressId",
                        column: x => x.EmailAddressId,
                        principalSchema: "contact",
                        principalTable: "EmailAddresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEmailAddressRel_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalSchema: "iam",
                        principalTable: "UserAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserPhoneNumberRel",
                schema: "user",
                columns: table => new
                {
                    UserAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhoneNumberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserPhoneNumberRel", x => new { x.UserAccountId, x.PhoneNumberId });
                    table.ForeignKey(
                        name: "FK_UserPhoneNumberRel_PhoneNumbers_PhoneNumberId",
                        column: x => x.PhoneNumberId,
                        principalSchema: "contact",
                        principalTable: "PhoneNumbers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPhoneNumberRel_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalSchema: "iam",
                        principalTable: "UserAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                schema: "user",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MiddleNames = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Introduction = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ProfilePictureImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CoverPictureImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Images_CoverPictureImageId",
                        column: x => x.CoverPictureImageId,
                        principalSchema: "content",
                        principalTable: "Images",
                        principalColumn: "ImageId");
                    table.ForeignKey(
                        name: "FK_UserProfiles_Images_ProfilePictureImageId",
                        column: x => x.ProfilePictureImageId,
                        principalSchema: "content",
                        principalTable: "Images",
                        principalColumn: "ImageId");
                    table.ForeignKey(
                        name: "FK_UserProfiles_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalSchema: "iam",
                        principalTable: "UserAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserAccountRoleRel",
                schema: "iam",
                columns: table => new
                {
                    UserAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserRoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccountRoleRel", x => new { x.UserAccountId, x.UserRoleId });
                    table.ForeignKey(
                        name: "FK_UserAccountRoleRel_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalSchema: "iam",
                        principalTable: "UserAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAccountRoleRel_UserRoles_UserRoleId",
                        column: x => x.UserRoleId,
                        principalSchema: "iam",
                        principalTable: "UserRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Comments",
                schema: "content",
                columns: table => new
                {
                    CommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    TargetPostId = table.Column<long>(type: "bigint", nullable: true),
                    TargetCommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetVideoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetAudioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetGifId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetContentCollectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TargetLinkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    TargeCommentCommentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_Audios_TargetAudioId",
                        column: x => x.TargetAudioId,
                        principalSchema: "content",
                        principalTable: "Audios",
                        principalColumn: "AudioId");
                    table.ForeignKey(
                        name: "FK_Comments_Audios_TargetContentCollectionId",
                        column: x => x.TargetContentCollectionId,
                        principalSchema: "content",
                        principalTable: "Audios",
                        principalColumn: "AudioId");
                    table.ForeignKey(
                        name: "FK_Comments_Comments_TargeCommentCommentId",
                        column: x => x.TargeCommentCommentId,
                        principalSchema: "content",
                        principalTable: "Comments",
                        principalColumn: "CommentId");
                    table.ForeignKey(
                        name: "FK_Comments_Images_TargetGifId",
                        column: x => x.TargetGifId,
                        principalSchema: "content",
                        principalTable: "Images",
                        principalColumn: "ImageId");
                    table.ForeignKey(
                        name: "FK_Comments_Images_TargetImageId",
                        column: x => x.TargetImageId,
                        principalSchema: "content",
                        principalTable: "Images",
                        principalColumn: "ImageId");
                    table.ForeignKey(
                        name: "FK_Comments_Links_TargetLinkId",
                        column: x => x.TargetLinkId,
                        principalSchema: "content",
                        principalTable: "Links",
                        principalColumn: "LinkId");
                    table.ForeignKey(
                        name: "FK_Comments_Posts_TargetPostId",
                        column: x => x.TargetPostId,
                        principalSchema: "content",
                        principalTable: "Posts",
                        principalColumn: "PostId");
                    table.ForeignKey(
                        name: "FK_Comments_Videos_TargetVideoId",
                        column: x => x.TargetVideoId,
                        principalSchema: "content",
                        principalTable: "Videos",
                        principalColumn: "VideoId");
                });

            migrationBuilder.CreateTable(
                name: "ContentCollectionItems",
                schema: "content",
                columns: table => new
                {
                    ContentCollectionItemId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContentCollectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MediaType = table.Column<int>(type: "int", nullable: false),
                    LinkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VideoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AudioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GifId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentCollectionItems", x => x.ContentCollectionItemId);
                    table.ForeignKey(
                        name: "FK_ContentCollectionItems_Audios_AudioId",
                        column: x => x.AudioId,
                        principalSchema: "content",
                        principalTable: "Audios",
                        principalColumn: "AudioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContentCollectionItems_ContentCollections_ContentCollectionId",
                        column: x => x.ContentCollectionId,
                        principalSchema: "content",
                        principalTable: "ContentCollections",
                        principalColumn: "ContentCollectionId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ContentCollectionItems_Images_GifId",
                        column: x => x.GifId,
                        principalSchema: "content",
                        principalTable: "Images",
                        principalColumn: "ImageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContentCollectionItems_Images_ImageId",
                        column: x => x.ImageId,
                        principalSchema: "content",
                        principalTable: "Images",
                        principalColumn: "ImageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContentCollectionItems_Links_LinkId",
                        column: x => x.LinkId,
                        principalSchema: "content",
                        principalTable: "Links",
                        principalColumn: "LinkId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ContentCollectionItems_Videos_VideoId",
                        column: x => x.VideoId,
                        principalSchema: "content",
                        principalTable: "Videos",
                        principalColumn: "VideoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PostAttachments",
                schema: "content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Caption = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    Type = table.Column<int>(type: "int", nullable: false),
                    LinkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GifId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AudioId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VideoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContentCollectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FeelingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    PostId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostAttachments_Audios_AudioId",
                        column: x => x.AudioId,
                        principalSchema: "content",
                        principalTable: "Audios",
                        principalColumn: "AudioId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostAttachments_ContentCollections_ContentCollectionId",
                        column: x => x.ContentCollectionId,
                        principalSchema: "content",
                        principalTable: "ContentCollections",
                        principalColumn: "ContentCollectionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostAttachments_Feelings_FeelingId",
                        column: x => x.FeelingId,
                        principalSchema: "config",
                        principalTable: "Feelings",
                        principalColumn: "FeelingId");
                    table.ForeignKey(
                        name: "FK_PostAttachments_Images_GifId",
                        column: x => x.GifId,
                        principalSchema: "content",
                        principalTable: "Images",
                        principalColumn: "ImageId");
                    table.ForeignKey(
                        name: "FK_PostAttachments_Images_ImageId",
                        column: x => x.ImageId,
                        principalSchema: "content",
                        principalTable: "Images",
                        principalColumn: "ImageId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostAttachments_Links_LinkId",
                        column: x => x.LinkId,
                        principalSchema: "content",
                        principalTable: "Links",
                        principalColumn: "LinkId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostAttachments_Locations_LocationId",
                        column: x => x.LocationId,
                        principalSchema: "content",
                        principalTable: "Locations",
                        principalColumn: "LocationId");
                    table.ForeignKey(
                        name: "FK_PostAttachments_Posts_PostId",
                        column: x => x.PostId,
                        principalSchema: "content",
                        principalTable: "Posts",
                        principalColumn: "PostId");
                    table.ForeignKey(
                        name: "FK_PostAttachments_Videos_VideoId",
                        column: x => x.VideoId,
                        principalSchema: "content",
                        principalTable: "Videos",
                        principalColumn: "VideoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserProfileDetails",
                schema: "user",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Label = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IconName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DisplayOrder = table.Column<short>(type: "smallint", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfileDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfileDetails_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalSchema: "user",
                        principalTable: "UserProfiles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Audiences",
                schema: "config",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    MinimumAge = table.Column<short>(type: "smallint", nullable: true),
                    MaximumAge = table.Column<short>(type: "smallint", nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    UserProfileDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Audiences", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Audiences_UserProfileDetails_UserProfileDetailId",
                        column: x => x.UserProfileDetailId,
                        principalSchema: "user",
                        principalTable: "UserProfileDetails",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                schema: "config",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameTrxCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    TwoLetterCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ThreeLetterCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AudienceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_Audiences_AudienceId",
                        column: x => x.AudienceId,
                        principalSchema: "config",
                        principalTable: "Audiences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Countries_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "config",
                        principalTable: "Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Peers",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    PeerAccessToken = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsMuted = table.Column<bool>(type: "bit", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AudienceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AudienceId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Peers_Audiences_AudienceId",
                        column: x => x.AudienceId,
                        principalSchema: "config",
                        principalTable: "Audiences",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Peers_Audiences_AudienceId1",
                        column: x => x.AudienceId1,
                        principalSchema: "config",
                        principalTable: "Audiences",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                schema: "content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AudienceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Tags_Audiences_AudienceId",
                        column: x => x.AudienceId,
                        principalSchema: "config",
                        principalTable: "Audiences",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Countries",
                columns: new[] { "Id", "AudienceId", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "LanguageId", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode", "ThreeLetterCode", "TwoLetterCode" },
                values: new object[,]
                {
                    { 1L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), "Australia", "country_name_au", "AUS", "AU" },
                    { 2L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), "Brazil", "country_name_br", "BRA", "BR" },
                    { 3L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), "China", "country_name_cn", "CHN", "CN" },
                    { 4L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), "France", "country_name_fr", "FRA", "FR" },
                    { 5L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), "India", "country_name_in", "IND", "IN" },
                    { 6L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), "Israel", "country_name_il", "ILR", "IL" },
                    { 7L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), "Russia", "country_name_ru", "RUS", "RU" },
                    { 8L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), "South Africa", "country_name_za", "ZAF", "ZA" },
                    { 9L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), "Spain", "country_name_es", "ESP", "ES" },
                    { 10L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), "United Kingdom", "country_name_gb", "GBR", "GB" },
                    { 11L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(3836), new TimeSpan(0, 0, 0, 0, 0)), "United States", "country_name_us", "USA", "US" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Feelings",
                columns: new[] { "FeelingId", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "IconName", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode", "ShortCode", "UnicodeIcon" },
                values: new object[,]
                {
                    { new Guid("01603187-ec5c-450a-96b9-1ce4a2fc1f86"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "unwanted", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Unwanted", "feeling_name_unwanted", "", "" },
                    { new Guid("03dc9c4b-fae8-498b-b1b0-1590fef6f7ee"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "stressed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Stressed", "feeling_name_stressed", "", "" },
                    { new Guid("043af833-0934-4995-9035-e53b907191e9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "old", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Old", "feeling_name_old", "", "" },
                    { new Guid("05eaec67-aba8-4023-b1ef-2db454ae851e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "broken", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Broken", "feeling_name_broken", "", "" },
                    { new Guid("067d2c9b-e98e-43d0-8ddd-de27d1856e96"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mighty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Mighty", "feeling_name_mighty", "", "" },
                    { new Guid("06ac71e0-5da4-4cfc-9700-f6f548d6e4e7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "confident", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Confident", "feeling_name_confident", "", "😏" },
                    { new Guid("0712c675-67c5-4059-b325-7731da69f628"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "impatient", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Impatient", "feeling_name_impatient", "", "" },
                    { new Guid("074c0bd2-2aba-4688-abd9-3c1af64e07db"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "insecure", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Insecure", "feeling_name_insecure", "", "" },
                    { new Guid("08b4b4c8-238c-43db-9ec5-5883767c2999"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hungry", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Hungry", "feeling_name_hungry", "", "" },
                    { new Guid("0ba3ba65-1e0c-4382-8b01-148f66473dd8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "optimistic", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Optimistic", "feeling_name_optimistic", "", "" },
                    { new Guid("0cd1f55f-7f72-48b2-b8ba-296b8abce88b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "different", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Different", "feeling_name_different", "", "" },
                    { new Guid("0cf321dc-cf87-4f26-88f3-a9d26f08b45e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "amused", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Amused", "feeling_name_amused", "", "" },
                    { new Guid("0d6837d9-bef5-4301-913e-7ba9c68965cf"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hopeless", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Hopeless", "feeling_name_hopeless", "", "" },
                    { new Guid("0ddc35eb-b78b-4668-bdbd-9e6bc10646f9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "aggravated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Aggravated", "feeling_name_aggravated", "", "" },
                    { new Guid("0de407d6-4865-40bf-ad53-4f9dc3f00580"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "relieved", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Relieved", "feeling_name_relieved", "", "" },
                    { new Guid("0ff05d76-9a54-4ec4-913a-803772be4c20"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "wonderful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Wonderful", "feeling_name_wonderful", "", "" },
                    { new Guid("124f1279-68a5-4335-a538-b502837c8943"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "free", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Free", "feeling_name_free", "", "" },
                    { new Guid("1305d278-b255-4046-b1b3-5150b8c98151"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "satisfied", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Satisfied", "feeling_name_satisfied", "", "" },
                    { new Guid("13e32dcc-b60d-4ea2-87ea-e541168f3d2d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "shy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Shy", "feeling_name_shy", "", "" },
                    { new Guid("145a7f4e-e9af-45be-92f0-dbf0189d23e1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sleepy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Sleepy", "feeling_name_sleepy", "", "" },
                    { new Guid("14caa29a-a8f9-4219-81c5-f6a31f3e4e1f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "strange", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Strange", "feeling_name_strange", "", "" },
                    { new Guid("152f108d-cd37-4f9b-ac63-3a65d3cea016"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sick", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Sick", "feeling_name_sick", "", "🤢" },
                    { new Guid("18efa9a7-dedc-4eae-9d2a-a50eeb8ba279"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "comfortable", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Comfortable", "feeling_name_comfortable", "", "" },
                    { new Guid("1a93fc4b-cc3a-4700-85f6-4c47ad899341"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "dirty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Dirty", "feeling_name_dirty", "", "" },
                    { new Guid("1b4a2b76-145d-43db-a27e-01c550d32970"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "safe", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Safe", "feeling_name_safe", "", "" },
                    { new Guid("1b4fe485-cf8c-491b-be7f-f510083dd677"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "puzzled", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Puzzled", "feeling_name_puzzled", "", "" },
                    { new Guid("1cd61fa5-d54c-456c-9150-f52607ae3690"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "determined", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Determined", "feeling_name_determined", "", "" },
                    { new Guid("1cf4c841-283f-4ea5-a3ce-5a0dbec8ad12"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "tired", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Tired", "feeling_name_tired", "", "" },
                    { new Guid("1db05553-82cd-4b16-9766-339c27187e01"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "motivated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Motivated", "feeling_name_motivated", "", "" },
                    { new Guid("1e53b19e-622d-44b5-ba1b-be93951e3f70"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "angry", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Angry", "feeling_name_angry", "", "😠" },
                    { new Guid("1eb3bd74-fa27-4601-af9b-63a4e9da19aa"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lazy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Lazy", "feeling_name_lazy", "", "" },
                    { new Guid("1f32c2bd-926b-4d13-83af-e3cb46006071"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sorry", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Sorry", "feeling_name_sorry", "", "" },
                    { new Guid("1f6ebfb2-2b1d-4ae5-b375-9dbd6a47bcdf"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "weak", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Weak", "feeling_name_weak", "", "" },
                    { new Guid("2029f255-582d-4b03-a49d-99ae5c838d12"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "unloved", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Unloved", "feeling_name_unloved", "", "" },
                    { new Guid("211f7345-3c4c-4d55-a84a-72f23f1d4f6e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "deep", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Deep", "feeling_name_deep", "", "" },
                    { new Guid("21410885-5c62-4971-86b4-a05a9a35baf1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hopeful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Hopeful", "feeling_name_hopeful", "", "" },
                    { new Guid("21ac6ba3-26f7-4871-ad2c-438d2adaf607"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "whole", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Whole", "feeling_name_whole", "", "" },
                    { new Guid("2305a1fc-6bb5-4a39-96dc-34c84364ba2e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "super", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Super", "feeling_name_super", "", "" },
                    { new Guid("236a1a77-b806-497c-9d3c-8cd129a2ccf7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "guilty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Guilty", "feeling_name_guilty", "", "" },
                    { new Guid("24397290-74fc-4947-8da9-d40b575900a5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "perfect", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Perfect", "feeling_name_perfect", "", "" },
                    { new Guid("29532088-30b6-48b6-ad0f-3cd3b28dc727"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "awful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Awful", "feeling_name_awful", "", "" },
                    { new Guid("2a155f6a-2032-409f-92b0-7aa20ff690b2"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "goofy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Goofy", "feeling_name_goofy", "", "🤪" },
                    { new Guid("2ad79475-c31f-44e2-af54-6acbb42189e0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "jolly", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Jolly", "feeling_name_jolly", "", "" },
                    { new Guid("2bad282f-1466-4111-919a-ac7dfb8d337f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fresh", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Fresh", "feeling_name_fresh", "", "" },
                    { new Guid("2dd29189-d44b-4fed-b167-d8890b033a56"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bored", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Bored", "feeling_name_bored", "", "" },
                    { new Guid("2e1e707d-0819-4385-8e43-46a6be053c06"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fine", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Fine", "feeling_name_fine", "", "" },
                    { new Guid("2fb2c0f2-eb47-4d7e-b016-1768aea88b45"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "miserable", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Miserable", "feeling_name_miserable", "", "" },
                    { new Guid("2fbeb2a6-d760-4660-80bb-27da49902431"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "rich", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Rich", "feeling_name_rich", "", "🤑" },
                    { new Guid("33efc0e5-0bed-4dc2-9bfe-afa0be7785b9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "strong", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Strong", "feeling_name_strong", "", "" },
                    { new Guid("35f22209-d6bc-4cd4-b7bc-0097a8f386b4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "crazy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Crazy", "feeling_name_crazy", "", "🤪" },
                    { new Guid("36e9cba3-19e1-4d30-90b1-df6a6bdd9796"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "uncomfortable", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Uncomfortable", "feeling_name_uncomfortable", "", "" },
                    { new Guid("39513aca-8aab-4bd4-ac8c-2a91601aadb8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Fed", "feeling_name_fed", "", "" },
                    { new Guid("39938827-e9e7-42c8-a9e0-b1dadb3cefa9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "blissful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Blissful", "feeling_name_blissful", "", "😊" },
                    { new Guid("3c22049f-f1f5-4024-9683-24d5a96ce3f2"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "concerned", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Concerned", "feeling_name_concerned", "", "" },
                    { new Guid("3c493747-95e1-4e78-a6f4-59ddae6453dd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "meh", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Meh", "feeling_name_meh", "", "😐️" },
                    { new Guid("3e26f171-6b7e-4ed7-8ae0-59a3056bbed8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cool", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Cool", "feeling_name_cool", "", "" },
                    { new Guid("3e3e48ee-cb23-4703-8bf6-e721b9434d9d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "naked", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Naked", "feeling_name_naked", "", "" },
                    { new Guid("3e9bfebf-9a1b-4e1c-a015-a9b7749bf55f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nostalgic", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Nostalgic", "feeling_name_nostalgic", "", "" },
                    { new Guid("402986b7-7b8f-4f0b-bfe5-88a112ba5906"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ignored", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Ignored", "feeling_name_ignored", "", "" },
                    { new Guid("4057bc42-626d-4928-ace5-3586cc417377"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "amazed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Amazed", "feeling_name_amazed", "", "" },
                    { new Guid("405c02ad-e2fb-4404-9ce8-3536a486400c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "betrayed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Betrayed", "feeling_name_betrayed", "", "" },
                    { new Guid("44c52173-1c8b-4ff8-9dc1-249eda495e80"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "surprised", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Surprised", "feeling_name_surprised", "", "" },
                    { new Guid("4607f160-3509-486a-8202-1cef9babc9c2"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "delighted", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Delighted", "feeling_name_delighted", "", "" },
                    { new Guid("47b15106-5c98-4b2c-b628-9f8eb51832a4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "asleep", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Asleep", "feeling_name_asleep", "", "" },
                    { new Guid("48599062-63e3-473a-88f5-202fa98bbca5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "jealous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Jealous", "feeling_name_jealous", "", "" },
                    { new Guid("4865b3ae-151a-437d-aec6-c236bd7837db"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lonely", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Lonely", "feeling_name_lonely", "", "" },
                    { new Guid("48c63d39-dcc4-4dd4-b28d-1369035c47fd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "excited", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Excited", "feeling_name_excited", "", "🤩" },
                    { new Guid("4a18f89e-c9f9-4746-8247-b5406464a4c3"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sarcastic", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Sarcastic", "feeling_name_sarcastic", "", "" },
                    { new Guid("4db8d1b7-cd96-4815-9f65-cb8309ee2974"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "silly", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Silly", "feeling_name_silly", "", "😜" },
                    { new Guid("4e2c6399-4186-4357-a0f1-d3b344766e9c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "heartbroken", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Heartbroken", "feeling_name_heartbroken", "", "" },
                    { new Guid("4f66f5c8-54e4-4c30-bd3b-ff3d3e5fdc83"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "good", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Good", "feeling_name_good", "", "" },
                    { new Guid("541d1785-9b99-47a1-9f34-3a0db1b07e04"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "blessed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Blessed", "feeling_name_blessed", "", "😇" },
                    { new Guid("5507246c-06e6-4d41-bb0a-4add0b1a6f4f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "incomplete", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Incomplete", "feeling_name_incomplete", "", "" },
                    { new Guid("578ab0fe-8935-4009-9052-adb886a741fd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "positive", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Positive", "feeling_name_positive", "", "" },
                    { new Guid("589a2dfe-df9a-4582-b55e-7e2e883af3c4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "threatened", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Threatened", "feeling_name_threatened", "", "" },
                    { new Guid("589cd603-7f8e-43b2-a901-40a1e5af2b7d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "energised", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Energised", "feeling_name_energised", "", "" },
                    { new Guid("590949e5-397c-42a4-a39c-bd7b301ed51c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "blue", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Blue", "feeling_name_blue", "", "" },
                    { new Guid("59435ea0-ba5b-44f2-9495-e80cf3dd05a4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "blah", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Blah", "feeling_name_blah", "", "" },
                    { new Guid("5b3e0af7-9cbf-4e2b-94ca-21a8943769e0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "down", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Down", "feeling_name_down", "", "" },
                    { new Guid("5b976d63-b090-43e3-9241-bc7c52b2a45d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ready", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Ready", "feeling_name_ready", "", "" },
                    { new Guid("5c7b26a8-035f-42e1-bd3f-e5c80d9cdb3e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "annoyed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Annoyed", "feeling_name_annoyed", "", "😒" },
                    { new Guid("5ea28d6a-47f1-4a82-a168-3a249e620bda"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "refreshed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Refreshed", "feeling_name_refreshed", "", "" },
                    { new Guid("64efb0de-d6e8-4786-90b1-8069a92b55a1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "warm", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Warm", "feeling_name_warm", "", "" },
                    { new Guid("6649a7f2-f209-4d81-855b-7b799f985d33"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "missing", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Missing", "feeling_name_missing", "", "" },
                    { new Guid("677e227b-1a4f-4281-b744-830f8a8c3bec"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "thirsty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Thirsty", "feeling_name_thirsty", "", "" },
                    { new Guid("68368fc1-da27-4090-a0bc-39701cd444d7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "kind", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Kind", "feeling_name_kind", "", "" },
                    { new Guid("68d397fa-f782-4f5f-b2ad-99ec48db63db"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "joyful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Joyful", "feeling_name_joyful", "", "" },
                    { new Guid("6971aa0c-e2c3-4a93-ad3f-95cbc0c8ef50"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lovely", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Lovely", "feeling_name_lovely", "", "🥰" },
                    { new Guid("6d58d385-5a97-4a6c-81b6-e7b23269dc55"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "overwhelmed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Overwhelmed", "feeling_name_overwhelmed", "", "" },
                    { new Guid("6e75efcc-7a70-4c78-8eca-94724da74f52"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "scared", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Scared", "feeling_name_scared", "", "" },
                    { new Guid("6f4a0451-a067-4dcf-b642-0a3dade49a33"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "welcome", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Welcome", "feeling_name_welcome", "", "" },
                    { new Guid("6fbac255-b51e-4403-ae02-6a7b7df3f0ac"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "awkward", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Awkward", "feeling_name_awkward", "", "" },
                    { new Guid("70b86cd6-5c78-49f1-a9b2-3a893cc86845"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "peaceful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Peaceful", "feeling_name_peaceful", "", "" },
                    { new Guid("72cbca49-bbc8-4a74-8bb6-8b774449f14d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "important", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Important", "feeling_name_important", "", "" },
                    { new Guid("72d3ebee-5ee8-4f5d-b84e-e1ff60017fd5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "small", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Small", "feeling_name_small", "", "" },
                    { new Guid("73fca304-f02c-407a-b21b-bb747edcbb8d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Mad", "feeling_name_mad", "", "" },
                    { new Guid("7722d57a-2115-4966-90a1-3a4cf84ee4f6"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "normal", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Normal", "feeling_name_normal", "", "" },
                    { new Guid("78acbba9-3fb4-4968-b6b4-d4c75d93ffc5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "crappy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Crappy", "feeling_name_crappy", "", "" },
                    { new Guid("7965db24-c370-42b3-91c4-bdfcdd56937b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "OK", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Ok", "feeling_name_OK", "", "👌" },
                    { new Guid("796fb2ec-94e5-4e45-bcdf-bed3e9ba4380"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "festive", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Festive", "feeling_name_festive", "", "" },
                    { new Guid("7a090833-24b5-4302-80d5-8dc684846ebf"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "relaxed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Relaxed", "feeling_name_relaxed", "", "" },
                    { new Guid("7a189d3c-9b88-4c64-9145-7f38fba44e92"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Sad", "feeling_name_sad", "", "🙁" },
                    { new Guid("7a1eb1da-7b0f-4b48-a6cb-4f6d4b209105"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "professional", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Professional", "feeling_name_professional", "", "" },
                    { new Guid("7b74a584-387e-46bb-a99a-63a71baf8879"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "stuck", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Stuck", "feeling_name_stuck", "", "" },
                    { new Guid("7b9de060-e550-40c7-ae15-23fb9cc86acb"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cold", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Cold", "feeling_name_cold", "", "" },
                    { new Guid("7bba8764-3dc3-4446-82a3-2318e5581922"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "happy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Happy", "feeling_name_happy", "", "😀" },
                    { new Guid("7c652c24-c22b-4b74-888e-ebf329887447"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "glad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Glad", "feeling_name_glad", "", "" },
                    { new Guid("7d057480-0743-497d-a80c-dbd87e3bbc25"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "better", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Better", "feeling_name_better", "", "" },
                    { new Guid("7d1f1c5d-e229-442b-b427-4494981d0566"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "smart", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Smart", "feeling_name_smart", "", "" },
                    { new Guid("7f18c641-fa8b-4458-b6f8-f0c11f69627d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "well", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Well", "feeling_name_well", "", "" },
                    { new Guid("8294b6fb-e1b0-42a2-b63d-19a8b2a5f8fe"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cute", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Cute", "feeling_name_cute", "", "" },
                    { new Guid("82c3ce92-a301-45ef-8152-d29f507a329b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "trapped", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Trapped", "feeling_name_trapped", "", "" },
                    { new Guid("832051b9-5004-40d3-b325-fc6d3f1fc2f8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "drunk", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Drunk", "feeling_name_drunk", "", "" },
                    { new Guid("857680e5-a9ff-4a4b-acdd-a6dc4c0c906d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "challenged", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Challenged", "feeling_name_challenged", "", "" },
                    { new Guid("872a9e68-1847-4881-9cf7-ea84414b1898"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nice", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Nice", "feeling_name_nice", "", "" },
                    { new Guid("89ae9b29-5170-4044-b004-698e889adfb8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "horrible", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Horrible", "feeling_name_horrible", "", "" },
                    { new Guid("8b3862d5-e081-428c-8efb-d1d4a9eb1aba"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "calm", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Calm", "feeling_name_calm", "", "" },
                    { new Guid("8c4778d1-051f-4d48-980d-9a0077e15752"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lost", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Lost", "feeling_name_lost", "", "" },
                    { new Guid("8ceca85d-e889-46b6-b927-ed8846a9de70"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "exhausted", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Exhausted", "feeling_name_exhausted", "", "" },
                    { new Guid("8f03f5e3-6579-4d2a-97f9-70e4c19a6878"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "yucky", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Yucky", "feeling_name_yucky", "", "" },
                    { new Guid("90d1318b-c36c-44f3-aad1-a0a07811df7f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "proud", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Proud", "feeling_name_proud", "", "" },
                    { new Guid("92333245-f001-4c36-8546-8843c8c70135"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "in love", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "In Love", "feeling_name_in_love", "", "🥰" },
                    { new Guid("941e3057-d199-40a8-9f66-b4a1c0c76961"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "invisible", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Invisible", "feeling_name_invisible", "", "🫥" },
                    { new Guid("95667c93-5210-4fb6-8590-b1d1963f0647"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "wanted", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Wanted", "feeling_name_wanted", "", "" },
                    { new Guid("959d2b3f-26e8-49a5-bf1a-10bb0aae2083"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "thankful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Thankful", "feeling_name_thankful", "", "😄" },
                    { new Guid("997e6cd1-86d0-4214-9a53-f745188362f9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "embarrassed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Embarrassed", "feeling_name_embarrassed", "", "" },
                    { new Guid("9b2be3c8-b5a6-4420-8de4-38a1779cff79"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "evil", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Evil", "feeling_name_evil", "", "" },
                    { new Guid("9c89b84c-a0ba-4b7a-9361-f60f83809a0c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "frustrated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Frustrated", "feeling_name_frustrated", "", "" },
                    { new Guid("9e3f15a9-7a4b-4184-8de2-837f5bf15abf"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "honoured", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Honoured", "feeling_name_honoured", "", "" },
                    { new Guid("a052ca37-fd6c-4a88-b7f1-06c7325e88d0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "terrible", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Terrible", "feeling_name_terrible", "", "" },
                    { new Guid("a0935845-0481-4ca8-879b-3c903a59d4c8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "loved", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Loved", "feeling_name_loved", "", "🥰" },
                    { new Guid("a1d59a85-aeff-4796-b7a4-a6450a33b83a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hyper", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Hyper", "feeling_name_hyper", "", "" },
                    { new Guid("a3cf1a2d-96ec-46ac-a93d-09d2c302a1dd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pumped", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Pumped", "feeling_name_pumped", "", "" },
                    { new Guid("a4c403ba-15dd-498c-a263-69055f19e863"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cheated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Cheated", "feeling_name_cheated", "", "" },
                    { new Guid("a8e03b38-4113-438a-a5e1-237587f761c4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "awesome", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Awesome", "feeling_name_awesome", "", "" },
                    { new Guid("aa941b7d-43da-4f7b-8012-8049c9848aa0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fantastic", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Fantastic", "feeling_name_fantastic", "", "" },
                    { new Guid("abee92c1-6996-448d-8d5a-d47af5715cd6"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "broke", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Broke", "feeling_name_broke", "", "" },
                    { new Guid("ae64e3ba-706f-4c43-b8d9-1883563f1e2b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "curious", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Curious", "feeling_name_curious", "", "" },
                    { new Guid("ae975e84-be62-45df-9519-2d714cc4b746"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "worthless", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Worthless", "feeling_name_worthless", "", "" },
                    { new Guid("af07d376-0e6f-4754-a3da-7340b5870397"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "alive", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Alive", "feeling_name_alive", "", "" },
                    { new Guid("b317cef0-7bce-48bb-ab33-adb789b259c0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "thoughtful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Thoughtful", "feeling_name_thoughtful", "", "🤔" },
                    { new Guid("b709ae99-0dd5-46ac-b6a1-4b443163bb43"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "offended", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Offended", "feeling_name_offended", "", "" },
                    { new Guid("b9ad62eb-d56c-4696-b5cb-feaf125f8e4d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "light", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Light", "feeling_name_light", "", "" },
                    { new Guid("bac799a0-1199-433f-969a-34659e201606"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "appreciated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Appreciated", "feeling_name_appreciated", "", "" },
                    { new Guid("baf49aaf-9cbc-42ff-8b21-79495295f636"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "beautiful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Beautiful", "feeling_name_beautiful", "", "" },
                    { new Guid("bd76d2ba-551f-4034-8bee-44c24411d132"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "full", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Full", "feeling_name_full", "", "" },
                    { new Guid("bed2ef91-0fca-4ef7-9323-6d0b7871043d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fabulous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Fabulous", "feeling_name_fabulous", "", "" },
                    { new Guid("bfc3c2e0-0c13-436d-8379-bf7d8299f964"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pretty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Pretty", "feeling_name_pretty", "", "" },
                    { new Guid("c3fcb34f-6df8-40c1-b629-8ad51d63743a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ashamed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Ashamed", "feeling_name_ashamed", "", "" },
                    { new Guid("c5ee0217-f7bd-45fb-8b9d-5d1819a82e22"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hurt", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Hurt", "feeling_name_hurt", "", "" },
                    { new Guid("c62f5b1a-4be0-4a93-8e29-73ec20876b2d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "privileged", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Privileged", "feeling_name_privileged", "", "" },
                    { new Guid("c7df61ac-0036-4672-ab9c-5a7f319d5e49"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "busy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Busy", "feeling_name_busy", "", "" },
                    { new Guid("c8a63864-4fd3-4848-840c-b49f97ea3024"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "drained", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Drained", "feeling_name_drained", "", "" },
                    { new Guid("c90284b0-9cba-447b-91d0-be0607fcb164"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pained", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Pained", "feeling_name_pained", "", "" },
                    { new Guid("cbcfed12-e9b7-45e3-817a-dc15fd007176"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "furious", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Furious", "feeling_name_furious", "", "" },
                    { new Guid("cfe44450-adc3-4af3-9aa8-5c254c2fdb88"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sore", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Sore", "feeling_name_sore", "", "" },
                    { new Guid("d488891b-12b3-4189-9b8f-d831afd063ff"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "helpless", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Helpless", "feeling_name_helpless", "", "" },
                    { new Guid("d4e45a5d-18be-4236-b517-61bbed738b3f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "chill", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Chill", "feeling_name_chill", "", "" },
                    { new Guid("d511a997-bc56-4d4e-ab3f-30d647268d6f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "rough", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Rough", "feeling_name_rough", "", "" },
                    { new Guid("d6184707-0dcf-4195-9ae9-72a3dce92389"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "human", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Human", "feeling_name_human", "", "" },
                    { new Guid("d645074c-dffe-48fb-aa37-c3a611c77f4b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "irritated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Irritated", "feeling_name_irritated", "", "" },
                    { new Guid("d8852ee1-774f-4740-a685-326d694f7ba8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "perplexed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Perplexed", "feeling_name_perplexed", "", "" },
                    { new Guid("d922162a-d1f9-4c59-8f07-06749004112e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "low", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Low", "feeling_name_low", "", "" },
                    { new Guid("d92cb004-887f-4186-8d0e-24d2c956c156"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nervous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Nervous", "feeling_name_nervous", "", "" },
                    { new Guid("d9b18d3b-99a8-4d94-ac1f-53166869f576"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "dumb", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Dumb", "feeling_name_dumb", "", "" },
                    { new Guid("da707751-954b-4be2-93ea-a7410ed2caed"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "grateful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Grateful", "feeling_name_grateful", "", "😄" },
                    { new Guid("dd0e77d6-e5e6-45c5-95b5-e66180401592"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "qualified", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Qualified", "feeling_name_qualified", "", "" },
                    { new Guid("dd193858-6c9d-442a-819e-785c69e9eaf9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lucky", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Lucky", "feeling_name_lucky", "", "" },
                    { new Guid("dda26b56-c85c-41d0-9264-3b605e92e14b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "rested", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Rested", "feeling_name_rested", "", "" },
                    { new Guid("de2972e4-f5e2-4ebc-8279-254c5a3fe5a6"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "healthy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Healthy", "feeling_name_healthy", "", "😊" },
                    { new Guid("de545dad-2dac-4cdb-8347-5c714a51ee7b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "amazing", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Amazing", "feeling_name_amazing", "", "" },
                    { new Guid("df8c8566-9fcf-4068-8618-8a516a7f3f67"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hung-over", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Hung-Over", "feeling_name_hung-over", "", "" },
                    { new Guid("e0c98f92-ff42-4581-ae43-5acfe3315744"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "funny", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Funny", "feeling_name_funny", "", "" },
                    { new Guid("e0d15329-48e2-4de1-b923-f8e739a1f790"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "depressed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Depressed", "feeling_name_depressed", "", "" },
                    { new Guid("e199c00c-83e3-4e37-a544-1ad5d1e90cb0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "alone", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Alone", "feeling_name_alone", "", "" },
                    { new Guid("e1c1084e-e989-476a-824f-cdd53ef208ce"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "upset", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Upset", "feeling_name_upset", "", "" },
                    { new Guid("e20f033d-a643-497d-8164-ad97a672e9ff"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "afraid", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Afraid", "feeling_name_afraid", "", "😨" },
                    { new Guid("e2421860-0207-41b7-8a62-2d2ee39c8042"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "anxious", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Anxious", "feeling_name_anxious", "", "" },
                    { new Guid("e3e82cff-9a87-4690-9c17-cff3ef888d32"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Bad", "feeling_name_bad", "", "" },
                    { new Guid("e44f69cc-80dc-4057-b60f-2d8597f33a75"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "emotional", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Emotional", "feeling_name_emotional", "", "" },
                    { new Guid("e6933824-4080-473c-bccb-5e5cb6a0c6b9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "useless", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Useless", "feeling_name_useless", "", "" },
                    { new Guid("e71f8cad-7194-4069-ab73-38a9cf858c5c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "worried", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Worried", "feeling_name_worried", "", "" },
                    { new Guid("e921b0a8-4188-415d-aa4f-96bb3daacaa4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "generous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Generous", "feeling_name_generous", "", "" },
                    { new Guid("e939b867-e72a-4e9a-a0c8-512e488c9f9b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "weird", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Weird", "feeling_name_weird", "", "" },
                    { new Guid("ea153439-3f9c-4eb0-9d43-11d824cf40eb"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "stupid", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Stupid", "feeling_name_stupid", "", "" },
                    { new Guid("eb7708f5-0ba4-43e8-9102-111fff100e1b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "regret", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Regret", "feeling_name_regret", "", "" },
                    { new Guid("f1768471-7fbc-43c3-b09c-192499541343"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "confused", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Confused", "feeling_name_confused", "", "😕" },
                    { new Guid("f1de0012-b70c-45df-b436-c19bcd0fa368"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "worse", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Worse", "feeling_name_worse", "", "" },
                    { new Guid("f252d7be-98b2-4843-b7dd-76473d25baab"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "special", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Special", "feeling_name_special", "", "" },
                    { new Guid("f3020764-d044-482c-b9ad-89138dee53c1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "numb", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Numb", "feeling_name_numb", "", "" },
                    { new Guid("f4342aec-aba2-413c-a22d-e7b0c198d486"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nauseous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Nauseous", "feeling_name_nauseous", "", "" },
                    { new Guid("f4b3b4a7-b441-4e2b-882f-fd67fd844f8e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "secure", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Secure", "feeling_name_secure", "", "" },
                    { new Guid("f80e554b-7398-4cee-97c7-151f66e82e53"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "disappointed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Disappointed", "feeling_name_disappointed", "", "" },
                    { new Guid("fa5578ab-fe0f-4d18-8cbf-8f3104dbb2c7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mischievous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Mischievous", "feeling_name_mischievous", "", "" },
                    { new Guid("fad8090a-0de8-44a6-9017-f5293fcb89f5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "unimportant", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Unimportant", "feeling_name_unimportant", "", "" },
                    { new Guid("fcaf302b-a1ed-4439-9e11-a2010ace1bba"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "accomplished", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Accomplished", "feeling_name_accomplished", "", "" },
                    { new Guid("ff4ab6a4-2e12-434f-bd31-c9aae0f0495d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "great", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Great", "feeling_name_great", "", "" },
                    { new Guid("ffcc670c-084e-4b95-bc53-81a6bd41137b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "inspired", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(7232), new TimeSpan(0, 0, 0, 0, 0)), "Inspired", "feeling_name_inspired", "", "" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Languages",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "Direction", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode", "ThreeLetterCode", "TwoLetterCode" },
                values: new object[,]
                {
                    { new Guid("0377fb65-8ab6-4070-9dcc-d7c326a2cd82"), "ZU", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), "Zulu", "language_name_zu", "ZUL", "ZU" },
                    { new Guid("044f8e8a-9132-4dc8-99f8-55546d50de37"), "ZH", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), "Chinese", "language_name_zh", "ZHO", "ZH" },
                    { new Guid("5a091b8c-4e1a-447e-903c-1d3994eb353e"), "HE", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 1, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), "Hebrew", "language_name_he", "HEB", "HE" },
                    { new Guid("5efb8347-66d0-418c-bb65-31127b2d01d5"), "HI", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), "Hindi", "language_name_hi", "HIN", "HI" },
                    { new Guid("7a1d5cdb-6789-4211-8f88-c3cc6ecf154c"), "EN", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), "English", "language_name_en", "ENG", "EN" },
                    { new Guid("883fe16a-169f-4ddd-a238-c6ab424743ab"), "RU", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), "Russian", "language_name_ru", "RUS", "RU" },
                    { new Guid("b9c4ad50-6076-4b68-a547-106548dc9ff7"), "ES", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), "Spanish", "language_name_es", "ESP", "ES" },
                    { new Guid("cc118c2e-56b5-420d-99b9-e31be6318951"), "AF", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), "Afrikaans", "language_name_af", "AFR", "AF" },
                    { new Guid("fef7216e-caac-41e7-8626-9026c174c50e"), "FR", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(1976), new TimeSpan(0, 0, 0, 0, 0)), "French", "language_name_fr", "FRA", "FR" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Reactions",
                columns: new[] { "Id", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "IconName", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode", "UnicodeIcon" },
                values: new object[,]
                {
                    { new Guid("4678ded6-0a22-4d21-9ecb-12889c910e03"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "wow", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), "Wow", "reaction_name_wow", "1" },
                    { new Guid("4cc7041f-b9d4-4593-8ccc-44a8adaf5270"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), "Sad", "reaction_name_sad", "1" },
                    { new Guid("6dcce034-bfd7-4872-95fa-47c74768dc2e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "dislike", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), "Dislike", "reaction_name_dislike", "1" },
                    { new Guid("70ac643f-4ed1-4516-8cd4-acd29d593ebd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "like", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), "Like", "reaction_name_like", "1" },
                    { new Guid("82037233-161d-4ff0-b2df-4240938bc179"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "love", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), "Love", "reaction_name_love", "1" },
                    { new Guid("aa293935-4a72-44f9-8716-d3360c4a45fd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "angry", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), "Angry", "reaction_name_angry", "1" },
                    { new Guid("ae1e44d0-10c1-4fee-bb75-0f16069aeb95"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "laugh", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), "Haha", "reaction_name_laugh", "1" },
                    { new Guid("ee378421-6005-4f2b-a909-8ca0471cd96f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "care", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 248, DateTimeKind.Unspecified).AddTicks(5561), new TimeSpan(0, 0, 0, 0, 0)), "Care", "reaction_name_care", "1" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Settings",
                columns: new[] { "Id", "CreatedBy", "CreatedTimestamp", "DataType", "DefaultValue", "HelpText", "LastModifiedBy", "LastModifiedTimestamp", "Name", "SettingCategoryId", "ShortDescription", "Value" },
                values: new object[,]
                {
                    { new Guid("067a784e-6aec-4d8d-b44c-71e4eadc90e5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 247, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), 21, "", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 247, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), "Default Skin Tone", null, "The secret used for generating the Idp Issuer Signing Key for the Astrana instance.", "69473DFCE4E2D15A343495F3612FBD2C69473DFCE4E2D15A343495F3612FBD2C" },
                    { new Guid("089afae1-e9fa-4fd7-a2db-13442aa7727f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 247, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), 1, "0", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 247, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), "Multi-factor Authentication", null, "Turn multi-factor authentication on/off.", null },
                    { new Guid("43852f40-5f7b-4701-904a-b5415f55aa0b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 247, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), 4, "AUS Eastern Standard Time", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 247, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), "Time Zone", null, "The time zone of the Astrana instance user.", null },
                    { new Guid("523e4780-8a65-47e8-af74-bf59265e0113"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 247, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), 4, "EN", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 247, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), "Language Code", null, "The language code of the Astrana instance user.", null },
                    { new Guid("61bf10c2-2b11-4b1c-969e-2274ff1d0b81"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 247, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), 4, "AU", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 247, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), "Regional Format", null, "Formats for dates, times and numbers.", null },
                    { new Guid("95b0d595-6bb6-4d7a-9f5f-7b704847104c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 247, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), 4, "", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 247, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), "Idp Issuer Signing Key Secret", null, "The secret used for generating the Idp Issuer Signing Key for the Astrana instance.", "69473DFCE4E2D15A343495F3612FBD2C69473DFCE4E2D15A343495F3612FBD2C" },
                    { new Guid("c51b9951-f193-4490-89f4-0d0769552e03"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 247, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), 4, "", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 247, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), "Host Port Number", null, "The host port number of the Astrana instance.", null },
                    { new Guid("eaf0cbf5-d1d7-4858-a4a3-648615b96b1b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 247, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), 4, "localhost", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 10, 8, 4, 6, 30, 247, DateTimeKind.Unspecified).AddTicks(8423), new TimeSpan(0, 0, 0, 0, 0)), "Host Name", null, "The address of the Astrana instance.", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApiAccessTokens_Token",
                schema: "iam",
                table: "ApiAccessTokens",
                column: "Token",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Audiences_Name",
                schema: "config",
                table: "Audiences",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Audiences_UserProfileDetailId",
                schema: "config",
                table: "Audiences",
                column: "UserProfileDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TargeCommentCommentId",
                schema: "content",
                table: "Comments",
                column: "TargeCommentCommentId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TargetAudioId",
                schema: "content",
                table: "Comments",
                column: "TargetAudioId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TargetContentCollectionId",
                schema: "content",
                table: "Comments",
                column: "TargetContentCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TargetGifId",
                schema: "content",
                table: "Comments",
                column: "TargetGifId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TargetImageId",
                schema: "content",
                table: "Comments",
                column: "TargetImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TargetLinkId",
                schema: "content",
                table: "Comments",
                column: "TargetLinkId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TargetPostId",
                schema: "content",
                table: "Comments",
                column: "TargetPostId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TargetVideoId",
                schema: "content",
                table: "Comments",
                column: "TargetVideoId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentCollectionItems_AudioId",
                schema: "content",
                table: "ContentCollectionItems",
                column: "AudioId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentCollectionItems_ContentCollectionId",
                schema: "content",
                table: "ContentCollectionItems",
                column: "ContentCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentCollectionItems_GifId",
                schema: "content",
                table: "ContentCollectionItems",
                column: "GifId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentCollectionItems_ImageId",
                schema: "content",
                table: "ContentCollectionItems",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentCollectionItems_LinkId",
                schema: "content",
                table: "ContentCollectionItems",
                column: "LinkId");

            migrationBuilder.CreateIndex(
                name: "IX_ContentCollectionItems_VideoId",
                schema: "content",
                table: "ContentCollectionItems",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_AudienceId",
                schema: "config",
                table: "Countries",
                column: "AudienceId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_LanguageId",
                schema: "config",
                table: "Countries",
                column: "LanguageId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_NameTrxCode",
                schema: "config",
                table: "Countries",
                column: "NameTrxCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_ThreeLetterCode",
                schema: "config",
                table: "Countries",
                column: "ThreeLetterCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_TwoLetterCode",
                schema: "config",
                table: "Countries",
                column: "TwoLetterCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ExternalContentSubscriptions_PreviewImageId",
                schema: "content",
                table: "ExternalContentSubscriptions",
                column: "PreviewImageId");

            migrationBuilder.CreateIndex(
                name: "IX_FeatureToggles_FeatureName",
                schema: "config",
                table: "FeatureToggles",
                column: "FeatureName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Feelings_NameTrxCode",
                schema: "config",
                table: "Feelings",
                column: "NameTrxCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_Code",
                schema: "config",
                table: "Languages",
                column: "Code",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_NameTrxCode",
                schema: "config",
                table: "Languages",
                column: "NameTrxCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_ThreeLetterCode",
                schema: "config",
                table: "Languages",
                column: "ThreeLetterCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Languages_TwoLetterCode",
                schema: "config",
                table: "Languages",
                column: "TwoLetterCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Links_PreviewImageId",
                schema: "content",
                table: "Links",
                column: "PreviewImageId");

            migrationBuilder.CreateIndex(
                name: "IX_MessengerUsernameRel_MessengerUsernameId",
                schema: "user",
                table: "MessengerUsernameRel",
                column: "MessengerUsernameId");

            migrationBuilder.CreateIndex(
                name: "IX_PeerConnectionRequestsReceived_Address",
                schema: "dbo",
                table: "PeerConnectionRequestsReceived",
                column: "Address",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PeerConnectionRequestsSubmitted_Address",
                schema: "dbo",
                table: "PeerConnectionRequestsSubmitted",
                column: "Address",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Peers_AudienceId",
                schema: "dbo",
                table: "Peers",
                column: "AudienceId");

            migrationBuilder.CreateIndex(
                name: "IX_Peers_AudienceId1",
                schema: "dbo",
                table: "Peers",
                column: "AudienceId1");

            migrationBuilder.CreateIndex(
                name: "IX_PostAttachments_AudioId",
                schema: "content",
                table: "PostAttachments",
                column: "AudioId");

            migrationBuilder.CreateIndex(
                name: "IX_PostAttachments_ContentCollectionId",
                schema: "content",
                table: "PostAttachments",
                column: "ContentCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_PostAttachments_FeelingId",
                schema: "content",
                table: "PostAttachments",
                column: "FeelingId");

            migrationBuilder.CreateIndex(
                name: "IX_PostAttachments_GifId",
                schema: "content",
                table: "PostAttachments",
                column: "GifId");

            migrationBuilder.CreateIndex(
                name: "IX_PostAttachments_ImageId",
                schema: "content",
                table: "PostAttachments",
                column: "ImageId");

            migrationBuilder.CreateIndex(
                name: "IX_PostAttachments_LinkId",
                schema: "content",
                table: "PostAttachments",
                column: "LinkId");

            migrationBuilder.CreateIndex(
                name: "IX_PostAttachments_LocationId",
                schema: "content",
                table: "PostAttachments",
                column: "LocationId");

            migrationBuilder.CreateIndex(
                name: "IX_PostAttachments_PostId",
                schema: "content",
                table: "PostAttachments",
                column: "PostId");

            migrationBuilder.CreateIndex(
                name: "IX_PostAttachments_VideoId",
                schema: "content",
                table: "PostAttachments",
                column: "VideoId");

            migrationBuilder.CreateIndex(
                name: "IX_Reactions_NameTrxCode",
                schema: "config",
                table: "Reactions",
                column: "NameTrxCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Settings_SettingCategoryId",
                schema: "config",
                table: "Settings",
                column: "SettingCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Tags_AudienceId",
                schema: "content",
                table: "Tags",
                column: "AudienceId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccountRoleRel_UserRoleId",
                schema: "iam",
                table: "UserAccountRoleRel",
                column: "UserRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_EmailAddress",
                schema: "iam",
                table: "UserAccounts",
                column: "EmailAddress",
                unique: true,
                filter: "[EmailAddress] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_PhoneNumber",
                schema: "iam",
                table: "UserAccounts",
                column: "PhoneNumber",
                unique: true,
                filter: "[PhoneNumber] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_UserName",
                schema: "iam",
                table: "UserAccounts",
                column: "UserName",
                unique: true,
                filter: "[UserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_UserEmailAddressRel_EmailAddressId",
                schema: "user",
                table: "UserEmailAddressRel",
                column: "EmailAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_UserPhoneNumberRel_PhoneNumberId",
                schema: "user",
                table: "UserPhoneNumberRel",
                column: "PhoneNumberId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfileDetails_UserProfileId",
                schema: "user",
                table: "UserProfileDetails",
                column: "UserProfileId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_CoverPictureImageId",
                schema: "user",
                table: "UserProfiles",
                column: "CoverPictureImageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_ProfilePictureImageId",
                schema: "user",
                table: "UserProfiles",
                column: "ProfilePictureImageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_UserAccountId",
                schema: "user",
                table: "UserProfiles",
                column: "UserAccountId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ApiAccessTokens",
                schema: "iam");

            migrationBuilder.DropTable(
                name: "Comments",
                schema: "content");

            migrationBuilder.DropTable(
                name: "ContentCollectionItems",
                schema: "content");

            migrationBuilder.DropTable(
                name: "ContentSafetyRatings",
                schema: "content");

            migrationBuilder.DropTable(
                name: "Countries",
                schema: "config");

            migrationBuilder.DropTable(
                name: "ExternalContentSubscriptions",
                schema: "content");

            migrationBuilder.DropTable(
                name: "FeatureToggles",
                schema: "config");

            migrationBuilder.DropTable(
                name: "MessengerUsernameRel",
                schema: "user");

            migrationBuilder.DropTable(
                name: "PeerConnectionRequestsReceived",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PeerConnectionRequestsSubmitted",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "Peers",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "PhoneNumberTypes",
                schema: "config");

            migrationBuilder.DropTable(
                name: "PostAttachments",
                schema: "content");

            migrationBuilder.DropTable(
                name: "Reactions",
                schema: "config");

            migrationBuilder.DropTable(
                name: "Settings",
                schema: "config");

            migrationBuilder.DropTable(
                name: "Tags",
                schema: "content");

            migrationBuilder.DropTable(
                name: "UserAccountRoleRel",
                schema: "iam");

            migrationBuilder.DropTable(
                name: "UserEmailAddressRel",
                schema: "user");

            migrationBuilder.DropTable(
                name: "UserPhoneNumberRel",
                schema: "user");

            migrationBuilder.DropTable(
                name: "Languages",
                schema: "config");

            migrationBuilder.DropTable(
                name: "InstantMessengerUsernames",
                schema: "contact");

            migrationBuilder.DropTable(
                name: "Audios",
                schema: "content");

            migrationBuilder.DropTable(
                name: "ContentCollections",
                schema: "content");

            migrationBuilder.DropTable(
                name: "Feelings",
                schema: "config");

            migrationBuilder.DropTable(
                name: "Links",
                schema: "content");

            migrationBuilder.DropTable(
                name: "Locations",
                schema: "content");

            migrationBuilder.DropTable(
                name: "Posts",
                schema: "content");

            migrationBuilder.DropTable(
                name: "Videos",
                schema: "content");

            migrationBuilder.DropTable(
                name: "SettingCategories",
                schema: "config");

            migrationBuilder.DropTable(
                name: "Audiences",
                schema: "config");

            migrationBuilder.DropTable(
                name: "UserRoles",
                schema: "iam");

            migrationBuilder.DropTable(
                name: "EmailAddresses",
                schema: "contact");

            migrationBuilder.DropTable(
                name: "PhoneNumbers",
                schema: "contact");

            migrationBuilder.DropTable(
                name: "UserProfileDetails",
                schema: "user");

            migrationBuilder.DropTable(
                name: "UserProfiles",
                schema: "user");

            migrationBuilder.DropTable(
                name: "Images",
                schema: "content");

            migrationBuilder.DropTable(
                name: "UserAccounts",
                schema: "iam");
        }
    }
}
