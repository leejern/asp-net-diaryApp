using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace DiaryApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedSeedingDataDiaryEntry : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "DiaryEntries",
                columns: new[] { "Id", "Content", "DateCreated", "Title" },
                values: new object[,]
                {
                    { 1, "This is my first diary entry.", new DateTime(2024, 11, 27, 18, 4, 27, 523, DateTimeKind.Local).AddTicks(4899), "First Entry" },
                    { 2, "This is my second diary entry.", new DateTime(2024, 11, 27, 18, 4, 27, 523, DateTimeKind.Local).AddTicks(4903), "Second Entry" },
                    { 3, "This is my third unhappy entry.", new DateTime(2024, 11, 27, 18, 4, 27, 523, DateTimeKind.Local).AddTicks(4907), "Third Entry" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "DiaryEntries",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
