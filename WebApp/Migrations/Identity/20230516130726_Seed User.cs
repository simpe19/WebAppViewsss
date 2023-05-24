using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApp.Migrations.Identity
{
    /// <inheritdoc />
    public partial class SeedUser : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c39cfe9d-5d5f-4b15-bf0a-f95dbe86e436");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5c53708f-c4a2-4065-b548-d0a905e4a196", null, "System Administrator", "SYSTEM ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "CompanyName", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "ImageUrl", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bb89850d-ad5d-442b-92cb-2a4bfea43410", 0, null, "b8ceec9d-bbc4-4d76-b1bd-5fd5f86c700b", null, false, "System", null, "Administrator", false, null, null, null, "AQAAAAIAAYagAAAAEEYX51nlyvsIXMLYtJAXxOmfc3IBGHclhkjFGXoMEsYGJW1gqkAHz1U7C8cF5lHhLw==", null, false, "bc0820b5-143c-4987-bbee-54912f07d101", false, "administrator" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5c53708f-c4a2-4065-b548-d0a905e4a196");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb89850d-ad5d-442b-92cb-2a4bfea43410");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c39cfe9d-5d5f-4b15-bf0a-f95dbe86e436", null, "System Administrator", "SYSTEM ADMINISTRATOR" });
        }
    }
}
