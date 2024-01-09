using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessLogic.Migrations
{
    /// <inheritdoc />
    public partial class ChangeDamageType : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "Damage",
                table: "Monsters",
                type: "text",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "integer");

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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<int>(
                name: "Damage",
                table: "Monsters",
                type: "integer",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(string),
                oldType: "text",
                oldNullable: true);

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
    }
}
