using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace UserManagementSystem.Migrations
{
    /// <inheritdoc />
    public partial class addnew99098 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "IdUser",
                table: "Posts");

            migrationBuilder.AddColumn<Guid>(
                name: "UserId",
                table: "Posts",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "NameRole" },
                values: new object[,]
                {
                    { new Guid("084e08eb-75cf-420e-a9aa-46740f917a38"), "Manager" },
                    { new Guid("086bd35e-60f1-4391-8be6-ed17e1979302"), "Customer" },
                    { new Guid("876a39de-4e4e-429b-8883-d85af31e4f01"), "Staff" },
                    { new Guid("ffd7e0d7-2623-4fe0-925e-cc96a1b1d06f"), "Admin" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Posts_UserId",
                table: "Posts",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Posts_Users_UserId",
                table: "Posts");

            migrationBuilder.DropIndex(
                name: "IX_Posts_UserId",
                table: "Posts");

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("084e08eb-75cf-420e-a9aa-46740f917a38"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("086bd35e-60f1-4391-8be6-ed17e1979302"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("876a39de-4e4e-429b-8883-d85af31e4f01"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("ffd7e0d7-2623-4fe0-925e-cc96a1b1d06f"));

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "Posts");

            migrationBuilder.AddColumn<int>(
                name: "IdUser",
                table: "Posts",
                type: "int",
                nullable: false,
                defaultValue: 0);

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
    }
}
