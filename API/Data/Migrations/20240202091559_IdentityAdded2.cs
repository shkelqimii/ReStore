using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace API.Data.Migrations
{
    /// <inheritdoc />
    public partial class IdentityAdded2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a63c923e-00ae-4787-8239-43cb24bf6277");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e560a1dc-11a5-48c3-9262-6e117a08d34c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "af8753c7-e723-40b2-abd5-9ca37065f96d", null, "Member", "MEMBER" },
                    { "ccf7b08a-530e-464c-9e4a-48d66a199c34", null, "Admin", "ADMIN" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                    { "a63c923e-00ae-4787-8239-43cb24bf6277", null, "Admin", "ADMIN" },
                    { "e560a1dc-11a5-48c3-9262-6e117a08d34c", null, "Member", "MEMBER" }
                });
        }
    }
}
