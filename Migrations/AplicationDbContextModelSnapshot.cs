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
