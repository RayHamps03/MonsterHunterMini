using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MonsterHunterMini.Migrations
{
    /// <inheritdoc />
    public partial class EquipmentNavProperty : Migration
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

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 1,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 2,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 3,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { 1, 1 });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 4,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 5,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 6,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { 2, 2 });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 7,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 8,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { 3, 3 });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 9,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { 3, 3 });

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

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 1,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 2,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 3,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 4,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 5,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 6,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 7,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 8,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 9,
                columns: new[] { "ArmorId", "WeaponId" },
                values: new object[] { null, null });
        }
    }
}
