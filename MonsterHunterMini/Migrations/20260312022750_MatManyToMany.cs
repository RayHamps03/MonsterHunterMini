using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace MonsterHunterMini.Migrations
{
    /// <inheritdoc />
    public partial class MatManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArmorMaterial_Armor_ArmorId",
                table: "ArmorMaterial");

            migrationBuilder.DropForeignKey(
                name: "FK_ArmorMaterial_Material_MaterialsMaterialId",
                table: "ArmorMaterial");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialWeapon_Material_MaterialsMaterialId",
                table: "MaterialWeapon");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialWeapon_Weapon_WeaponsWeaponId",
                table: "MaterialWeapon");

            migrationBuilder.RenameColumn(
                name: "WeaponsWeaponId",
                table: "MaterialWeapon",
                newName: "RequiredMaterialsMaterialId");

            migrationBuilder.RenameColumn(
                name: "MaterialsMaterialId",
                table: "MaterialWeapon",
                newName: "RequiredByWeaponsWeaponId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialWeapon_WeaponsWeaponId",
                table: "MaterialWeapon",
                newName: "IX_MaterialWeapon_RequiredMaterialsMaterialId");

            migrationBuilder.RenameColumn(
                name: "MaterialsMaterialId",
                table: "ArmorMaterial",
                newName: "RequiredMaterialsMaterialId");

            migrationBuilder.RenameColumn(
                name: "ArmorId",
                table: "ArmorMaterial",
                newName: "RequiredByArmorArmorId");

            migrationBuilder.RenameIndex(
                name: "IX_ArmorMaterial_MaterialsMaterialId",
                table: "ArmorMaterial",
                newName: "IX_ArmorMaterial_RequiredMaterialsMaterialId");

            migrationBuilder.InsertData(
                table: "ArmorMaterial",
                columns: new[] { "RequiredByArmorArmorId", "RequiredMaterialsMaterialId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 }
                });

            migrationBuilder.InsertData(
                table: "MaterialWeapon",
                columns: new[] { "RequiredByWeaponsWeaponId", "RequiredMaterialsMaterialId" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 4 },
                    { 2, 5 },
                    { 2, 6 },
                    { 3, 7 },
                    { 3, 8 },
                    { 3, 9 }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ArmorMaterial_Armor_RequiredByArmorArmorId",
                table: "ArmorMaterial",
                column: "RequiredByArmorArmorId",
                principalTable: "Armor",
                principalColumn: "ArmorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArmorMaterial_Material_RequiredMaterialsMaterialId",
                table: "ArmorMaterial",
                column: "RequiredMaterialsMaterialId",
                principalTable: "Material",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialWeapon_Material_RequiredMaterialsMaterialId",
                table: "MaterialWeapon",
                column: "RequiredMaterialsMaterialId",
                principalTable: "Material",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialWeapon_Weapon_RequiredByWeaponsWeaponId",
                table: "MaterialWeapon",
                column: "RequiredByWeaponsWeaponId",
                principalTable: "Weapon",
                principalColumn: "WeaponId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArmorMaterial_Armor_RequiredByArmorArmorId",
                table: "ArmorMaterial");

            migrationBuilder.DropForeignKey(
                name: "FK_ArmorMaterial_Material_RequiredMaterialsMaterialId",
                table: "ArmorMaterial");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialWeapon_Material_RequiredMaterialsMaterialId",
                table: "MaterialWeapon");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialWeapon_Weapon_RequiredByWeaponsWeaponId",
                table: "MaterialWeapon");

            migrationBuilder.DeleteData(
                table: "ArmorMaterial",
                keyColumns: new[] { "RequiredByArmorArmorId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "ArmorMaterial",
                keyColumns: new[] { "RequiredByArmorArmorId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "ArmorMaterial",
                keyColumns: new[] { "RequiredByArmorArmorId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "ArmorMaterial",
                keyColumns: new[] { "RequiredByArmorArmorId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "ArmorMaterial",
                keyColumns: new[] { "RequiredByArmorArmorId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "ArmorMaterial",
                keyColumns: new[] { "RequiredByArmorArmorId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "ArmorMaterial",
                keyColumns: new[] { "RequiredByArmorArmorId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "ArmorMaterial",
                keyColumns: new[] { "RequiredByArmorArmorId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "ArmorMaterial",
                keyColumns: new[] { "RequiredByArmorArmorId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.DeleteData(
                table: "MaterialWeapon",
                keyColumns: new[] { "RequiredByWeaponsWeaponId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MaterialWeapon",
                keyColumns: new[] { "RequiredByWeaponsWeaponId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "MaterialWeapon",
                keyColumns: new[] { "RequiredByWeaponsWeaponId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "MaterialWeapon",
                keyColumns: new[] { "RequiredByWeaponsWeaponId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "MaterialWeapon",
                keyColumns: new[] { "RequiredByWeaponsWeaponId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 2, 5 });

            migrationBuilder.DeleteData(
                table: "MaterialWeapon",
                keyColumns: new[] { "RequiredByWeaponsWeaponId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 2, 6 });

            migrationBuilder.DeleteData(
                table: "MaterialWeapon",
                keyColumns: new[] { "RequiredByWeaponsWeaponId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "MaterialWeapon",
                keyColumns: new[] { "RequiredByWeaponsWeaponId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 3, 8 });

            migrationBuilder.DeleteData(
                table: "MaterialWeapon",
                keyColumns: new[] { "RequiredByWeaponsWeaponId", "RequiredMaterialsMaterialId" },
                keyValues: new object[] { 3, 9 });

            migrationBuilder.RenameColumn(
                name: "RequiredMaterialsMaterialId",
                table: "MaterialWeapon",
                newName: "WeaponsWeaponId");

            migrationBuilder.RenameColumn(
                name: "RequiredByWeaponsWeaponId",
                table: "MaterialWeapon",
                newName: "MaterialsMaterialId");

            migrationBuilder.RenameIndex(
                name: "IX_MaterialWeapon_RequiredMaterialsMaterialId",
                table: "MaterialWeapon",
                newName: "IX_MaterialWeapon_WeaponsWeaponId");

            migrationBuilder.RenameColumn(
                name: "RequiredMaterialsMaterialId",
                table: "ArmorMaterial",
                newName: "MaterialsMaterialId");

            migrationBuilder.RenameColumn(
                name: "RequiredByArmorArmorId",
                table: "ArmorMaterial",
                newName: "ArmorId");

            migrationBuilder.RenameIndex(
                name: "IX_ArmorMaterial_RequiredMaterialsMaterialId",
                table: "ArmorMaterial",
                newName: "IX_ArmorMaterial_MaterialsMaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArmorMaterial_Armor_ArmorId",
                table: "ArmorMaterial",
                column: "ArmorId",
                principalTable: "Armor",
                principalColumn: "ArmorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArmorMaterial_Material_MaterialsMaterialId",
                table: "ArmorMaterial",
                column: "MaterialsMaterialId",
                principalTable: "Material",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialWeapon_Material_MaterialsMaterialId",
                table: "MaterialWeapon",
                column: "MaterialsMaterialId",
                principalTable: "Material",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialWeapon_Weapon_WeaponsWeaponId",
                table: "MaterialWeapon",
                column: "WeaponsWeaponId",
                principalTable: "Weapon",
                principalColumn: "WeaponId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
