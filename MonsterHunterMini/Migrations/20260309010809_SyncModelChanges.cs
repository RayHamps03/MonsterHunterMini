using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonsterHunterMini.Migrations
{
    /// <inheritdoc />
    public partial class SyncModelChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Material_PLayers_PlayerId",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_PLayers_Armor_EquippedArmorWeaponId",
                table: "PLayers");

            migrationBuilder.DropForeignKey(
                name: "FK_PLayers_Weapon_EquippedWeaponWeaponId",
                table: "PLayers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_PLayers",
                table: "PLayers");

            migrationBuilder.RenameTable(
                name: "PLayers",
                newName: "Players");

            migrationBuilder.RenameIndex(
                name: "IX_PLayers_EquippedWeaponWeaponId",
                table: "Players",
                newName: "IX_Players_EquippedWeaponWeaponId");

            migrationBuilder.RenameIndex(
                name: "IX_PLayers_EquippedArmorWeaponId",
                table: "Players",
                newName: "IX_Players_EquippedArmorWeaponId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Players",
                type: "nvarchar(20)",
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Players",
                table: "Players",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Players_PlayerId",
                table: "Material",
                column: "PlayerId",
                principalTable: "Players",
                principalColumn: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Players_Armor_EquippedArmorWeaponId",
                table: "Players",
                column: "EquippedArmorWeaponId",
                principalTable: "Armor",
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Material_Players_PlayerId",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Armor_EquippedArmorWeaponId",
                table: "Players");

            migrationBuilder.DropForeignKey(
                name: "FK_Players_Weapon_EquippedWeaponWeaponId",
                table: "Players");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Players",
                table: "Players");

            migrationBuilder.RenameTable(
                name: "Players",
                newName: "PLayers");

            migrationBuilder.RenameIndex(
                name: "IX_Players_EquippedWeaponWeaponId",
                table: "PLayers",
                newName: "IX_PLayers_EquippedWeaponWeaponId");

            migrationBuilder.RenameIndex(
                name: "IX_Players_EquippedArmorWeaponId",
                table: "PLayers",
                newName: "IX_PLayers_EquippedArmorWeaponId");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "PLayers",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(20)",
                oldMaxLength: 20);

            migrationBuilder.AddPrimaryKey(
                name: "PK_PLayers",
                table: "PLayers",
                column: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Material_PLayers_PlayerId",
                table: "Material",
                column: "PlayerId",
                principalTable: "PLayers",
                principalColumn: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_PLayers_Armor_EquippedArmorWeaponId",
                table: "PLayers",
                column: "EquippedArmorWeaponId",
                principalTable: "Armor",
                principalColumn: "WeaponId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_PLayers_Weapon_EquippedWeaponWeaponId",
                table: "PLayers",
                column: "EquippedWeaponWeaponId",
                principalTable: "Weapon",
                principalColumn: "WeaponId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
