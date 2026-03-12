using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonsterHunterMini.Migrations
{
    /// <inheritdoc />
    public partial class AddEquipmentMaterialJoin : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Material_Armor_ArmorId",
                table: "Material");

            migrationBuilder.DropForeignKey(
                name: "FK_Material_Weapon_WeaponId",
                table: "Material");

            migrationBuilder.DropIndex(
                name: "IX_Material_ArmorId",
                table: "Material");

            migrationBuilder.DropIndex(
                name: "IX_Material_WeaponId",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "ArmorId",
                table: "Material");

            migrationBuilder.DropColumn(
                name: "WeaponId",
                table: "Material");

            migrationBuilder.CreateTable(
                name: "ArmorMaterial",
                columns: table => new
                {
                    ArmorId = table.Column<int>(type: "int", nullable: false),
                    MaterialsMaterialId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmorMaterial", x => new { x.ArmorId, x.MaterialsMaterialId });
                    table.ForeignKey(
                        name: "FK_ArmorMaterial_Armor_ArmorId",
                        column: x => x.ArmorId,
                        principalTable: "Armor",
                        principalColumn: "ArmorId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArmorMaterial_Material_MaterialsMaterialId",
                        column: x => x.MaterialsMaterialId,
                        principalTable: "Material",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialWeapon",
                columns: table => new
                {
                    MaterialsMaterialId = table.Column<int>(type: "int", nullable: false),
                    WeaponsWeaponId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialWeapon", x => new { x.MaterialsMaterialId, x.WeaponsWeaponId });
                    table.ForeignKey(
                        name: "FK_MaterialWeapon_Material_MaterialsMaterialId",
                        column: x => x.MaterialsMaterialId,
                        principalTable: "Material",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialWeapon_Weapon_WeaponsWeaponId",
                        column: x => x.WeaponsWeaponId,
                        principalTable: "Weapon",
                        principalColumn: "WeaponId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArmorMaterial_MaterialsMaterialId",
                table: "ArmorMaterial",
                column: "MaterialsMaterialId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialWeapon_WeaponsWeaponId",
                table: "MaterialWeapon",
                column: "WeaponsWeaponId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArmorMaterial");

            migrationBuilder.DropTable(
                name: "MaterialWeapon");

            migrationBuilder.AddColumn<int>(
                name: "ArmorId",
                table: "Material",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "WeaponId",
                table: "Material",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Material_ArmorId",
                table: "Material",
                column: "ArmorId");

            migrationBuilder.CreateIndex(
                name: "IX_Material_WeaponId",
                table: "Material",
                column: "WeaponId");

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Armor_ArmorId",
                table: "Material",
                column: "ArmorId",
                principalTable: "Armor",
                principalColumn: "ArmorId");

            migrationBuilder.AddForeignKey(
                name: "FK_Material_Weapon_WeaponId",
                table: "Material",
                column: "WeaponId",
                principalTable: "Weapon",
                principalColumn: "WeaponId");
        }
    }
}
