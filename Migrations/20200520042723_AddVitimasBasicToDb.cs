using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ROSESHIELD.WEB.Migrations
{
    public partial class AddVitimasBasicToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VitimaBasic",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    NomeCompleto = table.Column<string>(nullable: false),
                    Rg_CPF = table.Column<string>(nullable: false),
                    Endereco = table.Column<string>(nullable: true),
                    Contato = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: false),
                    RedeSocial = table.Column<string>(nullable: false),
                    ContatoRecado = table.Column<string>(nullable: true),
                    Ativo = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VitimaBasic", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VitimaBasic");
        }
    }
}
