using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace LeaveManagementSystem.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class IdentityUserAndRoleAndDataSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "a80f92ca-0961-4d0a-9576-1211a89b23f3", null, "Employee", "EMPLOYEE" },
                    { "b47ad046-1092-43bb-a2f0-e697bde302d2", null, "Admin", "ADMIN" },
                    { "d1683113-5b67-4a62-b096-c619583c6195", null, "Supervisor", "SUPERVISOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d46ad749-c5cb-4e69-8e5a-e2e7e308e837", 0, "19913130-4b57-41a0-801f-bf2e5e7a56dd", "admin@gmail.com", true, false, null, "ADMIN@GMAIL.COM", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEG3ObqcKtCTayv/YKLC+uWwk+jX9+tm5pbg5XtQt0duj8MByKMHryXaVH5zTqWCumg==", null, false, "0221e926-c487-409b-88a3-b3233ccc6d8e", false, "admin@gmail.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b47ad046-1092-43bb-a2f0-e697bde302d2", "d46ad749-c5cb-4e69-8e5a-e2e7e308e837" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a80f92ca-0961-4d0a-9576-1211a89b23f3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d1683113-5b67-4a62-b096-c619583c6195");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b47ad046-1092-43bb-a2f0-e697bde302d2", "d46ad749-c5cb-4e69-8e5a-e2e7e308e837" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b47ad046-1092-43bb-a2f0-e697bde302d2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d46ad749-c5cb-4e69-8e5a-e2e7e308e837");
        }
    }
}
