using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FuarProjesi.Migrations
{
    /// <inheritdoc />
    public partial class _17kasimmm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Yaratılma Tarihi",
                value: new DateTime(2023, 11, 17, 15, 32, 53, 468, DateTimeKind.Utc).AddTicks(6822));

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId", "Yaratılma Tarihi", "DeletedDate", "ModifiedDate", "Status" },
                values: new object[] { 1, 1, new DateTime(2023, 11, 17, 15, 32, 53, 468, DateTimeKind.Utc).AddTicks(6824), null, null, 1 });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "dea4f2a1-d50a-4ba5-aeb5-2fee874c9b47");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: 1,
                column: "Yaratılma Tarihi",
                value: new DateTime(2023, 11, 17, 15, 26, 58, 98, DateTimeKind.Utc).AddTicks(9763));

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: 1,
                column: "ConcurrencyStamp",
                value: "cff10f13-6368-4907-a8bd-6f3124aaaffc");
        }
    }
}
