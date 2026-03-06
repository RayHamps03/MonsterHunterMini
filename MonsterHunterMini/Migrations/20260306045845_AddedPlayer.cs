using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonsterHunterMini.Migrations
{
    /// <inheritdoc />
    public partial class AddedPlayer : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "ArmorWeaponId",
                table: "Material",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PlayerId",
                table: "Material",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WeaponId",
                table: "Material",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Armor",
                columns: table => new
                {
                    WeaponId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Defense = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Armor", x => x.WeaponId);
                });

            migrationBuilder.CreateTable(
                name: "Weapon",
                columns: table => new
                {
                    WeaponId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Attack = table.Column<double>(type: "float", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Weapon", x => x.WeaponId);
                });

            migrationBuilder.CreateTable(
                name: "PLayers",
                columns: table => new
                {
                    PlayerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EquippedWeaponWeaponId = table.Column<int>(type: "int", nullable: false),
                    EquippedArmorWeaponId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PLayers", x => x.PlayerId);
                    table.ForeignKey(
                        name: "FK_PLayers_Armor_EquippedArmorWeaponId",
                        column: x => x.EquippedArmorWeaponId,
                        principalTable: "Armor",
                        principalColumn: "WeaponId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PLayers_Weapon_EquippedWeaponWeaponId",
                        column: x => x.EquippedWeaponWeaponId,
                        principalTable: "Weapon",
                        principalColumn: "WeaponId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Material_ArmorWeaponId",
                table: "Material",
                column: "ArmorWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_PlayerId",
                table: "Material",
                column: "PlayerId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_WeaponId",
                table: "Material",
                column: "WeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_PLayers_EquippedArmorWeaponId",
                table: "PLayers",
                column: "EquippedArmorWeaponId");

            migrationBuilder.CreateIndex(
                name: "IX_PLayers_EquippedWeaponWeaponId",
                table: "PLayers",
                column: "EquippedWeaponWeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Armor_ArmorWeaponId",
                table: "Material",
                column: "ArmorWeaponId",
                principalTable: "Armor",
                principalColumn: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Material_PLayers_PlayerId",
                table: "Material",
                column: "PlayerId",
                principalTable: "PLayers",
                principalColumn: "PlayerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Weapon_WeaponId",
                table: "Material",
                column: "WeaponId",
                principalTable: "Weapon",
                principalColumn: "WeaponId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Material_Armor_ArmorWeaponId",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_Material_PLayers_PlayerId",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_Material_Weapon_WeaponId",
                table: "Material");

            migrationBuilder.DropTable(
                name: "PLayers");

            migrationBuilder.DropTable(
                name: "Armor");

            migrationBuilder.DropTable(
                name: "Weapon");

            migrationBuilder.DropIndex(
                name: "IX_Material_ArmorWeaponId",
                table: "Material");

            migrationBuilder.DropIndex(
                name: "IX_Material_PlayerId",
                table: "Material");

            migrationBuilder.DropIndex(
                name: "IX_Material_WeaponId",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "ArmorWeaponId",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "PlayerId",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "WeaponId",
                table: "Material");
        }
    }
}
