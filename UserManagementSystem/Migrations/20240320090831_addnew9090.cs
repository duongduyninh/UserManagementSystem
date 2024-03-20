using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class addnew9090 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "RoleId",
                table: "Users");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "NameRole" },
                values: new object[,]
                {
                    { new Guid("3b3ad0f9-c812-4298-b3d7-b51a107fbcd9"), "Staff" },
                    { new Guid("801ca525-736f-45ee-a92b-a39621956d34"), "Customer" },
                    { new Guid("841d58b2-a9c5-466e-97df-c3faa3f5a9bc"), "Manager" },
                    { new Guid("bc3dbfa8-b3a8-4a9a-822c-45f85aefb113"), "Admin" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("3b3ad0f9-c812-4298-b3d7-b51a107fbcd9"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("801ca525-736f-45ee-a92b-a39621956d34"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("841d58b2-a9c5-466e-97df-c3faa3f5a9bc"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("bc3dbfa8-b3a8-4a9a-822c-45f85aefb113"));

            migrationBuilder.AddColumn<int>(
                name: "RoleId",
                table: "Users",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
