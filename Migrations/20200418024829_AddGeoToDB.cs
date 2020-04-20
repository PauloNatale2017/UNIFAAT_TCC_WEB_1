using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ROSESHIELD.WEB.Migrations
{
    public partial class AddGeoToDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Geo",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    CEP = table.Column<string>(nullable: true),
                    Complemento = table.Column<string>(nullable: true),
                    Lat = table.Column<string>(nullable: true),
                    Long = table.Column<string>(nullable: true),
                    IdUsuario = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Geo", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Geo");
        }
    }
}
