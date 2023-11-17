using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuarProjesi.Migrations
{
    /// <inheritdoc />
    public partial class _17kasimmmmm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Yaratılma Tarihi",
                value: new DateTime(2023, 11, 17, 15, 49, 32, 784, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Yaratılma Tarihi", "DeletedDate", "ModifiedDate", "Name", "NormalizedName", "Status" },
                values: new object[] { 2, null, new DateTime(2023, 11, 17, 15, 49, 32, 784, DateTimeKind.Utc).AddTicks(1885), null, null, "Member", null, 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "Yaratılma Tarihi",
                value: new DateTime(2023, 11, 17, 15, 49, 32, 784, DateTimeKind.Utc).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f6173252-78cc-4cb6-a28a-3da5a701dc29", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Yaratılma Tarihi",
                value: new DateTime(2023, 11, 17, 15, 32, 53, 468, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.UpdateData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 },
                column: "Yaratılma Tarihi",
                value: new DateTime(2023, 11, 17, 15, 32, 53, 468, DateTimeKind.Utc).AddTicks(6824));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dea4f2a1-d50a-4ba5-aeb5-2fee874c9b47", "123" });
        }
    }
}
