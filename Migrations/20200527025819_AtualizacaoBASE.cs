using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ROSESHIELD.WEB.Migrations
{
    public partial class AtualizacaoBASE : Migration
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
                    IdCadastroBasico = table.Column<int>(nullable: false),
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
                    IdCadastroBasico = table.Column<int>(nullable: false),
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
                name: "CadastroFilho",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IdCadastroBasico = table.Column<int>(nullable: false),
                    Nomefilho = table.Column<string>(nullable: true),
                    Escolaondeestuda = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<string>(nullable: true),
                    Endereçoescola = table.Column<string>(nullable: true),
                    NecessidadesespeciaisSIM = table.Column<string>(nullable: true),
                    NecessidadesespeciaisNAO = table.Column<string>(nullable: true),
                    Qualnecessidade = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroFilho", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CadastroIdoso",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IdCadastroBasico = table.Column<int>(nullable: false),
                    Nomoidoso = table.Column<string>(nullable: true),
                    DataNascimento = table.Column<string>(nullable: true),
                    NecessidadesEspeciaisSIM = table.Column<string>(nullable: true),
                    NecessidadesEspeciaisNAO = table.Column<string>(nullable: true),
                    Qual = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroIdoso", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CadastroSOS",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IdCadastroBasico = table.Column<int>(nullable: false),
                    NomeSOS = table.Column<string>(nullable: true),
                    NumeroCelular = table.Column<string>(nullable: true),
                    Vinculo = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CadastroSOS", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Login",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    EmailUser = table.Column<string>(nullable: false),
                    Password = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Login", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Oficiais",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Nome = table.Column<string>(nullable: true),
                    Contato = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Notificacao = table.Column<bool>(nullable: false),
                    Horario = table.Column<string>(nullable: true),
                    NumeroBO = table.Column<string>(nullable: true),
                    BOfeito = table.Column<bool>(nullable: false),
                    NomeDepartamento = table.Column<string>(nullable: true),
                    AbrangenciaDeAtuacao = table.Column<string>(nullable: true),
                    PontoFocalDeContato = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Oficiais", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Ong",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    RazaoSocial = table.Column<string>(nullable: true),
                    NomeFantasia = table.Column<string>(nullable: true),
                    NomeOng = table.Column<string>(nullable: true),
                    CNPJ_CPF = table.Column<string>(nullable: true),
                    Contato = table.Column<string>(nullable: true),
                    Endereco = table.Column<string>(nullable: true),
                    TotalFuncionarios = table.Column<string>(nullable: true),
                    Cidade = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ong", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OngPerfil",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    NomePerfil = table.Column<string>(nullable: true),
                    Accesso = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OngPerfil", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Parceiro",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    NOMEEMPRESA = table.Column<string>(nullable: true),
                    CNPJ_CPF = table.Column<string>(nullable: true),
                    CONTATO = table.Column<string>(nullable: true),
                    ENDERECO = table.Column<string>(nullable: true),
                    EMAIL = table.Column<string>(nullable: true),
                    TOTAL_VAGAS_CADASTRADAS = table.Column<string>(nullable: true),
                    IdVaga = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Parceiro", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ParceiroEmpregos",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IdEmpresa = table.Column<int>(nullable: false),
                    NomeVaga = table.Column<string>(nullable: true),
                    AreaAtuacao = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    FaixaSalarial = table.Column<string>(nullable: true),
                    HorarioTrabalho = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ParceiroEmpregos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Perfil",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    NomePerfil = table.Column<string>(nullable: true),
                    IdSistema = table.Column<int>(nullable: false),
                    AccessPerfil = table.Column<string>(nullable: true),
                    ActionsPerfil = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Perfil", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "Sistemas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    NomeSistema = table.Column<string>(nullable: true),
                    Options = table.Column<string>(nullable: true),
                    Url = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sistemas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SiteSistema",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    Menu = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    IdSistema = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SiteSistema", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vagas",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    NomeVaga = table.Column<string>(nullable: true),
                    ValorSalario = table.Column<string>(nullable: true),
                    Descricao = table.Column<string>(nullable: true),
                    InformacoeAdicionais = table.Column<string>(nullable: true),
                    AvisosDaEmpresa = table.Column<string>(nullable: true),
                    Restricoes = table.Column<string>(nullable: true),
                    IdEmpresa = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vagas", x => x.Id);
                });

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

            migrationBuilder.CreateTable(
                name: "UserAccounts",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    IdLogin = table.Column<int>(nullable: false),
                    NomeCompleto = table.Column<string>(nullable: false),
                    Idade = table.Column<string>(nullable: false),
                    Endereco = table.Column<string>(nullable: false),
                    Contato = table.Column<string>(nullable: false),
                    Cpf = table.Column<string>(nullable: false),
                    Cidade = table.Column<string>(nullable: false),
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

            migrationBuilder.CreateTable(
                name: "UsuarioOng",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreateDate = table.Column<DateTime>(nullable: true),
                    UpdateDate = table.Column<DateTime>(nullable: true),
                    NomeCompleto = table.Column<string>(nullable: true),
                    Cargo = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    PerfilId = table.Column<int>(nullable: true),
                    IdOng = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UsuarioOng", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UsuarioOng_OngPerfil_PerfilId",
                        column: x => x.PerfilId,
                        principalTable: "OngPerfil",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserAccounts_UsuarioAccessoId",
                table: "UserAccounts",
                column: "UsuarioAccessoId");

            migrationBuilder.CreateIndex(
                name: "IX_UsuarioOng_PerfilId",
                table: "UsuarioOng",
                column: "PerfilId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CadastroComplementar");

            migrationBuilder.DropTable(
                name: "CadastroDeOcorrencia");

            migrationBuilder.DropTable(
                name: "CadastroFilho");

            migrationBuilder.DropTable(
                name: "CadastroIdoso");

            migrationBuilder.DropTable(
                name: "CadastroSOS");

            migrationBuilder.DropTable(
                name: "Geo");

            migrationBuilder.DropTable(
                name: "Oficiais");

            migrationBuilder.DropTable(
                name: "Ong");

            migrationBuilder.DropTable(
                name: "Parceiro");

            migrationBuilder.DropTable(
                name: "ParceiroEmpregos");

            migrationBuilder.DropTable(
                name: "Perfil");

            migrationBuilder.DropTable(
                name: "Profissional");

            migrationBuilder.DropTable(
                name: "Sistemas");

            migrationBuilder.DropTable(
                name: "SiteSistema");

            migrationBuilder.DropTable(
                name: "UserAccounts");

            migrationBuilder.DropTable(
                name: "UsuarioOng");

            migrationBuilder.DropTable(
                name: "Vagas");

            migrationBuilder.DropTable(
                name: "VinculoSistemaUsuario");

            migrationBuilder.DropTable(
                name: "VitimaBasic");

            migrationBuilder.DropTable(
                name: "Login");

            migrationBuilder.DropTable(
                name: "OngPerfil");
        }
    }
}
