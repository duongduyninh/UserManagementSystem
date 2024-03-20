using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class addnew999 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "NameRole" },
                values: new object[,]
                {
                    { new Guid("2459dcc7-a506-4f24-9d32-38d12399cc09"), "Admin" },
                    { new Guid("a12c6950-efb8-4365-a199-9ca524efe476"), "Customer" },
                    { new Guid("b30b93ac-cbd6-40cb-9993-82cd0d18320e"), "Staff" },
                    { new Guid("fbbbea11-e2d2-4faf-b133-bcdad9b86511"), "Manager" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("2459dcc7-a506-4f24-9d32-38d12399cc09"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a12c6950-efb8-4365-a199-9ca524efe476"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("b30b93ac-cbd6-40cb-9993-82cd0d18320e"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("fbbbea11-e2d2-4faf-b133-bcdad9b86511"));
        }
    }
}
