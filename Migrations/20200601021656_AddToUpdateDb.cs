using Microsoft.EntityFrameworkCore.Migrations;

namespace ROSESHIELD.WEB.Migrations
{
    public partial class AddToUpdateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Endereçoescola",
                table: "CadastroFilho");

            migrationBuilder.AddColumn<string>(
                name: "Enderecoescola",
                table: "CadastroFilho",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Enderecoescola",
                table: "CadastroFilho");

            migrationBuilder.AddColumn<string>(
                name: "Endereçoescola",
                table: "CadastroFilho",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
