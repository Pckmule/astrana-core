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
                name: "workflow");

            migrationBuilder.EnsureSchema(
                name: "dbo");

            migrationBuilder.CreateTable(
                name: "ApiAccessTokens",
                schema: "iam",
                columns: table => new
                {
                    ApiAccessTokenId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_ApiAccessTokens", x => x.ApiAccessTokenId);
                });

            migrationBuilder.CreateTable(
                name: "AudioClips",
                schema: "content",
                columns: table => new
                {
                    AudioClipId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_AudioClips", x => x.AudioClipId);
                });

            migrationBuilder.CreateTable(
                name: "ContentCollections",
                schema: "content",
                columns: table => new
                {
                    ContentCollectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CollectionType = table.Column<int>(type: "int", nullable: false),
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
                    ContentSafetyRatingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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
                    table.PrimaryKey("PK_ContentSafetyRatings", x => x.ContentSafetyRatingId);
                });

            migrationBuilder.CreateTable(
                name: "EmailAddresses",
                schema: "contact",
                columns: table => new
                {
                    EmailAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
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
                    table.PrimaryKey("PK_EmailAddresses", x => x.EmailAddressId);
                });

            migrationBuilder.CreateTable(
                name: "FeatureToggles",
                schema: "config",
                columns: table => new
                {
                    FeatureToggleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_FeatureToggles", x => x.FeatureToggleId);
                });

            migrationBuilder.CreateTable(
                name: "Feelings",
                schema: "content",
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
                name: "FeelingTemplates",
                schema: "config",
                columns: table => new
                {
                    FeelingTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_FeelingTemplates", x => x.FeelingTemplateId);
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
                    MessengerUsernameId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Username = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
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
                    table.PrimaryKey("PK_InstantMessengerUsernames", x => x.MessengerUsernameId);
                });

            migrationBuilder.CreateTable(
                name: "Languages",
                schema: "config",
                columns: table => new
                {
                    LanguageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Languages", x => x.LanguageId);
                });

            migrationBuilder.CreateTable(
                name: "Locations",
                schema: "content",
                columns: table => new
                {
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
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
                name: "NewContentWorkflowStage",
                schema: "workflow",
                columns: table => new
                {
                    NewContentWorkflowStageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContentEntityId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContentEntityTypeId = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Stage = table.Column<int>(type: "int", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NewContentWorkflowStage", x => x.NewContentWorkflowStageId);
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                schema: "workflow",
                columns: table => new
                {
                    NotificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    SourceType = table.Column<int>(type: "int", nullable: false),
                    SourceId = table.Column<string>(type: "nvarchar(36)", maxLength: 36, nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notifications", x => x.NotificationId);
                });

            migrationBuilder.CreateTable(
                name: "PeerCircles",
                schema: "dbo",
                columns: table => new
                {
                    PeerCircleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameTrxCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DescriptionTrxCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    IsUserDefined = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_PeerCircles", x => x.PeerCircleId);
                });

            migrationBuilder.CreateTable(
                name: "PeerConnectionRequestsReceived",
                schema: "dbo",
                columns: table => new
                {
                    PeerConnectionRequestReceivedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<short>(type: "smallint", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_PeerConnectionRequestsReceived", x => x.PeerConnectionRequestReceivedId);
                });

            migrationBuilder.CreateTable(
                name: "PeerConnectionRequestsSubmitted",
                schema: "dbo",
                columns: table => new
                {
                    PeerConnectionRequestSubmittedId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<short>(type: "smallint", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
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
                    table.PrimaryKey("PK_PeerConnectionRequestsSubmitted", x => x.PeerConnectionRequestSubmittedId);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumbers",
                schema: "contact",
                columns: table => new
                {
                    PhoneNumberId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Number = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
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
                    table.PrimaryKey("PK_PhoneNumbers", x => x.PhoneNumberId);
                });

            migrationBuilder.CreateTable(
                name: "PhoneNumberTypes",
                schema: "config",
                columns: table => new
                {
                    PhoneNumberTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_PhoneNumberTypes", x => x.PhoneNumberTypeId);
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
                schema: "content",
                columns: table => new
                {
                    ReactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Reactions", x => x.ReactionId);
                });

            migrationBuilder.CreateTable(
                name: "ReactionTemplates",
                schema: "config",
                columns: table => new
                {
                    ReactionTemplateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_ReactionTemplates", x => x.ReactionTemplateId);
                });

            migrationBuilder.CreateTable(
                name: "SettingCategories",
                schema: "config",
                columns: table => new
                {
                    SystemSettingCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameTrxCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    DescriptionTrxCode = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SettingCategories", x => x.SystemSettingCategoryId);
                });

            migrationBuilder.CreateTable(
                name: "SkinTones",
                schema: "config",
                columns: table => new
                {
                    SkinToneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NameTrxCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DescriptionTrxCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ColorCode = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SkinTones", x => x.SkinToneId);
                });

            migrationBuilder.CreateTable(
                name: "TimeZones",
                schema: "config",
                columns: table => new
                {
                    TimeZoneId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NameTrxCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Abbreviation = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: false),
                    CorrespondingUtcZone = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    DaylightSavingApplies = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TimeZones", x => new { x.CorrespondingUtcZone, x.Abbreviation, x.Name });
                });

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                schema: "iam",
                columns: table => new
                {
                    UserAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    NormalizedEmailAddress = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    IsEmailAddressConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PasswordSalt = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(25)", maxLength: 25, nullable: true),
                    PhoneCountryCodeISO = table.Column<string>(type: "nvarchar(6)", maxLength: 6, nullable: true),
                    IsPhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    IsTwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    IsLockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    FailedAccessCount = table.Column<short>(type: "smallint", nullable: false),
                    TimeZone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LanguageCode = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    CountryCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
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
                    table.PrimaryKey("PK_UserAccounts", x => x.UserAccountId);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                schema: "iam",
                columns: table => new
                {
                    UserRoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_UserRoles", x => x.UserRoleId);
                });

            migrationBuilder.CreateTable(
                name: "Videos",
                schema: "content",
                columns: table => new
                {
                    VideoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Videos", x => x.VideoId);
                });

            migrationBuilder.CreateTable(
                name: "ExternalContentSubscriptions",
                schema: "content",
                columns: table => new
                {
                    ExternalContentSubscriptionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_ExternalContentSubscriptions", x => x.ExternalContentSubscriptionId);
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
                    SystemSettingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    NameTrxCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DataType = table.Column<int>(type: "int", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    HelpText = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    HelpTextTrxCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    DefaultValue = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Value = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    ValueChoicesLookupName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MaximumValues = table.Column<int>(type: "int", nullable: true),
                    MinimumValues = table.Column<int>(type: "int", nullable: true),
                    MaximumValueLength = table.Column<int>(type: "int", nullable: true),
                    MinimumValueLength = table.Column<int>(type: "int", nullable: true),
                    SettingCategoryId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserMaySet = table.Column<bool>(type: "bit", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ShortDescriptionTrxCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Settings", x => x.SystemSettingId);
                    table.ForeignKey(
                        name: "FK_Settings_SettingCategories_SettingCategoryId",
                        column: x => x.SettingCategoryId,
                        principalSchema: "config",
                        principalTable: "SettingCategories",
                        principalColumn: "SystemSettingCategoryId");
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
                        principalColumn: "MessengerUsernameId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MessengerUsernameRel_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalSchema: "iam",
                        principalTable: "UserAccounts",
                        principalColumn: "UserAccountId",
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
                        principalColumn: "EmailAddressId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserEmailAddressRel_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalSchema: "iam",
                        principalTable: "UserAccounts",
                        principalColumn: "UserAccountId",
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
                        principalColumn: "PhoneNumberId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserPhoneNumberRel_UserAccounts_UserAccountId",
                        column: x => x.UserAccountId,
                        principalSchema: "iam",
                        principalTable: "UserAccounts",
                        principalColumn: "UserAccountId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserProfiles",
                schema: "user",
                columns: table => new
                {
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    MiddleNames = table.Column<string>(type: "nvarchar(300)", maxLength: 300, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DateOfBirth = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    Introduction = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    ProfilePictureImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProfilePicturesCollectionContentCollectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CoverPictureImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CoverPicturesCollectionContentCollectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfiles", x => x.UserProfileId);
                    table.ForeignKey(
                        name: "FK_UserProfiles_ContentCollections_CoverPicturesCollectionContentCollectionId",
                        column: x => x.CoverPicturesCollectionContentCollectionId,
                        principalSchema: "content",
                        principalTable: "ContentCollections",
                        principalColumn: "ContentCollectionId");
                    table.ForeignKey(
                        name: "FK_UserProfiles_ContentCollections_ProfilePicturesCollectionContentCollectionId",
                        column: x => x.ProfilePicturesCollectionContentCollectionId,
                        principalSchema: "content",
                        principalTable: "ContentCollections",
                        principalColumn: "ContentCollectionId");
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
                        principalColumn: "UserAccountId",
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
                        principalColumn: "UserAccountId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserAccountRoleRel_UserRoles_UserRoleId",
                        column: x => x.UserRoleId,
                        principalSchema: "iam",
                        principalTable: "UserRoles",
                        principalColumn: "UserRoleId",
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
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Comments", x => x.CommentId);
                    table.ForeignKey(
                        name: "FK_Comments_AudioClips_TargetAudioId",
                        column: x => x.TargetAudioId,
                        principalSchema: "content",
                        principalTable: "AudioClips",
                        principalColumn: "AudioClipId");
                    table.ForeignKey(
                        name: "FK_Comments_AudioClips_TargetContentCollectionId",
                        column: x => x.TargetContentCollectionId,
                        principalSchema: "content",
                        principalTable: "AudioClips",
                        principalColumn: "AudioClipId");
                    table.ForeignKey(
                        name: "FK_Comments_Comments_TargetCommentId",
                        column: x => x.TargetCommentId,
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
                        name: "FK_ContentCollectionItems_AudioClips_AudioId",
                        column: x => x.AudioId,
                        principalSchema: "content",
                        principalTable: "AudioClips",
                        principalColumn: "AudioClipId",
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
                    PostAttachmentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Caption = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false),
                    LinkId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ImageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    VideoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AudioClipId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ContentCollectionId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GifId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    FeelingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    LocationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                    table.PrimaryKey("PK_PostAttachments", x => x.PostAttachmentId);
                    table.ForeignKey(
                        name: "FK_PostAttachments_AudioClips_AudioClipId",
                        column: x => x.AudioClipId,
                        principalSchema: "content",
                        principalTable: "AudioClips",
                        principalColumn: "AudioClipId",
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
                        principalSchema: "content",
                        principalTable: "Feelings",
                        principalColumn: "FeelingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PostAttachments_Images_GifId",
                        column: x => x.GifId,
                        principalSchema: "content",
                        principalTable: "Images",
                        principalColumn: "ImageId",
                        onDelete: ReferentialAction.Restrict);
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
                        principalColumn: "LocationId",
                        onDelete: ReferentialAction.Restrict);
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
                    UserProfileDetailId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Key = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Label = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Value = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    IconName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    DisplayOrder = table.Column<short>(type: "smallint", nullable: false),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserProfileDetails", x => x.UserProfileDetailId);
                    table.ForeignKey(
                        name: "FK_UserProfileDetails_UserProfiles_UserProfileId",
                        column: x => x.UserProfileId,
                        principalSchema: "user",
                        principalTable: "UserProfiles",
                        principalColumn: "UserProfileId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Audiences",
                schema: "config",
                columns: table => new
                {
                    AudienceId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(30)", maxLength: 30, nullable: false),
                    NameTrxCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: true),
                    DescriptionTrxCode = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    MinimumAge = table.Column<short>(type: "smallint", nullable: true),
                    MaximumAge = table.Column<short>(type: "smallint", nullable: true),
                    IsUserDefined = table.Column<bool>(type: "bit", nullable: false),
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
                    table.PrimaryKey("PK_Audiences", x => x.AudienceId);
                    table.ForeignKey(
                        name: "FK_Audiences_UserProfileDetails_UserProfileDetailId",
                        column: x => x.UserProfileDetailId,
                        principalSchema: "user",
                        principalTable: "UserProfileDetails",
                        principalColumn: "UserProfileDetailId");
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                schema: "config",
                columns: table => new
                {
                    CountryId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    NameTrxCode = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    OfficialName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    OfficialNameTrxCode = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    TwoLetterCode = table.Column<string>(type: "nvarchar(2)", maxLength: 2, nullable: false),
                    ThreeLetterCode = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    NumberCode = table.Column<int>(type: "int", nullable: true),
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
                    table.PrimaryKey("PK_Countries", x => x.CountryId);
                    table.ForeignKey(
                        name: "FK_Countries_Audiences_AudienceId",
                        column: x => x.AudienceId,
                        principalSchema: "config",
                        principalTable: "Audiences",
                        principalColumn: "AudienceId");
                });

            migrationBuilder.CreateTable(
                name: "Peers",
                schema: "dbo",
                columns: table => new
                {
                    PeerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    VirtualProfileId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Age = table.Column<short>(type: "smallint", nullable: false),
                    Sex = table.Column<int>(type: "int", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    Note = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    PeerAccessToken = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    IsMuted = table.Column<bool>(type: "bit", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    AudienceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AudienceId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PeerCircleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Peers", x => x.PeerId);
                    table.ForeignKey(
                        name: "FK_Peers_Audiences_AudienceId",
                        column: x => x.AudienceId,
                        principalSchema: "config",
                        principalTable: "Audiences",
                        principalColumn: "AudienceId");
                    table.ForeignKey(
                        name: "FK_Peers_Audiences_AudienceId1",
                        column: x => x.AudienceId1,
                        principalSchema: "config",
                        principalTable: "Audiences",
                        principalColumn: "AudienceId");
                    table.ForeignKey(
                        name: "FK_Peers_PeerCircles_PeerCircleId",
                        column: x => x.PeerCircleId,
                        principalSchema: "dbo",
                        principalTable: "PeerCircles",
                        principalColumn: "PeerCircleId");
                });

            migrationBuilder.CreateTable(
                name: "Tags",
                schema: "content",
                columns: table => new
                {
                    TagId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
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
                    table.PrimaryKey("PK_Tags", x => x.TagId);
                    table.ForeignKey(
                        name: "FK_Tags_Audiences_AudienceId",
                        column: x => x.AudienceId,
                        principalSchema: "config",
                        principalTable: "Audiences",
                        principalColumn: "AudienceId");
                });

            migrationBuilder.CreateTable(
                name: "CountryTimeZone",
                schema: "config",
                columns: table => new
                {
                    CountriesCountryId = table.Column<long>(type: "bigint", nullable: false),
                    TimeZonesCorrespondingUtcZone = table.Column<string>(type: "nvarchar(5)", nullable: false),
                    TimeZonesAbbreviation = table.Column<string>(type: "nvarchar(6)", nullable: false),
                    TimeZonesName = table.Column<string>(type: "nvarchar(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CountryTimeZone", x => new { x.CountriesCountryId, x.TimeZonesCorrespondingUtcZone, x.TimeZonesAbbreviation, x.TimeZonesName });
                    table.ForeignKey(
                        name: "FK_CountryTimeZone_Countries_CountriesCountryId",
                        column: x => x.CountriesCountryId,
                        principalSchema: "config",
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_CountryTimeZone_TimeZones_TimeZonesCorrespondingUtcZone_TimeZonesAbbreviation_TimeZonesName",
                        columns: x => new { x.TimeZonesCorrespondingUtcZone, x.TimeZonesAbbreviation, x.TimeZonesName },
                        principalSchema: "config",
                        principalTable: "TimeZones",
                        principalColumns: new[] { "CorrespondingUtcZone", "Abbreviation", "Name" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TopLevelDomains",
                schema: "config",
                columns: table => new
                {
                    TopLevelDomainId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Domain = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    IsImplemented = table.Column<bool>(type: "bit", nullable: false),
                    DeactivatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    DeactivatedReason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DeactivatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LastModifiedBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    LastModifiedTimestamp = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TopLevelDomains", x => x.TopLevelDomainId);
                    table.ForeignKey(
                        name: "FK_TopLevelDomains_Countries_CountryId",
                        column: x => x.CountryId,
                        principalSchema: "config",
                        principalTable: "Countries",
                        principalColumn: "CountryId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Audiences",
                columns: new[] { "AudienceId", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "Description", "DescriptionTrxCode", "IsUserDefined", "LastModifiedBy", "LastModifiedTimestamp", "MaximumAge", "MinimumAge", "Name", "NameTrxCode", "UserProfileDetailId" },
                values: new object[,]
                {
                    { new Guid("0b255ccf-19e4-49c0-a3e0-d8513416d52d"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Content associated with this audience will only be accessible to peers that are considered family.", "audience_description_family", false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Family", "family", null },
                    { new Guid("0c4e6f37-09af-4b5b-9081-42368f9884ea"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Content associated with this audience will be accessible to everyone.", "audience_description_public", false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Public", "public", null },
                    { new Guid("7255b812-56c0-4293-ba3e-f3a28e7256e3"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Content associated with this audience will only be accessible to peers that are considered part of your professional network.", "audience_description_professional", false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Professional", "professional", null },
                    { new Guid("94b9b87c-a0a1-4721-a905-897b12e81fc7"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "Content associated with this audience will only be accessible to it's owner.", "audience_description_me", false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 0, 0, 0, 0)), null, null, "Only Me", "only_me", null }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Countries",
                columns: new[] { "CountryId", "AudienceId", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode", "NumberCode", "OfficialName", "OfficialNameTrxCode", "ThreeLetterCode", "TwoLetterCode" },
                values: new object[,]
                {
                    { 1L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Afghanistan", "country_name_afg", 4, "The Islamic Republic of Afghanistan", "country_name_official_afg", "AFG", "AF" },
                    { 2L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Åland Islands", "country_name_ala", 248, "Åland", "country_name_official_ala", "ALA", "AX" },
                    { 3L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Albania", "country_name_alb", 8, "The Republic of Albania", "country_name_official_alb", "ALB", "AL" },
                    { 4L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Algeria", "country_name_dza", 12, "The People's Democratic Republic of Algeria", "country_name_official_dza", "DZA", "DZ" },
                    { 5L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "American Samoa", "country_name_asm", 16, "The Territory of American Samoa", "country_name_official_asm", "ASM", "AS" },
                    { 6L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Andorra", "country_name_and", 20, "The Principality of Andorra", "country_name_official_and", "AND", "AD" },
                    { 7L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Angola", "country_name_ago", 24, "The Republic of Angola", "country_name_official_ago", "AGO", "AO" },
                    { 8L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Anguilla", "country_name_aia", 660, "Anguilla", "country_name_official_aia", "AIA", "AI" },
                    { 9L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Antarctica", "country_name_ata", 10, "All land and ice shelves south of the 60th parallel south", "country_name_official_ata", "ATA", "AQ" },
                    { 10L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Antigua and Barbuda", "country_name_atg", 28, "Antigua and Barbuda", "country_name_official_atg", "ATG", "AG" },
                    { 11L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Argentina", "country_name_arg", 32, "The Argentine Republic", "country_name_official_arg", "ARG", "AR" },
                    { 12L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Armenia", "country_name_arm", 51, "The Republic of Armenia", "country_name_official_arm", "ARM", "AM" },
                    { 13L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Aruba", "country_name_abw", 533, "Aruba", "country_name_official_abw", "ABW", "AW" },
                    { 14L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Australia", "country_name_aus", 36, "The Commonwealth of Australia", "country_name_official_aus", "AUS", "AU" },
                    { 15L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Austria", "country_name_aut", 40, "The Republic of Austria", "country_name_official_aut", "AUT", "AT" },
                    { 16L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Azerbaijan", "country_name_aze", 31, "The Republic of Azerbaijan", "country_name_official_aze", "AZE", "AZ" },
                    { 17L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Bahamas", "country_name_bhs", 44, "The Commonwealth of The Bahamas", "country_name_official_bhs", "BHS", "BS" },
                    { 18L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Bahrain", "country_name_bhr", 48, "The Kingdom of Bahrain", "country_name_official_bhr", "BHR", "BH" },
                    { 19L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Bangladesh", "country_name_bgd", 50, "The People's Republic of Bangladesh", "country_name_official_bgd", "BGD", "BD" },
                    { 20L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Barbados", "country_name_brb", 52, "Barbados", "country_name_official_brb", "BRB", "BB" },
                    { 21L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Belarus", "country_name_blr", 112, "The Republic of Belarus", "country_name_official_blr", "BLR", "BY" },
                    { 22L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Belgium", "country_name_bel", 56, "The Kingdom of Belgium", "country_name_official_bel", "BEL", "BE" },
                    { 23L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Belize", "country_name_blz", 84, "Belize", "country_name_official_blz", "BLZ", "BZ" },
                    { 24L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Benin", "country_name_ben", 204, "The Republic of Benin", "country_name_official_ben", "BEN", "BJ" },
                    { 25L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Bermuda", "country_name_bmu", 60, "Bermuda", "country_name_official_bmu", "BMU", "BM" },
                    { 26L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Bhutan", "country_name_btn", 64, "The Kingdom of Bhutan", "country_name_official_btn", "BTN", "BT" },
                    { 27L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Bolivia", "country_name_bol", 68, "The Plurinational State of Bolivia", "country_name_official_bol", "BOL", "BO" },
                    { 28L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Bonaire, Sint Eustatius and Saba", "country_name_bes", 535, "Bonaire, Sint Eustatius and Saba", "country_name_official_bes", "BES", "BQ" },
                    { 29L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Bosnia and Herzegovina", "country_name_bih", 70, "Bosnia and Herzegovina", "country_name_official_bih", "BIH", "BA" },
                    { 30L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Botswana", "country_name_bwa", 72, "The Republic of Botswana", "country_name_official_bwa", "BWA", "BW" },
                    { 31L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Bouvet Island", "country_name_bvt", 74, "Bouvet Island", "country_name_official_bvt", "BVT", "BV" },
                    { 32L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Brazil", "country_name_bra", 76, "The Federative Republic of Brazil", "country_name_official_bra", "BRA", "BR" },
                    { 33L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "British Indian Ocean Territory", "country_name_iot", 86, "The British Indian Ocean Territory", "country_name_official_iot", "IOT", "IO" },
                    { 34L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Brunei Darussalam", "country_name_brn", 96, "The Nation of Brunei, the Abode of Peace", "country_name_official_brn", "BRN", "BN" },
                    { 35L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Bulgaria", "country_name_bgr", 100, "The Republic of Bulgaria", "country_name_official_bgr", "BGR", "BG" },
                    { 36L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Burkina Faso", "country_name_bfa", 854, "Burkina Faso", "country_name_official_bfa", "BFA", "BF" },
                    { 37L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Burundi", "country_name_bdi", 108, "The Republic of Burundi", "country_name_official_bdi", "BDI", "BI" },
                    { 38L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Cabo Verde", "country_name_cpv", 132, "The Republic of Cabo Verde", "country_name_official_cpv", "CPV", "CV" },
                    { 39L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Cambodia", "country_name_khm", 116, "The Kingdom of Cambodia", "country_name_official_khm", "KHM", "KH" },
                    { 40L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Cameroon", "country_name_cmr", 120, "The Republic of Cameroon", "country_name_official_cmr", "CMR", "CM" },
                    { 41L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Canada", "country_name_can", 124, "Canada", "country_name_official_can", "CAN", "CA" },
                    { 42L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Cayman Islands", "country_name_cym", 136, "The Cayman Islands", "country_name_official_cym", "CYM", "KY" },
                    { 43L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Central African Republic", "country_name_caf", 140, "The Central African Republic", "country_name_official_caf", "CAF", "CF" },
                    { 44L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Chad", "country_name_tcd", 148, "The Republic of Chad", "country_name_official_tcd", "TCD", "TD" },
                    { 45L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Chile", "country_name_chl", 152, "The Republic of Chile", "country_name_official_chl", "CHL", "CL" },
                    { 46L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "China", "country_name_chn", 156, "The People's Republic of China", "country_name_official_chn", "CHN", "CN" },
                    { 47L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Christmas Island", "country_name_cxr", 162, "The Territory of Christmas Island", "country_name_official_cxr", "CXR", "CX" },
                    { 48L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Cocos (Keeling) Islands", "country_name_cck", 166, "The Territory of Cocos (Keeling) Islands", "country_name_official_cck", "CCK", "CC" },
                    { 49L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Colombia", "country_name_col", 170, "The Republic of Colombia", "country_name_official_col", "COL", "CO" },
                    { 50L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Comoros", "country_name_com", 174, "The Union of the Comoros", "country_name_official_com", "COM", "KM" },
                    { 51L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Congo (Kinshasa)", "country_name_cod", 180, "The Democratic Republic of the Congo", "country_name_official_cod", "COD", "CD" },
                    { 52L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Congo (Brazzaville)", "country_name_cog", 178, "The Republic of the Congo", "country_name_official_cog", "COG", "CG" },
                    { 53L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Cook Islands", "country_name_cok", 184, "The Cook Islands", "country_name_official_cok", "COK", "CK" },
                    { 54L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Costa Rica", "country_name_cri", 188, "The Republic of Costa Rica", "country_name_official_cri", "CRI", "CR" },
                    { 55L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Côte d'Ivoire", "country_name_civ", 384, "The Republic of Côte d'Ivoire", "country_name_official_civ", "CIV", "CI" },
                    { 56L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Croatia", "country_name_hrv", 191, "The Republic of Croatia", "country_name_official_hrv", "HRV", "HR" },
                    { 57L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Cuba", "country_name_cub", 192, "The Republic of Cuba", "country_name_official_cub", "CUB", "CU" },
                    { 58L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Curaçao", "country_name_cuw", 531, "The Country of Curaçao", "country_name_official_cuw", "CUW", "CW" },
                    { 59L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Cyprus", "country_name_cyp", 196, "The Republic of Cyprus", "country_name_official_cyp", "CYP", "CY" },
                    { 60L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Czechia", "country_name_cze", 203, "The Czech Republic", "country_name_official_cze", "CZE", "CZ" },
                    { 61L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Denmark", "country_name_dnk", 208, "The Kingdom of Denmark", "country_name_official_dnk", "DNK", "DK" },
                    { 62L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Djibouti", "country_name_dji", 262, "The Republic of Djibouti", "country_name_official_dji", "DJI", "DJ" },
                    { 63L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Dominica", "country_name_dma", 212, "The Commonwealth of Dominica", "country_name_official_dma", "DMA", "DM" },
                    { 64L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Dominican Republic", "country_name_dom", 214, "The Dominican Republic", "country_name_official_dom", "DOM", "DO" },
                    { 65L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Ecuador", "country_name_ecu", 218, "The Republic of Ecuador", "country_name_official_ecu", "ECU", "EC" },
                    { 66L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Egypt", "country_name_egy", 818, "The Arab Republic of Egypt", "country_name_official_egy", "EGY", "EG" },
                    { 67L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "El Salvador", "country_name_slv", 222, "The Republic of El Salvador", "country_name_official_slv", "SLV", "SV" },
                    { 68L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Equatorial Guinea", "country_name_gnq", 226, "The Republic of Equatorial Guinea", "country_name_official_gnq", "GNQ", "GQ" },
                    { 69L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Eritrea", "country_name_eri", 232, "The State of Eritrea", "country_name_official_eri", "ERI", "ER" },
                    { 70L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Estonia", "country_name_est", 233, "The Republic of Estonia", "country_name_official_est", "EST", "EE" },
                    { 71L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Eswatini", "country_name_swz", 748, "The Kingdom of Eswatini", "country_name_official_swz", "SWZ", "SZ" },
                    { 72L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Ethiopia", "country_name_eth", 231, "The Federal Democratic Republic of Ethiopia", "country_name_official_eth", "ETH", "ET" },
                    { 73L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Falkland Islands", "country_name_flk", 238, "The Falkland Islands", "country_name_official_flk", "FLK", "FK" },
                    { 74L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Faroe Islands", "country_name_fro", 234, "The Faroe Islands", "country_name_official_fro", "FRO", "FO" },
                    { 75L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Fiji", "country_name_fji", 242, "The Republic of Fiji", "country_name_official_fji", "FJI", "FJ" },
                    { 76L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Finland", "country_name_fin", 246, "The Republic of Finland", "country_name_official_fin", "FIN", "FI" },
                    { 77L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "France", "country_name_fra", 250, "The French Republic", "country_name_official_fra", "FRA", "FR" },
                    { 78L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "French Guiana", "country_name_guf", 254, "Guyane", "country_name_official_guf", "GUF", "GF" },
                    { 79L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "French Polynesia", "country_name_pyf", 258, "French Polynesia", "country_name_official_pyf", "PYF", "PF" },
                    { 80L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "French Southern Territories", "country_name_atf", 260, "The French Southern and Antarctic Lands", "country_name_official_atf", "ATF", "TF" },
                    { 81L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Gabon", "country_name_gab", 266, "The Gabonese Republic", "country_name_official_gab", "GAB", "GA" },
                    { 82L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Gambia", "country_name_gmb", 270, "The Republic of The Gambia", "country_name_official_gmb", "GMB", "GM" },
                    { 83L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Georgia", "country_name_geo", 268, "Georgia", "country_name_official_geo", "GEO", "GE" },
                    { 84L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Germany", "country_name_deu", 276, "The Federal Republic of Germany", "country_name_official_deu", "DEU", "DE" },
                    { 85L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Ghana", "country_name_gha", 288, "The Republic of Ghana", "country_name_official_gha", "GHA", "GH" },
                    { 86L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Gibraltar", "country_name_gib", 292, "Gibraltar", "country_name_official_gib", "GIB", "GI" },
                    { 87L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Greece", "country_name_grc", 300, "The Hellenic Republic", "country_name_official_grc", "GRC", "GR" },
                    { 88L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Greenland", "country_name_grl", 304, "Kalaallit Nunaat", "country_name_official_grl", "GRL", "GL" },
                    { 89L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Grenada", "country_name_grd", 308, "Grenada", "country_name_official_grd", "GRD", "GD" },
                    { 90L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Guadeloupe", "country_name_glp", 312, "Guadeloupe", "country_name_official_glp", "GLP", "GP" },
                    { 91L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Guam", "country_name_gum", 316, "The Territory of Guam", "country_name_official_gum", "GUM", "GU" },
                    { 92L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Guatemala", "country_name_gtm", 320, "The Republic of Guatemala", "country_name_official_gtm", "GTM", "GT" },
                    { 93L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Guernsey", "country_name_ggy", 831, "The Bailiwick of Guernsey", "country_name_official_ggy", "GGY", "GG" },
                    { 94L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Guinea", "country_name_gin", 324, "The Republic of Guinea", "country_name_official_gin", "GIN", "GN" },
                    { 95L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Guinea-Bissau", "country_name_gnb", 624, "The Republic of Guinea-Bissau", "country_name_official_gnb", "GNB", "GW" },
                    { 96L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Guyana", "country_name_guy", 328, "The Co-operative Republic of Guyana", "country_name_official_guy", "GUY", "GY" },
                    { 97L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Haiti", "country_name_hti", 332, "The Republic of Haiti", "country_name_official_hti", "HTI", "HT" },
                    { 98L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Heard Island and McDonald Islands", "country_name_hmd", 334, "The Territory of Heard Island and McDonald Islands", "country_name_official_hmd", "HMD", "HM" },
                    { 99L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Vatican City", "country_name_vat", 336, "Vatican City", "country_name_official_vat", "VAT", "VA" },
                    { 100L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Honduras", "country_name_hnd", 340, "The Republic of Honduras", "country_name_official_hnd", "HND", "HN" },
                    { 101L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Hong Kong", "country_name_hkg", 344, "The Hong Kong Special Administrative Region of China", "country_name_official_hkg", "HKG", "HK" },
                    { 102L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Hungary", "country_name_hun", 348, "Hungary", "country_name_official_hun", "HUN", "HU" },
                    { 103L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Iceland", "country_name_isl", 352, "Iceland", "country_name_official_isl", "ISL", "IS" },
                    { 104L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "India", "country_name_ind", 356, "The Republic of India", "country_name_official_ind", "IND", "IN" },
                    { 105L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Indonesia", "country_name_idn", 360, "The Republic of Indonesia", "country_name_official_idn", "IDN", "ID" },
                    { 106L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Iran", "country_name_irn", 364, "The Islamic Republic of Iran", "country_name_official_irn", "IRN", "IR" },
                    { 107L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Iraq", "country_name_irq", 368, "The Republic of Iraq", "country_name_official_irq", "IRQ", "IQ" },
                    { 108L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Ireland", "country_name_irl", 372, "Ireland", "country_name_official_irl", "IRL", "IE" },
                    { 109L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Isle of Man", "country_name_imn", 833, "The Isle of Man", "country_name_official_imn", "IMN", "IM" },
                    { 110L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Israel", "country_name_isr", 376, "The State of Israel", "country_name_official_isr", "ISR", "IL" },
                    { 111L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Italy", "country_name_ita", 380, "The Italian Republic", "country_name_official_ita", "ITA", "IT" },
                    { 112L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Jamaica", "country_name_jam", 388, "Jamaica", "country_name_official_jam", "JAM", "JM" },
                    { 113L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Japan", "country_name_jpn", 392, "Japan", "country_name_official_jpn", "JPN", "JP" },
                    { 114L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Jersey", "country_name_jey", 832, "The Bailiwick of Jersey", "country_name_official_jey", "JEY", "JE" },
                    { 115L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Jordan", "country_name_jor", 400, "The Hashemite Kingdom of Jordan", "country_name_official_jor", "JOR", "JO" },
                    { 116L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Kazakhstan", "country_name_kaz", 398, "The Republic of Kazakhstan", "country_name_official_kaz", "KAZ", "KZ" },
                    { 117L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Kenya", "country_name_ken", 404, "The Republic of Kenya", "country_name_official_ken", "KEN", "KE" },
                    { 118L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Kiribati", "country_name_kir", 296, "The Republic of Kiribati", "country_name_official_kir", "KIR", "KI" },
                    { 119L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "NorthKorea", "country_name_prk", 408, "The Democratic People's Republic of Korea", "country_name_official_prk", "PRK", "KP" },
                    { 120L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "South Korea", "country_name_kor", 410, "The Republic of Korea", "country_name_official_kor", "KOR", "KR" },
                    { 121L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Kuwait", "country_name_kwt", 414, "The State of Kuwait", "country_name_official_kwt", "KWT", "KW" },
                    { 122L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Kyrgyzstan", "country_name_kgz", 417, "The Kyrgyz Republic", "country_name_official_kgz", "KGZ", "KG" },
                    { 123L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Lao People's Democratic Republic", "country_name_lao", 418, "The Lao People's Democratic Republic", "country_name_official_lao", "LAO", "LA" },
                    { 124L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Latvia", "country_name_lva", 428, "The Republic of Latvia", "country_name_official_lva", "LVA", "LV" },
                    { 125L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Lebanon", "country_name_lbn", 422, "The Lebanese Republic", "country_name_official_lbn", "LBN", "LB" },
                    { 126L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Lesotho", "country_name_lso", 426, "The Kingdom of Lesotho", "country_name_official_lso", "LSO", "LS" },
                    { 127L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Liberia", "country_name_lbr", 430, "The Republic of Liberia", "country_name_official_lbr", "LBR", "LR" },
                    { 128L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Libya", "country_name_lby", 434, "The State of Libya", "country_name_official_lby", "LBY", "LY" },
                    { 129L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Liechtenstein", "country_name_lie", 438, "The Principality of Liechtenstein", "country_name_official_lie", "LIE", "LI" },
                    { 130L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Lithuania", "country_name_ltu", 440, "The Republic of Lithuania", "country_name_official_ltu", "LTU", "LT" },
                    { 131L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Luxembourg", "country_name_lux", 442, "The Grand Duchy of Luxembourg", "country_name_official_lux", "LUX", "LU" },
                    { 132L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Macao", "country_name_mac", 446, "The Macao Special Administrative Region of China", "country_name_official_mac", "MAC", "MO" },
                    { 133L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "North Macedonia", "country_name_mkd", 807, "The Republic of North Macedonia", "country_name_official_mkd", "MKD", "MK" },
                    { 134L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Madagascar", "country_name_mdg", 450, "The Republic of Madagascar", "country_name_official_mdg", "MDG", "MG" },
                    { 135L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Malawi", "country_name_mwi", 454, "The Republic of Malawi", "country_name_official_mwi", "MWI", "MW" },
                    { 136L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Malaysia", "country_name_mys", 458, "Malaysia", "country_name_official_mys", "MYS", "MY" },
                    { 137L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Maldives", "country_name_mdv", 462, "The Republic of Maldives", "country_name_official_mdv", "MDV", "MV" },
                    { 138L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Mali", "country_name_mli", 466, "The Republic of Mali", "country_name_official_mli", "MLI", "ML" },
                    { 139L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Malta", "country_name_mlt", 470, "The Republic of Malta", "country_name_official_mlt", "MLT", "MT" },
                    { 140L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Marshall Islands", "country_name_mhl", 584, "The Republic of the Marshall Islands", "country_name_official_mhl", "MHL", "MH" },
                    { 141L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Martinique", "country_name_mtq", 474, "Martinique", "country_name_official_mtq", "MTQ", "MQ" },
                    { 142L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Mauritania", "country_name_mrt", 478, "The Islamic Republic of Mauritania", "country_name_official_mrt", "MRT", "MR" },
                    { 143L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Mauritius", "country_name_mus", 480, "The Republic of Mauritius", "country_name_official_mus", "MUS", "MU" },
                    { 144L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Mayotte", "country_name_myt", 175, "The Department of Mayotte", "country_name_official_myt", "MYT", "YT" },
                    { 145L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Mexico", "country_name_mex", 484, "The United Mexican States", "country_name_official_mex", "MEX", "MX" },
                    { 146L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Micronesia", "country_name_fsm", 583, "The Federated States of Micronesia", "country_name_official_fsm", "FSM", "FM" },
                    { 147L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Moldova", "country_name_mda", 498, "The Republic of Moldova", "country_name_official_mda", "MDA", "MD" },
                    { 148L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Monaco", "country_name_mco", 492, "The Principality of Monaco", "country_name_official_mco", "MCO", "MC" },
                    { 149L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Mongolia", "country_name_mng", 496, "Mongolia", "country_name_official_mng", "MNG", "MN" },
                    { 150L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Montenegro", "country_name_mne", 499, "Montenegro", "country_name_official_mne", "MNE", "ME" },
                    { 151L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Montserrat", "country_name_msr", 500, "Montserrat", "country_name_official_msr", "MSR", "MS" },
                    { 152L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Morocco", "country_name_mar", 504, "The Kingdom of Morocco", "country_name_official_mar", "MAR", "MA" },
                    { 153L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Mozambique", "country_name_moz", 508, "The Republic of Mozambique", "country_name_official_moz", "MOZ", "MZ" },
                    { 154L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Myanmar", "country_name_mmr", 104, "The Republic of the Union of Myanmar", "country_name_official_mmr", "MMR", "MM" },
                    { 155L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Namibia", "country_name_nam", 516, "The Republic of Namibia", "country_name_official_nam", "NAM", "NA" },
                    { 156L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Nauru", "country_name_nru", 520, "The Republic of Nauru", "country_name_official_nru", "NRU", "NR" },
                    { 157L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Nepal", "country_name_npl", 524, "The Federal Democratic Republic of Nepal", "country_name_official_npl", "NPL", "NP" },
                    { 158L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Netherlands, Kingdom of the", "country_name_nld", 528, "The Kingdom of the Netherlands", "country_name_official_nld", "NLD", "NL" },
                    { 159L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "New Caledonia", "country_name_ncl", 540, "New Caledonia", "country_name_official_ncl", "NCL", "NC" },
                    { 160L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "New Zealand", "country_name_nzl", 554, "New Zealand", "country_name_official_nzl", "NZL", "NZ" },
                    { 161L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Nicaragua", "country_name_nic", 558, "The Republic of Nicaragua", "country_name_official_nic", "NIC", "NI" },
                    { 162L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Niger", "country_name_ner", 562, "The Republic of the Niger", "country_name_official_ner", "NER", "NE" },
                    { 163L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Nigeria", "country_name_nga", 566, "The Federal Republic of Nigeria", "country_name_official_nga", "NGA", "NG" },
                    { 164L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Niue", "country_name_niu", 570, "Niue", "country_name_official_niu", "NIU", "NU" },
                    { 165L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Norfolk Island", "country_name_nfk", 574, "The Territory of Norfolk Island", "country_name_official_nfk", "NFK", "NF" },
                    { 166L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Northern Mariana Islands", "country_name_mnp", 580, "The Commonwealth of the Northern Mariana Islands", "country_name_official_mnp", "MNP", "MP" },
                    { 167L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Norway", "country_name_nor", 578, "The Kingdom of Norway", "country_name_official_nor", "NOR", "NO" },
                    { 168L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Oman", "country_name_omn", 512, "The Sultanate of Oman", "country_name_official_omn", "OMN", "OM" },
                    { 169L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Pakistan", "country_name_pak", 586, "The Islamic Republic of Pakistan", "country_name_official_pak", "PAK", "PK" },
                    { 170L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Palau", "country_name_plw", 585, "The Republic of Palau", "country_name_official_plw", "PLW", "PW" },
                    { 171L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Palestine", "country_name_pse", 275, "The State of Palestine", "country_name_official_pse", "PSE", "PS" },
                    { 172L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Panama", "country_name_pan", 591, "The Republic of Panamá", "country_name_official_pan", "PAN", "PA" },
                    { 173L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Papua New Guinea", "country_name_png", 598, "The Independent State of Papua New Guinea", "country_name_official_png", "PNG", "PG" },
                    { 174L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Paraguay", "country_name_pry", 600, "The Republic of Paraguay", "country_name_official_pry", "PRY", "PY" },
                    { 175L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Peru", "country_name_per", 604, "The Republic of Perú", "country_name_official_per", "PER", "PE" },
                    { 176L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Philippines", "country_name_phl", 608, "The Republic of the Philippines", "country_name_official_phl", "PHL", "PH" },
                    { 177L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Pitcairn", "country_name_pcn", 612, "The Pitcairn, Henderson, Ducie and Oeno Islands", "country_name_official_pcn", "PCN", "PN" },
                    { 178L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Poland", "country_name_pol", 616, "The Republic of Poland", "country_name_official_pol", "POL", "PL" },
                    { 179L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Portugal", "country_name_prt", 620, "The Portuguese Republic", "country_name_official_prt", "PRT", "PT" },
                    { 180L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Puerto Rico", "country_name_pri", 630, "The Commonwealth of Puerto Rico", "country_name_official_pri", "PRI", "PR" },
                    { 181L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Qatar", "country_name_qat", 634, "The State of Qatar", "country_name_official_qat", "QAT", "QA" },
                    { 182L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Réunion", "country_name_reu", 638, "Réunion", "country_name_official_reu", "REU", "RE" },
                    { 183L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Romania", "country_name_rou", 642, "Romania", "country_name_official_rou", "ROU", "RO" },
                    { 184L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Russia", "country_name_rus", 643, "The Russian Federation", "country_name_official_rus", "RUS", "RU" },
                    { 185L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Rwanda", "country_name_rwa", 646, "The Republic of Rwanda", "country_name_official_rwa", "RWA", "RW" },
                    { 186L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Saint Barthélemy", "country_name_blm", 652, "The Collectivity of Saint-Barthélemy", "country_name_official_blm", "BLM", "BL" },
                    { 187L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Saint Helena, Ascension and Tristan da Cunha", "country_name_shn", 654, "Saint Helena, Ascension and Tristan da Cunha", "country_name_official_shn", "SHN", "SH" },
                    { 188L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Saint Kitts and Nevis", "country_name_kna", 659, "Saint Kitts and Nevis", "country_name_official_kna", "KNA", "KN" },
                    { 189L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Saint Lucia", "country_name_lca", 662, "Saint Lucia", "country_name_official_lca", "LCA", "LC" },
                    { 190L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Saint Martin (French part)", "country_name_maf", 663, "The Collectivity of Saint-Martin", "country_name_official_maf", "MAF", "MF" },
                    { 191L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Saint Pierre and Miquelon", "country_name_spm", 666, "The Overseas Collectivity of Saint-Pierre and Miquelon", "country_name_official_spm", "SPM", "PM" },
                    { 192L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Saint Vincent and the Grenadines", "country_name_vct", 670, "Saint Vincent and the Grenadines", "country_name_official_vct", "VCT", "VC" },
                    { 193L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Samoa", "country_name_wsm", 882, "The Independent State of Samoa", "country_name_official_wsm", "WSM", "WS" },
                    { 194L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "San Marino", "country_name_smr", 674, "The Republic of San Marino", "country_name_official_smr", "SMR", "SM" },
                    { 195L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Sao Tome and Principe", "country_name_stp", 678, "The Democratic Republic of São Tomé and Príncipe", "country_name_official_stp", "STP", "ST" },
                    { 196L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Saudi Arabia", "country_name_sau", 682, "The Kingdom of Saudi Arabia", "country_name_official_sau", "SAU", "SA" },
                    { 197L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Senegal", "country_name_sen", 686, "The Republic of Senegal", "country_name_official_sen", "SEN", "SN" },
                    { 198L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Serbia", "country_name_srb", 688, "The Republic of Serbia", "country_name_official_srb", "SRB", "RS" },
                    { 199L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Seychelles", "country_name_syc", 690, "The Republic of Seychelles", "country_name_official_syc", "SYC", "SC" },
                    { 200L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Sierra Leone", "country_name_sle", 694, "The Republic of Sierra Leone", "country_name_official_sle", "SLE", "SL" },
                    { 201L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Singapore", "country_name_sgp", 702, "The Republic of Singapore", "country_name_official_sgp", "SGP", "SG" },
                    { 202L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Sint Maarten (Dutch part)", "country_name_sxm", 534, "Sint Maarten", "country_name_official_sxm", "SXM", "SX" },
                    { 203L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Slovakia", "country_name_svk", 703, "The Slovak Republic", "country_name_official_svk", "SVK", "SK" },
                    { 204L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Slovenia", "country_name_svn", 705, "The Republic of Slovenia", "country_name_official_svn", "SVN", "SI" },
                    { 205L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Solomon Islands", "country_name_slb", 90, "The Solomon Islands", "country_name_official_slb", "SLB", "SB" },
                    { 206L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Somalia", "country_name_som", 706, "The Federal Republic of Somalia", "country_name_official_som", "SOM", "SO" },
                    { 207L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "South Africa", "country_name_zaf", 710, "The Republic of South Africa", "country_name_official_zaf", "ZAF", "ZA" },
                    { 208L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "South Georgia and the South Sandwich Islands", "country_name_sgs", 239, "South Georgia and the South Sandwich Islands", "country_name_official_sgs", "SGS", "GS" },
                    { 209L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "South Sudan", "country_name_ssd", 728, "The Republic of South Sudan", "country_name_official_ssd", "SSD", "SS" },
                    { 210L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Spain", "country_name_esp", 724, "The Kingdom of Spain", "country_name_official_esp", "ESP", "ES" },
                    { 211L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Sri Lanka", "country_name_lka", 144, "The Democratic Socialist Republic of Sri Lanka", "country_name_official_lka", "LKA", "LK" },
                    { 212L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Sudan", "country_name_sdn", 729, "The Republic of the Sudan", "country_name_official_sdn", "SDN", "SD" },
                    { 213L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Suriname", "country_name_sur", 740, "The Republic of Suriname", "country_name_official_sur", "SUR", "SR" },
                    { 214L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Svalbard and Jan Mayen", "country_name_sjm", 744, "Svalbard and Jan Mayen", "country_name_official_sjm", "SJM", "SJ" },
                    { 215L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Sweden", "country_name_swe", 752, "The Kingdom of Sweden", "country_name_official_swe", "SWE", "SE" },
                    { 216L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Switzerland", "country_name_che", 756, "The Swiss Confederation", "country_name_official_che", "CHE", "CH" },
                    { 217L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Syrian Arab Republic", "country_name_syr", 760, "The Syrian Arab Republic", "country_name_official_syr", "SYR", "SY" },
                    { 218L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Taiwan (Province of China)", "country_name_twn", 158, "The Republic of China", "country_name_official_twn", "TWN", "TW" },
                    { 219L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Tajikistan", "country_name_tjk", 762, "The Republic of Tajikistan", "country_name_official_tjk", "TJK", "TJ" },
                    { 220L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Tanzania, the United Republic of", "country_name_tza", 834, "The United Republic of Tanzania", "country_name_official_tza", "TZA", "TZ" },
                    { 221L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Thailand", "country_name_tha", 764, "The Kingdom of Thailand", "country_name_official_tha", "THA", "TH" },
                    { 222L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Timor-Leste", "country_name_tls", 626, "The Democratic Republic of Timor-Leste", "country_name_official_tls", "TLS", "TL" },
                    { 223L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Togo", "country_name_tgo", 768, "The Togolese Republic", "country_name_official_tgo", "TGO", "TG" },
                    { 224L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Tokelau", "country_name_tkl", 772, "Tokelau", "country_name_official_tkl", "TKL", "TK" },
                    { 225L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Tonga", "country_name_ton", 776, "The Kingdom of Tonga", "country_name_official_ton", "TON", "TO" },
                    { 226L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Trinidad and Tobago", "country_name_tto", 780, "The Republic of Trinidad and Tobago", "country_name_official_tto", "TTO", "TT" },
                    { 227L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Tunisia", "country_name_tun", 788, "The Republic of Tunisia", "country_name_official_tun", "TUN", "TN" },
                    { 228L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Türkiye", "country_name_tur", 792, "The Republic of Türkiye", "country_name_official_tur", "TUR", "TR" },
                    { 229L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Turkmenistan", "country_name_tkm", 795, "Turkmenistan", "country_name_official_tkm", "TKM", "TM" },
                    { 230L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Turks and Caicos Islands", "country_name_tca", 796, "The Turks and Caicos Islands", "country_name_official_tca", "TCA", "TC" },
                    { 231L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Tuvalu", "country_name_tuv", 798, "Tuvalu", "country_name_official_tuv", "TUV", "TV" },
                    { 232L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Uganda", "country_name_uga", 800, "The Republic of Uganda", "country_name_official_uga", "UGA", "UG" },
                    { 233L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Ukraine", "country_name_ukr", 804, "Ukraine", "country_name_official_ukr", "UKR", "UA" },
                    { 234L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "United Arab Emirates", "country_name_are", 784, "The United Arab Emirates", "country_name_official_are", "ARE", "AE" },
                    { 235L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "United Kingdom", "country_name_gbr", 826, "The United Kingdom of Great Britain and Northern Ireland", "country_name_official_gbr", "GBR", "GB" },
                    { 236L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "United States Minor Outlying Islands", "country_name_umi", 581, "Baker Island, Howland Island, Jarvis Island, Johnston Atoll, Kingman Reef, Midway Atoll, Navassa Island, Palmyra Atoll, and Wake Island", "country_name_official_umi", "UMI", "UM" },
                    { 237L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "United States of America", "country_name_usa", 840, "The United States of America", "country_name_official_usa", "USA", "US" },
                    { 238L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Uruguay", "country_name_ury", 858, "The Oriental Republic of Uruguay", "country_name_official_ury", "URY", "UY" },
                    { 239L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Uzbekistan", "country_name_uzb", 860, "The Republic of Uzbekistan", "country_name_official_uzb", "UZB", "UZ" },
                    { 240L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Vanuatu", "country_name_vut", 548, "The Republic of Vanuatu", "country_name_official_vut", "VUT", "VU" },
                    { 241L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Venezuela", "country_name_ven", 862, "The Bolivarian Republic of Venezuela", "country_name_official_ven", "VEN", "VE" },
                    { 242L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Viet Nam", "country_name_vnm", 704, "The Socialist Republic of Viet Nam", "country_name_official_vnm", "VNM", "VN" },
                    { 243L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Virgin Islands (British)", "country_name_vgb", 92, "The Virgin Islands", "country_name_official_vgb", "VGB", "VG" },
                    { 244L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Virgin Islands (U.S.)", "country_name_vir", 850, "The Virgin Islands of the United States", "country_name_official_vir", "VIR", "VI" },
                    { 245L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Wallis and Futuna", "country_name_wlf", 876, "The Territory of the Wallis and Futuna Islands", "country_name_official_wlf", "WLF", "WF" },
                    { 246L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Western Sahara", "country_name_esh", 732, "The Sahrawi Arab Democratic Republic", "country_name_official_esh", "ESH", "EH" },
                    { 247L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Yemen", "country_name_yem", 887, "The Republic of Yemen", "country_name_official_yem", "YEM", "YE" },
                    { 248L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Zambia", "country_name_zmb", 894, "The Republic of Zambia", "country_name_official_zmb", "ZMB", "ZM" },
                    { 249L, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), "Zimbabwe", "country_name_zwe", 716, "The Republic of Zimbabwe", "country_name_official_zwe", "ZWE", "ZW" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Languages",
                columns: new[] { "LanguageId", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "Direction", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode", "ThreeLetterCode", "TwoLetterCode" },
                values: new object[,]
                {
                    { new Guid("0b79c147-cc62-4071-ada8-cb2e5d06ad72"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), "Japanese", "language_name_ja", "jpn", "ja" },
                    { new Guid("1c9985ff-2c5f-4574-a126-fd04d583c0d2"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), "Italian", "language_name_it", "ita", "it" },
                    { new Guid("2dde1e98-256b-4816-a58a-d9430982f525"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), "German", "language_name_de", "deu", "de" },
                    { new Guid("4bd4c1a1-9736-4f04-b974-90bc1cd61630"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), "English", "language_name_en", "eng", "en" },
                    { new Guid("54880bec-0fdd-4ad6-af13-9042d0916615"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), "Zulu", "language_name_zu", "zul", "zu" },
                    { new Guid("65cff48a-6729-4d4f-a974-7bc27204b09a"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), "Hindi", "language_name_hi", "hin", "hi" },
                    { new Guid("804b9015-ca16-4fb0-8cc6-20e362fb3afb"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), "French", "language_name_fr", "fra", "fr" },
                    { new Guid("884a154f-eb78-4a7a-bddc-e58ae631b884"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), "Xhosa", "language_name_xh", "xho", "xh" },
                    { new Guid("b0b595b9-5133-4d31-8218-901b6426ec0f"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), "Russian", "language_name_ru", "rus", "ru" },
                    { new Guid("c09905d9-10e4-4e61-bf83-d037533e377e"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), "Hebrew", "language_name_he", "heb", "he" },
                    { new Guid("ccb2efb1-74b4-4aca-b110-a3ba153e4b92"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), "Afrikaans", "language_name_af", "afr", "af" },
                    { new Guid("e2bd6da4-2d43-49ff-ae10-c61ebcf305b6"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, 0, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), "Chinese", "language_name_zh", "zho", "zh" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "SettingCategories",
                columns: new[] { "SystemSettingCategoryId", "CreatedBy", "CreatedTimestamp", "Description", "DescriptionTrxCode", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode" },
                values: new object[,]
                {
                    { new Guid("083ea747-18db-4048-9a8f-96aa6ded38c4"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)), "Personalization settings.", "system_setting_category_description_personalization", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)), "Personalization", "system_setting_category_personalization" },
                    { new Guid("7dc564b5-9cc9-459e-987a-695fbfcab4a0"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)), "Settings relating to rights and permissions for system access.", "setting_category_description_access_control", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)), "Access Control", "system_setting_category_access_control" },
                    { new Guid("e031d3cb-b5f7-4267-b373-d70996e70828"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)), "Localization settings.", "system_setting_category_description_localization", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)), "Localization", "system_setting_category_localization" },
                    { new Guid("edcbb17e-d9ee-481d-b79c-340858cff353"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)), "Security settings.", "system_setting_category_description_security", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)), "Security", "system_setting_category_security" },
                    { new Guid("f71b0459-44ab-499e-b5d7-afca31ab19b5"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)), "Instance settings.", "system_setting_category_description_instance", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)), "Instance", "system_setting_category_instance" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "Settings",
                columns: new[] { "SystemSettingId", "CreatedBy", "CreatedTimestamp", "DataType", "DefaultValue", "HelpText", "HelpTextTrxCode", "LastModifiedBy", "LastModifiedTimestamp", "MaximumValueLength", "MaximumValues", "MinimumValueLength", "MinimumValues", "Name", "NameTrxCode", "SettingCategoryId", "ShortDescription", "ShortDescriptionTrxCode", "UserMaySet", "Value", "ValueChoicesLookupName" },
                values: new object[,]
                {
                    { new Guid("0e5df38d-9b2a-4263-8dd2-624b3391e0dc"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), 21, "", null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, "Default Skin Tone", "system_setting_default_skin_tone", null, "The skin tone that represents the instance user.", null, true, null, null },
                    { new Guid("214315b5-6109-40ca-b23b-4419b4369de7"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), 21, "EN", null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, "Language Code", "system_setting_language_code", null, "The language code of the Astrana instance user.", null, true, null, null },
                    { new Guid("5fcf50f5-2d8a-4085-82c0-b0a6316b129f"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), 4, "AUS Eastern Standard Time", null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, "Time Zone", "system_setting_time_zone", null, "The time zone of the Astrana instance user.", null, true, null, null },
                    { new Guid("64bd6c09-bd2e-47d9-92c3-a215fd30f342"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), 4, "localhost", null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, "Host Name", "system_setting_host_name", null, "The address of the Astrana instance.", null, true, null, null },
                    { new Guid("68c8d22a-85fd-4ace-918f-33b9949ba7bb"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), 4, "", null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, "Idp Issuer Signing Key Secret", "system_setting_idp_issuer_signing_key_secret", null, "The secret used for generating the Idp Issuer Signing Key for the Astrana instance.", null, false, "69473DFCE4E2D15A343495F3612FBD2C69473DFCE4E2D15A343495F3612FBD2C", null },
                    { new Guid("8cf6f718-c898-4605-8e60-ae085b569f1d"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), 2, "", null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, "Host Port Number", "system_setting_host_port_number", null, "The host port number of the Astrana instance.", null, true, null, null },
                    { new Guid("c269f856-f3f6-48f8-a6c7-0acac6dbe50b"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), 1, "0", null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, "Multi-factor Authentication", "system_setting_multi-factor_authentication", null, "Turn multi-factor authentication on/off.", null, true, null, null },
                    { new Guid("f40d10d2-48a1-4771-b30e-abd65bc2b53d"), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), 21, "AU", null, null, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, null, "Regional Format", "system_setting_regional_format", null, "Formats for dates, times and numbers.", null, true, null, null }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "SkinTones",
                columns: new[] { "SkinToneId", "ColorCode", "CreatedBy", "CreatedTimestamp", "Description", "DescriptionTrxCode", "LastModifiedBy", "LastModifiedTimestamp", "Name", "NameTrxCode" },
                values: new object[,]
                {
                    { new Guid("13cf913a-613e-403d-a55c-5bf30a1205af"), "#6A462F", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), "", "skintone_description_dark", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), "Dark", "skintone_name_dark" },
                    { new Guid("2469a010-313c-4c7f-991d-2fab9bf2245f"), "#FADCDC", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), "", "skintone_description_light", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), "Light", "skintone_name_light" },
                    { new Guid("4b61cbb8-8c4a-4893-a73c-47fc8e0361e3"), "#A57939", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), "", "skintone_description_mediumdark", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), "MediumDark", "skintone_name_mediumdark" },
                    { new Guid("59bc3be7-4bb1-4c9d-801d-de233002e6e7"), "#DEBB90", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), "", "skintone_description_mediumlight", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), "MediumLight", "skintone_name_mediumlight" },
                    { new Guid("86146d02-a42a-4804-8d6b-1cdb90baafd7"), "#FCEA2B", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), "", "skintone_description_default", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), "Default", "skintone_name_default" },
                    { new Guid("a11a3f21-e8fa-49d3-b516-ec5b95f2fa70"), "#C19A65", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), "", "skintone_description_medium", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), "Medium", "skintone_name_medium" }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "TimeZones",
                columns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name", "CreatedBy", "CreatedTimestamp", "DaylightSavingApplies", "LastModifiedBy", "LastModifiedTimestamp", "NameTrxCode", "TimeZoneId" },
                values: new object[,]
                {
                    { "AZOT", "-1", "Azores Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_azores_time", new Guid("4ff8414a-a8f5-4414-b63b-eedc5934d304") },
                    { "CVT", "-1", "Cape Verde Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_cape_verde_time", new Guid("260699bc-fe91-44e8-b3d1-ae7820974d7f") },
                    { "EGT", "-1", "Eastern Greenland Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_eastern_greenland_time", new Guid("70e2e257-65bf-477f-b072-4a10a48164af") },
                    { "CKT", "-10", "Cook Island Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_cook_island_time", new Guid("c698cc39-5a22-4018-b69a-aaee9536439d") },
                    { "HAST", "-10", "Hawaii-Aleutian Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_hawaii-aleutian_standard_time", new Guid("bb3fa043-aa06-4778-a488-f07914ebf576") },
                    { "HST", "-10", "Hawaii Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_hawaii_standard_time", new Guid("0113cd67-280c-42a0-81fd-8f6969e3ab5e") },
                    { "TAHT", "-10", "Tahiti Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_tahiti_time", new Guid("35fe7e1d-1097-43f5-9233-cd4f556545b0") },
                    { "NUT", "-11", "Niue Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_niue_time", new Guid("334f2dfb-1186-4cd3-be60-16bde76f4610") },
                    { "SST", "-11", "Samoa Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_samoa_standard_time", new Guid("01c82835-13d0-4a15-8722-e7eeaf56df04") },
                    { "AoE", "-12", "Anywhere on Earth", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_anywhere_on_earth", new Guid("67291fd8-a782-4e54-bd63-9bd09988a290") },
                    { "FNT", "-2", "Fernando de Noronha Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_fernando_de_noronha_time", new Guid("91685b30-7211-43f5-a80e-92c17b93bda7") },
                    { "GST", "-2", "South Georgia Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_south_georgia_time", new Guid("979249a7-2eb7-4985-88b7-c3f6f69936b2") },
                    { "ADST", "-3", "Atlantic Daylight Saving Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_atlantic_daylight_saving_time", new Guid("d2cb2bd1-3794-42e6-8ef6-b1434fc71a01") },
                    { "ART", "-3", "Argentina Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_argentina_time", new Guid("cc402626-3bc9-46aa-ac9d-be13ddfc7c1a") },
                    { "BRT", "-3", "Brasília Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_brasília_time", new Guid("296760b6-f5cb-49eb-8513-b6ad10524a85") },
                    { "GFT", "-3", "French Guiana Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_french_guiana_time", new Guid("b0e0c943-be63-4e9d-876d-1ffcc47bc304") },
                    { "PMST", "-3", "Pierre & Miquelon Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_pierre_&_miquelon_standard_time", new Guid("aad28d22-d76d-409e-b9b2-5ce1c113ee86") },
                    { "ROTT", "-3", "Rothera Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_rothera_time", new Guid("b579f716-497b-4147-bb0a-4a0167b99d08") },
                    { "SRT", "-3", "Suriname Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_suriname_time", new Guid("fc0cc2da-0fbc-4bd5-87e1-2e69d822ba18") },
                    { "UYT", "-3", "Uruguay Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_uruguay_time", new Guid("2a95085b-99e2-463c-97a6-32a54b81b867") },
                    { "WGT", "-3", "Western Greenland Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_western_greenland_time", new Guid("54b6d6de-0105-4771-9c25-bdb0a5ebf39c") },
                    { "NST", "-3:30", "Newfoundland Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_newfoundland_standard_time", new Guid("c6734cef-03de-4742-8896-5c436f6ea29a") },
                    { "AMT", "-4", "Amazon Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_amazon_time", new Guid("bf96ebb0-f81a-441c-9ebc-758297316f66") },
                    { "AST", "-4", "Atlantic Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_atlantic_standard_time", new Guid("99db2735-4845-4f02-a424-4582840390b2") },
                    { "BOT", "-4", "Bolivia Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_bolivia_time", new Guid("5391feba-a260-4b22-85a9-b34244241bea") },
                    { "CIDST", "-4", "Cayman Islands Daylight Saving Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_cayman_islands_daylight_saving_time", new Guid("cd7304d0-b278-4d72-b181-ec7145845644") },
                    { "CLST", "-4", "Chile Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_chile_standard_time", new Guid("95e487fe-2164-4a9d-8690-d67316f1934c") },
                    { "CT", "-4", "Chile Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_chile_time", new Guid("109833e9-273a-4722-af21-c205a128fa7d") },
                    { "EDST", "-4", "Eastern Daylight Savings Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_eastern_daylight_savings_time", new Guid("aa078093-e096-4903-898f-2eec2f836b54") },
                    { "FKST", "-4", "Falkland Island Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_falkland_island_standard_time", new Guid("67407251-f96f-4288-9c5c-66fc30f48cd5") },
                    { "GYT", "-4", "Guyana Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_guyana_time", new Guid("7ebbcdb8-5c4f-40c6-943a-4dce73ce2111") },
                    { "PYT", "-4", "Paraguay Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_paraguay_time", new Guid("7a08b14b-ecd9-4a2a-a387-06d8571baf5a") },
                    { "VET", "-4", "Venezuelan Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_venezuelan_standard_time", new Guid("1c49bb5f-378d-4815-840e-6d89d68381a5") },
                    { "ACT", "-5", "Acre Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_acre_time", new Guid("4824fc62-b838-4493-8281-071aa5f3250d") },
                    { "CDST", "-5", "Central Daylight Saving Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_central_daylight_saving_time", new Guid("e601eb38-a7a4-43bb-82c7-2667f69772f1") },
                    { "CIST", "-5", "Cayman Islands Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_cayman_islands_standard_time", new Guid("c3855cdd-efe0-4fa2-af42-0fd9789d86ad") },
                    { "CIT", "-5", "Cayman Islands Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_cayman_islands_time", new Guid("33346f06-808e-4361-b6ab-e6d693616c24") },
                    { "COT", "-5", "Colombia Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_colombia_time", new Guid("1e2abfe9-6eb5-46a2-8697-6cf100b6503e") },
                    { "CST", "-5", "Cuba Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_cuba_standard_time", new Guid("bb72ca01-7792-45dc-8667-e7a6a9f597c0") },
                    { "ECT", "-5", "Ecuador Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_ecuador_time", new Guid("2ef808fe-bf91-47a9-b0a1-d7bb21942013") },
                    { "EST", "-5", "Eastern Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_eastern_standard_time", new Guid("81b11e80-c327-4215-b5b6-06c1bed9d154") },
                    { "ET", "-5", "Eastern Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_eastern_time", new Guid("67167fbf-34b8-439a-b54b-3318136ad2cd") },
                    { "NAEST", "-5", "North American Eastern Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_north_american_eastern_standard_time", new Guid("35a8c94e-19ac-4e16-aa8b-9b552187436b") },
                    { "PET", "-5", "Peru Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_peru_time", new Guid("0f10d3be-b945-4062-a2de-2e08a96e2e4c") },
                    { "CST", "-6", "Central Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_central_standard_time", new Guid("3ebab140-7825-46b2-b835-7745718e7e91") },
                    { "EAST", "-6", "Easter Island Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_easter_island_standard_time", new Guid("b82062f6-64cb-465d-a4cd-cb381acfefb4") },
                    { "GALT", "-6", "Galapagos Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_galapagos_time", new Guid("82c6b672-53d9-48dd-869c-2e3cd6703073") },
                    { "MDST", "-6", "Mountain Daylight Saving Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_mountain_daylight_saving_time", new Guid("85532bb2-2e45-4cfa-85de-cb1ef2264b14") },
                    { "NACST", "-6", "North American Central Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_north_american_central_standard_time", new Guid("2001cda9-cf4c-46bd-afec-471e6988bc8c") },
                    { "MST", "-7", "Mountain Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_mountain_standard_time", new Guid("d1b16860-5de1-4fc8-8362-fc4416aca8ae") },
                    { "NAMST", "-7", "North American Mountain Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_north_american_mountain_standard_time", new Guid("452598bb-ede1-40dd-9abd-6c6385d576e0") },
                    { "PDST", "-7", "Pacific Daylight Saving Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_pacific_daylight_saving_time", new Guid("dc81e266-502a-4994-b58a-40c79500a463") },
                    { "ADST", "-8", "Alaska Daylight Saving Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_alaska_daylight_saving_time", new Guid("e73df2b3-ff41-4942-aa2a-7337c360f41c") },
                    { "NAPST", "-8", "North American Pacific Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_north_american_pacific_standard_time", new Guid("5d10fb2c-6703-437b-87b0-914627c8dc32") },
                    { "PST", "-8", "Pacific Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_pacific_standard_time", new Guid("c7e3ed5b-f8a7-41ac-94ae-fdcb7f8f6bb6") },
                    { "PST", "-8", "Pitcairn Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_pitcairn_standard_time", new Guid("ce92fb1e-6f9d-47ec-ba2e-a47c4f93ff01") },
                    { "PT", "-8", "Pacific Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_pacific_time", new Guid("cf623469-da5e-40ff-b071-2c16876989b0") },
                    { "AKST", "-9", "Alaska Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_alaska_standard_time", new Guid("d0f78a94-6f49-45b7-98e0-bbecb6fa7160") },
                    { "AT", "-9", "Alaska Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_alaska_time", new Guid("96072e2c-4501-41b9-a493-6e6a0257c62a") },
                    { "GAMT", "-9", "Gambier Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_gambier_time", new Guid("ffc18fd2-1cdf-4994-883e-b69b2e6f792b") },
                    { "MART", "-9:30", "Marquesas Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_marquesas_time", new Guid("d897d9aa-b87d-45ba-b3ec-f8c0de44d048") },
                    { "GMT", "0", "Greenwich Mean Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_greenwich_mean_time", new Guid("873a0504-9711-4182-aaf3-321a04ad9805") },
                    { "WET", "0", "Western European Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_western_european_time", new Guid("db077106-e786-4e5c-9a36-3528e4da2d08") },
                    { "WT", "0", "Western Sahara Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_western_sahara_standard_time", new Guid("94b768ce-337f-4928-9500-37d4c5324e0d") },
                    { "BDST", "1", "British Daylight Saving Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_british_daylight_saving_time", new Guid("e10b6410-2003-4dab-8553-6abf16adc93c") },
                    { "CET", "1", "Central European Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_central_european_time", new Guid("9c4b54b1-bb12-4b8d-9392-a4a9605b5c56") },
                    { "ECT", "1", "European Central Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_european_central_time", new Guid("71bf7c3c-d9a7-498a-85df-01188840448f") },
                    { "IST", "1", "Irish Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_irish_standard_time", new Guid("e8623192-68a8-47b8-b98a-0f773f4b7c3d") },
                    { "WAT", "1", "West Africa Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_west_africa_time", new Guid("79370e67-54c4-4465-8adf-1ea5a20d0a75") },
                    { "AEST", "10", "Australian Eastern Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_australian_eastern_standard_time", new Guid("5b7493d6-5c86-459d-abe9-4a56eddd543f") },
                    { "AET", "10", "Australian Eastern Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_australian_eastern_time", new Guid("fc1bebce-f99a-461e-af7e-6676b32afc64") },
                    { "ChST", "10", "Chamorro Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_chamorro_standard_time", new Guid("6444400f-2b9b-4e96-be57-6701bee9452c") },
                    { "CHUT", "10", "Chuuk Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_chuuk_time", new Guid("14ee677a-86ed-4953-8ec6-c6a7fa3fa04c") },
                    { "DDUT", "10", "Dumont-d'Urville Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_dumont-d'urville_time", new Guid("ed146a84-6fde-41f8-9518-4b20ac6b2db9") },
                    { "EST", "10", "Eastern Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_eastern_standard_time", new Guid("bd6c6e9e-d361-466d-9043-9db59a71bddb") },
                    { "GST", "10", "Guam Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_guam_standard_time", new Guid("2fcec5b9-0a3c-4bec-be6c-ca17cdc18884") },
                    { "PGT", "10", "Papua New Guinea Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_papua_new_guinea_time", new Guid("9ff5c176-697d-428d-bc84-66fb597308cc") },
                    { "VLAT", "10", "Vladivostok Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_vladivostok_time", new Guid("c250bb29-58de-4314-85f8-9a567c6398e7") },
                    { "YAPT", "10", "Yap Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_yap_time", new Guid("1fdc63b0-0d2b-4e0e-9926-f25cb5f08547") },
                    { "CDST", "10:30", "Central Daylight Savings Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_central_daylight_savings_time", new Guid("1848b51b-cf61-4bfd-b3a4-183081cb3c0b") },
                    { "LHST", "10:30", "Lord Howe Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_lord_howe_standard_time", new Guid("fd85e5a7-bfed-48c3-ac80-267a491efd55") },
                    { "BST", "11", "Bougainville Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_bougainville_standard_time", new Guid("eb91a2cc-7f89-4de4-8882-f3aafd4916e1") },
                    { "EDST", "11", "Eastern Daylight Saving Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_eastern_daylight_saving_time", new Guid("454a3bea-a3f4-43bd-9249-3121dd095608") },
                    { "EFATE", "11", "Efate Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_efate_time", new Guid("5fcd18b2-5198-4f60-a617-5380f3ee265b") },
                    { "KOST", "11", "Kosrae Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_kosrae_time", new Guid("4c875850-81c6-4a3b-b1d1-99d8631653cd") },
                    { "MAGT", "11", "Magadan Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_magadan_time", new Guid("9aebcae9-0b01-432f-9d04-c8ca592f8bec") },
                    { "NCT", "11", "New Caledonia Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_new_caledonia_time", new Guid("2716818e-6769-4301-a099-9f89f03d8e29") },
                    { "NFT", "11", "Norfolk Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_norfolk_time", new Guid("0e843141-48b1-4e61-8745-b0e4c2f7b012") },
                    { "PONT", "11", "Pohnpei Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_pohnpei_standard_time", new Guid("157491e4-d8cc-4138-9aef-84a90b05c0ab") },
                    { "SAKT", "11", "Sakhalin Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_sakhalin_time", new Guid("3fe9b36a-1568-4322-b5af-692f0ab54dac") },
                    { "SBT", "11", "Solomon Islands Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_solomon_islands_time", new Guid("674fc518-d598-48e4-9028-fe0de7bb078f") },
                    { "SRET", "11", "Srednekolymsk Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_srednekolymsk_time", new Guid("67d76082-520a-4a69-9a22-8ed08e126bd0") },
                    { "VUT", "11", "Vanuatu Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_vanuatu_time", new Guid("f7312000-5524-4dd4-9b59-caeaed168f7c") },
                    { "ANAT", "12", "Anadyr Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_anadyr_time", new Guid("00499512-3437-4f1b-a53c-cd6f7d3c7ac1") },
                    { "FJT", "12", "Fiji Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_fiji_time", new Guid("2a8b2676-3725-4b76-b580-74139ac73acb") },
                    { "GILT", "12", "Gilbert Island Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_gilbert_island_time", new Guid("77d2a0f0-aef4-4ac9-be32-fe00bdab3f54") },
                    { "MHT", "12", "Marshall Islands Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_marshall_islands_time", new Guid("96e8887f-65a3-4bb9-a0ba-cc6e1455f944") },
                    { "NRT", "12", "Nauru Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_nauru_time", new Guid("7ef7d0ca-d161-4ec2-ba2f-5a49713b527c") },
                    { "NZST", "12", "New Zealand Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_new_zealand_standard_time", new Guid("5cbb59f0-178b-4fb5-981b-e37bab9c1e9c") },
                    { "PETT", "12", "Kamchatka Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_kamchatka_time", new Guid("541768f0-7a1b-4323-aa99-f897c32f2320") },
                    { "TVT", "12", "Tuvalu Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_tuvalu_time", new Guid("31af7caa-50a0-48b2-ba70-26615b345419") },
                    { "WAKT", "12", "Wake Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_wake_time", new Guid("86d2185e-6fbd-48b3-9c97-81eab528eea3") },
                    { "WFT", "12", "Wallis and Futuna Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_wallis_and_futuna_time", new Guid("ff13dd84-e10a-4643-a9d2-1ea85559334e") },
                    { "CHAST", "12:45", "Chatham Island Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_chatham_island_standard_time", new Guid("5970f57e-96dd-467c-a206-397073eb758d") },
                    { "PHOT", "13", "Phoenix Island Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_phoenix_island_time", new Guid("db57b342-401b-425d-a958-b448fcf7b1f8") },
                    { "ST", "13", "Samoa Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_samoa_time", new Guid("076a66c6-f410-479d-9af2-172a1cc07d5f") },
                    { "TKT", "13", "Tokelau Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_tokelau_time", new Guid("096bdc22-a505-4d1c-a8d2-f6c4bf5b69c7") },
                    { "TOT", "13", "Tonga Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_tonga_time", new Guid("989a7dcb-12cc-4472-933f-e77e26a60e67") },
                    { "WST", "13", "West Samoa Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_west_samoa_time", new Guid("ac84f112-f5b2-4711-a68c-2aaef1c1df47") },
                    { "LINT", "14", "Line Islands Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_line_islands_time", new Guid("4dc32b79-e034-4dc0-ae0c-5acca37ffffe") },
                    { "CAT", "2", "Central Africa Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_central_africa_time", new Guid("20b1cffe-640f-4461-b27a-8059cbb49470") },
                    { "EET", "2", "Eastern European Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_eastern_european_time", new Guid("69709005-059a-4170-875f-43f4e44b7a2b") },
                    { "IST", "2", "Israel Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_israel_standard_time", new Guid("766b0079-4253-479a-9852-4d293dcf1afc") },
                    { "SAST", "2", "South African Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_south_african_standard_time", new Guid("882bb8e6-06b0-413e-a666-671ea2156286") },
                    { "AST", "3", "Arabia Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_arabia_standard_time", new Guid("9a806572-b4e7-4d16-8277-9b76d749cc37") },
                    { "EAT", "3", "Eastern Africa Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_eastern_africa_time", new Guid("c04980a0-3d02-42d4-9ba1-cb23a88bc1cf") },
                    { "FET", "3", "Further-Eastern European Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_further-eastern_european_time", new Guid("5dc2d120-a5c1-44b3-8abf-4d23f1031c37") },
                    { "MCK", "3", "Moscow Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_moscow_time", new Guid("0c6ca9b3-71dd-4bf0-9874-595e6042b6dd") },
                    { "MSK", "3", "Moscow Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_moscow_standard_time", new Guid("6063bc96-d773-46d3-92c9-11252749d8e1") },
                    { "SYOT", "3", "Syowa Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_syowa_time", new Guid("d0a30222-db35-41c6-acf8-013a0cfcb16e") },
                    { "TRT", "3", "Turkey Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_turkey_time", new Guid("97e467df-b732-4722-9a4f-89732d41325a") },
                    { "IRST", "3:30", "Iran Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_iran_standard_time", new Guid("cbf97546-253e-4a28-800b-87a790ecf664") },
                    { "AMT", "4", "Armenia Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_armenia_time", new Guid("80a3adc6-95ae-4940-ac9f-62d65f221a08") },
                    { "AZT", "4", "Azerbaijan Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_azerbaijan_time", new Guid("7ab58eee-dae5-4f32-bc16-0df823051303") },
                    { "GET", "4", "Georgia Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_georgia_standard_time", new Guid("3311d497-cf3c-42f8-ace1-9f1bdba08572") },
                    { "GST", "4", "Gulf Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_gulf_standard_time", new Guid("3857dec2-25cb-4e94-9f4f-5a233973814f") },
                    { "KUYT", "4", "Kuybyshev Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_kuybyshev_time", new Guid("1c41e07f-7864-42b4-a5a4-4871900a6544") },
                    { "MUT", "4", "Mauritius Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_mauritius_time", new Guid("f842692d-b0ec-4aae-83a4-5b992d993a58") },
                    { "RET", "4", "Reunion Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_reunion_time", new Guid("25a11511-d966-4e1c-bf1e-d177d347abd7") },
                    { "SAMT", "4", "Samara Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_samara_standard_time", new Guid("835f13e1-fe55-42b5-917e-b7ad27bf4eaf") },
                    { "SCT", "4", "Seychelles Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_seychelles_time", new Guid("b697e7bd-0e0f-46b2-8142-db4417be8a90") },
                    { "AFT", "4:30", "Afghanistan Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_afghanistan_time", new Guid("01209189-36fa-4e14-b3eb-c887754b76b8") },
                    { "AQTT", "5", "Aqtobe Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_aqtobe_time", new Guid("0359fe57-68ba-4b4b-8776-c2bb4b08bab0") },
                    { "KIT", "5", "Kerguelen (Islands) Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_kerguelen_(islands)_time", new Guid("db8aad36-d70c-4afb-b1f6-c6bf7acd218b") },
                    { "MAWT", "5", "Mawson Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_mawson_time", new Guid("0f9ce16c-a25f-44f6-bdae-2e524a40741a") },
                    { "MVT", "5", "Maldives Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_maldives_time", new Guid("c4906f59-ef56-45a0-8b4e-4c3d98139ef6") },
                    { "ORAT", "5", "Oral Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_oral_time", new Guid("274750c4-c63f-4eb0-8114-6032606dc647") },
                    { "PKT", "5", "Pakistan Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_pakistan_standard_time", new Guid("a241c4f6-b116-4b2b-824b-5770078628d1") },
                    { "TFT", "5", "French Southern and Antarctic Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_french_southern_and_antarctic_time", new Guid("04bc44af-7ee7-4247-a61d-909aab4559cc") },
                    { "TJT", "5", "Tajikistan Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_tajikistan_time", new Guid("38de27b2-ef80-4361-91c7-bc2f3d6f1009") },
                    { "TMT", "5", "Turkmenistan Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_turkmenistan_time", new Guid("73741f9d-8458-4c05-beb2-de59e82f262a") },
                    { "UZT", "5", "Uzbekistan Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_uzbekistan_time", new Guid("a3666059-c3a5-492d-a2e8-ce6a190fa79f") },
                    { "YEKT", "5", "Yekaterinburg Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_yekaterinburg_time", new Guid("fe9d118c-e82d-47c3-85f6-8620f954013f") },
                    { "IST", "5:30", "India Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_india_standard_time", new Guid("86d21087-0bf8-4ff2-a064-279d8f6a6bbd") },
                    { "IT", "5:30", "India Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_india_time", new Guid("73d7a46b-96a3-42bf-87ae-aa58cc7b1e5d") },
                    { "NPT", "5:45", "Nepal Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_nepal_time", new Guid("215c1492-5b3b-48ff-a1b9-b25b373faa96") },
                    { "ALMT", "6", "Alma-Ata Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_alma-ata_time", new Guid("a3c67c15-0902-4299-ab8c-230a860d2bea") },
                    { "BST", "6", "Bangladesh Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_bangladesh_standard_time", new Guid("e727ccc5-7b8f-408f-aa3b-026fa30796ce") },
                    { "BTT", "6", "Bhutan Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_bhutan_time", new Guid("0ddb3db3-70a8-4b74-862e-bf16aca69c3c") },
                    { "IOT", "6", "Indian Chagos Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_indian_chagos_time", new Guid("e92362a9-ab12-4c2e-9a87-ab49a24c08ac") },
                    { "KGT", "6", "Kyrgyzstan Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_kyrgyzstan_time", new Guid("ebd45284-2c51-4656-90bf-62b71dc73c39") },
                    { "OMST", "6", "Omsk Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_omsk_standard_time", new Guid("ee822069-e036-4e7a-82de-f49870357a0f") },
                    { "QYZT", "6", "Qyzylorda Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_qyzylorda_time", new Guid("1bcd2e3a-725d-40b2-8687-3c37177f6419") },
                    { "VOST", "6", "Vostok Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_vostok_time", new Guid("fd5d9147-78c3-48ce-b05a-825a71775fee") },
                    { "CCT", "6:30", "Cocos Islands Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_cocos_islands_time", new Guid("05aa85e8-39e6-4fe9-857c-1ecf3465d913") },
                    { "MMT", "6:30", "Myanmar Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_myanmar_time", new Guid("40d700e4-cac4-4c80-8903-02f2047c979f") },
                    { "CXT", "7", "Christmas Island Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_christmas_island_time", new Guid("e4078641-ef5c-4e22-956d-739f8b21c8fb") },
                    { "DAVT", "7", "Davis Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_davis_time", new Guid("9e888ef0-963b-40bc-8f92-0bbbfe546bba") },
                    { "HOVT", "7", "Hovd Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_hovd_time", new Guid("962ef749-f27d-4810-860f-12502f414f0e") },
                    { "ICT", "7", "Indochina Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_indochina_time", new Guid("680ebeac-d333-41a4-bad3-42438fa7028a") },
                    { "KRAT", "7", "Krasnoyarsk Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_krasnoyarsk_time", new Guid("850416d4-dee9-4b35-a440-d42d3b1fe6f3") },
                    { "NOVT", "7", "Novosibirsk Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_novosibirsk_time", new Guid("74dabf98-55d8-49c7-960e-acb19d59cf6c") },
                    { "WIB", "7", "Western Indonesian Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_western_indonesian_time", new Guid("eba26378-bcce-4723-b63c-1792382a29e0") },
                    { "AWST", "8", "Australian Western Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_australian_western_standard_time", new Guid("429a37d7-d05f-4664-b2eb-9f7ef1b234a9") },
                    { "BNT", "8", "Brunei Darussalam Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_brunei_darussalam_time", new Guid("6687c1a5-b5c2-4705-bdc2-db6bbb90513e") },
                    { "CAST", "8", "Casey Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_casey_time", new Guid("c899cbcd-e481-4528-99ae-0b700ad1a910") },
                    { "CHOT", "8", "Choibalsan Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_choibalsan_time", new Guid("87688954-43c2-448d-8e3e-2211c251ef61") },
                    { "CST", "8", "China Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_china_standard_time", new Guid("5637db4f-a009-4504-b1a4-32760fc40249") },
                    { "HKT", "8", "Hong Kong Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_hong_kong_time", new Guid("0754f653-7dd2-4d86-917b-1a0f7043bf5b") },
                    { "HOVDST", "8", "Hovd Daylight Saving Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_hovd_daylight_saving_time", new Guid("50ee28ce-18b6-4641-9fe0-fc342054f2ec") },
                    { "IRKT", "8", "Irkutsk Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_irkutsk_time", new Guid("13609e04-58fb-461f-bac8-e85d5371694b") },
                    { "MST", "8", "Malaysian Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_malaysian_standard_time", new Guid("efdfedc9-1acb-4b8e-9435-2cd4c778a9ab") },
                    { "MYT", "8", "Malaysia Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_malaysia_time", new Guid("ca2d5e09-f2f0-4230-8cc9-90be4844f694") },
                    { "PHT", "8", "Philippine Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_philippine_time", new Guid("56543442-45c0-409b-a991-e2d1a1cd628d") },
                    { "PST", "8", "Philippine Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_philippine_standard_time", new Guid("c05c10c5-3f4d-4748-ac11-8d83d30a6cba") },
                    { "SGT", "8", "Singapore Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_singapore_time", new Guid("65ec1177-4fc2-4e99-b7c8-617097919b76") },
                    { "SST", "8", "Singapore Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_singapore_standard_time", new Guid("781f807e-d9fa-490e-a0d1-1c55a8073815") },
                    { "ULAT", "8", "Ulaanbaatar Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_ulaanbaatar_time", new Guid("2f2dc3f6-48b4-4d67-a16b-06beaceba2cd") },
                    { "WAT", "8", "Western Australia Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_western_australia_time", new Guid("2fec63b0-0d2b-4e0e-9926-f25cb5f08547") },
                    { "WITA", "8", "Central Indonesian Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_central_indonesian_time", new Guid("f84f3b22-7b6f-4c03-b77b-fb751bce5c14") },
                    { "WST", "8", "Western Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_western_standard_time", new Guid("caf75ecd-c0a7-4216-b50a-6f3b60b72f93") },
                    { "PYST", "8:30", "Pyongyang Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_pyongyang_standard_time", new Guid("84d204d6-bdaa-4158-94ee-ff3accf98814") },
                    { "ACWST", "8:45", "Australian Central Western Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_australian_central_western_standard_time", new Guid("e283c380-64fc-4a9d-88f5-e901af22db22") },
                    { "CHODST", "9", "Choibalsan Daylight Saving Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_choibalsan_daylight_saving_time", new Guid("9e0140cb-0ebe-46f1-af26-18ced4d07725") },
                    { "JST", "9", "Japan Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_japan_standard_time", new Guid("118b3cb8-eabd-40dc-8e5f-1c8e9c433be9") },
                    { "KST", "9", "Korea Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_korea_standard_time", new Guid("0742f884-a79c-491a-bf37-878873a6d43a") },
                    { "PWT", "9", "Palau Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_palau_time", new Guid("a46234bb-37a2-4b5a-a191-72fe94c29101") },
                    { "TLT", "9", "East Timor Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_east_timor_time", new Guid("db6bdd90-e20f-432f-9219-1686b24d2d7f") },
                    { "WIT", "9", "Eastern Indonesian Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_eastern_indonesian_time", new Guid("e54da034-5d78-47a1-993e-99917f5821e4") },
                    { "YAKT", "9", "Yakutsk Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_yakutsk_time", new Guid("daf02608-b8a1-4f35-b7f4-2e725188d153") },
                    { "ACST", "9:30", "Australian Central Standard Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_australian_central_standard_time", new Guid("b3cdda4c-4816-4f2c-b0f4-f86606936604") },
                    { "ACT", "9:30", "Australian Central Time", new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), "timezone_name_australian_central_time", new Guid("e9fa9a48-9828-4e0d-9717-ea39888457ec") }
                });

            migrationBuilder.InsertData(
                schema: "config",
                table: "TopLevelDomains",
                columns: new[] { "TopLevelDomainId", "CountryId", "CreatedBy", "CreatedTimestamp", "DeactivatedBy", "DeactivatedReason", "DeactivatedTimestamp", "Domain", "IsImplemented", "LastModifiedBy", "LastModifiedTimestamp" },
                values: new object[,]
                {
                    { new Guid("01076970-a0b9-459c-bbb9-9f72cd237296"), 223L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "tg", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("027bbb33-0052-4382-a856-8cc23146317a"), 23L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bz", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("082a73ea-8b77-4615-b29d-a65f1d749c7b"), 213L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sr", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("0848232d-0bc9-4c97-9e3b-3451aff31a58"), 214L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sj", false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("096d14ed-f8f0-4a78-8b77-8a88cb41f658"), 123L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "la", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("0a66da3e-96d9-4103-a89a-000ebeb944f9"), 150L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "me", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("0cec773c-e941-413a-874d-ab3d38927752"), 247L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ye", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("12f7d31f-0a58-43de-b583-c4e46f56e57c"), 193L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ws", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("13b3c70f-7e34-447c-91e2-633682e9260a"), 154L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mm", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("14cbb46c-532e-4382-8dde-edf9a99024d6"), 235L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gb", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("14d2b9d2-46d1-4309-a7d7-3e800835f448"), 157L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "np", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("15a158b3-4686-4210-94db-6f9b73c99332"), 206L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "so", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("15bcdf3c-f286-4a3c-bd0f-95917eeee20a"), 6L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ad", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("16b47e60-ca99-4a54-9a81-806e2b0550ab"), 96L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gy", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("17464404-ad94-4f1f-ad8f-a7e511416d9f"), 181L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "qa", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("17739145-6581-4e11-bc97-ae175fad4971"), 178L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pl", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("177d4efb-c449-4557-85e2-8d0172db92b8"), 45L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cl", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("18773161-1dc3-4e37-84a6-cf299391a93d"), 115L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "jo", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("19c1d3fb-a77b-4940-a894-5edee5df46ea"), 68L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gq", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("1b1ad134-9f6b-467a-844d-150b04906f6a"), 211L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lk", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("1d33cd4c-8242-4484-aaf5-8018f06e6e79"), 158L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nl", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("1d882cdb-bdb0-4112-95da-bcd72ed466d2"), 117L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ke", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("1ee6d7e5-dd7d-46a5-8368-dc85d3ab0001"), 15L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "at", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("1f7f99af-fb34-4b56-a343-329d2dbb4855"), 47L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cx", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("21b54c82-87be-4410-9a25-dbb0a302642c"), 128L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ly", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("21cabec1-f759-430d-952c-c77c3cd5354b"), 86L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gi", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("22a5ff07-2206-41f2-ade7-84bedeeecdd1"), 5L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "as", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("231e5098-c807-4018-9592-27c23b061d52"), 88L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gl", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("24290b68-c722-498e-aacb-b1cc94d819cd"), 103L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "is", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("242c849e-969e-494f-b500-4e56419cdbeb"), 73L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fk", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("243e7b21-2915-4711-b49f-23b99f19c928"), 12L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "am", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("244c4bab-636a-44a7-ba21-c03f75271ecc"), 212L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sd", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("24de3719-a701-4e73-8509-77ae6e04bcfa"), 121L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "kw", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("25dffe65-1896-4adf-aef6-fdf0200235ea"), 138L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ml", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("26499a54-bcab-4921-8bb4-893c2fc240e2"), 136L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "my", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("2704c9ff-fbad-4cd4-ba22-cbaeef24edd2"), 87L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gr", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("272da3e7-0123-41f0-ac51-4b0331680337"), 171L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ps", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("282f47fb-c45f-4d72-b647-c4e9d8e64060"), 241L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ve", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("29ba041e-b9cf-44c6-89ff-76ac8bfe15d0"), 92L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gt", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("29c1c3f7-88da-4549-9ab8-e7c918412f35"), 176L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ph", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("2b1115cb-1333-4712-b7ac-6de23aa84b6e"), 238L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "uy", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("2b80b7c5-d9e7-4ff5-b094-38113397cbd2"), 210L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "es", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("2b93c5ac-9c66-4aef-bac1-488b132a59dd"), 36L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bf", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("2c9b9831-025e-4293-9353-cb595572e27e"), 18L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bh", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("2dcc0d11-4051-4cc0-9c2c-a8649e4a35a5"), 149L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mn", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("32073e7a-a39f-42f7-b05e-a7d89206c78c"), 140L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mh", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("322e041d-1464-49e8-9507-89766cd99eef"), 194L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sm", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("32739830-b374-4150-80cd-d7d176e4d747"), 85L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gh", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("329648b3-9d64-4d91-abec-e0a8ca777bdd"), 99L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "va", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("34ad0d6d-a1ad-42b2-b2b3-0dd4021f49c0"), 174L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "py", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("35574551-897d-4e5d-a146-08cde064db84"), 130L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lt", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("3629aaca-b73e-42cc-b4cf-eff6daab2b06"), 244L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "vi", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("363776e7-e6d5-415f-8b5a-8813d95193f4"), 98L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hm", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("365f42ef-38a7-4d44-b0ad-4a3803300219"), 89L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gd", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("37009bc4-f2d6-4603-87f0-a4528160148e"), 79L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pf", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("3855e9b7-50f6-4315-9315-700b1c949a71"), 132L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mo", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("38c0f0f7-149c-4b78-8d77-f8d2df7c7abe"), 164L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nu", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("38eee82f-066f-4f7e-9e48-479e9a7622b8"), 151L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ms", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("391aa354-13d8-463c-9c1d-f4fd2b8cbc1c"), 168L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "om", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("3a04cc4b-6a0b-4c06-8a34-58937cfddb2f"), 195L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "st", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("3ad5680a-eb13-42ee-9718-51e33f7c5ac6"), 114L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "je", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("3ae772ca-10d1-47f6-b46a-eb8b99b7feee"), 225L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "to", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("3b4e75ed-8677-419e-97e1-0dff7cdef4f1"), 3L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "al", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("3b850cb4-7fcb-4654-95db-fd1863ab66da"), 235L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "uk", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("3c1a72b5-3977-43fc-90ca-bf9c3ec00f4e"), 220L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "tz", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("3daec8ec-d6db-4ccc-bcde-dbcd55f11f4a"), 166L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mp", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("3f2a8ebc-202e-485d-ae12-0c95e7a55057"), 216L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ch", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("3fa54555-26d6-47db-b3d9-5264f88b52c8"), 11L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ar", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("4327f779-b05c-4951-83dd-6670fc9718e8"), 239L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "uz", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("461542f0-2382-4eca-a112-f59936874d6e"), 165L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nf", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("46c6cc8e-a47a-44b9-977d-515e96f1ac7f"), 17L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bs", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("46e8ece1-fb10-4c46-9e5b-6b8390cf4cb0"), 200L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sl", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("471d291f-e795-4343-a1b4-bfbe3ffd11e5"), 135L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mw", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("48ac7530-218c-4221-bf3c-9a18f1a0d67a"), 71L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sz", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("4bac53ca-899f-40b6-bf06-56f4779023f2"), 63L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "dm", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("4c16e1ef-4e6f-4156-998f-cf1795b15180"), 198L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "rs", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("518d55c2-5ba1-4040-9b7d-c87dbfb75686"), 134L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mg", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("526d0971-5960-4c77-9c48-3febb643f904"), 120L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "kr", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("538e7585-cf50-49e2-8398-5f51e3715cd0"), 229L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "tm", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("547924e3-bcb6-4746-98d1-132a09849025"), 106L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ir", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("549a072f-92e3-461a-9b83-106ec032405b"), 93L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gg", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("55ca304d-37d6-489b-a668-fa7b01e7db9f"), 40L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cm", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("5655241a-6c36-4643-8f0d-0fd9301ff6e0"), 204L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "si", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("57384c73-511f-4488-b47c-cb5f07a44c1b"), 2L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ax", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("5820cb7e-37bf-4caa-9c70-290d3b006986"), 27L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bo", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("5865ffbe-83e8-43c5-b2a9-ad4a388dbd9a"), 48L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cc", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("592b8fa8-07b1-4633-a3a6-b7aa30b93db3"), 20L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bb", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("59316263-31f3-4b20-9605-942d8ed7b6a5"), 75L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fj", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("59cc2568-53e7-45fd-89c7-6d9827c6afbb"), 177L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pn", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("5a9a825d-28c1-4193-863b-44890f695215"), 142L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mr", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("5bc1fffa-2368-49c0-beba-d294b73f7019"), 64L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "do", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("5c1285c9-1fdc-4175-a86b-d2cca2204c03"), 122L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "kg", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("5c264b44-e8c4-4ba9-b783-0f1b7d20dc35"), 217L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sy", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("5c32fcd1-d962-458a-a888-dc6244c6cbec"), 228L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "tr", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("5cd8939b-3265-47cd-8213-6adea4b60206"), 172L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pa", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("5d033fef-c396-41e6-89c8-5e5762d79b47"), 69L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "er", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("5f8a062d-c74e-4177-a90e-84688e35c044"), 10L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ag", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("5fba22b1-1c8a-4d4e-ab27-724438068128"), 231L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "tv", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("61767884-6c42-49af-bac4-51b801ff7d1f"), 72L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "et", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("6295ca0d-2036-43f5-b5fe-7fdd8fcd395f"), 116L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "kz", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("6314d727-eba2-4083-873d-71cc4e17ddfc"), 26L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bt", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("631b262b-8290-45c3-8872-35029ee408f9"), 57L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cu", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("638b27e4-480a-4a69-9fa5-16af6b0dd940"), 183L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ro", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("63a01740-1f47-4710-8aca-9aafef4db890"), 118L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ki", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("693f9671-da6e-4689-81d7-824b1bad5275"), 139L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mt", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("69559e84-024d-4755-8c3d-a290c81ea660"), 129L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "li", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("6c3e19f3-e2bd-46eb-bc8b-3c6b9743c6b9"), 94L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gn", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("6c79cb04-864b-47f9-8684-24070424bcaa"), 209L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ss", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("6f5e92d6-71a4-42a7-97bb-75a8d03652b7"), 49L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "co", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("70a3febe-d579-4b9c-86b5-02205138a1b2"), 52L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cg", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("70e3e8f7-1e6e-440c-931a-1a287b587186"), 169L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pk", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("712b3908-161f-47cf-a068-efb65f61d900"), 222L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "tl", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("713691bf-4a8b-4df2-b00c-243f3d0b4db8"), 156L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nr", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("714d854c-604c-4410-b66d-f6a878e90405"), 59L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cy", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("717950dc-3f30-4993-aeae-0129c3babbe8"), 242L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "vn", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("72dc9f92-d8d2-44ab-a7bc-6de663734f98"), 84L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "de", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("73e2abc1-a4c8-4f37-bbe2-1926a2149c9f"), 37L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bi", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("757e6914-1de4-49fa-bb5b-55ab3095dc60"), 249L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "zw", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("75c0fe2a-e2c8-4d3f-a923-ce210d78197c"), 8L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ai", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("7714ef6d-1f97-4dc3-afde-ba48f25da95f"), 51L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cd", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("7773dba5-be41-421a-8b55-0354bfdc6c6d"), 224L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "tk", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("79056f23-4b70-426b-b660-49b8107b3599"), 24L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bj", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("79a3984a-c2cf-47a4-988c-f78a4f17f9f0"), 104L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "in", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("7aac7f8f-dae4-4cc2-a62e-da209993f3b3"), 201L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sg", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("7b58c078-ca0d-44d4-a8c9-4cc742c19467"), 161L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ni", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("7b79def5-45f7-4f9a-aaa1-af1a7c5ec268"), 109L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "im", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("7c12d733-be51-414a-8a57-627051d773d9"), 218L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "tw", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("7e89eaf1-5df9-4d1b-a65a-7ce5d76ddd16"), 67L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sv", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("7f2ba6d1-e06f-4611-bd8f-02c114df67e4"), 173L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pg", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("8138b651-d5e9-4d39-8651-769942c66a9a"), 111L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "it", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("8212ab49-52eb-4d8c-b6f6-d7cd5506aed0"), 203L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sk", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("829fc8a2-be81-47fc-b5f1-b2eff6696f1b"), 230L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "tc", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("8329f3ca-e85e-4095-a050-72d1110b0f9f"), 196L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sa", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("8531d22a-e4da-4e63-86b5-b0d87328ff5f"), 208L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gs", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("858f02d7-5995-4688-8c55-547fdeca30f5"), 152L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ma", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("866f447a-83d4-4fb7-aca1-c77226eef755"), 35L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bg", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("8678f309-eba5-4d99-a687-7ef9e58d9eda"), 125L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lb", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("87a1f57e-6536-4f11-b42d-f337d05200bf"), 55L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ci", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("87b72b9b-5267-478a-bfe2-9507ea53364a"), 144L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "yt", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("8898c6ec-a735-496b-b65b-30b822e6a2fc"), 60L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cz", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("895ab7fa-37c9-4737-96e4-2d253be74f0e"), 245L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "wf", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("8b047175-3737-4b3f-ae99-ea67c0d67dad"), 205L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sb", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("8be30ab5-dd39-454b-bd16-96d8dd142f99"), 113L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "jp", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("8c69930b-f082-420b-b5ac-b78cb758a730"), 77L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fr", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("8eaa002b-f1c4-4261-af0b-e86e93440b01"), 240L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "vu", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("8fad4d37-50c7-48e4-9aea-8405a77d5414"), 108L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ie", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("93868440-1fda-4a25-af55-cdc16cc38c2c"), 226L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "tt", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("959148f1-d193-4660-a5ea-6c8cda370402"), 145L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mx", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("95bd15fb-6ef0-48eb-a736-41db6e9f03c2"), 44L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "td", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("96f0c18f-2740-4c02-a7bf-173adbc28fe0"), 155L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "na", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("979c5434-7118-42fe-bbc7-75ec8cb3c90c"), 9L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "aq", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("986d0e8a-8516-45fc-a5e1-36c50ecde14b"), 232L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ug", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("98be3bcc-0378-44ef-8927-7680c7473810"), 175L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pe", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("98cef487-f352-4560-9af1-8a7459c875dd"), 65L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ec", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("98efb068-36e3-437d-978a-9caeac2f3eac"), 46L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cn", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("99b4c15d-370b-4c55-8f92-96d4bda19a1b"), 58L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cw", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("9c93b5eb-b1f8-4f7c-b9fd-f34da6e796ad"), 137L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mv", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("9cd198db-fc95-4f79-b0da-9be5f4b7f142"), 91L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gu", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("9d1ebe67-954b-4217-9b82-18bb08b1ede2"), 1L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "af", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("9dbffd7b-975b-4c45-b6a1-0d64fb2ad789"), 192L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "vc", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("9e711ee1-98f0-4108-9d40-f150e28d641e"), 95L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gw", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("a1bbea9c-58e7-452b-a2f8-c423d96d283b"), 191L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pm", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("a2fbe716-24cc-4d58-814e-771095de536b"), 78L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gf", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("a4073ec0-ad1a-4df6-a119-88dee82df613"), 199L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sc", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("a4c42c23-5b01-430e-863e-42f24c3b8a17"), 30L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bw", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("a5a092e1-f558-42d5-92ff-8f5ffbfaa7a0"), 119L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "kp", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("a75729ff-a31a-4e6a-84b0-5938827ba81d"), 80L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "tf", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("a849b003-a398-4e67-b90c-bd96df8ae9a8"), 66L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "eg", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("a8b459aa-9b88-46fa-8ec0-80a6fe557dda"), 42L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ky", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("aa28c7b2-c93e-46c5-9ad6-569879fc2eb9"), 182L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "re", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("aa2cefc3-4bfa-48dc-871f-1132220f96e7"), 76L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fi", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("aa85e0ce-869c-4dbf-89bd-4a55f8adbede"), 146L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fm", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("aabd4404-5baa-43a5-b2a2-4a1b32f95463"), 207L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "za", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("ab57b3ef-2aa1-468d-addd-a354d49dc19b"), 248L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "zm", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("ad23df61-dfab-446c-a929-2f4bcb1b70f3"), 56L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hr", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("adafb987-5c82-4065-ba45-649d02b83887"), 22L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "be", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("adf86d89-c120-4cd0-9841-5664b280ede2"), 21L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "by", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("ae7efee8-69d2-42d9-87d1-7f46caba780f"), 237L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "us", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("aeb16ed5-49cc-4a0e-8f2c-ba05910ebd6d"), 170L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pw", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("b040474e-6e2b-40c4-93f2-9548e6029910"), 34L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bn", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("b18ee36d-7a38-475c-92db-f1e5f8f09bf8"), 233L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ua", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("b4a8bfad-6cb2-4b9a-beb7-17c387de97d4"), 179L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pt", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("b504c431-262c-423d-91f6-e1bf8ef6b3bd"), 70L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ee", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("b549762e-ec4a-481c-973c-41bb2639ac45"), 39L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "kh", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("b5dd4c70-f997-46b4-a036-1731ccaca068"), 110L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "il", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("b6bd87db-9300-4eb0-8cf0-99aeb4a639d2"), 202L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sx", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("b935b965-c9c4-4c99-8121-c3e846ddba7f"), 43L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cf", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("ba7f56ea-5251-41e0-9a05-668f03d7136a"), 124L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lv", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("bae6ac01-31bc-49b8-ba4f-a173b2fd91a0"), 221L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "th", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("bec2168d-88b3-4df0-80ce-0dbf52007b1b"), 74L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "fo", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("c3fdd866-61ef-4b00-a987-d07e4360d53a"), 112L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "jm", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("c8d80c6f-2fc4-45b6-b467-50101d7edae3"), 102L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hu", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("c96d1172-f011-445d-9829-e5ba02e71e73"), 33L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "io", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("cbd0c1e4-9412-470f-8800-589f335108cf"), 159L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nc", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("cbe95acb-be87-4312-8188-63ceb7910b76"), 127L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lr", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("cc134b62-7d4a-4c4b-9692-a0509587ad77"), 62L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "dj", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("cdb9c0c0-a71f-4c33-907a-0b73ec9e3494"), 101L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hk", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("ce010369-d47f-4f49-addb-479a71187804"), 184L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ru", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("ce0ddfdf-bc22-4f6a-b275-80f30694fea5"), 7L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ao", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("ce63f14b-bac6-4177-9052-17c1991c8cc7"), 81L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ga", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("cf9e7090-6017-42d1-a39d-1bcdbc528efa"), 141L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mq", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("d1a91fe6-6e54-4e58-854c-bbc9f08f22dd"), 215L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "se", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("d1de73df-2aff-40df-8d33-3f0d2fbd9fce"), 188L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "kn", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("d387e16c-fc7e-401f-bcd3-f477442b59e0"), 54L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cr", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("d3934553-d09a-41a0-99c4-e496dadf3dd3"), 107L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "iq", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("d46b95ee-a45b-4716-942c-3874c1712bc5"), 25L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bm", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("d55ecbcc-c82e-4700-8b8d-a366a59e1683"), 153L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mz", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("d5a696c9-9ab0-40ee-a852-5e2ba9fcc3e6"), 185L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "rw", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("d72332ad-b0ce-4a29-a952-765e59845a75"), 53L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ck", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("d72a661e-f903-4c18-9d54-79a01202ed4c"), 100L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "hn", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("d9d19544-7a33-45d7-a2bb-cdcdfea97978"), 4L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "dz", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("dc57ce7d-8505-49f7-a3c4-5c18d9f46cbb"), 243L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "vg", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("de037e52-f4e7-4c5a-91f4-01359cc2f079"), 133L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mk", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("de652552-27bc-4c9f-a534-f9df8e604b61"), 162L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ne", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("de764772-3dc3-4070-b7d2-2a9c76d0e218"), 28L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bq.nl", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("de7ff6b2-a744-4e24-a2cf-a48f009cdd69"), 227L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "tn", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("de953436-e182-499d-b96e-60c211efd1c1"), 13L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "aw", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("df414d00-7ab9-4a9a-a7ae-398e1710ef73"), 14L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "au", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("df4e4296-7cd4-4778-8a2b-9101821e79e0"), 16L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "az", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("dfe6e493-a9c2-4c01-bfb0-beee778d22f3"), 126L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ls", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("e2d93796-9abb-4c48-b0f6-90c5b9a60279"), 105L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "id", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("e31209a8-17e7-4ecf-a35e-12b2da46f53b"), 61L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "dk", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("e3e8ed55-cd64-4e77-b5da-941c404f57bf"), 131L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lu", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("e48542d6-f4c2-49c0-8c91-b49be0111c27"), 97L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ht", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("e505010c-3a42-4159-9739-9116eb8cdda0"), 180L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "pr", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("e7028f53-6739-4225-9469-feaca3342954"), 234L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ae", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("e8e2d7ce-a26e-404c-a1ed-3846d4272334"), 236L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "um", false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("e97eb580-accf-41e8-89a6-d4566760fa58"), 82L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gm", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("e9d1a276-b1d9-4876-b6a5-86c5e98f3f78"), 189L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "lc", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("eb2b848e-d50a-4fe5-9595-83fa517b2ec2"), 41L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ca", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("ef453f4f-de94-4b8c-82e6-9d5f3f80c70b"), 197L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sn", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("efb0ced7-2466-4cbb-8a20-3d22f78846d1"), 190L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mf", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("efc58f9c-5181-4b19-ba82-2a561f3a595b"), 32L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "br", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("f105a9ff-e39d-4951-aa58-72df41889849"), 148L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mc", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("f2c4f97c-fa1c-44cb-b966-569ea362a6ca"), 246L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "eh", false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("f3090090-f8b7-47d5-b1c4-8ce05d1675f5"), 50L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "km", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("f3a9dc6a-d43d-48dc-92ce-5a7b3333042e"), 31L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bv", false, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("f4dffff9-2487-404a-a554-baf7bffcfd70"), 219L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "tj", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("f733f17f-8a75-47f4-9a73-244d40b760e7"), 143L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "mu", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("f75b6c2a-b5ff-404b-a9f2-2a5bfd304360"), 29L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ba", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("f884da6a-89a5-4ce5-8049-d2fe5c2284a5"), 160L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "nz", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("f90b4cb5-0bda-4589-9ca9-0184be138d4a"), 167L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "no", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("fa02111a-ed52-4591-b4da-170e4bc6f1b9"), 147L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "md", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("fa031865-4cc2-450f-9e11-7cea1a3fa538"), 163L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ng", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("fb293bd9-23e0-4a47-872d-69ca4d8b8916"), 90L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "gp", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("fb97cb17-0371-49e6-b7ac-57cc94a09f61"), 186L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bl", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("fde1117b-bc0b-4482-ad7c-7a02a2653d20"), 83L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "ge", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("fe13ad03-b316-4eec-92e9-1f9ddeb70073"), 38L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "cv", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("fe4e1316-c338-4f47-b493-23b0d11ecd62"), 187L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "sh", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) },
                    { new Guid("ff70b70d-5ad9-4384-8618-f38aa3b71428"), 19L, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), null, null, null, "bd", true, new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) }
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
                name: "IX_Audiences_NameTrxCode",
                schema: "config",
                table: "Audiences",
                column: "NameTrxCode",
                unique: true,
                filter: "[NameTrxCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Audiences_UserProfileDetailId",
                schema: "config",
                table: "Audiences",
                column: "UserProfileDetailId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TargetAudioId",
                schema: "content",
                table: "Comments",
                column: "TargetAudioId");

            migrationBuilder.CreateIndex(
                name: "IX_Comments_TargetCommentId",
                schema: "content",
                table: "Comments",
                column: "TargetCommentId");

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
                name: "IX_Countries_NameTrxCode",
                schema: "config",
                table: "Countries",
                column: "NameTrxCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Countries_NumberCode",
                schema: "config",
                table: "Countries",
                column: "NumberCode",
                unique: true,
                filter: "[NumberCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_OfficialNameTrxCode",
                schema: "config",
                table: "Countries",
                column: "OfficialNameTrxCode",
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
                name: "IX_CountryTimeZone_TimeZonesCorrespondingUtcZone_TimeZonesAbbreviation_TimeZonesName",
                schema: "config",
                table: "CountryTimeZone",
                columns: new[] { "TimeZonesCorrespondingUtcZone", "TimeZonesAbbreviation", "TimeZonesName" });

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
                schema: "content",
                table: "Feelings",
                column: "NameTrxCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_FeelingTemplates_NameTrxCode",
                schema: "config",
                table: "FeelingTemplates",
                column: "NameTrxCode",
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
                name: "IX_Peers_Address",
                schema: "dbo",
                table: "Peers",
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
                name: "IX_Peers_PeerCircleId",
                schema: "dbo",
                table: "Peers",
                column: "PeerCircleId");

            migrationBuilder.CreateIndex(
                name: "IX_Peers_VirtualProfileId",
                schema: "dbo",
                table: "Peers",
                column: "VirtualProfileId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PostAttachments_AudioClipId",
                schema: "content",
                table: "PostAttachments",
                column: "AudioClipId");

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
                schema: "content",
                table: "Reactions",
                column: "NameTrxCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReactionTemplates_NameTrxCode",
                schema: "config",
                table: "ReactionTemplates",
                column: "NameTrxCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_SettingCategories_DescriptionTrxCode",
                schema: "config",
                table: "SettingCategories",
                column: "DescriptionTrxCode",
                unique: true,
                filter: "[DescriptionTrxCode] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_SettingCategories_NameTrxCode",
                schema: "config",
                table: "SettingCategories",
                column: "NameTrxCode",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Settings_NameTrxCode",
                schema: "config",
                table: "Settings",
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
                name: "IX_Tags_Text",
                schema: "content",
                table: "Tags",
                column: "Text",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TopLevelDomains_CountryId",
                schema: "config",
                table: "TopLevelDomains",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_TopLevelDomains_Domain",
                schema: "config",
                table: "TopLevelDomains",
                column: "Domain",
                unique: true);

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
                unique: true,
                filter: "[PhoneNumber] IS NOT NULL");

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
                name: "IX_UserProfiles_CoverPictureImageId",
                schema: "user",
                table: "UserProfiles",
                column: "CoverPictureImageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_CoverPicturesCollectionContentCollectionId",
                schema: "user",
                table: "UserProfiles",
                column: "CoverPicturesCollectionContentCollectionId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_ProfilePictureImageId",
                schema: "user",
                table: "UserProfiles",
                column: "ProfilePictureImageId");

            migrationBuilder.CreateIndex(
                name: "IX_UserProfiles_ProfilePicturesCollectionContentCollectionId",
                schema: "user",
                table: "UserProfiles",
                column: "ProfilePicturesCollectionContentCollectionId");

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
                name: "CountryTimeZone",
                schema: "config");

            migrationBuilder.DropTable(
                name: "ExternalContentSubscriptions",
                schema: "content");

            migrationBuilder.DropTable(
                name: "FeatureToggles",
                schema: "config");

            migrationBuilder.DropTable(
                name: "FeelingTemplates",
                schema: "config");

            migrationBuilder.DropTable(
                name: "Languages",
                schema: "config");

            migrationBuilder.DropTable(
                name: "MessengerUsernameRel",
                schema: "user");

            migrationBuilder.DropTable(
                name: "NewContentWorkflowStage",
                schema: "workflow");

            migrationBuilder.DropTable(
                name: "Notifications",
                schema: "workflow");

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
                schema: "content");

            migrationBuilder.DropTable(
                name: "ReactionTemplates",
                schema: "config");

            migrationBuilder.DropTable(
                name: "Settings",
                schema: "config");

            migrationBuilder.DropTable(
                name: "SkinTones",
                schema: "config");

            migrationBuilder.DropTable(
                name: "Tags",
                schema: "content");

            migrationBuilder.DropTable(
                name: "TopLevelDomains",
                schema: "config");

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
                name: "TimeZones",
                schema: "config");

            migrationBuilder.DropTable(
                name: "InstantMessengerUsernames",
                schema: "contact");

            migrationBuilder.DropTable(
                name: "PeerCircles",
                schema: "dbo");

            migrationBuilder.DropTable(
                name: "AudioClips",
                schema: "content");

            migrationBuilder.DropTable(
                name: "Feelings",
                schema: "content");

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
                name: "Countries",
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
                name: "Audiences",
                schema: "config");

            migrationBuilder.DropTable(
                name: "UserProfileDetails",
                schema: "user");

            migrationBuilder.DropTable(
                name: "UserProfiles",
                schema: "user");

            migrationBuilder.DropTable(
                name: "ContentCollections",
                schema: "content");

            migrationBuilder.DropTable(
                name: "Images",
                schema: "content");

            migrationBuilder.DropTable(
                name: "UserAccounts",
                schema: "iam");
        }
    }
}
