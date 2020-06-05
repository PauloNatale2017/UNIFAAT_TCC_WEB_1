using Microsoft.EntityFrameworkCore.Migrations;

namespace ROSESHIELD.WEB.Migrations
{
    public partial class AddNewModelToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UsuarioOng_OngPerfil_PerfilId",
                table: "UsuarioOng");

            migrationBuilder.DropIndex(
                name: "IX_UsuarioOng_PerfilId",
                table: "UsuarioOng");

            migrationBuilder.DropColumn(
                name: "PerfilId",
                table: "UsuarioOng");

            migrationBuilder.AlterColumn<string>(
                name: "IdOng",
                table: "UsuarioOng",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "Perfil",
                table: "UsuarioOng",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Perfil",
                table: "UsuarioOng");

            migrationBuilder.AlterColumn<int>(
                name: "IdOng",
                table: "UsuarioOng",
                type: "int",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "PerfilId",
                table: "UsuarioOng",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioOng_PerfilId",
                table: "UsuarioOng",
                column: "PerfilId");

            migrationBuilder.AddForeignKey(
                name: "FK_UsuarioOng_OngPerfil_PerfilId",
                table: "UsuarioOng",
                column: "PerfilId",
                principalTable: "OngPerfil",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
