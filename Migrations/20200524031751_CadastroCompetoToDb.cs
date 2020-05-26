using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ROSESHIELD.WEB.Migrations
{
    public partial class CadastroCompetoToDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CadastroComplementar",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Profissao = table.Column<string>(nullable: true),
                    RendaPessoal = table.Column<string>(nullable: true),
                    RendaFamiliar = table.Column<string>(nullable: true),
                    drogaslicitasSIM = table.Column<string>(nullable: true),
                    drogaslicitasNAO = table.Column<string>(nullable: true),
                    QualdrogaDescri1 = table.Column<string>(nullable: true),
                    DrogasilicitasSIM = table.Column<string>(nullable: true),
                    DrogasilicitasNAO = table.Column<string>(nullable: true),
                    QualdrogaDescri2 = table.Column<string>(nullable: true),
                    PossuifilhosSIM = table.Column<string>(nullable: true),
                    PossuiFilhosNAO = table.Column<string>(nullable: true),
                    Qtdo = table.Column<string>(nullable: true),
                    IdosoSIM = table.Column<string>(nullable: true),
                    IdosoNAO = table.Column<string>(nullable: true),
                    Quantidade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroComplementar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CadastroDeOcorrencia",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    TipoViolencia = table.Column<string>(nullable: true),
                    DiaOcorrido = table.Column<string>(nullable: true),
                    LocalOcorrido = table.Column<string>(nullable: true),
                    Testemunha = table.Column<string>(nullable: true),
                    UsodeDrogasIlicitas = table.Column<string>(nullable: true),
                    UsodeDrograsLicitas = table.Column<string>(nullable: true),
                    VinculocomAgressor = table.Column<string>(nullable: true),
                    BOSIM = table.Column<string>(nullable: true),
                    BONAO = table.Column<string>(nullable: true),
                    NumeroBO = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroDeOcorrencia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CadastroDeVitimasCompleto",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    CadastroBasicoId = table.Column<int>(nullable: true),
                    CadastroDeOcorrenciaId = table.Column<int>(nullable: true),
                    CadastroComplementarId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroDeVitimasCompleto", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CadastroDeVitimasCompleto_VitimaBasic_CadastroBasicoId",
                        column: x => x.CadastroBasicoId,
                        principalTable: "VitimaBasic",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CadastroDeVitimasCompleto_CadastroComplementar_CadastroComplementarId",
                        column: x => x.CadastroComplementarId,
                        principalTable: "CadastroComplementar",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_CadastroDeVitimasCompleto_CadastroDeOcorrencia_CadastroDeOcorrenciaId",
                        column: x => x.CadastroDeOcorrenciaId,
                        principalTable: "CadastroDeOcorrencia",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CadastroFilho",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Nomefilho = table.Column<string>(nullable: true),
                    Escolaondeestuda = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<string>(nullable: true),
                    Endereçoescola = table.Column<string>(nullable: true),
                    NecessidadesespeciaisSIM = table.Column<string>(nullable: true),
                    NecessidadesespeciaisNAO = table.Column<string>(nullable: true),
                    Qualnecessidade = table.Column<string>(nullable: true),
                    CadastroDeVitimasCompletoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroFilho", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CadastroFilho_CadastroDeVitimasCompleto_CadastroDeVitimasCompletoId",
                        column: x => x.CadastroDeVitimasCompletoId,
                        principalTable: "CadastroDeVitimasCompleto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CadastroIdoso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Nomoidoso = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<string>(nullable: true),
                    NecessidadesEspeciaisSIM = table.Column<string>(nullable: true),
                    NecessidadesEspeciaisNAO = table.Column<string>(nullable: true),
                    Qual = table.Column<string>(nullable: true),
                    CadastroDeVitimasCompletoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroIdoso", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CadastroIdoso_CadastroDeVitimasCompleto_CadastroDeVitimasCompletoId",
                        column: x => x.CadastroDeVitimasCompletoId,
                        principalTable: "CadastroDeVitimasCompleto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "CadastroSOS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    NomeSOS = table.Column<string>(nullable: true),
                    NumeroCelular = table.Column<string>(nullable: true),
                    Vinculo = table.Column<string>(nullable: true),
                    CadastroDeVitimasCompletoId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroSOS", x => x.Id);
                    table.ForeignKey(
                        name: "FK_CadastroSOS_CadastroDeVitimasCompleto_CadastroDeVitimasCompletoId",
                        column: x => x.CadastroDeVitimasCompletoId,
                        principalTable: "CadastroDeVitimasCompleto",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CadastroDeVitimasCompleto_CadastroBasicoId",
                table: "CadastroDeVitimasCompleto",
                column: "CadastroBasicoId");

            migrationBuilder.CreateIndex(
                name: "IX_CadastroDeVitimasCompleto_CadastroComplementarId",
                table: "CadastroDeVitimasCompleto",
                column: "CadastroComplementarId");

            migrationBuilder.CreateIndex(
                name: "IX_CadastroDeVitimasCompleto_CadastroDeOcorrenciaId",
                table: "CadastroDeVitimasCompleto",
                column: "CadastroDeOcorrenciaId");

            migrationBuilder.CreateIndex(
                name: "IX_CadastroFilho_CadastroDeVitimasCompletoId",
                table: "CadastroFilho",
                column: "CadastroDeVitimasCompletoId");

            migrationBuilder.CreateIndex(
                name: "IX_CadastroIdoso_CadastroDeVitimasCompletoId",
                table: "CadastroIdoso",
                column: "CadastroDeVitimasCompletoId");

            migrationBuilder.CreateIndex(
                name: "IX_CadastroSOS_CadastroDeVitimasCompletoId",
                table: "CadastroSOS",
                column: "CadastroDeVitimasCompletoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadastroFilho");

            migrationBuilder.DropTable(
                name: "CadastroIdoso");

            migrationBuilder.DropTable(
                name: "CadastroSOS");

            migrationBuilder.DropTable(
                name: "CadastroDeVitimasCompleto");

            migrationBuilder.DropTable(
                name: "CadastroComplementar");

            migrationBuilder.DropTable(
                name: "CadastroDeOcorrencia");
        }
    }
}
