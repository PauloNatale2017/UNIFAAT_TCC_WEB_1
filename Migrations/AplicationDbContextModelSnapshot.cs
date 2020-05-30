﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ROSESHIELD.WEB.Models;

namespace ROSESHIELD.WEB.Migrations
{
    [DbContext(typeof(AplicationDbContext))]
    partial class AplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.CadastroComplementar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DrogasilicitasNAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DrogasilicitasSIM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCadastroBasico")
                        .HasColumnType("int");

                    b.Property<string>("IdosoNAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdosoSIM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PossuiFilhosNAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PossuifilhosSIM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Profissao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qtdo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QualdrogaDescri1")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("QualdrogaDescri2")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Quantidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RendaFamiliar")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RendaPessoal")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("drogaslicitasNAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("drogaslicitasSIM")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CadastroComplementar");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.CadastroDeOcorrencia", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("BONAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BOSIM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DiaOcorrido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCadastroBasico")
                        .HasColumnType("int");

                    b.Property<string>("LocalOcorrido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroBO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Testemunha")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TipoViolencia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("UsodeDrogasIlicitas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UsodeDrograsLicitas")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VinculocomAgressor")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CadastroDeOcorrencia");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.CadastroDeVitimasCompleto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCadastroBasico")
                        .HasColumnType("int");

                    b.Property<int>("IdCadastroComplementar")
                        .HasColumnType("int");

                    b.Property<int>("IdCadastroDeOcorrencia")
                        .HasColumnType("int");

                    b.Property<int>("IdCadastroFilhos")
                        .HasColumnType("int");

                    b.Property<int>("IdCadastroIdosos")
                        .HasColumnType("int");

                    b.Property<int>("IdCadastroSOS")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CadastroDeVitimasCompleto");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.CadastroFilho", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataNascimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereçoescola")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Escolaondeestuda")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCadastroBasico")
                        .HasColumnType("int");

                    b.Property<string>("NecessidadesespeciaisNAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NecessidadesespeciaisSIM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nomefilho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qualnecessidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CadastroFilho");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.CadastroIdoso", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DataNascimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdCadastroBasico")
                        .HasColumnType("int");

                    b.Property<string>("NecessidadesEspeciaisNAO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NecessidadesEspeciaisSIM")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nomoidoso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Qual")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("CadastroIdoso");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.CadastroSOS", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdCadastroBasico")
                        .HasColumnType("int");

                    b.Property<string>("NomeSOS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroCelular")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Vinculo")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CadastroSOS");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.GeoCadastro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CEP")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Complemento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Lat")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Long")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Geo");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.Login", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmailUser")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Login");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.Oficiais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AbrangenciaDeAtuacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("BOfeito")
                        .HasColumnType("bit");

                    b.Property<string>("Contato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Horario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeDepartamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Notificacao")
                        .HasColumnType("bit");

                    b.Property<string>("NumeroBO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PontoFocalDeContato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Oficiais");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.Ong", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ_CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cidade")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFantasia")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeOng")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazaoSocial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TotalFuncionarios")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Ong");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.OngPerfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Accesso")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomePerfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("OngPerfil");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.Parceiro", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CNPJ_CPF")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CONTATO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("EMAIL")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ENDERECO")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdVaga")
                        .HasColumnType("int");

                    b.Property<string>("NOMEEMPRESA")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TOTAL_VAGAS_CADASTRADAS")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Parceiro");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.ParceiroEmpregos", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AreaAtuacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FaixaSalarial")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorarioTrabalho")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<string>("NomeVaga")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("ParceiroEmpregos");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.Perfil", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AccessPerfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ActionsPerfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IdSistema")
                        .HasColumnType("int");

                    b.Property<string>("NomePerfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("Perfil");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.Profissional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Contato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Desconto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaAtendimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorarioAtendimento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeProfissional")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RamoAtuacao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ValorCobrado")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profissional");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.Sistemas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NomeSistema")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Options")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Url")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sistemas");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.SiteSistema", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdSistema")
                        .HasColumnType("int");

                    b.Property<string>("Menu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("SiteSistema");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.UserAccounts", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Contato")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Endereco")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdLogin")
                        .HasColumnType("int");

                    b.Property<string>("Idade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UsuarioAccessoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuarioAccessoId");

                    b.ToTable("UserAccounts");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.UsuarioOng", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Cargo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdOng")
                        .HasColumnType("int");

                    b.Property<string>("NomeCompleto")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PerfilId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("PerfilId");

                    b.ToTable("UsuarioOng");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.Vagas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AvisosDaEmpresa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Descricao")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdEmpresa")
                        .HasColumnType("int");

                    b.Property<string>("InformacoeAdicionais")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeVaga")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Restricoes")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("ValorSalario")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Vagas");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.VinculoSistemaUsuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdPerfil")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdSistema")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("VinculoSistemaUsuario");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.VitimaBasic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Ativo")
                        .HasColumnType("bit");

                    b.Property<string>("Contato")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ContatoRecado")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Endereco")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RedeSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rg_CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("VitimaBasic");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.UserAccounts", b =>
                {
                    b.HasOne("ROSESHIELD.WEB.Entities.Login", "UsuarioAccesso")
                        .WithMany()
                        .HasForeignKey("UsuarioAccessoId");
                });

            modelBuilder.Entity("ROSESHIELD.WEB.Entities.UsuarioOng", b =>
                {
                    b.HasOne("ROSESHIELD.WEB.Entities.OngPerfil", "Perfil")
                        .WithMany()
                        .HasForeignKey("PerfilId");
                });
#pragma warning restore 612, 618
        }
    }
}
