using Microsoft.EntityFrameworkCore.Migrations;

namespace ROSESHIELD.WEB.Migrations
{
    public partial class AddToNewCompleDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Rg_CPF",
                table: "CadastroDeVitimasCompleto",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Rg_CPF",
                table: "CadastroDeVitimasCompleto");
        }
    }
}
