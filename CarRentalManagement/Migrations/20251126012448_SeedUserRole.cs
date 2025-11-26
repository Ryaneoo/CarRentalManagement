using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedUserRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "ad2bcf0c-20db-474f-8407-5a6b159518ba", null, "Administrator", "ADMINISTRATOR" },
                    { "bd2bcf0c-20db-474f-8407-5a6b159518bb", null, "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3781efa7-66dc-47f0-860f-e506d04102e4", 0, "c2c19d4d-07ad-4f22-9d19-d9792cda9ef3", "admin@localhost.com", true, "Admin", "User", false, null, "ADMIN@LOCALHOST.COM", "ADMIN@LOCALHOST.COM", "AQAAAAIAAYagAAAAEJuMfQnIR7/TNf2Hc4G88Y7cstkFKU3teO4dLlF09cCx9F6HZHR9zfLTNn7l3RoHHA==", null, false, "59dbb51e-f3bc-480d-9f1c-b2e4bbde37cd", false, "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 24, 47, 745, DateTimeKind.Local).AddTicks(3648), new DateTime(2025, 11, 26, 9, 24, 47, 745, DateTimeKind.Local).AddTicks(3662) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 24, 47, 745, DateTimeKind.Local).AddTicks(3664), new DateTime(2025, 11, 26, 9, 24, 47, 745, DateTimeKind.Local).AddTicks(3664) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 24, 47, 745, DateTimeKind.Local).AddTicks(3820), new DateTime(2025, 11, 26, 9, 24, 47, 745, DateTimeKind.Local).AddTicks(3820) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 24, 47, 745, DateTimeKind.Local).AddTicks(3822), new DateTime(2025, 11, 26, 9, 24, 47, 745, DateTimeKind.Local).AddTicks(3823) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 24, 47, 745, DateTimeKind.Local).AddTicks(3891), new DateTime(2025, 11, 26, 9, 24, 47, 745, DateTimeKind.Local).AddTicks(3891) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 24, 47, 745, DateTimeKind.Local).AddTicks(3893), new DateTime(2025, 11, 26, 9, 24, 47, 745, DateTimeKind.Local).AddTicks(3893) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 24, 47, 745, DateTimeKind.Local).AddTicks(3895), new DateTime(2025, 11, 26, 9, 24, 47, 745, DateTimeKind.Local).AddTicks(3895) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 26, 9, 24, 47, 745, DateTimeKind.Local).AddTicks(3896), new DateTime(2025, 11, 26, 9, 24, 47, 745, DateTimeKind.Local).AddTicks(3897) });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd2bcf0c-20db-474f-8407-5a6b159518bb");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ad2bcf0c-20db-474f-8407-5a6b159518ba", "3781efa7-66dc-47f0-860f-e506d04102e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ad2bcf0c-20db-474f-8407-5a6b159518ba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3781efa7-66dc-47f0-860f-e506d04102e4");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "AspNetUsers");

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 51, 18, 208, DateTimeKind.Local).AddTicks(8370), new DateTime(2025, 11, 24, 16, 51, 18, 208, DateTimeKind.Local).AddTicks(8384) });

            migrationBuilder.UpdateData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 51, 18, 208, DateTimeKind.Local).AddTicks(8386), new DateTime(2025, 11, 24, 16, 51, 18, 208, DateTimeKind.Local).AddTicks(8387) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 51, 18, 208, DateTimeKind.Local).AddTicks(8572), new DateTime(2025, 11, 24, 16, 51, 18, 208, DateTimeKind.Local).AddTicks(8573) });

            migrationBuilder.UpdateData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 51, 18, 208, DateTimeKind.Local).AddTicks(8575), new DateTime(2025, 11, 24, 16, 51, 18, 208, DateTimeKind.Local).AddTicks(8576) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 51, 18, 208, DateTimeKind.Local).AddTicks(8656), new DateTime(2025, 11, 24, 16, 51, 18, 208, DateTimeKind.Local).AddTicks(8656) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 51, 18, 208, DateTimeKind.Local).AddTicks(8658), new DateTime(2025, 11, 24, 16, 51, 18, 208, DateTimeKind.Local).AddTicks(8659) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 51, 18, 208, DateTimeKind.Local).AddTicks(8660), new DateTime(2025, 11, 24, 16, 51, 18, 208, DateTimeKind.Local).AddTicks(8661) });

            migrationBuilder.UpdateData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "DateCreated", "DateUpdated" },
                values: new object[] { new DateTime(2025, 11, 24, 16, 51, 18, 208, DateTimeKind.Local).AddTicks(8662), new DateTime(2025, 11, 24, 16, 51, 18, 208, DateTimeKind.Local).AddTicks(8663) });
        }
    }
}
