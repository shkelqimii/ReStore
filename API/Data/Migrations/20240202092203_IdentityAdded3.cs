using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class IdentityAdded3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "af8753c7-e723-40b2-abd5-9ca37065f96d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ccf7b08a-530e-464c-9e4a-48d66a199c34");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "7dfc7d1b-ffa6-40a4-8b7b-8c8eb81637cb", null, "Admin", "ADMIN" },
                    { "c69b43cc-66e8-4283-a854-bad782e12281", null, "Member", "MEMBER" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "7dfc7d1b-ffa6-40a4-8b7b-8c8eb81637cb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c69b43cc-66e8-4283-a854-bad782e12281");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "af8753c7-e723-40b2-abd5-9ca37065f96d", null, "Member", "MEMBER" },
                    { "ccf7b08a-530e-464c-9e4a-48d66a199c34", null, "Admin", "ADMIN" }
                });
        }
    }
}
