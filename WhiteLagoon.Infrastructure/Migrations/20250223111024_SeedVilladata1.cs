using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WhiteLagoon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedVilladata1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: ["CreatedAt", "UpdatedAt"],
                values: [new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified)]);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: ["CreatedAt", "UpdatedAt"],
                values: [new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified)]);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: ["CreatedAt", "UpdatedAt"],
                values: [new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 1, 1, 12, 0, 0, 0, DateTimeKind.Unspecified)]);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1,
                columns: ["CreatedAt", "UpdatedAt"],
                values: [new DateTime(2025, 2, 23, 16, 37, 39, 576, DateTimeKind.Local).AddTicks(6041), new DateTime(2025, 2, 23, 16, 37, 39, 578, DateTimeKind.Local).AddTicks(9)]);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2,
                columns: ["CreatedAt", "UpdatedAt"],
                values: [new DateTime(2025, 2, 23, 16, 37, 39, 578, DateTimeKind.Local).AddTicks(367), new DateTime(2025, 2, 23, 16, 37, 39, 578, DateTimeKind.Local).AddTicks(370)]);

            migrationBuilder.UpdateData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3,
                columns: ["CreatedAt", "UpdatedAt"],
                values: [new DateTime(2025, 2, 23, 16, 37, 39, 578, DateTimeKind.Local).AddTicks(372), new DateTime(2025, 2, 23, 16, 37, 39, 578, DateTimeKind.Local).AddTicks(373)]);
        }
    }
}
