using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace CarRentalManagement.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Colour",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 1, 57, 42, DateTimeKind.Local).AddTicks(9507), new DateTime(2025, 11, 24, 15, 1, 57, 42, DateTimeKind.Local).AddTicks(9528), "Black", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 1, 57, 42, DateTimeKind.Local).AddTicks(9534), new DateTime(2025, 11, 24, 15, 1, 57, 42, DateTimeKind.Local).AddTicks(9535), "Blue", "System" }
                });

            migrationBuilder.InsertData(
                table: "Make",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 1, 57, 42, DateTimeKind.Local).AddTicks(9996), new DateTime(2025, 11, 24, 15, 1, 57, 42, DateTimeKind.Local).AddTicks(9997), "BMW", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 1, 57, 43, DateTimeKind.Local).AddTicks(2), new DateTime(2025, 11, 24, 15, 1, 57, 43, DateTimeKind.Local).AddTicks(3), "Toyota", "System" }
                });

            migrationBuilder.InsertData(
                table: "Model",
                columns: new[] { "Id", "CreatedBy", "DateCreated", "DateUpdated", "Name", "UpdatedBy" },
                values: new object[,]
                {
                    { 1, "System", new DateTime(2025, 11, 24, 15, 1, 57, 43, DateTimeKind.Local).AddTicks(152), new DateTime(2025, 11, 24, 15, 1, 57, 43, DateTimeKind.Local).AddTicks(153), "i4", "System" },
                    { 2, "System", new DateTime(2025, 11, 24, 15, 1, 57, 43, DateTimeKind.Local).AddTicks(157), new DateTime(2025, 11, 24, 15, 1, 57, 43, DateTimeKind.Local).AddTicks(159), "X5", "System" },
                    { 3, "System", new DateTime(2025, 11, 24, 15, 1, 57, 43, DateTimeKind.Local).AddTicks(162), new DateTime(2025, 11, 24, 15, 1, 57, 43, DateTimeKind.Local).AddTicks(163), "Prius", "System" },
                    { 4, "System", new DateTime(2025, 11, 24, 15, 1, 57, 43, DateTimeKind.Local).AddTicks(166), new DateTime(2025, 11, 24, 15, 1, 57, 43, DateTimeKind.Local).AddTicks(168), "C-HR", "System" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Colour",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Make",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Model",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
