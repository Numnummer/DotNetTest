using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessLogic.Migrations
{
    /// <inheritdoc />
    public partial class AddMonsters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Monsters",
                columns: new[] { "Id", "AC", "AttackModifier", "AttackPerRound", "Damage", "DamageModifier", "HitPoints", "Name" },
                values: new object[,]
                {
                    { new Guid("426f73d2-a8dc-4564-8dc0-c984219f1305"), 22, 3, 5, 6, 4, 44, "Monster4" },
                    { new Guid("71c59502-89de-45c2-87cc-fdc83ce05898"), 16, 4, 4, 5, 2, 15, "Monster2" },
                    { new Guid("a08557ce-9156-4958-b78e-2ecc6cc13ede"), 21, 10, 1, 8, 5, 46, "Monster3" },
                    { new Guid("dc1cbf3c-f4b1-4af8-a1e0-3b82cd94b49c"), 21, 3, 1, 4, 3, 43, "Monster5" },
                    { new Guid("e4157234-1fc2-4710-8e76-d398cab9697d"), 23, 6, 5, 2, 2, 22, "Monster1" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: new Guid("426f73d2-a8dc-4564-8dc0-c984219f1305"));

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: new Guid("71c59502-89de-45c2-87cc-fdc83ce05898"));

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: new Guid("a08557ce-9156-4958-b78e-2ecc6cc13ede"));

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: new Guid("dc1cbf3c-f4b1-4af8-a1e0-3b82cd94b49c"));

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: new Guid("e4157234-1fc2-4710-8e76-d398cab9697d"));
        }
    }
}
