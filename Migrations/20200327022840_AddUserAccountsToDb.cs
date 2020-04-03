using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ROSESHIELD.WEB.Migrations
{
    public partial class AddUserAccountsToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IdLogin = table.Column<int>(nullable: false),
                    NomeCompleto = table.Column<string>(nullable: true),
                    Idade = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Contato = table.Column<string>(nullable: true),
                    Cpf = table.Column<string>(nullable: true),
                    UsuarioAccessoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserAccounts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserAccounts_Login_UsuarioAccessoId",
                        column: x => x.UsuarioAccessoId,
                        principalTable: "Login",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_UsuarioAccessoId",
                table: "UserAccounts",
                column: "UsuarioAccessoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserAccounts");
        }
    }
}
