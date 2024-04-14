using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Astrana.Core.Data.Migrations.MSSqlServer.Migrations
{
    /// <inheritdoc />
    public partial class ExternalContentSubscription2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_ExternalContentSubscriptions_Url",
                schema: "content",
                table: "ExternalContentSubscriptions",
                column: "Url",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_ExternalContentSubscriptions_Url",
                schema: "content",
                table: "ExternalContentSubscriptions");
        }
    }
}
