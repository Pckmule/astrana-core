using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Astrana.Core.Data.Migrations.MSSqlServer.Migrations
{
    /// <inheritdoc />
    public partial class ExternalContentSubscription : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExternalContentSubscriptions_Images_PreviewImageId",
                schema: "content",
                table: "ExternalContentSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_ExternalContentSubscriptions_PreviewImageId",
                schema: "content",
                table: "ExternalContentSubscriptions");

            migrationBuilder.DropColumn(
                name: "PreviewImageId",
                schema: "content",
                table: "ExternalContentSubscriptions");

            migrationBuilder.RenameColumn(
                name: "SiteName",
                schema: "content",
                table: "ExternalContentSubscriptions",
                newName: "WebsiteUrl");

            migrationBuilder.RenameColumn(
                name: "Robots",
                schema: "content",
                table: "ExternalContentSubscriptions",
                newName: "Language");

            migrationBuilder.RenameColumn(
                name: "CharSet",
                schema: "content",
                table: "ExternalContentSubscriptions",
                newName: "Copyright");

            migrationBuilder.AlterColumn<string>(
                name: "Locale",
                schema: "content",
                table: "ExternalContentSubscriptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "content",
                table: "ExternalContentSubscriptions",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 3);

            migrationBuilder.AlterColumn<string>(
                name: "WebsiteUrl",
                schema: "content",
                table: "ExternalContentSubscriptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<string>(
                name: "Language",
                schema: "content",
                table: "ExternalContentSubscriptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 8)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AlterColumn<string>(
                name: "Copyright",
                schema: "content",
                table: "ExternalContentSubscriptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AddColumn<string>(
                name: "AccessToken",
                schema: "content",
                table: "ExternalContentSubscriptions",
                type: "nvarchar(max)",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.AddColumn<Guid>(
                name: "CoverImageId",
                schema: "content",
                table: "ExternalContentSubscriptions",
                type: "uniqueidentifier",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 12);

            migrationBuilder.AddColumn<Guid>(
                name: "IconImageId",
                schema: "content",
                table: "ExternalContentSubscriptions",
                type: "uniqueidentifier",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 10);

            migrationBuilder.AddColumn<Guid>(
                name: "LogoImageId",
                schema: "content",
                table: "ExternalContentSubscriptions",
                type: "uniqueidentifier",
                nullable: true)
                .Annotation("Relational:ColumnOrder", 11);

            migrationBuilder.AddColumn<string>(
                name: "SubTitle",
                schema: "content",
                table: "ExternalContentSubscriptions",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: true)
                .Annotation("Relational:ColumnOrder", 3);

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("0e5df38d-9b2a-4263-8dd2-624b3391e0dc"),
                column: "SettingCategoryId",
                value: new Guid("f71b0459-44ab-499e-b5d7-afca31ab19b5"));

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("214315b5-6109-40ca-b23b-4419b4369de7"),
                column: "SettingCategoryId",
                value: new Guid("f71b0459-44ab-499e-b5d7-afca31ab19b5"));

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("5fcf50f5-2d8a-4085-82c0-b0a6316b129f"),
                column: "SettingCategoryId",
                value: new Guid("f71b0459-44ab-499e-b5d7-afca31ab19b5"));

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("64bd6c09-bd2e-47d9-92c3-a215fd30f342"),
                column: "SettingCategoryId",
                value: new Guid("f71b0459-44ab-499e-b5d7-afca31ab19b5"));

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("68c8d22a-85fd-4ace-918f-33b9949ba7bb"),
                column: "SettingCategoryId",
                value: new Guid("f71b0459-44ab-499e-b5d7-afca31ab19b5"));

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("8cf6f718-c898-4605-8e60-ae085b569f1d"),
                column: "SettingCategoryId",
                value: new Guid("f71b0459-44ab-499e-b5d7-afca31ab19b5"));

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("c269f856-f3f6-48f8-a6c7-0acac6dbe50b"),
                column: "SettingCategoryId",
                value: new Guid("7dc564b5-9cc9-459e-987a-695fbfcab4a0"));

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("f40d10d2-48a1-4771-b30e-abd65bc2b53d"),
                column: "SettingCategoryId",
                value: new Guid("f71b0459-44ab-499e-b5d7-afca31ab19b5"));

            migrationBuilder.CreateIndex(
                name: "IX_ExternalContentSubscriptions_CoverImageId",
                schema: "content",
                table: "ExternalContentSubscriptions",
                column: "CoverImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalContentSubscriptions_IconImageId",
                schema: "content",
                table: "ExternalContentSubscriptions",
                column: "IconImageId");

            migrationBuilder.CreateIndex(
                name: "IX_ExternalContentSubscriptions_LogoImageId",
                schema: "content",
                table: "ExternalContentSubscriptions",
                column: "LogoImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalContentSubscriptions_Images_CoverImageId",
                schema: "content",
                table: "ExternalContentSubscriptions",
                column: "CoverImageId",
                principalSchema: "content",
                principalTable: "Images",
                principalColumn: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalContentSubscriptions_Images_IconImageId",
                schema: "content",
                table: "ExternalContentSubscriptions",
                column: "IconImageId",
                principalSchema: "content",
                principalTable: "Images",
                principalColumn: "ImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalContentSubscriptions_Images_LogoImageId",
                schema: "content",
                table: "ExternalContentSubscriptions",
                column: "LogoImageId",
                principalSchema: "content",
                principalTable: "Images",
                principalColumn: "ImageId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ExternalContentSubscriptions_Images_CoverImageId",
                schema: "content",
                table: "ExternalContentSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalContentSubscriptions_Images_IconImageId",
                schema: "content",
                table: "ExternalContentSubscriptions");

            migrationBuilder.DropForeignKey(
                name: "FK_ExternalContentSubscriptions_Images_LogoImageId",
                schema: "content",
                table: "ExternalContentSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_ExternalContentSubscriptions_CoverImageId",
                schema: "content",
                table: "ExternalContentSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_ExternalContentSubscriptions_IconImageId",
                schema: "content",
                table: "ExternalContentSubscriptions");

            migrationBuilder.DropIndex(
                name: "IX_ExternalContentSubscriptions_LogoImageId",
                schema: "content",
                table: "ExternalContentSubscriptions");

            migrationBuilder.DropColumn(
                name: "AccessToken",
                schema: "content",
                table: "ExternalContentSubscriptions");

            migrationBuilder.DropColumn(
                name: "CoverImageId",
                schema: "content",
                table: "ExternalContentSubscriptions");

            migrationBuilder.DropColumn(
                name: "IconImageId",
                schema: "content",
                table: "ExternalContentSubscriptions");

            migrationBuilder.DropColumn(
                name: "LogoImageId",
                schema: "content",
                table: "ExternalContentSubscriptions");

            migrationBuilder.DropColumn(
                name: "SubTitle",
                schema: "content",
                table: "ExternalContentSubscriptions");

            migrationBuilder.RenameColumn(
                name: "WebsiteUrl",
                schema: "content",
                table: "ExternalContentSubscriptions",
                newName: "SiteName");

            migrationBuilder.RenameColumn(
                name: "Language",
                schema: "content",
                table: "ExternalContentSubscriptions",
                newName: "Robots");

            migrationBuilder.RenameColumn(
                name: "Copyright",
                schema: "content",
                table: "ExternalContentSubscriptions",
                newName: "CharSet");

            migrationBuilder.AlterColumn<string>(
                name: "Locale",
                schema: "content",
                table: "ExternalContentSubscriptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 4)
                .OldAnnotation("Relational:ColumnOrder", 7);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                schema: "content",
                table: "ExternalContentSubscriptions",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(500)",
                oldMaxLength: 500)
                .Annotation("Relational:ColumnOrder", 3)
                .OldAnnotation("Relational:ColumnOrder", 4);

            migrationBuilder.AlterColumn<string>(
                name: "SiteName",
                schema: "content",
                table: "ExternalContentSubscriptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 7)
                .OldAnnotation("Relational:ColumnOrder", 5);

            migrationBuilder.AlterColumn<string>(
                name: "Robots",
                schema: "content",
                table: "ExternalContentSubscriptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 6)
                .OldAnnotation("Relational:ColumnOrder", 8);

            migrationBuilder.AlterColumn<string>(
                name: "CharSet",
                schema: "content",
                table: "ExternalContentSubscriptions",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 5)
                .OldAnnotation("Relational:ColumnOrder", 6);

            migrationBuilder.AddColumn<Guid>(
                name: "PreviewImageId",
                schema: "content",
                table: "ExternalContentSubscriptions",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"))
                .Annotation("Relational:ColumnOrder", 9);

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("0e5df38d-9b2a-4263-8dd2-624b3391e0dc"),
                column: "SettingCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("214315b5-6109-40ca-b23b-4419b4369de7"),
                column: "SettingCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("5fcf50f5-2d8a-4085-82c0-b0a6316b129f"),
                column: "SettingCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("64bd6c09-bd2e-47d9-92c3-a215fd30f342"),
                column: "SettingCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("68c8d22a-85fd-4ace-918f-33b9949ba7bb"),
                column: "SettingCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("8cf6f718-c898-4605-8e60-ae085b569f1d"),
                column: "SettingCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("c269f856-f3f6-48f8-a6c7-0acac6dbe50b"),
                column: "SettingCategoryId",
                value: null);

            migrationBuilder.UpdateData(
                schema: "config",
                table: "Settings",
                keyColumn: "SystemSettingId",
                keyValue: new Guid("f40d10d2-48a1-4771-b30e-abd65bc2b53d"),
                column: "SettingCategoryId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_ExternalContentSubscriptions_PreviewImageId",
                schema: "content",
                table: "ExternalContentSubscriptions",
                column: "PreviewImageId");

            migrationBuilder.AddForeignKey(
                name: "FK_ExternalContentSubscriptions_Images_PreviewImageId",
                schema: "content",
                table: "ExternalContentSubscriptions",
                column: "PreviewImageId",
                principalSchema: "content",
                principalTable: "Images",
                principalColumn: "ImageId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
