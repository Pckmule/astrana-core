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
                name: "Albums",
                schema: "content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    table.PrimaryKey("PK_Albums", x => x.Id);
                });

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
                name: "Links",
                schema: "content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Text = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Links", x => x.Id);
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
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peers", x => x.Id);
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
                name: "PostAttachments",
                schema: "content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
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
                    table.PrimaryKey("PK_PostAttachments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Settings",
                schema: "config",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataType = table.Column<int>(type: "int", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    HelpText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DefaultValue = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.Id);
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
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Tags", x => x.Id);
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
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Videos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Images",
                schema: "content",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(2500)", maxLength: 2500, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Copyright = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AlbumId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Images", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Images_Albums_AlbumId",
                        column: x => x.AlbumId,
                        principalSchema: "content",
                        principalTable: "Albums",
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
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_Languages_LanguageId",
                        column: x => x.LanguageId,
                        principalSchema: "config",
                        principalTable: "Languages",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Posts",
                schema: "content",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Text = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AttachmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Posts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Posts_PostAttachments_AttachmentId",
                        column: x => x.AttachmentId,
                        principalSchema: "content",
                        principalTable: "PostAttachments",
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
                    ProfilePictureId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CoverPictureId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
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

            migrationBuilder.InsertData(
                schema: "config",
                table: "Countries",
                columns: new[] { "Id", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "LanguageId", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode", "ThreeLetterCode", "TwoLetterCode" },
                values: new object[,]
                {
                    { 1L, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), "Australia", "country_name_au", "AUS", "AU" },
                    { 2L, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), "Brazil", "country_name_br", "BRA", "BR" },
                    { 3L, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), "China", "country_name_cn", "CHN", "CN" },
                    { 4L, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), "France", "country_name_fr", "FRA", "FR" },
                    { 5L, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), "India", "country_name_in", "IND", "IN" },
                    { 6L, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), "Israel", "country_name_il", "ILR", "IL" },
                    { 7L, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), "Russia", "country_name_ru", "RUS", "RU" },
                    { 8L, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), "South Africa", "country_name_za", "ZAF", "ZA" },
                    { 9L, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), "Spain", "country_name_es", "ESP", "ES" },
                    { 10L, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), "United Kingdom", "country_name_gb", "GBR", "GB" },
                    { 11L, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 907, DateTimeKind.Unspecified).AddTicks(839), new TimeSpan(0, 0, 0, 0, 0)), "United States", "country_name_us", "USA", "US" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Languages",
                columns: new[] { "Id", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "Direction", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode", "ThreeLetterCode", "TwoLetterCode" },
                values: new object[,]
                {
                    { new Guid("00af240d-f142-4636-a50e-7454cbf969c1"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 0, 0, 0, 0)), "Russian", "language_name_ru", "RUS", "RU" },
                    { new Guid("0119d23e-5858-4852-9b3d-9696a203723a"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 0, 0, 0, 0)), "Spanish", "language_name_es", "ESP", "ES" },
                    { new Guid("2ff0da56-f966-4f28-a876-f3a1fd4a3d10"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 0, 0, 0, 0)), "French", "language_name_fr", "FRA", "FR" },
                    { new Guid("8810c969-c4f0-4bb5-bfc7-fb3653c49dd9"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 0, 0, 0, 0)), "Hindi", "language_name_hi", "HIN", "HI" },
                    { new Guid("b76c646d-f411-4429-b6f6-0280bdfa4ee7"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 0, 0, 0, 0)), "Chinese", "language_name_zh", "ZHO", "ZH" },
                    { new Guid("dfbb72e4-58f9-4378-a5d0-39ceeb5f33c5"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 1, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 0, 0, 0, 0)), "Hebrew", "language_name_he", "HEB", "HE" },
                    { new Guid("f0d5b326-2268-4d62-81bc-d0230e6a4dfd"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(9146), new TimeSpan(0, 0, 0, 0, 0)), "English", "language_name_en", "ENG", "EN" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Settings",
                columns: new[] { "Id", "CreatedBy", "CreatedTimestamp", "DataType", "DefaultValue", "HelpText", "LastModifiedBy", "LastModifiedTimestamp", "Name", "ShortDescription", "Value" },
                values: new object[,]
                {
                    { new Guid("089d549b-e4e3-46f1-bcfe-402ca9778e63"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 0, 0, 0, 0)), 2, "EN", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 0, 0, 0, 0)), "Language Code", "The language code of the Astrana instance user.", null },
                    { new Guid("0be03017-0c2f-488a-9ac3-9f0162e12de4"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 0, 0, 0, 0)), 1, "0", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 0, 0, 0, 0)), "Multi-factor Authentication", "Turn multi-factor authentication on/off.", null },
                    { new Guid("1bcfd564-ccd9-48d3-bd29-255f81970c8e"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 0, 0, 0, 0)), 2, "", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 0, 0, 0, 0)), "Idp Issuer Signing Key Secret", "The secret used for generating the Idp Issuer Signing Key for the Astrana instance.", "69473DFCE4E2D15A343495F3612FBD2C69473DFCE4E2D15A343495F3612FBD2C" },
                    { new Guid("a4dfb95e-866e-4c07-bc17-ea561a4f2645"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 0, 0, 0, 0)), 2, "AUS Eastern Standard Time", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 0, 0, 0, 0)), "Time Zone", "The time zone of the Astrana instance user.", null },
                    { new Guid("ae3789d7-21ba-4d81-8f0d-9cc91f66ba5f"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 0, 0, 0, 0)), 2, "AU", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 0, 0, 0, 0)), "Regional Format", "Formats for dates, times and numbers.", null },
                    { new Guid("be2222fb-d2be-4f7d-8b9d-c2fbf413f6aa"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 0, 0, 0, 0)), 2, "localhost", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 0, 0, 0, 0)), "Host Name", "The address of the Astrana instance.", null },
                    { new Guid("f273aa91-782c-4a99-a432-abee603e260c"), new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 0, 0, 0, 0)), 2, "", null, new Guid("0334ca45-b161-432c-ad23-ed7b7f0a74ab"), new DateTimeOffset(new DateTime(2023, 1, 29, 4, 39, 17, 906, DateTimeKind.Unspecified).AddTicks(6639), new TimeSpan(0, 0, 0, 0, 0)), "Host Port Number", "The host port number of the Astrana instance.", null }
                });

            migrationBuilder.CreateIndex(
                name: "IX_ApiAccessTokens_Token",
                schema: "iam",
                table: "ApiAccessTokens",
                column: "Token",
                unique: true);

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
                name: "IX_FeatureToggles_FeatureName",
                schema: "config",
                table: "FeatureToggles",
                column: "FeatureName",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Images_AlbumId",
                schema: "content",
                table: "Images",
                column: "AlbumId");

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
                name: "IX_Posts_AttachmentId",
                schema: "content",
                table: "Posts",
                column: "AttachmentId");

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
                name: "FeatureToggles",
                schema: "config");

            migrationBuilder.DropTable(
                name: "Links",
                schema: "content");

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
                name: "Posts",
                schema: "content");

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
                name: "UserProfiles",
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
                name: "PostAttachments",
                schema: "content");

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
                name: "Images",
                schema: "content");

            migrationBuilder.DropTable(
                name: "UserAccounts",
                schema: "iam");

            migrationBuilder.DropTable(
                name: "Albums",
                schema: "content");
        }
    }
}
