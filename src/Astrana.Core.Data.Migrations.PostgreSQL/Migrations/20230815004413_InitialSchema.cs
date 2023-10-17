using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Astrana.Core.Data.Migrations.PostgreSQL.Migrations
{
    /// <inheritdoc />
    public partial class InitialSchema : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "content");

            migrationBuilder.EnsureSchema(
                name: "iam");

            migrationBuilder.EnsureSchema(
                name: "config");

            migrationBuilder.EnsureSchema(
                name: "contact");

            migrationBuilder.EnsureSchema(
                name: "user");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "ContentCollections",
                schema: "content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Caption = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Copyright = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ContentCollections", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ApiAccessTokens",
                schema: "iam",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Token = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ApiAccessTokens", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ContentSafetyRatings",
                schema: "content",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Address = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FeatureName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    FeatureDescription = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    IsFeatureDisabled = table.Column<bool>(type: "boolean", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    NameTrxCode = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    IconName = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    UnicodeIcon = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    ShortCode = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feelings", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "InstantMessengerUsernames",
                schema: "contact",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Username = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: false),
                    NameTrxCode = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Code = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    TwoLetterCode = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    ThreeLetterCode = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    Direction = table.Column<int>(type: "integer", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PeerConnectionRequestsReceived",
                schema: "dbo",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Note = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    PeerPreviewAccessToken = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Note = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    PeerPreviewAccessToken = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    Status = table.Column<int>(type: "integer", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Address = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    Code = table.Column<string>(type: "character varying(20)", maxLength: 20, nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
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
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Text = table.Column<string>(type: "character varying(1000)", maxLength: 1000, nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Reactions",
                schema: "config",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    NameTrxCode = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    IconName = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    UnicodeIcon = table.Column<string>(type: "character varying(10)", maxLength: 10, nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    UserName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    EmailAddress = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    NormalizedEmailAddress = table.Column<string>(type: "text", nullable: true),
                    IsEmailAddressConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    PasswordHash = table.Column<string>(type: "text", nullable: true),
                    PasswordSalt = table.Column<string>(type: "text", nullable: true),
                    SecurityStamp = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true),
                    PhoneCountryCodeISO = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: true),
                    PhoneNumber = table.Column<string>(type: "character varying(25)", maxLength: 25, nullable: true),
                    IsPhoneNumberConfirmed = table.Column<bool>(type: "boolean", nullable: false),
                    IsTwoFactorEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    IsLockoutEnabled = table.Column<bool>(type: "boolean", nullable: false),
                    FailedAccessCount = table.Column<short>(type: "smallint", nullable: false),
                    TimeZone = table.Column<string>(type: "text", nullable: false),
                    LanguageCode = table.Column<string>(type: "character varying(5)", maxLength: 5, nullable: false),
                    CountryCode = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    LastLoginTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Name = table.Column<string>(type: "text", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "text", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "text", nullable: true)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Location = table.Column<string>(type: "text", nullable: false),
                    Caption = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    Copyright = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Videos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                schema: "content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Location = table.Column<string>(type: "character varying(2500)", maxLength: 2500, nullable: false),
                    Caption = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Copyright = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ContentCollectionId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_ContentCollections_ContentCollectionId",
                        column: x => x.ContentCollectionId,
                        principalSchema: "content",
                        principalTable: "ContentCollections",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                schema: "config",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(200)", maxLength: 200, nullable: false),
                    DataType = table.Column<int>(type: "integer", nullable: false),
                    ShortDescription = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    HelpText = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    DefaultValue = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Value = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    SettingCategoryId = table.Column<Guid>(type: "uuid", nullable: true)
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
                    UserAccountId = table.Column<Guid>(type: "uuid", nullable: false),
                    MessengerUsernameId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MessengerUsernameRel", x => new { x.UserAccountId, x.MessengerUsernameId });
                    table.ForeignKey(
                        name: "FK_MessengerUsernameRel_InstantMessengerUsernames_MessengerUse~",
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
                    UserAccountId = table.Column<Guid>(type: "uuid", nullable: false),
                    EmailAddressId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
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
                    UserAccountId = table.Column<Guid>(type: "uuid", nullable: false),
                    PhoneNumberId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
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
                name: "UserAccountRoleRel",
                schema: "iam",
                columns: table => new
                {
                    UserAccountId = table.Column<Guid>(type: "uuid", nullable: false),
                    UserRoleId = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
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
                name: "ExternalContentSubscriptions",
                schema: "content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Url = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Title = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Locale = table.Column<string>(type: "text", nullable: true),
                    CharSet = table.Column<string>(type: "text", nullable: true),
                    Robots = table.Column<string>(type: "text", nullable: true),
                    SiteName = table.Column<string>(type: "text", nullable: true),
                    PreviewImageId = table.Column<Guid>(type: "uuid", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ExternalContentSubscriptions", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ExternalContentSubscriptions_Images_PreviewImageId",
                        column: x => x.PreviewImageId,
                        principalSchema: "content",
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Links",
                schema: "content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Url = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Title = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    Description = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Locale = table.Column<string>(type: "text", nullable: true),
                    CharSet = table.Column<string>(type: "text", nullable: true),
                    Robots = table.Column<string>(type: "text", nullable: true),
                    SiteName = table.Column<string>(type: "text", nullable: true),
                    PreviewImageId = table.Column<Guid>(type: "uuid", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Links", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Links_Images_PreviewImageId",
                        column: x => x.PreviewImageId,
                        principalSchema: "content",
                        principalTable: "Images",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                schema: "user",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserAccountId = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    MiddleNames = table.Column<string>(type: "character varying(300)", maxLength: 300, nullable: true),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    DateOfBirth = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    Gender = table.Column<int>(type: "integer", nullable: false),
                    Introduction = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    ProfilePictureId = table.Column<Guid>(type: "uuid", nullable: true),
                    CoverPictureId = table.Column<Guid>(type: "uuid", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserProfiles_Images_CoverPictureId",
                        column: x => x.CoverPictureId,
                        principalSchema: "content",
                        principalTable: "Images",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserProfiles_Images_ProfilePictureId",
                        column: x => x.ProfilePictureId,
                        principalSchema: "content",
                        principalTable: "Images",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserProfiles_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalSchema: "iam",
                        principalTable: "UserAccounts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PostAttachments",
                schema: "content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Title = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    Caption = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: true),
                    Type = table.Column<int>(type: "integer", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LinkId = table.Column<Guid>(type: "uuid", nullable: true),
                    ImageId = table.Column<Guid>(type: "uuid", nullable: true),
                    AudioId = table.Column<Guid>(type: "uuid", nullable: true),
                    VideoId = table.Column<Guid>(type: "uuid", nullable: true),
                    ContentCollectionId = table.Column<Guid>(type: "uuid", nullable: true),
                    LocationId = table.Column<Guid>(type: "uuid", nullable: true),
                    FeelingId = table.Column<Guid>(type: "uuid", nullable: true),
                    PostId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PostAttachments", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PostAttachments_ContentCollections_ContentCollectionId",
                        column: x => x.ContentCollectionId,
                        principalSchema: "content",
                        principalTable: "ContentCollections",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PostAttachments_ContentCollections_LocationId",
                        column: x => x.LocationId,
                        principalSchema: "content",
                        principalTable: "ContentCollections",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PostAttachments_Feelings_FeelingId",
                        column: x => x.FeelingId,
                        principalSchema: "config",
                        principalTable: "Feelings",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PostAttachments_Links_AudioId",
                        column: x => x.AudioId,
                        principalSchema: "content",
                        principalTable: "Links",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PostAttachments_Links_ImageId",
                        column: x => x.ImageId,
                        principalSchema: "content",
                        principalTable: "Links",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PostAttachments_Links_LinkId",
                        column: x => x.LinkId,
                        principalSchema: "content",
                        principalTable: "Links",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PostAttachments_Links_VideoId",
                        column: x => x.VideoId,
                        principalSchema: "content",
                        principalTable: "Links",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PostAttachments_Posts_PostId",
                        column: x => x.PostId,
                        principalSchema: "content",
                        principalTable: "Posts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "UserProfileDetails",
                schema: "user",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    UserProfileId = table.Column<Guid>(type: "uuid", nullable: false),
                    Key = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Label = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: true),
                    Value = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    IconName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    DisplayOrder = table.Column<short>(type: "smallint", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Name = table.Column<string>(type: "character varying(30)", maxLength: 30, nullable: false),
                    Description = table.Column<string>(type: "character varying(250)", maxLength: 250, nullable: false),
                    MinimumAge = table.Column<short>(type: "smallint", nullable: true),
                    MaximumAge = table.Column<short>(type: "smallint", nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    UserProfileDetailId = table.Column<Guid>(type: "uuid", nullable: true)
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
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    NameTrxCode = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    TwoLetterCode = table.Column<string>(type: "character varying(2)", maxLength: 2, nullable: false),
                    ThreeLetterCode = table.Column<string>(type: "character varying(3)", maxLength: 3, nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    AudienceId = table.Column<Guid>(type: "uuid", nullable: true),
                    LanguageId = table.Column<Guid>(type: "uuid", nullable: true)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    FirstName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "character varying(100)", maxLength: 100, nullable: false),
                    Address = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: false),
                    Note = table.Column<string>(type: "character varying(500)", maxLength: 500, nullable: true),
                    PeerAccessToken = table.Column<string>(type: "character varying(2000)", maxLength: 2000, nullable: true),
                    IsMuted = table.Column<bool>(type: "boolean", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    AudienceId = table.Column<Guid>(type: "uuid", nullable: true),
                    AudienceId1 = table.Column<Guid>(type: "uuid", nullable: true)
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
                    Id = table.Column<Guid>(type: "uuid", nullable: false),
                    Text = table.Column<string>(type: "character varying(50)", maxLength: 50, nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "text", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uuid", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uuid", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "timestamp with time zone", nullable: false),
                    AudienceId = table.Column<Guid>(type: "uuid", nullable: true)
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
                    { 1L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), "Australia", "country_name_au", "AUS", "AU" },
                    { 2L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), "Brazil", "country_name_br", "BRA", "BR" },
                    { 3L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), "China", "country_name_cn", "CHN", "CN" },
                    { 4L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), "France", "country_name_fr", "FRA", "FR" },
                    { 5L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), "India", "country_name_in", "IND", "IN" },
                    { 6L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), "Israel", "country_name_il", "ILR", "IL" },
                    { 7L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), "Russia", "country_name_ru", "RUS", "RU" },
                    { 8L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), "South Africa", "country_name_za", "ZAF", "ZA" },
                    { 9L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), "Spain", "country_name_es", "ESP", "ES" },
                    { 10L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), "United Kingdom", "country_name_gb", "GBR", "GB" },
                    { 11L, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2189), new TimeSpan(0, 0, 0, 0, 0)), "United States", "country_name_us", "USA", "US" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Feelings",
                columns: new[] { "Id", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "IconName", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode", "ShortCode", "UnicodeIcon" },
                values: new object[,]
                {
                    { new Guid("01b0463e-e484-4341-920d-6c8e59054082"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "honoured", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Honoured", "feeling_name_honoured", "", "" },
                    { new Guid("0201059f-0961-4994-817f-c8ca73383942"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "perplexed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Perplexed", "feeling_name_perplexed", "", "" },
                    { new Guid("03937452-d33d-4884-94a7-52451095bf28"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "shy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Shy", "feeling_name_shy", "", "" },
                    { new Guid("03c9eb70-88a5-42d0-9b14-535ac8877759"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "betrayed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Betrayed", "feeling_name_betrayed", "", "" },
                    { new Guid("09f6e48c-ef89-4e68-b4cf-880f9266bfde"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "light", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Light", "feeling_name_light", "", "" },
                    { new Guid("0a2557d1-41fe-427f-b921-8f468ffc1bb0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "angry", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Angry", "feeling_name_angry", "", "😠" },
                    { new Guid("0a982d06-c5b5-485b-8d0e-bf612faa85ee"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Mad", "feeling_name_mad", "", "" },
                    { new Guid("0ed88db2-d546-4a09-9e42-6081fdf615fd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "OK", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Ok", "feeling_name_OK", "", "👌" },
                    { new Guid("0f407b75-2f6c-4ad3-ab38-7934af33d975"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "asleep", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Asleep", "feeling_name_asleep", "", "" },
                    { new Guid("107075f2-55d1-4681-9345-6daf86653906"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "thoughtful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Thoughtful", "feeling_name_thoughtful", "", "🤔" },
                    { new Guid("15907f94-9524-41e3-b97f-ee38f8ab0faa"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "annoyed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Annoyed", "feeling_name_annoyed", "", "😒" },
                    { new Guid("1685090a-fc14-44c0-80fd-f3a85e79032a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "embarrassed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Embarrassed", "feeling_name_embarrassed", "", "" },
                    { new Guid("1a6daf1b-f80e-4cea-85ff-f781e0e92268"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "wonderful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Wonderful", "feeling_name_wonderful", "", "" },
                    { new Guid("1d576a43-8c06-42c0-8eb5-8194551e8aee"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "missing", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Missing", "feeling_name_missing", "", "" },
                    { new Guid("1d7916c1-88a2-481c-8919-b7560d6ca464"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sarcastic", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Sarcastic", "feeling_name_sarcastic", "", "" },
                    { new Guid("1ebc19ab-9b1f-4d3c-9442-8dec12eabb44"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ready", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Ready", "feeling_name_ready", "", "" },
                    { new Guid("2225616e-3914-480f-a7ec-7d45126e59a6"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "better", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Better", "feeling_name_better", "", "" },
                    { new Guid("226fcc6b-27f0-4e27-8737-3d6ef18ade92"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "weird", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Weird", "feeling_name_weird", "", "" },
                    { new Guid("236edbd0-9058-4d45-9bab-b961f51d15ee"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "dumb", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Dumb", "feeling_name_dumb", "", "" },
                    { new Guid("24e9bc47-9854-4014-80ec-bc43427b2a61"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "awkward", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Awkward", "feeling_name_awkward", "", "" },
                    { new Guid("2518d02b-daa3-406f-af3a-521e4243f760"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "scared", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Scared", "feeling_name_scared", "", "" },
                    { new Guid("263c86d0-5f82-4e2b-a5da-e7e613680ecd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "worthless", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Worthless", "feeling_name_worthless", "", "" },
                    { new Guid("26c9e43f-3b06-4753-887a-225df2f5a677"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "strange", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Strange", "feeling_name_strange", "", "" },
                    { new Guid("28c3d73b-ef2c-43d5-a83b-5e9e404d6cf8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "broken", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Broken", "feeling_name_broken", "", "" },
                    { new Guid("29ba9385-c058-4bf8-9d4f-8d7046c3dbea"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "comfortable", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Comfortable", "feeling_name_comfortable", "", "" },
                    { new Guid("29c85d2a-0b79-4b39-8fdb-c5fda8b5fb0b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "safe", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Safe", "feeling_name_safe", "", "" },
                    { new Guid("29e04010-bfc4-4b30-9a72-2379395ed3ef"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "heartbroken", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Heartbroken", "feeling_name_heartbroken", "", "" },
                    { new Guid("2a6cae69-96d1-463e-90c0-f7780f4286bd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "weak", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Weak", "feeling_name_weak", "", "" },
                    { new Guid("2c95a7cc-937c-493b-954e-e8cd280407ec"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "down", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Down", "feeling_name_down", "", "" },
                    { new Guid("2eead6df-64dc-497a-8ab4-239a576beb5c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hurt", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Hurt", "feeling_name_hurt", "", "" },
                    { new Guid("300d7220-302d-487e-8ac8-2e451fbeb7ad"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "overwhelmed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Overwhelmed", "feeling_name_overwhelmed", "", "" },
                    { new Guid("31a09f34-cdad-4b47-8b0c-81f1c0179142"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "satisfied", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Satisfied", "feeling_name_satisfied", "", "" },
                    { new Guid("32b12946-0d5a-42e4-bc17-deedab9da25f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "broke", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Broke", "feeling_name_broke", "", "" },
                    { new Guid("337cbc92-bb1c-4896-aad0-6547c64c8363"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "upset", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Upset", "feeling_name_upset", "", "" },
                    { new Guid("37e50492-b9c1-4e19-8e8d-ef211348b532"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pained", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Pained", "feeling_name_pained", "", "" },
                    { new Guid("37e9710b-bf18-4909-8d0c-4afb81d634ff"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "loved", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Loved", "feeling_name_loved", "", "🥰" },
                    { new Guid("38bd1fd1-cd0d-4e8f-8e46-4fba7dc30194"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "worried", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Worried", "feeling_name_worried", "", "" },
                    { new Guid("3a1474e0-c73c-44ca-bf57-3fd67512524a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "refreshed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Refreshed", "feeling_name_refreshed", "", "" },
                    { new Guid("3a17f8e3-8bd8-4ead-8e80-c923e90186ef"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "insecure", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Insecure", "feeling_name_insecure", "", "" },
                    { new Guid("3a1c43ff-2324-47c0-8ff4-8c9931b13326"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fresh", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Fresh", "feeling_name_fresh", "", "" },
                    { new Guid("3bebc039-6c0a-4bfc-b65a-48129fd00d67"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "awesome", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Awesome", "feeling_name_awesome", "", "" },
                    { new Guid("3de69ccf-604b-47f9-b5be-7e15dbcc72e9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "jolly", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Jolly", "feeling_name_jolly", "", "" },
                    { new Guid("3fa25184-9767-49d3-9f1e-b20502e36941"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "awful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Awful", "feeling_name_awful", "", "" },
                    { new Guid("3fcbd2aa-a8f3-4a9d-aa0c-8c9af2987fe4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nauseous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Nauseous", "feeling_name_nauseous", "", "" },
                    { new Guid("4014d613-79c7-4f74-b19c-a4776784e35d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "depressed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Depressed", "feeling_name_depressed", "", "" },
                    { new Guid("4177bbf5-2fda-446e-9b6f-2bb7a01c58c2"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "perfect", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Perfect", "feeling_name_perfect", "", "" },
                    { new Guid("42919eec-c00b-4138-8795-e49198ac0fca"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "guilty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Guilty", "feeling_name_guilty", "", "" },
                    { new Guid("42d8061e-272b-46c0-b4ac-a75c31b9fdcd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "amused", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Amused", "feeling_name_amused", "", "" },
                    { new Guid("4310e059-94fa-4cf8-abb9-9b5ab34a56d7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "puzzled", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Puzzled", "feeling_name_puzzled", "", "" },
                    { new Guid("435516d8-f95a-41da-8f6a-7e7a885a71ef"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "naked", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Naked", "feeling_name_naked", "", "" },
                    { new Guid("4364c2ca-6526-45fc-8f97-25b01c6c2c3a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "offended", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Offended", "feeling_name_offended", "", "" },
                    { new Guid("44227c07-9c95-49f6-86ee-87df3dc76e59"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "human", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Human", "feeling_name_human", "", "" },
                    { new Guid("44e8054a-d3c3-4d48-987d-bb23ed3f0956"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "relaxed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Relaxed", "feeling_name_relaxed", "", "" },
                    { new Guid("45f18f5c-6eb7-413a-9743-9ff15a844909"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "unimportant", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Unimportant", "feeling_name_unimportant", "", "" },
                    { new Guid("46205352-edba-464c-b742-3a0f67205c96"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pumped", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Pumped", "feeling_name_pumped", "", "" },
                    { new Guid("47671af8-0e68-4bae-b397-b05fae7e4f27"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "emotional", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Emotional", "feeling_name_emotional", "", "" },
                    { new Guid("49f30683-7989-457d-9380-8a0ad37d25a2"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "amazed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Amazed", "feeling_name_amazed", "", "" },
                    { new Guid("4adf8413-b3d5-4d20-985c-2750b869a683"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "stuck", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Stuck", "feeling_name_stuck", "", "" },
                    { new Guid("4baa1e0f-b50f-4472-bbac-e1061d844f78"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "crazy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Crazy", "feeling_name_crazy", "", "🤪" },
                    { new Guid("4d3e2d30-0c30-4e0a-a5ce-d39f4787f48e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "silly", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Silly", "feeling_name_silly", "", "😜" },
                    { new Guid("4e1e3f2f-abd6-4588-a585-2098caa5a8e7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nostalgic", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Nostalgic", "feeling_name_nostalgic", "", "" },
                    { new Guid("4eb9c61e-f938-4359-a42d-19af03f362b0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "anxious", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Anxious", "feeling_name_anxious", "", "" },
                    { new Guid("4fbc1597-d125-4bec-8061-f4b858a52317"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "appreciated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Appreciated", "feeling_name_appreciated", "", "" },
                    { new Guid("537090b3-98da-4010-a943-8fd89c0a6042"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "blue", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Blue", "feeling_name_blue", "", "" },
                    { new Guid("54cacb5e-c9f1-4064-8ac6-3709f5d554e3"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "threatened", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Threatened", "feeling_name_threatened", "", "" },
                    { new Guid("554344f1-0959-43f8-9b9a-6240459e50fa"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "impatient", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Impatient", "feeling_name_impatient", "", "" },
                    { new Guid("5668a944-e868-48bd-b384-c1d8e27780d3"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "horrible", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Horrible", "feeling_name_horrible", "", "" },
                    { new Guid("574ca539-203d-4c23-b9fd-7ff3ba413c1d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "privileged", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Privileged", "feeling_name_privileged", "", "" },
                    { new Guid("5876d9db-f769-4e47-9b4b-9979f7bb94b7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "yucky", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Yucky", "feeling_name_yucky", "", "" },
                    { new Guid("5c4ae83e-e08b-46c5-8ccb-54472cbc23f8"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "blissful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Blissful", "feeling_name_blissful", "", "😊" },
                    { new Guid("5da8d9ef-9727-4f35-a98f-ebcab9b3f73e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sorry", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Sorry", "feeling_name_sorry", "", "" },
                    { new Guid("5dd8e2ab-98b9-4a79-aa69-17a3d77f2f66"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "busy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Busy", "feeling_name_busy", "", "" },
                    { new Guid("5eca8820-c00d-420c-9cec-ded630397cc4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ignored", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Ignored", "feeling_name_ignored", "", "" },
                    { new Guid("5f39dbce-016c-467c-9e4d-3b4722918b0d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "secure", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Secure", "feeling_name_secure", "", "" },
                    { new Guid("600f8b14-cadb-4d7c-b603-82706847fff4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "disappointed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Disappointed", "feeling_name_disappointed", "", "" },
                    { new Guid("631e1d7a-d927-4fd4-8dcc-a15de92d541f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "grateful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Grateful", "feeling_name_grateful", "", "😄" },
                    { new Guid("661677df-f188-4819-8d48-0c1acdc4acd2"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "drunk", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Drunk", "feeling_name_drunk", "", "" },
                    { new Guid("67f4607d-b02a-493f-b84e-d48bc04e7258"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pretty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Pretty", "feeling_name_pretty", "", "" },
                    { new Guid("68006e61-f26f-4456-b6d9-97ca35735870"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "terrible", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Terrible", "feeling_name_terrible", "", "" },
                    { new Guid("68bb2f78-78a6-4a4f-9d86-cefe272eb643"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "warm", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Warm", "feeling_name_warm", "", "" },
                    { new Guid("6bf5ef1d-f21a-4e59-ad91-23b4a6e04b79"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "miserable", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Miserable", "feeling_name_miserable", "", "" },
                    { new Guid("6cfe6ce3-d14f-4aff-bea5-43ea30254368"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "afraid", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Afraid", "feeling_name_afraid", "", "😨" },
                    { new Guid("6d65ab00-b9b1-456d-973c-c536823ec585"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lonely", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Lonely", "feeling_name_lonely", "", "" },
                    { new Guid("6e5f0a49-116a-4332-9e6d-3cc00423012c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "surprised", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Surprised", "feeling_name_surprised", "", "" },
                    { new Guid("6ebd362f-2360-4c06-b046-d40229fda222"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "stressed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Stressed", "feeling_name_stressed", "", "" },
                    { new Guid("738c2a45-ef16-4374-9916-4b1395b4a71f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "goofy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Goofy", "feeling_name_goofy", "", "🤪" },
                    { new Guid("7593cff3-6537-4129-99f7-376557aed4fb"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "numb", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Numb", "feeling_name_numb", "", "" },
                    { new Guid("75d364e8-a8e1-4e65-8bb8-12743c275e92"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "frustrated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Frustrated", "feeling_name_frustrated", "", "" },
                    { new Guid("7724e362-2c74-4f39-8cc1-8b64fe1a21af"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "peaceful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Peaceful", "feeling_name_peaceful", "", "" },
                    { new Guid("779da9d7-ef22-41f8-a9c8-80b6fec2d1e1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "inspired", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Inspired", "feeling_name_inspired", "", "" },
                    { new Guid("783b4ec6-e2a9-4f85-b225-3e69a61e7eb9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "optimistic", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Optimistic", "feeling_name_optimistic", "", "" },
                    { new Guid("78af9d62-f14a-4542-9bdc-0c92b633c17e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "free", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Free", "feeling_name_free", "", "" },
                    { new Guid("793d4aea-d070-4af8-8e8e-a8a3e242a610"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Sad", "feeling_name_sad", "", "🙁" },
                    { new Guid("7950d225-5009-458a-af3c-5ef18e3ecdd3"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "invisible", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Invisible", "feeling_name_invisible", "", "🫥" },
                    { new Guid("7a5f6698-f5dc-411f-ade2-752a2791049c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "well", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Well", "feeling_name_well", "", "" },
                    { new Guid("7b343e11-b72b-467c-af79-07dd2c352d10"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hopeless", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Hopeless", "feeling_name_hopeless", "", "" },
                    { new Guid("7d19f3f4-26ff-463c-86cf-6f4f858f9f1b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "trapped", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Trapped", "feeling_name_trapped", "", "" },
                    { new Guid("7d2696f6-0fb7-4ed2-ba54-ad624d34e94b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Fed", "feeling_name_fed", "", "" },
                    { new Guid("7e7ce6b4-a4f9-46e7-861e-566ae175852b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lucky", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Lucky", "feeling_name_lucky", "", "" },
                    { new Guid("7f04334f-dd60-4543-acd0-cb333bfee15d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hyper", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Hyper", "feeling_name_hyper", "", "" },
                    { new Guid("7f5e0a46-b949-420b-b293-7ad66a01f09d"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nice", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Nice", "feeling_name_nice", "", "" },
                    { new Guid("84ed4410-3c49-4c87-9478-b02d9711d6a0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "funny", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Funny", "feeling_name_funny", "", "" },
                    { new Guid("87155ab1-5050-4457-915e-1ac072253fad"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "exhausted", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Exhausted", "feeling_name_exhausted", "", "" },
                    { new Guid("8a52191e-1b15-4b27-8ee7-8bc85395696e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "evil", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Evil", "feeling_name_evil", "", "" },
                    { new Guid("8a5b3fc1-924f-4c1b-9516-274fe5771ccf"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "alone", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Alone", "feeling_name_alone", "", "" },
                    { new Guid("8c3b8a50-c98b-40f2-a3b2-ea3c1586b643"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "rich", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Rich", "feeling_name_rich", "", "🤑" },
                    { new Guid("8f468680-46fd-4ab2-b327-37908cd9e1cc"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "unwanted", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Unwanted", "feeling_name_unwanted", "", "" },
                    { new Guid("8fc4739d-0a48-4c15-823c-6e6a3dce882a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "generous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Generous", "feeling_name_generous", "", "" },
                    { new Guid("904ce616-8257-4066-979b-601c00e5776c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "different", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Different", "feeling_name_different", "", "" },
                    { new Guid("910de73d-c48c-41f7-b501-475bdd5200f4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "furious", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Furious", "feeling_name_furious", "", "" },
                    { new Guid("9177c229-acda-4fbd-aae7-c183c75b2ae7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "curious", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Curious", "feeling_name_curious", "", "" },
                    { new Guid("9328ac5e-8b06-4eec-bfd5-c6a5b07a19e0"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "tired", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Tired", "feeling_name_tired", "", "" },
                    { new Guid("9443f8a7-8fc2-4c27-9450-465c0305cc5c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "unloved", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Unloved", "feeling_name_unloved", "", "" },
                    { new Guid("94a9178c-17ff-4918-bcc9-a2f66babb04b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "energised", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Energised", "feeling_name_energised", "", "" },
                    { new Guid("9569de03-58b9-4606-88ad-5be5fed507c6"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "chill", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Chill", "feeling_name_chill", "", "" },
                    { new Guid("957f8895-811c-4bf9-974f-48ca5099aea1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "whole", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Whole", "feeling_name_whole", "", "" },
                    { new Guid("958a80ee-dc1e-41cc-bbc0-4d2499208ff6"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "blah", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Blah", "feeling_name_blah", "", "" },
                    { new Guid("95af4096-a28d-4cbd-89d2-48eea179ea9c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fantastic", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Fantastic", "feeling_name_fantastic", "", "" },
                    { new Guid("9ab06a13-34df-4147-a134-be699d8f8c0e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "joyful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Joyful", "feeling_name_joyful", "", "" },
                    { new Guid("9b08d786-bb4b-42c0-8ea1-0b126fd380be"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "normal", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Normal", "feeling_name_normal", "", "" },
                    { new Guid("9eb8b51e-9b7b-4644-a135-3198cc42a982"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "old", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Old", "feeling_name_old", "", "" },
                    { new Guid("a11f9101-b393-431c-91f0-36ebbf694618"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fabulous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Fabulous", "feeling_name_fabulous", "", "" },
                    { new Guid("a125ebf5-7825-4d2d-b2f8-2cc7401c9c10"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "proud", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Proud", "feeling_name_proud", "", "" },
                    { new Guid("a1d7fc82-d329-4490-9edd-8513ef5074a2"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "professional", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Professional", "feeling_name_professional", "", "" },
                    { new Guid("a272980b-18c7-4f49-8172-04110cc9c8a9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "accomplished", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Accomplished", "feeling_name_accomplished", "", "" },
                    { new Guid("a2d34d5e-ea92-425b-be9f-f199879dacd4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "rested", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Rested", "feeling_name_rested", "", "" },
                    { new Guid("a341b064-c688-43fd-9066-b644d0a97f33"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "special", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Special", "feeling_name_special", "", "" },
                    { new Guid("a64875db-26b0-4751-92d0-69033476bd76"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "positive", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Positive", "feeling_name_positive", "", "" },
                    { new Guid("a7ed6e07-d301-4c04-812e-64ca92eb6ae3"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "motivated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Motivated", "feeling_name_motivated", "", "" },
                    { new Guid("a8fb388b-9fe2-442d-a2e0-debbf273bbad"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "dirty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Dirty", "feeling_name_dirty", "", "" },
                    { new Guid("aa59d54c-e042-46bc-81e0-76e38c6362ce"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bored", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Bored", "feeling_name_bored", "", "" },
                    { new Guid("aac49b66-1283-40cd-9639-cdefba10c80e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "full", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Full", "feeling_name_full", "", "" },
                    { new Guid("abefcf02-075a-4e90-91c7-3b35ffec87c4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lovely", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Lovely", "feeling_name_lovely", "", "🥰" },
                    { new Guid("acea64da-5603-4827-8e39-a5e5be564089"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "small", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Small", "feeling_name_small", "", "" },
                    { new Guid("ad2a84a3-b070-462e-b350-d0b63c0c62d7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mischievous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Mischievous", "feeling_name_mischievous", "", "" },
                    { new Guid("ae387fde-acfe-4ead-9a20-c88fa8660a14"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "challenged", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Challenged", "feeling_name_challenged", "", "" },
                    { new Guid("af911b5a-1ae4-4aff-8c38-6cda8e9cd0e9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "confident", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Confident", "feeling_name_confident", "", "😏" },
                    { new Guid("b033462c-f841-4c24-ba27-251d2d569937"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "calm", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Calm", "feeling_name_calm", "", "" },
                    { new Guid("b146aa9e-853b-4534-bfd5-45b90c36ae06"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "blessed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Blessed", "feeling_name_blessed", "", "😇" },
                    { new Guid("b1568ee9-afc7-4184-b285-605b3a6d6f15"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "in love", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "In Love", "feeling_name_in_love", "", "🥰" },
                    { new Guid("b2d39460-360d-4087-a62f-a96779c62b14"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cool", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Cool", "feeling_name_cool", "", "" },
                    { new Guid("b40e52d0-92f0-4f7c-b09d-a6c5dd3cc98a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "meh", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Meh", "feeling_name_meh", "", "😐️" },
                    { new Guid("b4280d5e-b8f6-49b8-bc42-bf1f5cf4e7fe"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "jealous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Jealous", "feeling_name_jealous", "", "" },
                    { new Guid("b43669c6-f0f0-44e1-87fe-b9899284b89c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lazy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Lazy", "feeling_name_lazy", "", "" },
                    { new Guid("b602bc09-edbd-4aad-8ed4-633ecfb598b7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "confused", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Confused", "feeling_name_confused", "", "😕" },
                    { new Guid("b61b494a-9048-46d4-9600-ff0999731e4a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sick", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Sick", "feeling_name_sick", "", "🤢" },
                    { new Guid("b6988350-0f3b-418d-a397-5250ba27e76c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "aggravated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Aggravated", "feeling_name_aggravated", "", "" },
                    { new Guid("bdae3279-8e9e-471b-adeb-a0f2d4600d7f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "thankful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Thankful", "feeling_name_thankful", "", "😄" },
                    { new Guid("bdbe8210-2d07-40ad-9d8b-8746b3d3db74"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "amazing", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Amazing", "feeling_name_amazing", "", "" },
                    { new Guid("bf7b9e3b-d2fb-41af-8a07-75044a5fe923"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "alive", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Alive", "feeling_name_alive", "", "" },
                    { new Guid("c013de16-af35-4a83-8a9d-005411df1c5c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "important", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Important", "feeling_name_important", "", "" },
                    { new Guid("c024dcf5-5930-44fd-bc32-bb8b6ee7ade9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mighty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Mighty", "feeling_name_mighty", "", "" },
                    { new Guid("c27be5dc-51ec-4999-b9a2-2cea92c7205c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "glad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Glad", "feeling_name_glad", "", "" },
                    { new Guid("c4dca8f7-7be7-4714-b38b-828a3c229db1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "welcome", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Welcome", "feeling_name_welcome", "", "" },
                    { new Guid("c526aa6c-3aa6-49ba-b81f-b2f0c157756e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "wanted", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Wanted", "feeling_name_wanted", "", "" },
                    { new Guid("cad2a339-897e-4ccb-985c-101dae3cd945"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "kind", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Kind", "feeling_name_kind", "", "" },
                    { new Guid("cbca7f9d-5539-48b3-9f31-22b1d0bac6df"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fine", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Fine", "feeling_name_fine", "", "" },
                    { new Guid("ce50bcc6-71e5-4c8e-89f0-0014a1ed3f9b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hopeful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Hopeful", "feeling_name_hopeful", "", "" },
                    { new Guid("ce77d342-7e35-45d4-860e-74d7e41e1c0b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "helpless", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Helpless", "feeling_name_helpless", "", "" },
                    { new Guid("d1676f6a-01c7-4b63-9b5b-a779ac43ea3a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "beautiful", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Beautiful", "feeling_name_beautiful", "", "" },
                    { new Guid("d1772517-e204-435c-b4ce-83da146c64c5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "thirsty", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Thirsty", "feeling_name_thirsty", "", "" },
                    { new Guid("d1d4168e-067c-483d-8372-6e5cce795df1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "stupid", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Stupid", "feeling_name_stupid", "", "" },
                    { new Guid("d251aa90-f44e-42f3-bace-5d3f66639614"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "drained", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Drained", "feeling_name_drained", "", "" },
                    { new Guid("d4111bd4-83fb-4903-9d1b-26ce05cf0dd9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "determined", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Determined", "feeling_name_determined", "", "" },
                    { new Guid("d47e7249-ea11-47ab-bdb1-b530882db058"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sleepy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Sleepy", "feeling_name_sleepy", "", "" },
                    { new Guid("d547bb8a-f918-4e09-8a9d-1160f980ae6a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lost", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Lost", "feeling_name_lost", "", "" },
                    { new Guid("d60407cc-eae6-4661-80ff-f1b758c763c6"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "delighted", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Delighted", "feeling_name_delighted", "", "" },
                    { new Guid("d8c7d7cf-f6d7-4674-9be7-b767d43e89e2"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "great", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Great", "feeling_name_great", "", "" },
                    { new Guid("dab20c58-dab0-499e-b06e-77ef322338e6"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cheated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Cheated", "feeling_name_cheated", "", "" },
                    { new Guid("dab2eb48-1575-4668-b545-96eda677bebe"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "relieved", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Relieved", "feeling_name_relieved", "", "" },
                    { new Guid("dc9c7163-2c72-45dd-abeb-1b105c82ddb2"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hung-over", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Hung-Over", "feeling_name_hung-over", "", "" },
                    { new Guid("df322fce-0537-4936-a44c-82c3f5dcebdb"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "worse", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Worse", "feeling_name_worse", "", "" },
                    { new Guid("dfc81755-f1d6-41ae-a8dd-2242afa76405"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "healthy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Healthy", "feeling_name_healthy", "", "😊" },
                    { new Guid("e00c1cb9-2973-4f5b-9174-fa39c0c7457f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "useless", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Useless", "feeling_name_useless", "", "" },
                    { new Guid("e08c0de5-636a-4889-8dc4-a2face6e1767"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ashamed", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Ashamed", "feeling_name_ashamed", "", "" },
                    { new Guid("e0931962-be57-4bf8-a16d-b1c8afadc73c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "happy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Happy", "feeling_name_happy", "", "😀" },
                    { new Guid("e1c3d88f-c836-434a-b71e-73a73a1cbb4c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "strong", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Strong", "feeling_name_strong", "", "" },
                    { new Guid("e1d459dd-f299-429d-a749-816c1dc62ea4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "super", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Super", "feeling_name_super", "", "" },
                    { new Guid("e3accb95-f0d7-4256-9d64-e8f26d1f67fa"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nervous", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Nervous", "feeling_name_nervous", "", "" },
                    { new Guid("e3d9de4a-dea2-4be5-99c6-577c82b2ecb5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cute", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Cute", "feeling_name_cute", "", "" },
                    { new Guid("e450eeed-6c6e-4159-b905-9a99ac0928dd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "smart", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Smart", "feeling_name_smart", "", "" },
                    { new Guid("e4bf7119-60b4-4b6c-ad04-dea1a30f4eec"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "festive", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Festive", "feeling_name_festive", "", "" },
                    { new Guid("e6a5b487-ea31-4426-a24a-127743d6c13c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "deep", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Deep", "feeling_name_deep", "", "" },
                    { new Guid("e6e1dcda-a39e-4761-aafc-9a01f1c0381f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sore", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Sore", "feeling_name_sore", "", "" },
                    { new Guid("e932f05f-9913-49bb-b634-5c82d55ab7d3"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "regret", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Regret", "feeling_name_regret", "", "" },
                    { new Guid("ea2b6494-ab25-4b95-89cf-e4be975b8798"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cold", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Cold", "feeling_name_cold", "", "" },
                    { new Guid("ead77ffe-9249-432e-8594-ad6ef523b5a3"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "incomplete", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Incomplete", "feeling_name_incomplete", "", "" },
                    { new Guid("ebfb55ad-be5d-45dc-b787-513d596c3ff6"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "qualified", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Qualified", "feeling_name_qualified", "", "" },
                    { new Guid("edebd05b-512a-4974-8dc5-e820fc8fe102"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "uncomfortable", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Uncomfortable", "feeling_name_uncomfortable", "", "" },
                    { new Guid("ee078fc6-c5c0-412d-86d6-743bfa3ab602"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "rough", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Rough", "feeling_name_rough", "", "" },
                    { new Guid("ef9f2355-7218-4d5c-9fb8-207d21638286"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "concerned", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Concerned", "feeling_name_concerned", "", "" },
                    { new Guid("f21ae468-2d4c-47a1-9fab-91bc092fd659"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hungry", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Hungry", "feeling_name_hungry", "", "" },
                    { new Guid("f24ac28d-47c7-4985-b7ff-d12c4d68ccca"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "irritated", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Irritated", "feeling_name_irritated", "", "" },
                    { new Guid("f5e881e6-a785-456e-a5f3-62c64013e00f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Bad", "feeling_name_bad", "", "" },
                    { new Guid("f689207e-31ca-4738-8155-a752443ec687"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "excited", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Excited", "feeling_name_excited", "", "🤩" },
                    { new Guid("f8f6c4a8-e3e1-4ba1-958e-f22d2195bfad"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "good", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Good", "feeling_name_good", "", "" },
                    { new Guid("fe31329d-b63c-4516-98f2-97fbff97a17f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "crappy", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Crappy", "feeling_name_crappy", "", "" },
                    { new Guid("febf3b76-4147-4999-858d-8b97d994238b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "low", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(3691), new TimeSpan(0, 0, 0, 0, 0)), "Low", "feeling_name_low", "", "" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Languages",
                columns: new[] { "Id", "Code", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "Direction", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode", "ThreeLetterCode", "TwoLetterCode" },
                values: new object[,]
                {
                    { new Guid("014f2c34-4184-44d6-981f-f949e717227b"), "FR", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), "French", "language_name_fr", "FRA", "FR" },
                    { new Guid("1a9934d7-b9e5-43bd-a41e-9a1babe1c8ad"), "EN", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), "English", "language_name_en", "ENG", "EN" },
                    { new Guid("2613eb10-46ad-4bb4-a71c-99a0f22583ec"), "ZH", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), "Chinese", "language_name_zh", "ZHO", "ZH" },
                    { new Guid("31b238d7-963b-4a6f-9ec3-cdfbce418c90"), "HE", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 1, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), "Hebrew", "language_name_he", "HEB", "HE" },
                    { new Guid("34ed5be6-b77a-4a51-bce4-ddc24f284a57"), "ES", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), "Spanish", "language_name_es", "ESP", "ES" },
                    { new Guid("644426cf-be01-493d-9f9b-7039840bc0c5"), "HI", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), "Hindi", "language_name_hi", "HIN", "HI" },
                    { new Guid("b226f065-258b-4551-a6e2-250193ae95bd"), "ZU", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), "Zulu", "language_name_zu", "ZUL", "ZU" },
                    { new Guid("dfe2c8d9-96d8-4d3f-badf-c9eca2933ddd"), "AF", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), "Afrikaans", "language_name_af", "AFR", "AF" },
                    { new Guid("f5240d6e-bbd2-4994-8554-6d17cd8de802"), "RU", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(1027), new TimeSpan(0, 0, 0, 0, 0)), "Russian", "language_name_ru", "RUS", "RU" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Reactions",
                columns: new[] { "Id", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "IconName", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode", "UnicodeIcon" },
                values: new object[,]
                {
                    { new Guid("25b5f2df-4584-4186-8554-b7d4f4637b88"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "angry", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)), "Angry", "reaction_name_angry", "1" },
                    { new Guid("35597910-17c7-4c5d-935f-98d383c50285"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "like", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)), "Like", "reaction_name_like", "1" },
                    { new Guid("551c4f1b-27a9-43ce-81b3-41c584277172"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "laugh", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)), "Haha", "reaction_name_laugh", "1" },
                    { new Guid("6786bc5b-c44e-403e-a14e-985d8324d258"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sad", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)), "Sad", "reaction_name_sad", "1" },
                    { new Guid("7ae3fc17-8276-41ad-a608-12ad48731a8e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "dislike", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)), "Dislike", "reaction_name_dislike", "1" },
                    { new Guid("d972b482-222d-43ca-8495-17c05da25c2c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "wow", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)), "Wow", "reaction_name_wow", "1" },
                    { new Guid("f5d82b4a-e069-470c-90f7-70ff6c5d3d14"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "care", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)), "Care", "reaction_name_care", "1" },
                    { new Guid("fb4f7987-f52e-4e35-99c6-7691052cf72e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "love", new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 745, DateTimeKind.Unspecified).AddTicks(2982), new TimeSpan(0, 0, 0, 0, 0)), "Love", "reaction_name_love", "1" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Settings",
                columns: new[] { "Id", "CreatedBy", "CreatedTimestamp", "DataType", "DefaultValue", "HelpText", "LastModifiedBy", "LastModifiedTimestamp", "Name", "SettingCategoryId", "ShortDescription", "Value" },
                values: new object[,]
                {
                    { new Guid("22cd06b6-47f5-43c9-9542-65a475663572"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 744, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), 1, "0", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 744, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), "Multi-factor Authentication", null, "Turn multi-factor authentication on/off.", null },
                    { new Guid("2434721d-63f1-414a-96b8-5d305963a029"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 744, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), 4, "", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 744, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), "Idp Issuer Signing Key Secret", null, "The secret used for generating the Idp Issuer Signing Key for the Astrana instance.", "69473DFCE4E2D15A343495F3612FBD2C69473DFCE4E2D15A343495F3612FBD2C" },
                    { new Guid("307c120b-cd96-44b5-b9b2-6900ea7cab0e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 744, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), 4, "AU", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 744, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), "Regional Format", null, "Formats for dates, times and numbers.", null },
                    { new Guid("683294db-187a-4492-838e-7ea7ab31356b"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 744, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), 4, "AUS Eastern Standard Time", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 744, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), "Time Zone", null, "The time zone of the Astrana instance user.", null },
                    { new Guid("6d49af78-ec23-4d91-b0f5-04c002ef4fef"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 744, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), 4, "", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 744, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), "Host Port Number", null, "The host port number of the Astrana instance.", null },
                    { new Guid("71c8a537-3c5b-4c2a-9a87-5154aee58c2c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 744, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), 4, "localhost", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 744, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), "Host Name", null, "The address of the Astrana instance.", null },
                    { new Guid("d3572331-21c9-41d9-8208-5648727c2065"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 744, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), 4, "EN", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 744, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), "Language Code", null, "The language code of the Astrana instance user.", null },
                    { new Guid("e445c922-9e78-4d95-b8eb-46247a628714"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 744, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), 21, "", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 8, 15, 0, 44, 13, 744, DateTimeKind.Unspecified).AddTicks(8699), new TimeSpan(0, 0, 0, 0, 0)), "Default Skin Tone", null, "The secret used for generating the Idp Issuer Signing Key for the Astrana instance.", "69473DFCE4E2D15A343495F3612FBD2C69473DFCE4E2D15A343495F3612FBD2C" }
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
                name: "IX_Images_ContentCollectionId",
                schema: "content",
                table: "Images",
                column: "ContentCollectionId");

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
                name: "IX_PostAttachments_ContentCollectionId",
                schema: "content",
                table: "PostAttachments",
                column: "ContentCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_PostAttachments_AudioId",
                schema: "content",
                table: "PostAttachments",
                column: "AudioId");

            migrationBuilder.CreateIndex(
                name: "IX_PostAttachments_FeelingId",
                schema: "content",
                table: "PostAttachments",
                column: "FeelingId");

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
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_PhoneNumber",
                schema: "iam",
                table: "UserAccounts",
                column: "PhoneNumber",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_UserName",
                schema: "iam",
                table: "UserAccounts",
                column: "UserName",
                unique: true);

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
                name: "IX_UserProfiles_CoverPictureId",
                schema: "user",
                table: "UserProfiles",
                column: "CoverPictureId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_ProfilePictureId",
                schema: "user",
                table: "UserProfiles",
                column: "ProfilePictureId");

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
                name: "Videos",
                schema: "content");

            migrationBuilder.DropTable(
                name: "Languages",
                schema: "config");

            migrationBuilder.DropTable(
                name: "InstantMessengerUsernames",
                schema: "contact");

            migrationBuilder.DropTable(
                name: "Feelings",
                schema: "config");

            migrationBuilder.DropTable(
                name: "Links",
                schema: "content");

            migrationBuilder.DropTable(
                name: "Posts",
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

            migrationBuilder.DropTable(
                name: "ContentCollections",
                schema: "content");
        }
    }
}
