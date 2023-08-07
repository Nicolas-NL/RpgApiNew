using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RpgApi.Migrations
{
    /// <inheritdoc />
    public partial class MigracaoMuitosParaMuitos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Armas_Armas_armaId",
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
                name: "UsuarioId",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "armaId",
                table: "Armas");

            migrationBuilder.AddColumn<int>(
                name: "Derrotas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Disputas",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Vitorias",
                table: "Personagens",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Habilidades",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nome = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dano = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Habilidades", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "PersonagemHabilidades",
                columns: table => new
                {
                    PersonagemId = table.Column<int>(type: "int", nullable: false),
                    HabilidadeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PersonagemHabilidades", x => new { x.PersonagemId, x.HabilidadeId });
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Habilidades_HabilidadeId",
                        column: x => x.HabilidadeId,
                        principalTable: "Habilidades",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PersonagemHabilidades_Personagens_PersonagemId",
                        column: x => x.PersonagemId,
                        principalTable: "Personagens",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Habilidades",
                columns: new[] { "Id", "Dano", "Nome" },
                values: new object[,]
                {
                    { 1, 39, "Adormecer" },
                    { 2, 41, "Congelar" },
                    { 3, 37, "Hipnotizar" }
                });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Personagens",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Derrotas", "Disputas", "Vitorias" },
                values: new object[] { 0, 0, 0 });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "PasswordHash", "PasswordSalt" },
                values: new object[] { new byte[] { 167, 248, 93, 22, 153, 192, 193, 77, 147, 163, 102, 189, 79, 71, 154, 92, 131, 174, 242, 121, 197, 15, 244, 242, 226, 82, 188, 189, 90, 129, 235, 108 }, new byte[] { 87, 42, 58, 232, 186, 83, 169, 215, 68, 136, 205, 204, 208, 22, 102, 36, 255, 120, 104, 109, 34, 122, 34, 26, 39, 140, 175, 24, 90, 126, 153, 42, 38, 156, 235, 3, 48, 54, 70, 194, 125, 133, 237, 70, 209, 87, 103, 235, 218, 177, 78, 125, 181, 149, 93, 154, 131, 222, 100, 51, 96, 176, 156, 23 } });

            migrationBuilder.CreateIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas",
                column: "PersonagemId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_PersonagemHabilidades_HabilidadeId",
                table: "PersonagemHabilidades",
                column: "HabilidadeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PersonagemHabilidades");

            migrationBuilder.DropTable(
                name: "Habilidades");

            migrationBuilder.DropIndex(
                name: "IX_Armas_PersonagemId",
                table: "Armas");

            migrationBuilder.DropColumn(
                name: "Derrotas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Disputas",
                table: "Personagens");

            migrationBuilder.DropColumn(
                name: "Vitorias",
                table: "Personagens");

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
                columns: new[] { "UsuarioId", "armaId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "UsuarioId", "armaId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "UsuarioId", "armaId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "UsuarioId", "armaId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "UsuarioId", "armaId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "UsuarioId", "armaId" },
                values: new object[] { null, null });

            migrationBuilder.UpdateData(
                table: "Armas",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "UsuarioId", "armaId" },
                values: new object[] { null, null });

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
                name: "FK_Armas_Usuarios_UsuarioId",
                table: "Armas",
                column: "UsuarioId",
                principalTable: "Usuarios",
                principalColumn: "Id");
        }
    }
}
