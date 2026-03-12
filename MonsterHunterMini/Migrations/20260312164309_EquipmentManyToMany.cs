using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonsterHunterMini.Migrations
{
    /// <inheritdoc />
    public partial class EquipmentManyToMany : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Players_Armor_EquippedArmorArmorId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Weapons_EquippedWeaponWeaponId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_EquippedArmorArmorId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_EquippedWeaponWeaponId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "EquippedArmorArmorId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "EquippedWeaponWeaponId",
                table: "Players");

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Weapons",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Armor",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Armor",
                keyColumn: "ArmorId",
                keyValue: 1,
                column: "PlayerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Armor",
                keyColumn: "ArmorId",
                keyValue: 2,
                column: "PlayerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Armor",
                keyColumn: "ArmorId",
                keyValue: 3,
                column: "PlayerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 1,
                column: "PlayerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 2,
                column: "PlayerId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Weapons",
                keyColumn: "WeaponId",
                keyValue: 3,
                column: "PlayerId",
                value: null);

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_PlayerId",
                table: "Weapons",
                column: "PlayerId",
                unique: true,
                filter: "[PlayerId] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Armor_PlayerId",
                table: "Armor",
                column: "PlayerId",
                unique: true,
                filter: "[PlayerId] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Armor_Players_PlayerId",
                table: "Armor",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Players_PlayerId",
                table: "Weapons",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armor_Players_PlayerId",
                table: "Armor");

            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Players_PlayerId",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Weapons_PlayerId",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Armor_PlayerId",
                table: "Armor");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Weapons");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Armor");

            migrationBuilder.AddColumn<int>(
                name: "EquippedArmorArmorId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EquippedWeaponWeaponId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Players_EquippedArmorArmorId",
                table: "Players",
                column: "EquippedArmorArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_EquippedWeaponWeaponId",
                table: "Players",
                column: "EquippedWeaponWeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Armor_EquippedArmorArmorId",
                table: "Players",
                column: "EquippedArmorArmorId",
                principalTable: "Armor",
                principalColumn: "ArmorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Weapons_EquippedWeaponWeaponId",
                table: "Players",
                column: "EquippedWeaponWeaponId",
                principalTable: "Weapons",
                principalColumn: "WeaponId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
