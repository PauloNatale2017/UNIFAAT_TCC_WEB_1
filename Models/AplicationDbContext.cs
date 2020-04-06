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




    }
}
