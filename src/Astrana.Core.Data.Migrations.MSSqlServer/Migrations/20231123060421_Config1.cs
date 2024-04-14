using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Astrana.Core.Data.Migrations.MSSqlServer.Migrations
{
    /// <inheritdoc />
    public partial class Config1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MiddleNames",
                schema: "user",
                table: "UserProfiles",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModifiedTimestamp",
                schema: "config",
                table: "SkinTones",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset")
                .OldAnnotation("Relational:ColumnOrder", 99999);

            migrationBuilder.AlterColumn<Guid>(
                name: "LastModifiedBy",
                schema: "config",
                table: "SkinTones",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .OldAnnotation("Relational:ColumnOrder", 99997);

            migrationBuilder.AlterColumn<string>(
                name: "DescriptionTrxCode",
                schema: "config",
                table: "SkinTones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .OldAnnotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "config",
                table: "SkinTones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedTimestamp",
                schema: "config",
                table: "SkinTones",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset")
                .OldAnnotation("Relational:ColumnOrder", 99998);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                schema: "config",
                table: "SkinTones",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .OldAnnotation("Relational:ColumnOrder", 99996);

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Audiences",
                keyColumn: "AudienceId",
                keyValue: new Guid("0b255ccf-19e4-49c0-a3e0-d8513416d52d"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(4626), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(4626), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Audiences",
                keyColumn: "AudienceId",
                keyValue: new Guid("0c4e6f37-09af-4b5b-9081-42368f9884ea"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(4626), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(4626), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Audiences",
                keyColumn: "AudienceId",
                keyValue: new Guid("7255b812-56c0-4293-ba3e-f3a28e7256e3"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(4626), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(4626), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Audiences",
                keyColumn: "AudienceId",
                keyValue: new Guid("94b9b87c-a0a1-4721-a905-897b12e81fc7"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(4626), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(4626), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 5L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 6L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 7L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 8L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 9L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 10L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 11L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 12L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 13L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 14L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 15L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 16L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 17L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 18L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 19L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 20L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 21L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 22L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 23L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 24L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 25L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 26L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 27L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 28L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 29L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 30L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 31L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 32L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 33L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 34L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 35L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 36L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 37L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 38L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 39L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 40L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 41L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 42L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 43L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 44L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 45L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 46L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 47L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 48L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 49L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 50L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 51L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 52L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 53L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 54L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 55L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 56L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 57L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 58L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 59L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 60L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 61L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 62L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 63L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 64L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 65L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 66L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 67L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 68L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 69L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 70L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 71L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 72L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 73L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 74L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 75L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 76L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 77L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 78L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 79L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 80L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 81L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 82L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 83L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 84L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 85L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 86L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 87L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 88L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 89L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 90L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 91L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 92L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 93L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 94L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 95L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 96L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 97L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 98L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 99L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 100L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 101L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 102L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 103L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 104L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 105L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 106L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 107L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 108L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 109L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 110L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 111L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 112L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 113L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 114L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 115L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 116L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 117L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 118L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 119L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 120L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 121L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 122L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 123L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 124L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 125L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 126L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 127L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 128L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 129L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 130L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 131L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 132L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 133L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 134L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 135L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 136L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 137L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 138L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 139L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 140L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 141L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 142L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 143L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 144L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 145L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 146L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 147L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 148L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 149L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 150L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 151L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 152L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 153L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 154L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 155L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 156L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 157L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 158L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 159L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 160L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 161L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 162L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 163L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 164L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 165L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 166L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 167L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 168L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 169L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 170L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 171L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 172L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 173L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 174L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 175L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 176L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 177L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 178L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 179L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 180L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 181L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 182L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 183L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 184L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 185L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 186L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 187L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 188L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 189L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 190L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 191L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 192L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 193L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 194L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 195L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 196L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 197L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 198L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 199L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 200L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 201L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 202L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 203L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 204L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 205L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 206L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 207L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 208L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 209L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 210L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 211L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 212L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 213L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 214L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 215L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 216L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 217L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 218L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 219L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 220L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 221L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 222L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 223L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 224L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 225L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 226L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 227L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 228L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 229L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 230L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 231L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 232L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 233L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 234L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 235L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 236L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 237L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 238L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 239L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 240L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 241L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 242L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 243L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 244L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 245L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 246L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 247L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 248L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 249L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2295), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("0b79c147-cc62-4071-ada8-cb2e5d06ad72"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("1c9985ff-2c5f-4574-a126-fd04d583c0d2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("2dde1e98-256b-4816-a58a-d9430982f525"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("4bd4c1a1-9736-4f04-b974-90bc1cd61630"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("54880bec-0fdd-4ad6-af13-9042d0916615"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("65cff48a-6729-4d4f-a974-7bc27204b09a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("804b9015-ca16-4fb0-8cc6-20e362fb3afb"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("884a154f-eb78-4a7a-bddc-e58ae631b884"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("b0b595b9-5133-4d31-8218-901b6426ec0f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("c09905d9-10e4-4e61-bf83-d037533e377e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("ccb2efb1-74b4-4aca-b110-a3ba153e4b92"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e2bd6da4-2d43-49ff-ae10-c61ebcf305b6"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(2047), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SettingCategories",
                keyColumn: "SystemSettingCategoryId",
                keyValue: new Guid("083ea747-18db-4048-9a8f-96aa6ded38c4"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 679, DateTimeKind.Unspecified).AddTicks(9762), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 679, DateTimeKind.Unspecified).AddTicks(9762), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SettingCategories",
                keyColumn: "SystemSettingCategoryId",
                keyValue: new Guid("7dc564b5-9cc9-459e-987a-695fbfcab4a0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 679, DateTimeKind.Unspecified).AddTicks(9762), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 679, DateTimeKind.Unspecified).AddTicks(9762), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SettingCategories",
                keyColumn: "SystemSettingCategoryId",
                keyValue: new Guid("e031d3cb-b5f7-4267-b373-d70996e70828"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 679, DateTimeKind.Unspecified).AddTicks(9762), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 679, DateTimeKind.Unspecified).AddTicks(9762), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SettingCategories",
                keyColumn: "SystemSettingCategoryId",
                keyValue: new Guid("edcbb17e-d9ee-481d-b79c-340858cff353"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 679, DateTimeKind.Unspecified).AddTicks(9762), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 679, DateTimeKind.Unspecified).AddTicks(9762), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SettingCategories",
                keyColumn: "SystemSettingCategoryId",
                keyValue: new Guid("f71b0459-44ab-499e-b5d7-afca31ab19b5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 679, DateTimeKind.Unspecified).AddTicks(9762), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 679, DateTimeKind.Unspecified).AddTicks(9762), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("0e5df38d-9b2a-4263-8dd2-624b3391e0dc"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("214315b5-6109-40ca-b23b-4419b4369de7"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("5fcf50f5-2d8a-4085-82c0-b0a6316b129f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("64bd6c09-bd2e-47d9-92c3-a215fd30f342"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("68c8d22a-85fd-4ace-918f-33b9949ba7bb"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("8cf6f718-c898-4605-8e60-ae085b569f1d"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("c269f856-f3f6-48f8-a6c7-0acac6dbe50b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("f40d10d2-48a1-4771-b30e-abd65bc2b53d"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(299), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SkinTones",
                keyColumn: "SkinToneId",
                keyValue: new Guid("13cf913a-613e-403d-a55c-5bf30a1205af"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SkinTones",
                keyColumn: "SkinToneId",
                keyValue: new Guid("2469a010-313c-4c7f-991d-2fab9bf2245f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SkinTones",
                keyColumn: "SkinToneId",
                keyValue: new Guid("4b61cbb8-8c4a-4893-a73c-47fc8e0361e3"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SkinTones",
                keyColumn: "SkinToneId",
                keyValue: new Guid("59bc3be7-4bb1-4c9d-801d-de233002e6e7"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SkinTones",
                keyColumn: "SkinToneId",
                keyValue: new Guid("86146d02-a42a-4804-8d6b-1cdb90baafd7"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SkinTones",
                keyColumn: "SkinToneId",
                keyValue: new Guid("a11a3f21-e8fa-49d3-b516-ec5b95f2fa70"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(596), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AZOT", "-1", "Azores Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CVT", "-1", "Cape Verde Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EGT", "-1", "Eastern Greenland Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CKT", "-10", "Cook Island Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "HAST", "-10", "Hawaii-Aleutian Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "HST", "-10", "Hawaii Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TAHT", "-10", "Tahiti Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NUT", "-11", "Niue Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SST", "-11", "Samoa Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AoE", "-12", "Anywhere on Earth" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "FNT", "-2", "Fernando de Noronha Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GST", "-2", "South Georgia Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ADST", "-3", "Atlantic Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ART", "-3", "Argentina Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "BRT", "-3", "Brasília Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GFT", "-3", "French Guiana Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PMST", "-3", "Pierre & Miquelon Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ROTT", "-3", "Rothera Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SRT", "-3", "Suriname Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "UYT", "-3", "Uruguay Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WGT", "-3", "Western Greenland Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NST", "-3:30", "Newfoundland Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AMT", "-4", "Amazon Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AST", "-4", "Atlantic Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "BOT", "-4", "Bolivia Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CIDST", "-4", "Cayman Islands Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CLST", "-4", "Chile Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CT", "-4", "Chile Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EDST", "-4", "Eastern Daylight Savings Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "FKST", "-4", "Falkland Island Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GYT", "-4", "Guyana Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PYT", "-4", "Paraguay Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "VET", "-4", "Venezuelan Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ACT", "-5", "Acre Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CDST", "-5", "Central Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CIST", "-5", "Cayman Islands Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CIT", "-5", "Cayman Islands Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "COT", "-5", "Colombia Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CST", "-5", "Cuba Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ECT", "-5", "Ecuador Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EST", "-5", "Eastern Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ET", "-5", "Eastern Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NAEST", "-5", "North American Eastern Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PET", "-5", "Peru Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CST", "-6", "Central Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EAST", "-6", "Easter Island Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GALT", "-6", "Galapagos Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MDST", "-6", "Mountain Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NACST", "-6", "North American Central Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MST", "-7", "Mountain Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NAMST", "-7", "North American Mountain Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PDST", "-7", "Pacific Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ADST", "-8", "Alaska Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NAPST", "-8", "North American Pacific Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PST", "-8", "Pacific Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PST", "-8", "Pitcairn Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PT", "-8", "Pacific Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AKST", "-9", "Alaska Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AT", "-9", "Alaska Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GAMT", "-9", "Gambier Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MART", "-9:30", "Marquesas Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GMT", "0", "Greenwich Mean Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WET", "0", "Western European Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WT", "0", "Western Sahara Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "BDST", "1", "British Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CET", "1", "Central European Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ECT", "1", "European Central Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "IST", "1", "Irish Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WAT", "1", "West Africa Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AEST", "10", "Australian Eastern Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AET", "10", "Australian Eastern Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ChST", "10", "Chamorro Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CHUT", "10", "Chuuk Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "DDUT", "10", "Dumont-d'Urville Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EST", "10", "Eastern Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GST", "10", "Guam Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PGT", "10", "Papua New Guinea Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "VLAT", "10", "Vladivostok Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "YAPT", "10", "Yap Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CDST", "10:30", "Central Daylight Savings Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "LHST", "10:30", "Lord Howe Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "BST", "11", "Bougainville Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EDST", "11", "Eastern Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EFATE", "11", "Efate Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "KOST", "11", "Kosrae Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MAGT", "11", "Magadan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NCT", "11", "New Caledonia Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NFT", "11", "Norfolk Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PONT", "11", "Pohnpei Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SAKT", "11", "Sakhalin Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SBT", "11", "Solomon Islands Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SRET", "11", "Srednekolymsk Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "VUT", "11", "Vanuatu Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ANAT", "12", "Anadyr Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "FJT", "12", "Fiji Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GILT", "12", "Gilbert Island Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MHT", "12", "Marshall Islands Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NRT", "12", "Nauru Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NZST", "12", "New Zealand Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PETT", "12", "Kamchatka Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TVT", "12", "Tuvalu Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WAKT", "12", "Wake Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WFT", "12", "Wallis and Futuna Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CHAST", "12:45", "Chatham Island Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PHOT", "13", "Phoenix Island Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ST", "13", "Samoa Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TKT", "13", "Tokelau Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TOT", "13", "Tonga Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WST", "13", "West Samoa Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "LINT", "14", "Line Islands Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CAT", "2", "Central Africa Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EET", "2", "Eastern European Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "IST", "2", "Israel Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SAST", "2", "South African Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AST", "3", "Arabia Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EAT", "3", "Eastern Africa Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "FET", "3", "Further-Eastern European Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MCK", "3", "Moscow Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MSK", "3", "Moscow Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SYOT", "3", "Syowa Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TRT", "3", "Turkey Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "IRST", "3:30", "Iran Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AMT", "4", "Armenia Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AZT", "4", "Azerbaijan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GET", "4", "Georgia Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GST", "4", "Gulf Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "KUYT", "4", "Kuybyshev Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MUT", "4", "Mauritius Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "RET", "4", "Reunion Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SAMT", "4", "Samara Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SCT", "4", "Seychelles Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AFT", "4:30", "Afghanistan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AQTT", "5", "Aqtobe Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "KIT", "5", "Kerguelen (Islands) Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MAWT", "5", "Mawson Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MVT", "5", "Maldives Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ORAT", "5", "Oral Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PKT", "5", "Pakistan Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TFT", "5", "French Southern and Antarctic Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TJT", "5", "Tajikistan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TMT", "5", "Turkmenistan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "UZT", "5", "Uzbekistan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "YEKT", "5", "Yekaterinburg Time" },
                columns: new[] { "CreatedBy", "CreatedTimestamp", "LastModifiedBy", "LastModifiedTimestamp" },
                values: new object[] { new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new Guid("00000000-0000-0000-0000-000000000000"), new DateTimeOffset(new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "IST", "5:30", "India Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "IT", "5:30", "India Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NPT", "5:45", "Nepal Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ALMT", "6", "Alma-Ata Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "BST", "6", "Bangladesh Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "BTT", "6", "Bhutan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "IOT", "6", "Indian Chagos Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "KGT", "6", "Kyrgyzstan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "OMST", "6", "Omsk Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "QYZT", "6", "Qyzylorda Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "VOST", "6", "Vostok Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CCT", "6:30", "Cocos Islands Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MMT", "6:30", "Myanmar Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CXT", "7", "Christmas Island Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "DAVT", "7", "Davis Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "HOVT", "7", "Hovd Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ICT", "7", "Indochina Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "KRAT", "7", "Krasnoyarsk Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NOVT", "7", "Novosibirsk Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WIB", "7", "Western Indonesian Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AWST", "8", "Australian Western Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "BNT", "8", "Brunei Darussalam Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CAST", "8", "Casey Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CHOT", "8", "Choibalsan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CST", "8", "China Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "HKT", "8", "Hong Kong Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "HOVDST", "8", "Hovd Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "IRKT", "8", "Irkutsk Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MST", "8", "Malaysian Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MYT", "8", "Malaysia Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PHT", "8", "Philippine Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PST", "8", "Philippine Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SGT", "8", "Singapore Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SST", "8", "Singapore Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ULAT", "8", "Ulaanbaatar Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WAT", "8", "Western Australia Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WITA", "8", "Central Indonesian Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WST", "8", "Western Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PYST", "8:30", "Pyongyang Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ACWST", "8:45", "Australian Central Western Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CHODST", "9", "Choibalsan Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "JST", "9", "Japan Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "KST", "9", "Korea Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PWT", "9", "Palau Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TLT", "9", "East Timor Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WIT", "9", "Eastern Indonesian Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "YAKT", "9", "Yakutsk Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ACST", "9:30", "Australian Central Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ACT", "9:30", "Australian Central Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("01076970-a0b9-459c-bbb9-9f72cd237296"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("027bbb33-0052-4382-a856-8cc23146317a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("082a73ea-8b77-4615-b29d-a65f1d749c7b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("0848232d-0bc9-4c97-9e3b-3451aff31a58"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("096d14ed-f8f0-4a78-8b77-8a88cb41f658"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("0a66da3e-96d9-4103-a89a-000ebeb944f9"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("0cec773c-e941-413a-874d-ab3d38927752"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("12f7d31f-0a58-43de-b583-c4e46f56e57c"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("13b3c70f-7e34-447c-91e2-633682e9260a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("14cbb46c-532e-4382-8dde-edf9a99024d6"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("14d2b9d2-46d1-4309-a7d7-3e800835f448"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("15a158b3-4686-4210-94db-6f9b73c99332"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("15bcdf3c-f286-4a3c-bd0f-95917eeee20a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("16b47e60-ca99-4a54-9a81-806e2b0550ab"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("17464404-ad94-4f1f-ad8f-a7e511416d9f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("17739145-6581-4e11-bc97-ae175fad4971"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("177d4efb-c449-4557-85e2-8d0172db92b8"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("18773161-1dc3-4e37-84a6-cf299391a93d"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("19c1d3fb-a77b-4940-a894-5edee5df46ea"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("1b1ad134-9f6b-467a-844d-150b04906f6a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("1d33cd4c-8242-4484-aaf5-8018f06e6e79"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("1d882cdb-bdb0-4112-95da-bcd72ed466d2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("1ee6d7e5-dd7d-46a5-8368-dc85d3ab0001"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("1f7f99af-fb34-4b56-a343-329d2dbb4855"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("21b54c82-87be-4410-9a25-dbb0a302642c"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("21cabec1-f759-430d-952c-c77c3cd5354b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("22a5ff07-2206-41f2-ade7-84bedeeecdd1"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("231e5098-c807-4018-9592-27c23b061d52"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("24290b68-c722-498e-aacb-b1cc94d819cd"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("242c849e-969e-494f-b500-4e56419cdbeb"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("243e7b21-2915-4711-b49f-23b99f19c928"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("244c4bab-636a-44a7-ba21-c03f75271ecc"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("24de3719-a701-4e73-8509-77ae6e04bcfa"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("25dffe65-1896-4adf-aef6-fdf0200235ea"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("26499a54-bcab-4921-8bb4-893c2fc240e2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("2704c9ff-fbad-4cd4-ba22-cbaeef24edd2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("272da3e7-0123-41f0-ac51-4b0331680337"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("282f47fb-c45f-4d72-b647-c4e9d8e64060"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("29ba041e-b9cf-44c6-89ff-76ac8bfe15d0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("29c1c3f7-88da-4549-9ab8-e7c918412f35"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("2b1115cb-1333-4712-b7ac-6de23aa84b6e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("2b80b7c5-d9e7-4ff5-b094-38113397cbd2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("2b93c5ac-9c66-4aef-bac1-488b132a59dd"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("2c9b9831-025e-4293-9353-cb595572e27e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("2dcc0d11-4051-4cc0-9c2c-a8649e4a35a5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("32073e7a-a39f-42f7-b05e-a7d89206c78c"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("322e041d-1464-49e8-9507-89766cd99eef"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("32739830-b374-4150-80cd-d7d176e4d747"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("329648b3-9d64-4d91-abec-e0a8ca777bdd"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("34ad0d6d-a1ad-42b2-b2b3-0dd4021f49c0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("35574551-897d-4e5d-a146-08cde064db84"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3629aaca-b73e-42cc-b4cf-eff6daab2b06"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("363776e7-e6d5-415f-8b5a-8813d95193f4"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("365f42ef-38a7-4d44-b0ad-4a3803300219"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("37009bc4-f2d6-4603-87f0-a4528160148e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3855e9b7-50f6-4315-9315-700b1c949a71"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("38c0f0f7-149c-4b78-8d77-f8d2df7c7abe"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("38eee82f-066f-4f7e-9e48-479e9a7622b8"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("391aa354-13d8-463c-9c1d-f4fd2b8cbc1c"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3a04cc4b-6a0b-4c06-8a34-58937cfddb2f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3ad5680a-eb13-42ee-9718-51e33f7c5ac6"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3ae772ca-10d1-47f6-b46a-eb8b99b7feee"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3b4e75ed-8677-419e-97e1-0dff7cdef4f1"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3b850cb4-7fcb-4654-95db-fd1863ab66da"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3c1a72b5-3977-43fc-90ca-bf9c3ec00f4e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3daec8ec-d6db-4ccc-bcde-dbcd55f11f4a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3f2a8ebc-202e-485d-ae12-0c95e7a55057"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3fa54555-26d6-47db-b3d9-5264f88b52c8"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("4327f779-b05c-4951-83dd-6670fc9718e8"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("461542f0-2382-4eca-a112-f59936874d6e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("46c6cc8e-a47a-44b9-977d-515e96f1ac7f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("46e8ece1-fb10-4c46-9e5b-6b8390cf4cb0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("471d291f-e795-4343-a1b4-bfbe3ffd11e5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("48ac7530-218c-4221-bf3c-9a18f1a0d67a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("4bac53ca-899f-40b6-bf06-56f4779023f2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("4c16e1ef-4e6f-4156-998f-cf1795b15180"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("518d55c2-5ba1-4040-9b7d-c87dbfb75686"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("526d0971-5960-4c77-9c48-3febb643f904"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("538e7585-cf50-49e2-8398-5f51e3715cd0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("547924e3-bcb6-4746-98d1-132a09849025"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("549a072f-92e3-461a-9b83-106ec032405b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("55ca304d-37d6-489b-a668-fa7b01e7db9f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5655241a-6c36-4643-8f0d-0fd9301ff6e0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("57384c73-511f-4488-b47c-cb5f07a44c1b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5820cb7e-37bf-4caa-9c70-290d3b006986"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5865ffbe-83e8-43c5-b2a9-ad4a388dbd9a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("592b8fa8-07b1-4633-a3a6-b7aa30b93db3"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("59316263-31f3-4b20-9605-942d8ed7b6a5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("59cc2568-53e7-45fd-89c7-6d9827c6afbb"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5a9a825d-28c1-4193-863b-44890f695215"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5bc1fffa-2368-49c0-beba-d294b73f7019"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5c1285c9-1fdc-4175-a86b-d2cca2204c03"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5c264b44-e8c4-4ba9-b783-0f1b7d20dc35"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5c32fcd1-d962-458a-a888-dc6244c6cbec"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5cd8939b-3265-47cd-8213-6adea4b60206"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5d033fef-c396-41e6-89c8-5e5762d79b47"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5f8a062d-c74e-4177-a90e-84688e35c044"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5fba22b1-1c8a-4d4e-ab27-724438068128"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("61767884-6c42-49af-bac4-51b801ff7d1f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("6295ca0d-2036-43f5-b5fe-7fdd8fcd395f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("6314d727-eba2-4083-873d-71cc4e17ddfc"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("631b262b-8290-45c3-8872-35029ee408f9"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("638b27e4-480a-4a69-9fa5-16af6b0dd940"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("63a01740-1f47-4710-8aca-9aafef4db890"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("693f9671-da6e-4689-81d7-824b1bad5275"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("69559e84-024d-4755-8c3d-a290c81ea660"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("6c3e19f3-e2bd-46eb-bc8b-3c6b9743c6b9"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("6c79cb04-864b-47f9-8684-24070424bcaa"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("6f5e92d6-71a4-42a7-97bb-75a8d03652b7"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("70a3febe-d579-4b9c-86b5-02205138a1b2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("70e3e8f7-1e6e-440c-931a-1a287b587186"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("712b3908-161f-47cf-a068-efb65f61d900"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("713691bf-4a8b-4df2-b00c-243f3d0b4db8"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("714d854c-604c-4410-b66d-f6a878e90405"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("717950dc-3f30-4993-aeae-0129c3babbe8"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("72dc9f92-d8d2-44ab-a7bc-6de663734f98"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("73e2abc1-a4c8-4f37-bbe2-1926a2149c9f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("757e6914-1de4-49fa-bb5b-55ab3095dc60"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("75c0fe2a-e2c8-4d3f-a923-ce210d78197c"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("7714ef6d-1f97-4dc3-afde-ba48f25da95f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("7773dba5-be41-421a-8b55-0354bfdc6c6d"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("79056f23-4b70-426b-b660-49b8107b3599"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("79a3984a-c2cf-47a4-988c-f78a4f17f9f0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("7aac7f8f-dae4-4cc2-a62e-da209993f3b3"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("7b58c078-ca0d-44d4-a8c9-4cc742c19467"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("7b79def5-45f7-4f9a-aaa1-af1a7c5ec268"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("7c12d733-be51-414a-8a57-627051d773d9"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("7e89eaf1-5df9-4d1b-a65a-7ce5d76ddd16"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("7f2ba6d1-e06f-4611-bd8f-02c114df67e4"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8138b651-d5e9-4d39-8651-769942c66a9a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8212ab49-52eb-4d8c-b6f6-d7cd5506aed0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("829fc8a2-be81-47fc-b5f1-b2eff6696f1b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8329f3ca-e85e-4095-a050-72d1110b0f9f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8531d22a-e4da-4e63-86b5-b0d87328ff5f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("858f02d7-5995-4688-8c55-547fdeca30f5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("866f447a-83d4-4fb7-aca1-c77226eef755"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8678f309-eba5-4d99-a687-7ef9e58d9eda"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("87a1f57e-6536-4f11-b42d-f337d05200bf"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("87b72b9b-5267-478a-bfe2-9507ea53364a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8898c6ec-a735-496b-b65b-30b822e6a2fc"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("895ab7fa-37c9-4737-96e4-2d253be74f0e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8b047175-3737-4b3f-ae99-ea67c0d67dad"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8be30ab5-dd39-454b-bd16-96d8dd142f99"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8c69930b-f082-420b-b5ac-b78cb758a730"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8eaa002b-f1c4-4261-af0b-e86e93440b01"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8fad4d37-50c7-48e4-9aea-8405a77d5414"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("93868440-1fda-4a25-af55-cdc16cc38c2c"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("959148f1-d193-4660-a5ea-6c8cda370402"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("95bd15fb-6ef0-48eb-a736-41db6e9f03c2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("96f0c18f-2740-4c02-a7bf-173adbc28fe0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("979c5434-7118-42fe-bbc7-75ec8cb3c90c"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("986d0e8a-8516-45fc-a5e1-36c50ecde14b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("98be3bcc-0378-44ef-8927-7680c7473810"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("98cef487-f352-4560-9af1-8a7459c875dd"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("98efb068-36e3-437d-978a-9caeac2f3eac"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("99b4c15d-370b-4c55-8f92-96d4bda19a1b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("9c93b5eb-b1f8-4f7c-b9fd-f34da6e796ad"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("9cd198db-fc95-4f79-b0da-9be5f4b7f142"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("9d1ebe67-954b-4217-9b82-18bb08b1ede2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("9dbffd7b-975b-4c45-b6a1-0d64fb2ad789"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("9e711ee1-98f0-4108-9d40-f150e28d641e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("a1bbea9c-58e7-452b-a2f8-c423d96d283b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("a2fbe716-24cc-4d58-814e-771095de536b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("a4073ec0-ad1a-4df6-a119-88dee82df613"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("a4c42c23-5b01-430e-863e-42f24c3b8a17"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("a5a092e1-f558-42d5-92ff-8f5ffbfaa7a0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("a75729ff-a31a-4e6a-84b0-5938827ba81d"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("a849b003-a398-4e67-b90c-bd96df8ae9a8"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("a8b459aa-9b88-46fa-8ec0-80a6fe557dda"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("aa28c7b2-c93e-46c5-9ad6-569879fc2eb9"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("aa2cefc3-4bfa-48dc-871f-1132220f96e7"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("aa85e0ce-869c-4dbf-89bd-4a55f8adbede"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("aabd4404-5baa-43a5-b2a2-4a1b32f95463"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ab57b3ef-2aa1-468d-addd-a354d49dc19b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ad23df61-dfab-446c-a929-2f4bcb1b70f3"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("adafb987-5c82-4065-ba45-649d02b83887"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("adf86d89-c120-4cd0-9841-5664b280ede2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ae7efee8-69d2-42d9-87d1-7f46caba780f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("aeb16ed5-49cc-4a0e-8f2c-ba05910ebd6d"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("b040474e-6e2b-40c4-93f2-9548e6029910"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("b18ee36d-7a38-475c-92db-f1e5f8f09bf8"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("b4a8bfad-6cb2-4b9a-beb7-17c387de97d4"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("b504c431-262c-423d-91f6-e1bf8ef6b3bd"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("b549762e-ec4a-481c-973c-41bb2639ac45"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("b5dd4c70-f997-46b4-a036-1731ccaca068"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("b6bd87db-9300-4eb0-8cf0-99aeb4a639d2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("b935b965-c9c4-4c99-8121-c3e846ddba7f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ba7f56ea-5251-41e0-9a05-668f03d7136a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("bae6ac01-31bc-49b8-ba4f-a173b2fd91a0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("bec2168d-88b3-4df0-80ce-0dbf52007b1b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("c3fdd866-61ef-4b00-a987-d07e4360d53a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("c8d80c6f-2fc4-45b6-b467-50101d7edae3"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("c96d1172-f011-445d-9829-e5ba02e71e73"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("cbd0c1e4-9412-470f-8800-589f335108cf"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("cbe95acb-be87-4312-8188-63ceb7910b76"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("cc134b62-7d4a-4c4b-9692-a0509587ad77"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("cdb9c0c0-a71f-4c33-907a-0b73ec9e3494"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ce010369-d47f-4f49-addb-479a71187804"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ce0ddfdf-bc22-4f6a-b275-80f30694fea5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ce63f14b-bac6-4177-9052-17c1991c8cc7"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("cf9e7090-6017-42d1-a39d-1bcdbc528efa"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d1a91fe6-6e54-4e58-854c-bbc9f08f22dd"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d1de73df-2aff-40df-8d33-3f0d2fbd9fce"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d387e16c-fc7e-401f-bcd3-f477442b59e0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d3934553-d09a-41a0-99c4-e496dadf3dd3"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d46b95ee-a45b-4716-942c-3874c1712bc5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d55ecbcc-c82e-4700-8b8d-a366a59e1683"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d5a696c9-9ab0-40ee-a852-5e2ba9fcc3e6"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d72332ad-b0ce-4a29-a952-765e59845a75"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d72a661e-f903-4c18-9d54-79a01202ed4c"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d9d19544-7a33-45d7-a2bb-cdcdfea97978"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("dc57ce7d-8505-49f7-a3c4-5c18d9f46cbb"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("de037e52-f4e7-4c5a-91f4-01359cc2f079"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("de652552-27bc-4c9f-a534-f9df8e604b61"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("de764772-3dc3-4070-b7d2-2a9c76d0e218"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("de7ff6b2-a744-4e24-a2cf-a48f009cdd69"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("de953436-e182-499d-b96e-60c211efd1c1"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("df414d00-7ab9-4a9a-a7ae-398e1710ef73"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("df4e4296-7cd4-4778-8a2b-9101821e79e0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("dfe6e493-a9c2-4c01-bfb0-beee778d22f3"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e2d93796-9abb-4c48-b0f6-90c5b9a60279"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e31209a8-17e7-4ecf-a35e-12b2da46f53b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e3e8ed55-cd64-4e77-b5da-941c404f57bf"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e48542d6-f4c2-49c0-8c91-b49be0111c27"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e505010c-3a42-4159-9739-9116eb8cdda0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e7028f53-6739-4225-9469-feaca3342954"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e8e2d7ce-a26e-404c-a1ed-3846d4272334"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e97eb580-accf-41e8-89a6-d4566760fa58"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e9d1a276-b1d9-4876-b6a5-86c5e98f3f78"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("eb2b848e-d50a-4fe5-9595-83fa517b2ec2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ef453f4f-de94-4b8c-82e6-9d5f3f80c70b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("efb0ced7-2466-4cbb-8a20-3d22f78846d1"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("efc58f9c-5181-4b19-ba82-2a561f3a595b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f105a9ff-e39d-4951-aa58-72df41889849"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f2c4f97c-fa1c-44cb-b966-569ea362a6ca"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f3090090-f8b7-47d5-b1c4-8ce05d1675f5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f3a9dc6a-d43d-48dc-92ce-5a7b3333042e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f4dffff9-2487-404a-a554-baf7bffcfd70"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f733f17f-8a75-47f4-9a73-244d40b760e7"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f75b6c2a-b5ff-404b-a9f2-2a5bfd304360"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f884da6a-89a5-4ce5-8049-d2fe5c2284a5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f90b4cb5-0bda-4589-9ca9-0184be138d4a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("fa02111a-ed52-4591-b4da-170e4bc6f1b9"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("fa031865-4cc2-450f-9e11-7cea1a3fa538"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("fb293bd9-23e0-4a47-872d-69ca4d8b8916"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("fb97cb17-0371-49e6-b7ac-57cc94a09f61"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("fde1117b-bc0b-4482-ad7c-7a02a2653d20"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("fe13ad03-b316-4eec-92e9-1f9ddeb70073"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("fe4e1316-c338-4f47-b493-23b0d11ecd62"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ff70b70d-5ad9-4384-8618-f38aa3b71428"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 23, 6, 4, 19, 680, DateTimeKind.Unspecified).AddTicks(3655), new TimeSpan(0, 0, 0, 0, 0)) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "MiddleNames",
                schema: "user",
                table: "UserProfiles",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300,
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "LastModifiedTimestamp",
                schema: "config",
                table: "SkinTones",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset")
                .Annotation("Relational:ColumnOrder", 99999);

            migrationBuilder.AlterColumn<Guid>(
                name: "LastModifiedBy",
                schema: "config",
                table: "SkinTones",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("Relational:ColumnOrder", 99997);

            migrationBuilder.AlterColumn<string>(
                name: "DescriptionTrxCode",
                schema: "config",
                table: "SkinTones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 2);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "config",
                table: "SkinTones",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<DateTimeOffset>(
                name: "CreatedTimestamp",
                schema: "config",
                table: "SkinTones",
                type: "datetimeoffset",
                nullable: false,
                oldClrType: typeof(DateTimeOffset),
                oldType: "datetimeoffset")
                .Annotation("Relational:ColumnOrder", 99998);

            migrationBuilder.AlterColumn<Guid>(
                name: "CreatedBy",
                schema: "config",
                table: "SkinTones",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier")
                .Annotation("Relational:ColumnOrder", 99996);

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Audiences",
                keyColumn: "AudienceId",
                keyValue: new Guid("0b255ccf-19e4-49c0-a3e0-d8513416d52d"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Audiences",
                keyColumn: "AudienceId",
                keyValue: new Guid("0c4e6f37-09af-4b5b-9081-42368f9884ea"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Audiences",
                keyColumn: "AudienceId",
                keyValue: new Guid("7255b812-56c0-4293-ba3e-f3a28e7256e3"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Audiences",
                keyColumn: "AudienceId",
                keyValue: new Guid("94b9b87c-a0a1-4721-a905-897b12e81fc7"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7954), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 1L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 2L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 3L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 4L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 5L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 6L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 7L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 8L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 9L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 10L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 11L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 12L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 13L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 14L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 15L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 16L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 17L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 18L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 19L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 20L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 21L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 22L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 23L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 24L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 25L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 26L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 27L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 28L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 29L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 30L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 31L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 32L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 33L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 34L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 35L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 36L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 37L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 38L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 39L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 40L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 41L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 42L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 43L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 44L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 45L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 46L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 47L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 48L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 49L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 50L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 51L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 52L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 53L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 54L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 55L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 56L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 57L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 58L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 59L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 60L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 61L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 62L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 63L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 64L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 65L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 66L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 67L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 68L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 69L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 70L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 71L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 72L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 73L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 74L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 75L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 76L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 77L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 78L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 79L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 80L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 81L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 82L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 83L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 84L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 85L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 86L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 87L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 88L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 89L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 90L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 91L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 92L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 93L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 94L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 95L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 96L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 97L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 98L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 99L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 100L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 101L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 102L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 103L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 104L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 105L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 106L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 107L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 108L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 109L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 110L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 111L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 112L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 113L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 114L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 115L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 116L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 117L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 118L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 119L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 120L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 121L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 122L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 123L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 124L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 125L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 126L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 127L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 128L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 129L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 130L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 131L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 132L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 133L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 134L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 135L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 136L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 137L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 138L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 139L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 140L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 141L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 142L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 143L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 144L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 145L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 146L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 147L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 148L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 149L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 150L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 151L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 152L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 153L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 154L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 155L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 156L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 157L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 158L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 159L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 160L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 161L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 162L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 163L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 164L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 165L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 166L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 167L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 168L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 169L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 170L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 171L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 172L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 173L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 174L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 175L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 176L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 177L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 178L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 179L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 180L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 181L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 182L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 183L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 184L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 185L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 186L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 187L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 188L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 189L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 190L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 191L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 192L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 193L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 194L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 195L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 196L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 197L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 198L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 199L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 200L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 201L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 202L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 203L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 204L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 205L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 206L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 207L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 208L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 209L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 210L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 211L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 212L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 213L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 214L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 215L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 216L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 217L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 218L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 219L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 220L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 221L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 222L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 223L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 224L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 225L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 226L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 227L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 228L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 229L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 230L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 231L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 232L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 233L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 234L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 235L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 236L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 237L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 238L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 239L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 240L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 241L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 242L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 243L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 244L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 245L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 246L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 247L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 248L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Countries",
                keyColumn: "CountryId",
                keyValue: 249L,
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6406), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("0b79c147-cc62-4071-ada8-cb2e5d06ad72"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("1c9985ff-2c5f-4574-a126-fd04d583c0d2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("2dde1e98-256b-4816-a58a-d9430982f525"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("4bd4c1a1-9736-4f04-b974-90bc1cd61630"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("54880bec-0fdd-4ad6-af13-9042d0916615"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("65cff48a-6729-4d4f-a974-7bc27204b09a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("804b9015-ca16-4fb0-8cc6-20e362fb3afb"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("884a154f-eb78-4a7a-bddc-e58ae631b884"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("b0b595b9-5133-4d31-8218-901b6426ec0f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("c09905d9-10e4-4e61-bf83-d037533e377e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("ccb2efb1-74b4-4aca-b110-a3ba153e4b92"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Languages",
                keyColumn: "LanguageId",
                keyValue: new Guid("e2bd6da4-2d43-49ff-ae10-c61ebcf305b6"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(6313), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SettingCategories",
                keyColumn: "SystemSettingCategoryId",
                keyValue: new Guid("083ea747-18db-4048-9a8f-96aa6ded38c4"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SettingCategories",
                keyColumn: "SystemSettingCategoryId",
                keyValue: new Guid("7dc564b5-9cc9-459e-987a-695fbfcab4a0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SettingCategories",
                keyColumn: "SystemSettingCategoryId",
                keyValue: new Guid("e031d3cb-b5f7-4267-b373-d70996e70828"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SettingCategories",
                keyColumn: "SystemSettingCategoryId",
                keyValue: new Guid("edcbb17e-d9ee-481d-b79c-340858cff353"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SettingCategories",
                keyColumn: "SystemSettingCategoryId",
                keyValue: new Guid("f71b0459-44ab-499e-b5d7-afca31ab19b5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(4789), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("0e5df38d-9b2a-4263-8dd2-624b3391e0dc"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("214315b5-6109-40ca-b23b-4419b4369de7"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("5fcf50f5-2d8a-4085-82c0-b0a6316b129f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("64bd6c09-bd2e-47d9-92c3-a215fd30f342"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("68c8d22a-85fd-4ace-918f-33b9949ba7bb"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("8cf6f718-c898-4605-8e60-ae085b569f1d"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("c269f856-f3f6-48f8-a6c7-0acac6dbe50b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("f40d10d2-48a1-4771-b30e-abd65bc2b53d"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5316), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SkinTones",
                keyColumn: "SkinToneId",
                keyValue: new Guid("13cf913a-613e-403d-a55c-5bf30a1205af"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SkinTones",
                keyColumn: "SkinToneId",
                keyValue: new Guid("2469a010-313c-4c7f-991d-2fab9bf2245f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SkinTones",
                keyColumn: "SkinToneId",
                keyValue: new Guid("4b61cbb8-8c4a-4893-a73c-47fc8e0361e3"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SkinTones",
                keyColumn: "SkinToneId",
                keyValue: new Guid("59bc3be7-4bb1-4c9d-801d-de233002e6e7"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SkinTones",
                keyColumn: "SkinToneId",
                keyValue: new Guid("86146d02-a42a-4804-8d6b-1cdb90baafd7"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "SkinTones",
                keyColumn: "SkinToneId",
                keyValue: new Guid("a11a3f21-e8fa-49d3-b516-ec5b95f2fa70"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5516), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AZOT", "-1", "Azores Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CVT", "-1", "Cape Verde Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EGT", "-1", "Eastern Greenland Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CKT", "-10", "Cook Island Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "HAST", "-10", "Hawaii-Aleutian Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "HST", "-10", "Hawaii Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TAHT", "-10", "Tahiti Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NUT", "-11", "Niue Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SST", "-11", "Samoa Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AoE", "-12", "Anywhere on Earth" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "FNT", "-2", "Fernando de Noronha Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GST", "-2", "South Georgia Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ADST", "-3", "Atlantic Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ART", "-3", "Argentina Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "BRT", "-3", "Brasília Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GFT", "-3", "French Guiana Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PMST", "-3", "Pierre & Miquelon Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ROTT", "-3", "Rothera Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SRT", "-3", "Suriname Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "UYT", "-3", "Uruguay Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WGT", "-3", "Western Greenland Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NST", "-3:30", "Newfoundland Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AMT", "-4", "Amazon Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AST", "-4", "Atlantic Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "BOT", "-4", "Bolivia Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CIDST", "-4", "Cayman Islands Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CLST", "-4", "Chile Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CT", "-4", "Chile Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EDST", "-4", "Eastern Daylight Savings Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "FKST", "-4", "Falkland Island Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GYT", "-4", "Guyana Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PYT", "-4", "Paraguay Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "VET", "-4", "Venezuelan Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ACT", "-5", "Acre Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CDST", "-5", "Central Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CIST", "-5", "Cayman Islands Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CIT", "-5", "Cayman Islands Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "COT", "-5", "Colombia Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CST", "-5", "Cuba Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ECT", "-5", "Ecuador Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EST", "-5", "Eastern Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ET", "-5", "Eastern Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NAEST", "-5", "North American Eastern Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PET", "-5", "Peru Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CST", "-6", "Central Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EAST", "-6", "Easter Island Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GALT", "-6", "Galapagos Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MDST", "-6", "Mountain Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NACST", "-6", "North American Central Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MST", "-7", "Mountain Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NAMST", "-7", "North American Mountain Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PDST", "-7", "Pacific Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ADST", "-8", "Alaska Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NAPST", "-8", "North American Pacific Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PST", "-8", "Pacific Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PST", "-8", "Pitcairn Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PT", "-8", "Pacific Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AKST", "-9", "Alaska Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AT", "-9", "Alaska Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GAMT", "-9", "Gambier Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MART", "-9:30", "Marquesas Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GMT", "0", "Greenwich Mean Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WET", "0", "Western European Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WT", "0", "Western Sahara Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "BDST", "1", "British Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CET", "1", "Central European Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ECT", "1", "European Central Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "IST", "1", "Irish Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WAT", "1", "West Africa Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AEST", "10", "Australian Eastern Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AET", "10", "Australian Eastern Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ChST", "10", "Chamorro Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CHUT", "10", "Chuuk Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "DDUT", "10", "Dumont-d'Urville Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EST", "10", "Eastern Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GST", "10", "Guam Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PGT", "10", "Papua New Guinea Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "VLAT", "10", "Vladivostok Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "YAPT", "10", "Yap Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CDST", "10:30", "Central Daylight Savings Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "LHST", "10:30", "Lord Howe Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "BST", "11", "Bougainville Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EDST", "11", "Eastern Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EFATE", "11", "Efate Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "KOST", "11", "Kosrae Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MAGT", "11", "Magadan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NCT", "11", "New Caledonia Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NFT", "11", "Norfolk Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PONT", "11", "Pohnpei Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SAKT", "11", "Sakhalin Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SBT", "11", "Solomon Islands Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SRET", "11", "Srednekolymsk Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "VUT", "11", "Vanuatu Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ANAT", "12", "Anadyr Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "FJT", "12", "Fiji Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GILT", "12", "Gilbert Island Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MHT", "12", "Marshall Islands Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NRT", "12", "Nauru Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NZST", "12", "New Zealand Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PETT", "12", "Kamchatka Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TVT", "12", "Tuvalu Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WAKT", "12", "Wake Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WFT", "12", "Wallis and Futuna Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CHAST", "12:45", "Chatham Island Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PHOT", "13", "Phoenix Island Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ST", "13", "Samoa Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TKT", "13", "Tokelau Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TOT", "13", "Tonga Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WST", "13", "West Samoa Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "LINT", "14", "Line Islands Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CAT", "2", "Central Africa Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EET", "2", "Eastern European Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "IST", "2", "Israel Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SAST", "2", "South African Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AST", "3", "Arabia Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "EAT", "3", "Eastern Africa Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "FET", "3", "Further-Eastern European Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MCK", "3", "Moscow Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MSK", "3", "Moscow Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SYOT", "3", "Syowa Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TRT", "3", "Turkey Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "IRST", "3:30", "Iran Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AMT", "4", "Armenia Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AZT", "4", "Azerbaijan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GET", "4", "Georgia Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "GST", "4", "Gulf Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "KUYT", "4", "Kuybyshev Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MUT", "4", "Mauritius Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "RET", "4", "Reunion Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SAMT", "4", "Samara Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SCT", "4", "Seychelles Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AFT", "4:30", "Afghanistan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AQTT", "5", "Aqtobe Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "KIT", "5", "Kerguelen (Islands) Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MAWT", "5", "Mawson Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MVT", "5", "Maldives Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ORAT", "5", "Oral Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PKT", "5", "Pakistan Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TFT", "5", "French Southern and Antarctic Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TJT", "5", "Tajikistan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TMT", "5", "Turkmenistan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "UZT", "5", "Uzbekistan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "YEKT", "5", "Yekaterinburg Time" },
                columns: new[] { "CreatedBy", "CreatedTimestamp", "LastModifiedBy", "LastModifiedTimestamp" },
                values: new object[] { new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new Guid("11111111-1111-1111-1111-111111111111"), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "IST", "5:30", "India Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "IT", "5:30", "India Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NPT", "5:45", "Nepal Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ALMT", "6", "Alma-Ata Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "BST", "6", "Bangladesh Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "BTT", "6", "Bhutan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "IOT", "6", "Indian Chagos Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "KGT", "6", "Kyrgyzstan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "OMST", "6", "Omsk Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "QYZT", "6", "Qyzylorda Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "VOST", "6", "Vostok Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CCT", "6:30", "Cocos Islands Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MMT", "6:30", "Myanmar Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CXT", "7", "Christmas Island Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "DAVT", "7", "Davis Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "HOVT", "7", "Hovd Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ICT", "7", "Indochina Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "KRAT", "7", "Krasnoyarsk Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "NOVT", "7", "Novosibirsk Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WIB", "7", "Western Indonesian Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "AWST", "8", "Australian Western Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "BNT", "8", "Brunei Darussalam Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CAST", "8", "Casey Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CHOT", "8", "Choibalsan Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CST", "8", "China Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "HKT", "8", "Hong Kong Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "HOVDST", "8", "Hovd Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "IRKT", "8", "Irkutsk Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MST", "8", "Malaysian Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "MYT", "8", "Malaysia Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PHT", "8", "Philippine Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PST", "8", "Philippine Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SGT", "8", "Singapore Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "SST", "8", "Singapore Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ULAT", "8", "Ulaanbaatar Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WAT", "8", "Western Australia Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WITA", "8", "Central Indonesian Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WST", "8", "Western Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PYST", "8:30", "Pyongyang Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ACWST", "8:45", "Australian Central Western Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "CHODST", "9", "Choibalsan Daylight Saving Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "JST", "9", "Japan Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "KST", "9", "Korea Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "PWT", "9", "Palau Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "TLT", "9", "East Timor Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "WIT", "9", "Eastern Indonesian Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "YAKT", "9", "Yakutsk Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ACST", "9:30", "Australian Central Standard Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TimeZones",
                keyColumns: new[] { "Abbreviation", "CorrespondingUtcZone", "Name" },
                keyValues: new object[] { "ACT", "9:30", "Australian Central Time" },
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(5613), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("01076970-a0b9-459c-bbb9-9f72cd237296"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("027bbb33-0052-4382-a856-8cc23146317a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("082a73ea-8b77-4615-b29d-a65f1d749c7b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("0848232d-0bc9-4c97-9e3b-3451aff31a58"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("096d14ed-f8f0-4a78-8b77-8a88cb41f658"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("0a66da3e-96d9-4103-a89a-000ebeb944f9"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("0cec773c-e941-413a-874d-ab3d38927752"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("12f7d31f-0a58-43de-b583-c4e46f56e57c"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("13b3c70f-7e34-447c-91e2-633682e9260a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("14cbb46c-532e-4382-8dde-edf9a99024d6"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("14d2b9d2-46d1-4309-a7d7-3e800835f448"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("15a158b3-4686-4210-94db-6f9b73c99332"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("15bcdf3c-f286-4a3c-bd0f-95917eeee20a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("16b47e60-ca99-4a54-9a81-806e2b0550ab"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("17464404-ad94-4f1f-ad8f-a7e511416d9f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("17739145-6581-4e11-bc97-ae175fad4971"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("177d4efb-c449-4557-85e2-8d0172db92b8"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("18773161-1dc3-4e37-84a6-cf299391a93d"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("19c1d3fb-a77b-4940-a894-5edee5df46ea"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("1b1ad134-9f6b-467a-844d-150b04906f6a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("1d33cd4c-8242-4484-aaf5-8018f06e6e79"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("1d882cdb-bdb0-4112-95da-bcd72ed466d2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("1ee6d7e5-dd7d-46a5-8368-dc85d3ab0001"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("1f7f99af-fb34-4b56-a343-329d2dbb4855"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("21b54c82-87be-4410-9a25-dbb0a302642c"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("21cabec1-f759-430d-952c-c77c3cd5354b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("22a5ff07-2206-41f2-ade7-84bedeeecdd1"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("231e5098-c807-4018-9592-27c23b061d52"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("24290b68-c722-498e-aacb-b1cc94d819cd"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("242c849e-969e-494f-b500-4e56419cdbeb"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("243e7b21-2915-4711-b49f-23b99f19c928"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("244c4bab-636a-44a7-ba21-c03f75271ecc"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("24de3719-a701-4e73-8509-77ae6e04bcfa"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("25dffe65-1896-4adf-aef6-fdf0200235ea"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("26499a54-bcab-4921-8bb4-893c2fc240e2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("2704c9ff-fbad-4cd4-ba22-cbaeef24edd2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("272da3e7-0123-41f0-ac51-4b0331680337"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("282f47fb-c45f-4d72-b647-c4e9d8e64060"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("29ba041e-b9cf-44c6-89ff-76ac8bfe15d0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("29c1c3f7-88da-4549-9ab8-e7c918412f35"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("2b1115cb-1333-4712-b7ac-6de23aa84b6e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("2b80b7c5-d9e7-4ff5-b094-38113397cbd2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("2b93c5ac-9c66-4aef-bac1-488b132a59dd"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("2c9b9831-025e-4293-9353-cb595572e27e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("2dcc0d11-4051-4cc0-9c2c-a8649e4a35a5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("32073e7a-a39f-42f7-b05e-a7d89206c78c"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("322e041d-1464-49e8-9507-89766cd99eef"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("32739830-b374-4150-80cd-d7d176e4d747"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("329648b3-9d64-4d91-abec-e0a8ca777bdd"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("34ad0d6d-a1ad-42b2-b2b3-0dd4021f49c0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("35574551-897d-4e5d-a146-08cde064db84"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3629aaca-b73e-42cc-b4cf-eff6daab2b06"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("363776e7-e6d5-415f-8b5a-8813d95193f4"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("365f42ef-38a7-4d44-b0ad-4a3803300219"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("37009bc4-f2d6-4603-87f0-a4528160148e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3855e9b7-50f6-4315-9315-700b1c949a71"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("38c0f0f7-149c-4b78-8d77-f8d2df7c7abe"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("38eee82f-066f-4f7e-9e48-479e9a7622b8"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("391aa354-13d8-463c-9c1d-f4fd2b8cbc1c"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3a04cc4b-6a0b-4c06-8a34-58937cfddb2f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3ad5680a-eb13-42ee-9718-51e33f7c5ac6"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3ae772ca-10d1-47f6-b46a-eb8b99b7feee"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3b4e75ed-8677-419e-97e1-0dff7cdef4f1"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3b850cb4-7fcb-4654-95db-fd1863ab66da"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3c1a72b5-3977-43fc-90ca-bf9c3ec00f4e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3daec8ec-d6db-4ccc-bcde-dbcd55f11f4a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3f2a8ebc-202e-485d-ae12-0c95e7a55057"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("3fa54555-26d6-47db-b3d9-5264f88b52c8"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("4327f779-b05c-4951-83dd-6670fc9718e8"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("461542f0-2382-4eca-a112-f59936874d6e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("46c6cc8e-a47a-44b9-977d-515e96f1ac7f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("46e8ece1-fb10-4c46-9e5b-6b8390cf4cb0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("471d291f-e795-4343-a1b4-bfbe3ffd11e5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("48ac7530-218c-4221-bf3c-9a18f1a0d67a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("4bac53ca-899f-40b6-bf06-56f4779023f2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("4c16e1ef-4e6f-4156-998f-cf1795b15180"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("518d55c2-5ba1-4040-9b7d-c87dbfb75686"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("526d0971-5960-4c77-9c48-3febb643f904"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("538e7585-cf50-49e2-8398-5f51e3715cd0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("547924e3-bcb6-4746-98d1-132a09849025"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("549a072f-92e3-461a-9b83-106ec032405b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("55ca304d-37d6-489b-a668-fa7b01e7db9f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5655241a-6c36-4643-8f0d-0fd9301ff6e0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("57384c73-511f-4488-b47c-cb5f07a44c1b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5820cb7e-37bf-4caa-9c70-290d3b006986"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5865ffbe-83e8-43c5-b2a9-ad4a388dbd9a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("592b8fa8-07b1-4633-a3a6-b7aa30b93db3"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("59316263-31f3-4b20-9605-942d8ed7b6a5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("59cc2568-53e7-45fd-89c7-6d9827c6afbb"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5a9a825d-28c1-4193-863b-44890f695215"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5bc1fffa-2368-49c0-beba-d294b73f7019"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5c1285c9-1fdc-4175-a86b-d2cca2204c03"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5c264b44-e8c4-4ba9-b783-0f1b7d20dc35"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5c32fcd1-d962-458a-a888-dc6244c6cbec"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5cd8939b-3265-47cd-8213-6adea4b60206"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5d033fef-c396-41e6-89c8-5e5762d79b47"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5f8a062d-c74e-4177-a90e-84688e35c044"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("5fba22b1-1c8a-4d4e-ab27-724438068128"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("61767884-6c42-49af-bac4-51b801ff7d1f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("6295ca0d-2036-43f5-b5fe-7fdd8fcd395f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("6314d727-eba2-4083-873d-71cc4e17ddfc"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("631b262b-8290-45c3-8872-35029ee408f9"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("638b27e4-480a-4a69-9fa5-16af6b0dd940"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("63a01740-1f47-4710-8aca-9aafef4db890"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("693f9671-da6e-4689-81d7-824b1bad5275"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("69559e84-024d-4755-8c3d-a290c81ea660"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("6c3e19f3-e2bd-46eb-bc8b-3c6b9743c6b9"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("6c79cb04-864b-47f9-8684-24070424bcaa"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("6f5e92d6-71a4-42a7-97bb-75a8d03652b7"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("70a3febe-d579-4b9c-86b5-02205138a1b2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("70e3e8f7-1e6e-440c-931a-1a287b587186"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("712b3908-161f-47cf-a068-efb65f61d900"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("713691bf-4a8b-4df2-b00c-243f3d0b4db8"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("714d854c-604c-4410-b66d-f6a878e90405"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("717950dc-3f30-4993-aeae-0129c3babbe8"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("72dc9f92-d8d2-44ab-a7bc-6de663734f98"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("73e2abc1-a4c8-4f37-bbe2-1926a2149c9f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("757e6914-1de4-49fa-bb5b-55ab3095dc60"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("75c0fe2a-e2c8-4d3f-a923-ce210d78197c"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("7714ef6d-1f97-4dc3-afde-ba48f25da95f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("7773dba5-be41-421a-8b55-0354bfdc6c6d"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("79056f23-4b70-426b-b660-49b8107b3599"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("79a3984a-c2cf-47a4-988c-f78a4f17f9f0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("7aac7f8f-dae4-4cc2-a62e-da209993f3b3"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("7b58c078-ca0d-44d4-a8c9-4cc742c19467"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("7b79def5-45f7-4f9a-aaa1-af1a7c5ec268"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("7c12d733-be51-414a-8a57-627051d773d9"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("7e89eaf1-5df9-4d1b-a65a-7ce5d76ddd16"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("7f2ba6d1-e06f-4611-bd8f-02c114df67e4"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8138b651-d5e9-4d39-8651-769942c66a9a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8212ab49-52eb-4d8c-b6f6-d7cd5506aed0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("829fc8a2-be81-47fc-b5f1-b2eff6696f1b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8329f3ca-e85e-4095-a050-72d1110b0f9f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8531d22a-e4da-4e63-86b5-b0d87328ff5f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("858f02d7-5995-4688-8c55-547fdeca30f5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("866f447a-83d4-4fb7-aca1-c77226eef755"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8678f309-eba5-4d99-a687-7ef9e58d9eda"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("87a1f57e-6536-4f11-b42d-f337d05200bf"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("87b72b9b-5267-478a-bfe2-9507ea53364a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8898c6ec-a735-496b-b65b-30b822e6a2fc"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("895ab7fa-37c9-4737-96e4-2d253be74f0e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8b047175-3737-4b3f-ae99-ea67c0d67dad"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8be30ab5-dd39-454b-bd16-96d8dd142f99"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8c69930b-f082-420b-b5ac-b78cb758a730"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8eaa002b-f1c4-4261-af0b-e86e93440b01"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("8fad4d37-50c7-48e4-9aea-8405a77d5414"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("93868440-1fda-4a25-af55-cdc16cc38c2c"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("959148f1-d193-4660-a5ea-6c8cda370402"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("95bd15fb-6ef0-48eb-a736-41db6e9f03c2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("96f0c18f-2740-4c02-a7bf-173adbc28fe0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("979c5434-7118-42fe-bbc7-75ec8cb3c90c"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("986d0e8a-8516-45fc-a5e1-36c50ecde14b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("98be3bcc-0378-44ef-8927-7680c7473810"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("98cef487-f352-4560-9af1-8a7459c875dd"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("98efb068-36e3-437d-978a-9caeac2f3eac"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("99b4c15d-370b-4c55-8f92-96d4bda19a1b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("9c93b5eb-b1f8-4f7c-b9fd-f34da6e796ad"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("9cd198db-fc95-4f79-b0da-9be5f4b7f142"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("9d1ebe67-954b-4217-9b82-18bb08b1ede2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("9dbffd7b-975b-4c45-b6a1-0d64fb2ad789"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("9e711ee1-98f0-4108-9d40-f150e28d641e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("a1bbea9c-58e7-452b-a2f8-c423d96d283b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("a2fbe716-24cc-4d58-814e-771095de536b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("a4073ec0-ad1a-4df6-a119-88dee82df613"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("a4c42c23-5b01-430e-863e-42f24c3b8a17"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("a5a092e1-f558-42d5-92ff-8f5ffbfaa7a0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("a75729ff-a31a-4e6a-84b0-5938827ba81d"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("a849b003-a398-4e67-b90c-bd96df8ae9a8"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("a8b459aa-9b88-46fa-8ec0-80a6fe557dda"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("aa28c7b2-c93e-46c5-9ad6-569879fc2eb9"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("aa2cefc3-4bfa-48dc-871f-1132220f96e7"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("aa85e0ce-869c-4dbf-89bd-4a55f8adbede"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("aabd4404-5baa-43a5-b2a2-4a1b32f95463"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ab57b3ef-2aa1-468d-addd-a354d49dc19b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ad23df61-dfab-446c-a929-2f4bcb1b70f3"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("adafb987-5c82-4065-ba45-649d02b83887"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("adf86d89-c120-4cd0-9841-5664b280ede2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ae7efee8-69d2-42d9-87d1-7f46caba780f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("aeb16ed5-49cc-4a0e-8f2c-ba05910ebd6d"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("b040474e-6e2b-40c4-93f2-9548e6029910"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("b18ee36d-7a38-475c-92db-f1e5f8f09bf8"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("b4a8bfad-6cb2-4b9a-beb7-17c387de97d4"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("b504c431-262c-423d-91f6-e1bf8ef6b3bd"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("b549762e-ec4a-481c-973c-41bb2639ac45"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("b5dd4c70-f997-46b4-a036-1731ccaca068"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("b6bd87db-9300-4eb0-8cf0-99aeb4a639d2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("b935b965-c9c4-4c99-8121-c3e846ddba7f"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ba7f56ea-5251-41e0-9a05-668f03d7136a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("bae6ac01-31bc-49b8-ba4f-a173b2fd91a0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("bec2168d-88b3-4df0-80ce-0dbf52007b1b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("c3fdd866-61ef-4b00-a987-d07e4360d53a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("c8d80c6f-2fc4-45b6-b467-50101d7edae3"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("c96d1172-f011-445d-9829-e5ba02e71e73"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("cbd0c1e4-9412-470f-8800-589f335108cf"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("cbe95acb-be87-4312-8188-63ceb7910b76"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("cc134b62-7d4a-4c4b-9692-a0509587ad77"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("cdb9c0c0-a71f-4c33-907a-0b73ec9e3494"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ce010369-d47f-4f49-addb-479a71187804"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ce0ddfdf-bc22-4f6a-b275-80f30694fea5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ce63f14b-bac6-4177-9052-17c1991c8cc7"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("cf9e7090-6017-42d1-a39d-1bcdbc528efa"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d1a91fe6-6e54-4e58-854c-bbc9f08f22dd"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d1de73df-2aff-40df-8d33-3f0d2fbd9fce"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d387e16c-fc7e-401f-bcd3-f477442b59e0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d3934553-d09a-41a0-99c4-e496dadf3dd3"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d46b95ee-a45b-4716-942c-3874c1712bc5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d55ecbcc-c82e-4700-8b8d-a366a59e1683"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d5a696c9-9ab0-40ee-a852-5e2ba9fcc3e6"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d72332ad-b0ce-4a29-a952-765e59845a75"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d72a661e-f903-4c18-9d54-79a01202ed4c"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("d9d19544-7a33-45d7-a2bb-cdcdfea97978"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("dc57ce7d-8505-49f7-a3c4-5c18d9f46cbb"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("de037e52-f4e7-4c5a-91f4-01359cc2f079"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("de652552-27bc-4c9f-a534-f9df8e604b61"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("de764772-3dc3-4070-b7d2-2a9c76d0e218"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("de7ff6b2-a744-4e24-a2cf-a48f009cdd69"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("de953436-e182-499d-b96e-60c211efd1c1"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("df414d00-7ab9-4a9a-a7ae-398e1710ef73"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("df4e4296-7cd4-4778-8a2b-9101821e79e0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("dfe6e493-a9c2-4c01-bfb0-beee778d22f3"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e2d93796-9abb-4c48-b0f6-90c5b9a60279"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e31209a8-17e7-4ecf-a35e-12b2da46f53b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e3e8ed55-cd64-4e77-b5da-941c404f57bf"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e48542d6-f4c2-49c0-8c91-b49be0111c27"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e505010c-3a42-4159-9739-9116eb8cdda0"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e7028f53-6739-4225-9469-feaca3342954"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e8e2d7ce-a26e-404c-a1ed-3846d4272334"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e97eb580-accf-41e8-89a6-d4566760fa58"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("e9d1a276-b1d9-4876-b6a5-86c5e98f3f78"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("eb2b848e-d50a-4fe5-9595-83fa517b2ec2"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ef453f4f-de94-4b8c-82e6-9d5f3f80c70b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("efb0ced7-2466-4cbb-8a20-3d22f78846d1"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("efc58f9c-5181-4b19-ba82-2a561f3a595b"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f105a9ff-e39d-4951-aa58-72df41889849"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f2c4f97c-fa1c-44cb-b966-569ea362a6ca"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f3090090-f8b7-47d5-b1c4-8ce05d1675f5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f3a9dc6a-d43d-48dc-92ce-5a7b3333042e"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f4dffff9-2487-404a-a554-baf7bffcfd70"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f733f17f-8a75-47f4-9a73-244d40b760e7"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f75b6c2a-b5ff-404b-a9f2-2a5bfd304360"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f884da6a-89a5-4ce5-8049-d2fe5c2284a5"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("f90b4cb5-0bda-4589-9ca9-0184be138d4a"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("fa02111a-ed52-4591-b4da-170e4bc6f1b9"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("fa031865-4cc2-450f-9e11-7cea1a3fa538"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("fb293bd9-23e0-4a47-872d-69ca4d8b8916"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("fb97cb17-0371-49e6-b7ac-57cc94a09f61"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("fde1117b-bc0b-4482-ad7c-7a02a2653d20"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("fe13ad03-b316-4eec-92e9-1f9ddeb70073"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("fe4e1316-c338-4f47-b493-23b0d11ecd62"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });

            migrationBuilder.UpdateData(
                schema: "config",
                table: "TopLevelDomains",
                keyColumn: "TopLevelDomainId",
                keyValue: new Guid("ff70b70d-5ad9-4384-8618-f38aa3b71428"),
                columns: new[] { "CreatedTimestamp", "LastModifiedTimestamp" },
                values: new object[] { new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)), new DateTimeOffset(new DateTime(2023, 11, 21, 3, 57, 3, 686, DateTimeKind.Unspecified).AddTicks(7132), new TimeSpan(0, 0, 0, 0, 0)) });
        }
    }
}
