using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessLogic.Migrations
{
    /// <inheritdoc />
    public partial class ChangeAC : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: new Guid("49b62e77-ddfb-430c-8996-b85806be91ff"));

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: new Guid("587596d8-a08c-4029-b0a7-ba801364a61f"));

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: new Guid("666e3a10-7f73-492e-998d-8629922b7873"));

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: new Guid("b391e892-99bf-4e48-965a-d19700fadd82"));

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: new Guid("c031b307-6e59-4377-907d-86adc1ec324e"));

            migrationBuilder.InsertData(
                table: "Monsters",
                columns: new[] { "Id", "AC", "AttackModifier", "AttackPerRound", "Damage", "DamageModifier", "HitPoints", "Name" },
                values: new object[,]
                {
                    { new Guid("07cc2e2f-e7e9-4602-a152-84443ce179d9"), 12, 8, 4, "1d10", 3, 4, "Monster4" },
                    { new Guid("38c7eda9-f9d2-4ae0-8bd6-3bdf5fa6c69a"), 13, 3, 1, "1d12", 3, 24, "Monster5" },
                    { new Guid("390d5ae7-7be4-4eae-bd64-748fafa0a049"), 3, 10, 3, "1d20", 1, 26, "Monster1" },
                    { new Guid("4dffb04a-44ec-4c32-bce3-2f5cac57a993"), 13, 1, 1, "1d8", 4, 46, "Monster2" },
                    { new Guid("ffaa3f1d-a1e6-4a38-8550-dde3922cee63"), 15, 2, 4, "2d4", 4, 21, "Monster3" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: new Guid("07cc2e2f-e7e9-4602-a152-84443ce179d9"));

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: new Guid("38c7eda9-f9d2-4ae0-8bd6-3bdf5fa6c69a"));

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: new Guid("390d5ae7-7be4-4eae-bd64-748fafa0a049"));

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: new Guid("4dffb04a-44ec-4c32-bce3-2f5cac57a993"));

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: new Guid("ffaa3f1d-a1e6-4a38-8550-dde3922cee63"));

            migrationBuilder.InsertData(
                table: "Monsters",
                columns: new[] { "Id", "AC", "AttackModifier", "AttackPerRound", "Damage", "DamageModifier", "HitPoints", "Name" },
                values: new object[,]
                {
                    { new Guid("49b62e77-ddfb-430c-8996-b85806be91ff"), 3, 9, 5, "1d12", 5, 13, "Monster5" },
                    { new Guid("587596d8-a08c-4029-b0a7-ba801364a61f"), 5, 4, 1, "1d8", 3, 26, "Monster2" },
                    { new Guid("666e3a10-7f73-492e-998d-8629922b7873"), 15, 5, 2, "1d10", 2, 27, "Monster4" },
                    { new Guid("b391e892-99bf-4e48-965a-d19700fadd82"), 19, 8, 2, "2d4", 1, 1, "Monster3" },
                    { new Guid("c031b307-6e59-4377-907d-86adc1ec324e"), 9, 7, 5, "1d20", 3, 8, "Monster1" }
                });
        }
    }
}
