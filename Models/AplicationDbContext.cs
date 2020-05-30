using Microsoft.EntityFrameworkCore;
using ROSESHIELD.WEB.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Models
{
    public class AplicationDbContext : DbContext
    {
        public AplicationDbContext(DbContextOptions<AplicationDbContext> options):base(options)
        {

        }

        public DbSet<Login> Login { get; set; }
        public DbSet<UserAccounts> UserAccounts { get; set; } 
        public DbSet<Oficiais> Oficiais { get; set; }
        public DbSet<Ong> Ong { get; set; }
        public DbSet<UsuarioOng> UsuarioOng { get; set; }
        public DbSet<OngPerfil> OngPerfil { get; set; }
        public DbSet<Parceiro> Parceiro { get; set; }
        public DbSet<ParceiroEmpregos> ParceiroEmpregos { get; set; }
        public DbSet<Profissional> Profissional { get; set; }
        public DbSet<Sistemas> Sistemas { get; set; }
        public DbSet<Perfil> Perfil { get; set; }
        public DbSet<SiteSistema> SiteSistema { get; set; }
        public DbSet<VinculoSistemaUsuario> VinculoSistemaUsuario { get; set; }
        public DbSet<GeoCadastro> Geo { get; set; }
        public DbSet<Vagas> Vagas { get; set; }
        public DbSet<VitimaBasic> VitimaBasic { get; set; }        
        public DbSet<CadastroDeVitimasCompleto> CadastroDeVitimasCompleto { get; set; }
        public DbSet<CadastroDeOcorrencia> CadastroDeOcorrencia { get; set; }
        public DbSet<CadastroComplementar> CadastroComplementar { get; set; }
        public DbSet<CadastroFilho> CadastroFilho { get; set; }
        public DbSet<CadastroIdoso> CadastroIdoso { get; set; }
        public DbSet<CadastroSOS> CadastroSOS { get; set; }

    }
}
