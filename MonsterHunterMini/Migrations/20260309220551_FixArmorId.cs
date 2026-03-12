using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonsterHunterMini.Migrations
{
    /// <inheritdoc />
    public partial class FixArmorId : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Material_Armor_ArmorWeaponId",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Armor_EquippedArmorWeaponId",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "EquippedArmorWeaponId",
                table: "Players",
                newName: "EquippedArmorArmorId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_EquippedArmorWeaponId",
                table: "Players",
                newName: "IX_Players_EquippedArmorArmorId");

            migrationBuilder.RenameColumn(
                name: "ArmorWeaponId",
                table: "Material",
                newName: "ArmorId");

            migrationBuilder.RenameIndex(
                name: "IX_Material_ArmorWeaponId",
                table: "Material",
                newName: "IX_Material_ArmorId");

            migrationBuilder.RenameColumn(
                name: "WeaponId",
                table: "Armor",
                newName: "ArmorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Armor_ArmorId",
                table: "Material",
                column: "ArmorId",
                principalTable: "Armor",
                principalColumn: "ArmorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Armor_EquippedArmorArmorId",
                table: "Players",
                column: "EquippedArmorArmorId",
                principalTable: "Armor",
                principalColumn: "ArmorId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Material_Armor_ArmorId",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Armor_EquippedArmorArmorId",
                table: "Players");

            migrationBuilder.RenameColumn(
                name: "EquippedArmorArmorId",
                table: "Players",
                newName: "EquippedArmorWeaponId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_EquippedArmorArmorId",
                table: "Players",
                newName: "IX_Players_EquippedArmorWeaponId");

            migrationBuilder.RenameColumn(
                name: "ArmorId",
                table: "Material",
                newName: "ArmorWeaponId");

            migrationBuilder.RenameIndex(
                name: "IX_Material_ArmorId",
                table: "Material",
                newName: "IX_Material_ArmorWeaponId");

            migrationBuilder.RenameColumn(
                name: "ArmorId",
                table: "Armor",
                newName: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Armor_ArmorWeaponId",
                table: "Material",
                column: "ArmorWeaponId",
                principalTable: "Armor",
                principalColumn: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Armor_EquippedArmorWeaponId",
                table: "Players",
                column: "EquippedArmorWeaponId",
                principalTable: "Armor",
                principalColumn: "WeaponId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
