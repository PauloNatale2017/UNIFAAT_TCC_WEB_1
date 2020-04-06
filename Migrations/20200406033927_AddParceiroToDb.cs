using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ROSESHIELD.WEB.Migrations
{
    public partial class AddParceiroToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Parceiro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    NOMEEMPRESA = table.Column<string>(nullable: true),
                    CNPJ_CPF = table.Column<string>(nullable: true),
                    CONTATO = table.Column<string>(nullable: true),
                    ENDERECO = table.Column<string>(nullable: true),
                    EMAIL = table.Column<string>(nullable: true),
                    TOTAL_VAGAS_CADASTRADAS = table.Column<string>(nullable: true),
                    IdVaga = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parceiro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParceiroEmpregos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IdEmpresa = table.Column<int>(nullable: false),
                    NomeVaga = table.Column<string>(nullable: true),
                    AreaAtuacao = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    FaixaSalarial = table.Column<string>(nullable: true),
                    HorarioTrabalho = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParceiroEmpregos", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Parceiro");

            migrationBuilder.DropTable(
                name: "ParceiroEmpregos");
        }
    }
}
