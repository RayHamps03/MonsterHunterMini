using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MonsterHunterMini.Migrations
{
    /// <inheritdoc />
    public partial class SeedInitialMaterials : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Material",
                columns: new[] { "MaterialId", "ArmorWeaponId", "MonsterId", "Name", "PlayerId", "WeaponId" },
                values: new object[,]
                {
                    { 1, null, null, "Rathalos Scale", null, null },
                    { 2, null, null, "Rathalos Tail", null, null },
                    { 3, null, null, "Rathalos Webbing", null, null },
                    { 4, null, null, "Rathian Scale", null, null },
                    { 5, null, null, "Rathian Tail", null, null },
                    { 6, null, null, "Rathian Webbing", null, null },
                    { 7, null, null, "Diablos Ridge", null, null },
                    { 8, null, null, "Diablos Tailcase", null, null },
                    { 9, null, null, "Twisted Horn", null, null }
                });

            migrationBuilder.InsertData(
                table: "Monsters",
                columns: new[] { "MonsterId", "Attack", "Defense", "Name" },
                values: new object[,]
                {
                    { 5, 4, 4, "Yian-Kut-Ku" },
                    { 6, 4, 3, "Iodrome" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "MonsterId",
                keyValue: 6);
        }
    }
}
