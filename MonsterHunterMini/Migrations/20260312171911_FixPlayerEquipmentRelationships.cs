using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonsterHunterMini.Migrations
{
    /// <inheritdoc />
    public partial class FixPlayerEquipmentRelationships : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AddColumn<int>(
                name: "EquippedArmorId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "EquippedWeaponId",
                table: "Players",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Weapons_PlayerId",
                table: "Weapons",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_EquippedArmorId",
                table: "Players",
                column: "EquippedArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_Players_EquippedWeaponId",
                table: "Players",
                column: "EquippedWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_Armor_PlayerId",
                table: "Armor",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Armor_Players_PlayerId",
                table: "Armor",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Armor_EquippedArmorId",
                table: "Players",
                column: "EquippedArmorId",
                principalTable: "Armor",
                principalColumn: "ArmorId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Weapons_EquippedWeaponId",
                table: "Players",
                column: "EquippedWeaponId",
                principalTable: "Weapons",
                principalColumn: "WeaponId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Weapons_Players_PlayerId",
                table: "Weapons",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId",
                onDelete: ReferentialAction.Restrict);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armor_Players_PlayerId",
                table: "Armor");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Armor_EquippedArmorId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Weapons_EquippedWeaponId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Weapons_Players_PlayerId",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Weapons_PlayerId",
                table: "Weapons");

            migrationBuilder.DropIndex(
                name: "IX_Players_EquippedArmorId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Players_EquippedWeaponId",
                table: "Players");

            migrationBuilder.DropIndex(
                name: "IX_Armor_PlayerId",
                table: "Armor");

            migrationBuilder.DropColumn(
                name: "EquippedArmorId",
                table: "Players");

            migrationBuilder.DropColumn(
                name: "EquippedWeaponId",
                table: "Players");

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
    }
}
