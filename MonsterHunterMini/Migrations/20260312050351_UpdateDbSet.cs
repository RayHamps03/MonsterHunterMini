using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonsterHunterMini.Migrations
{
    /// <inheritdoc />
    public partial class UpdateDbSet : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArmorMaterial_Material_RequiredMaterialsMaterialId",
                table: "ArmorMaterial");

            migrationBuilder.DropForeignKey(
                name: "FK_Material_Monsters_MonsterId",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_Material_Players_PlayerId",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialWeapon_Material_RequiredMaterialsMaterialId",
                table: "MaterialWeapon");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialWeapon_Weapon_RequiredByWeaponsWeaponId",
                table: "MaterialWeapon");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Weapon_EquippedWeaponWeaponId",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weapon",
                table: "Weapon");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Material",
                table: "Material");

            migrationBuilder.RenameTable(
                name: "Weapon",
                newName: "Weapons");

            migrationBuilder.RenameTable(
                name: "Material",
                newName: "Materials");

            migrationBuilder.RenameIndex(
                name: "IX_Material_PlayerId",
                table: "Materials",
                newName: "IX_Materials_PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Material_MonsterId",
                table: "Materials",
                newName: "IX_Materials_MonsterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons",
                column: "WeaponId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Materials",
                table: "Materials",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArmorMaterial_Materials_RequiredMaterialsMaterialId",
                table: "ArmorMaterial",
                column: "RequiredMaterialsMaterialId",
                principalTable: "Materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Monsters_MonsterId",
                table: "Materials",
                column: "MonsterId",
                principalTable: "Monsters",
                principalColumn: "MonsterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Players_PlayerId",
                table: "Materials",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialWeapon_Materials_RequiredMaterialsMaterialId",
                table: "MaterialWeapon",
                column: "RequiredMaterialsMaterialId",
                principalTable: "Materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialWeapon_Weapons_RequiredByWeaponsWeaponId",
                table: "MaterialWeapon",
                column: "RequiredByWeaponsWeaponId",
                principalTable: "Weapons",
                principalColumn: "WeaponId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Weapons_EquippedWeaponWeaponId",
                table: "Players",
                column: "EquippedWeaponWeaponId",
                principalTable: "Weapons",
                principalColumn: "WeaponId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArmorMaterial_Materials_RequiredMaterialsMaterialId",
                table: "ArmorMaterial");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Monsters_MonsterId",
                table: "Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Players_PlayerId",
                table: "Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialWeapon_Materials_RequiredMaterialsMaterialId",
                table: "MaterialWeapon");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialWeapon_Weapons_RequiredByWeaponsWeaponId",
                table: "MaterialWeapon");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Weapons_EquippedWeaponWeaponId",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Weapons",
                table: "Weapons");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Materials",
                table: "Materials");

            migrationBuilder.RenameTable(
                name: "Weapons",
                newName: "Weapon");

            migrationBuilder.RenameTable(
                name: "Materials",
                newName: "Material");

            migrationBuilder.RenameIndex(
                name: "IX_Materials_PlayerId",
                table: "Material",
                newName: "IX_Material_PlayerId");

            migrationBuilder.RenameIndex(
                name: "IX_Materials_MonsterId",
                table: "Material",
                newName: "IX_Material_MonsterId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Weapon",
                table: "Weapon",
                column: "WeaponId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Material",
                table: "Material",
                column: "MaterialId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArmorMaterial_Material_RequiredMaterialsMaterialId",
                table: "ArmorMaterial",
                column: "RequiredMaterialsMaterialId",
                principalTable: "Material",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Monsters_MonsterId",
                table: "Material",
                column: "MonsterId",
                principalTable: "Monsters",
                principalColumn: "MonsterId");

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Players_PlayerId",
                table: "Material",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Weapon_EquippedWeaponWeaponId",
                table: "Players",
                column: "EquippedWeaponWeaponId",
                principalTable: "Weapon",
                principalColumn: "WeaponId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
