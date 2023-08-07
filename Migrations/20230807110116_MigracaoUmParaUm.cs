using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoUmParaUm : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "PersonagemId",
                table: "Armas",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "UsuarioId",
                table: "Armas",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "armaId",
                table: "Armas",
                type: "int",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PersonagemId", "UsuarioId", "armaId" },
                values: new object[] { 1, null, null });

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "PersonagemId", "UsuarioId", "armaId" },
                values: new object[] { 2, null, null });

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "PersonagemId", "UsuarioId", "armaId" },
                values: new object[] { 3, null, null });

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "PersonagemId", "UsuarioId", "armaId" },
                values: new object[] { 4, null, null });

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "PersonagemId", "UsuarioId", "armaId" },
                values: new object[] { 5, null, null });

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "PersonagemId", "UsuarioId", "armaId" },
                values: new object[] { 6, null, null });

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "PersonagemId", "UsuarioId", "armaId" },
                values: new object[] { 7, null, null });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 244, 95, 141, 246, 4, 223, 217, 225, 160, 39, 72, 213, 77, 119, 239, 208, 104, 141, 215, 97, 198, 59, 1, 21, 24, 209, 50, 250, 169, 191, 56, 60 }, new byte[] { 194, 186, 209, 58, 117, 214, 171, 243, 65, 255, 9, 115, 149, 195, 52, 181, 58, 208, 110, 148, 141, 210, 107, 33, 14, 59, 251, 11, 247, 106, 105, 32, 190, 122, 184, 110, 247, 40, 181, 42, 197, 248, 130, 156, 35, 97, 30, 114, 116, 126, 83, 102, 68, 158, 250, 122, 153, 154, 118, 12, 69, 88, 49, 160 } });

            migrationBuilder.CreateIndex(
                name: "IX_Armas_armaId",
                table: "Armas",
                column: "armaId");

            migrationBuilder.CreateIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas",
                column: "PersonagemId");

            migrationBuilder.CreateIndex(
                name: "IX_Armas_UsuarioId",
                table: "Armas",
                column: "UsuarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Armas_Armas_armaId",
                table: "Armas",
                column: "armaId",
                principalTable: "Armas",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                principalTable: "Personagens",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Armas_Usuarios_UsuarioId",
                table: "Armas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armas_Armas_armaId",
                table: "Armas");

            migrationBuilder.DropForeignKey(
                name: "FK_Armas_Personagens_PersonagemId",
                table: "Armas");

            migrationBuilder.DropForeignKey(
                name: "FK_Armas_Usuarios_UsuarioId",
                table: "Armas");

            migrationBuilder.DropIndex(
                name: "IX_Armas_armaId",
                table: "Armas");

            migrationBuilder.DropIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas");

            migrationBuilder.DropIndex(
                name: "IX_Armas_UsuarioId",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "PersonagemId",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "UsuarioId",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "armaId",
                table: "Armas");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { null, null });
        }
    }
}
