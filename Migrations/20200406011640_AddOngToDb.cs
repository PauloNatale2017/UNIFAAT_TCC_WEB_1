using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ROSESHIELD.WEB.Migrations
{
    public partial class AddOngToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Ong",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    RazaoSocial = table.Column<string>(nullable: true),
                    NomeFantasia = table.Column<string>(nullable: true),
                    NomeOng = table.Column<string>(nullable: true),
                    CNPJ_CPF = table.Column<string>(nullable: true),
                    Contato = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    TotalFuncionarios = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OngPerfil",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    NomePerfil = table.Column<string>(nullable: true),
                    Accesso = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OngPerfil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UsuarioOng",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    NomeCompleto = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PerfilId = table.Column<int>(nullable: true),
                    IdOng = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioOng", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioOng_OngPerfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "OngPerfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioOng_PerfilId",
                table: "UsuarioOng",
                column: "PerfilId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Ong");

            migrationBuilder.DropTable(
                name: "UsuarioOng");

            migrationBuilder.DropTable(
                name: "OngPerfil");
        }
    }
}
