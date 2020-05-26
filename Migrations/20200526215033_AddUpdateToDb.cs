using Microsoft.EntityFrameworkCore.Migrations;

namespace ROSESHIELD.WEB.Migrations
{
    public partial class AddUpdateToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IdCadastroBasico",
                table: "CadastroSOS",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCadastroBasico",
                table: "CadastroIdoso",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCadastroBasico",
                table: "CadastroFilho",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCadastroBasico",
                table: "CadastroDeOcorrencia",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "IdCadastroBasico",
                table: "CadastroComplementar",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IdCadastroBasico",
                table: "CadastroSOS");

            migrationBuilder.DropColumn(
                name: "IdCadastroBasico",
                table: "CadastroIdoso");

            migrationBuilder.DropColumn(
                name: "IdCadastroBasico",
                table: "CadastroFilho");

            migrationBuilder.DropColumn(
                name: "IdCadastroBasico",
                table: "CadastroDeOcorrencia");

            migrationBuilder.DropColumn(
                name: "IdCadastroBasico",
                table: "CadastroComplementar");
        }
    }
}
