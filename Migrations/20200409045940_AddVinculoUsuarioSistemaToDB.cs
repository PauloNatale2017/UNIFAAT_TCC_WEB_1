using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ROSESHIELD.WEB.Migrations
{
    public partial class AddVinculoUsuarioSistemaToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "VinculoSistemaUsuario",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IdUsuario = table.Column<string>(nullable: true),
                    IdPerfil = table.Column<string>(nullable: true),
                    IdSistema = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VinculoSistemaUsuario", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "VinculoSistemaUsuario");
        }
    }
}
