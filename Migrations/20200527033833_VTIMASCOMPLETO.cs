using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ROSESHIELD.WEB.Migrations
{
    public partial class VTIMASCOMPLETO : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CadastroDeVitimasCompleto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IdCadastroBasico = table.Column<int>(nullable: false),
                    IdCadastroDeOcorrencia = table.Column<int>(nullable: false),
                    IdCadastroComplementar = table.Column<int>(nullable: false),
                    IdCadastroFilhos = table.Column<int>(nullable: false),
                    IdCadastroIdosos = table.Column<int>(nullable: false),
                    IdCadastroSOS = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroDeVitimasCompleto", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadastroDeVitimasCompleto");
        }
    }
}
