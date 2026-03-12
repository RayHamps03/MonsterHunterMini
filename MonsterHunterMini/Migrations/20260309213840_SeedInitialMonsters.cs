using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MonsterHunterMini.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialMonsters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Monsters",
                columns: new[] { "MonsterId", "Attack", "Defense", "Name" },
                values: new object[,]
                {
                    { 1, 7, 7, "Rathalos" },
                    { 2, 9, 7, "Rathian" },
                    { 3, 6, 7, "Diablos" },
                    { 4, 3, 3, "Velocidrome" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 4);
        }
    }
}
