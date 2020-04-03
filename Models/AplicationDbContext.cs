using Microsoft.EntityFrameworkCore;
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

        public DbSet<Entities.Login> Login { get; set; }
        public DbSet<Entities.UserAccounts> UserAccounts { get; set; }

    }
}
