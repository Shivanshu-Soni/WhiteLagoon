using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace WhiteLagoon.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class SeedVilladata : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Villas",
                columns: new[] { "Id", "CreatedAt", "Description", "ImageUrl", "Name", "Occupancy", "Price", "SqFt", "UpdatedAt" },
                values: new object[,]
                {
                    { 1, new DateTime(2025, 2, 23, 16, 37, 39, 576, DateTimeKind.Local).AddTicks(6041), "Villa 1 Description", "https://via.placeholder.com/150", "Villa 1", 4, 1000.0, 2000, new DateTime(2025, 2, 23, 16, 37, 39, 578, DateTimeKind.Local).AddTicks(9) },
                    { 2, new DateTime(2025, 2, 23, 16, 37, 39, 578, DateTimeKind.Local).AddTicks(367), "Villa 2 Description", "https://via.placeholder.com/150", "Villa 2", 6, 2000.0, 3000, new DateTime(2025, 2, 23, 16, 37, 39, 578, DateTimeKind.Local).AddTicks(370) },
                    { 3, new DateTime(2025, 2, 23, 16, 37, 39, 578, DateTimeKind.Local).AddTicks(372), "Villa 3 Description", "https://via.placeholder.com/150", "Villa 3", 8, 3000.0, 4000, new DateTime(2025, 2, 23, 16, 37, 39, 578, DateTimeKind.Local).AddTicks(373) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Villas",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
