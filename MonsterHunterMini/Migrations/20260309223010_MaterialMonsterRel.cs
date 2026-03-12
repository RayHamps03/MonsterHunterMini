using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace MonsterHunterMini.Migrations
{
    /// <inheritdoc />
    public partial class MaterialMonsterRel : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 1,
                column: "MonsterId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 2,
                column: "MonsterId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 3,
                column: "MonsterId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 4,
                column: "MonsterId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 5,
                column: "MonsterId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 6,
                column: "MonsterId",
                value: 2);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 7,
                column: "MonsterId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 8,
                column: "MonsterId",
                value: 3);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 9,
                column: "MonsterId",
                value: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 1,
                column: "MonsterId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 2,
                column: "MonsterId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 3,
                column: "MonsterId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 4,
                column: "MonsterId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 5,
                column: "MonsterId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 6,
                column: "MonsterId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 7,
                column: "MonsterId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 8,
                column: "MonsterId",
                value: null);

            migrationBuilder.UpdateData(
                table: "Material",
                keyColumn: "MaterialId",
                keyValue: 9,
                column: "MonsterId",
                value: null);
        }
    }
}
