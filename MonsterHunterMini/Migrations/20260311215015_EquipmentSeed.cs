using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MonsterHunterMini.Migrations
{
    /// <inheritdoc />
    public partial class EquipmentSeed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Armor",
                columns: new[] { "ArmorId", "Defense", "Name" },
                values: new object[,]
                {
                    { 1, 12.0, "Rathalos Set" },
                    { 2, 10.0, "Rathian Set" },
                    { 3, 15.0, "Diablos Set" }
                });

            migrationBuilder.InsertData(
                table: "Weapon",
                columns: new[] { "WeaponId", "Attack", "Name" },
                values: new object[,]
                {
                    { 1, 10.0, "Rathalos Greatsword" },
                    { 2, 9.0, "Rathian Greatsword" },
                    { 3, 12.0, "Diablos Greatsword" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Armor",
                keyColumn: "ArmorId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Armor",
                keyColumn: "ArmorId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Armor",
                keyColumn: "ArmorId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Weapon",
                keyColumn: "WeaponId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Weapon",
                keyColumn: "WeaponId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Weapon",
                keyColumn: "WeaponId",
                keyValue: 3);
        }
    }
}
