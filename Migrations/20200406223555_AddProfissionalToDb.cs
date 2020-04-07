using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ROSESHIELD.WEB.Migrations
{
    public partial class AddProfissionalToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Profissional",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    NomeProfissional = table.Column<string>(nullable: true),
                    Contato = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    RamoAtuacao = table.Column<string>(nullable: true),
                    DiaAtendimento = table.Column<string>(nullable: true),
                    HorarioAtendimento = table.Column<string>(nullable: true),
                    ValorCobrado = table.Column<string>(nullable: true),
                    Desconto = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profissional", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Profissional");
        }
    }
}
