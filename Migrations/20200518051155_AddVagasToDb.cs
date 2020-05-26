using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ROSESHIELD.WEB.Migrations
{
    public partial class AddVagasToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Vagas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    NomeVaga = table.Column<string>(nullable: true),
                    ValorSalario = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    InformacoeAdicionais = table.Column<string>(nullable: true),
                    AvisosDaEmpresa = table.Column<string>(nullable: true),
                    Restricoes = table.Column<string>(nullable: true),
                    IdEmpresa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vagas", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Vagas");
        }
    }
}
