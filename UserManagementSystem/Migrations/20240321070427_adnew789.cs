using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class adnew789 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<string>(
                name: "Status",
                table: "Posts",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "NameRole" },
                values: new object[,]
                {
                    { new Guid("1aa358b9-af20-438b-bb45-05027de24d87"), "Admin" },
                    { new Guid("79e94fa0-7ccc-4f35-a5fe-769deabcfc79"), "Manager" },
                    { new Guid("99d66f10-b364-4c22-9366-30027f0f1f22"), "Staff" },
                    { new Guid("a2984f5b-fd2a-4e5b-a849-e8902dd90a44"), "Customer" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("1aa358b9-af20-438b-bb45-05027de24d87"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("79e94fa0-7ccc-4f35-a5fe-769deabcfc79"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("99d66f10-b364-4c22-9366-30027f0f1f22"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("a2984f5b-fd2a-4e5b-a849-e8902dd90a44"));

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Posts");

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
    }
}
