using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ROSESHIELD.WEB.Entities;
using ROSESHIELD.WEB.Models;

namespace ROSESHIELD.WEB
{
    public class IndexModel : PageModel
    {
        private readonly AplicationDbContext _db;

        public IndexModel(AplicationDbContext db)
        {
            _db = db;
        }

        public IEnumerable<UserAccounts> Logins { get; set; }
        public IEnumerable<Login> usuarioLogin { get; set; }

        public async Task OnGet()
        {
            Logins = await _db.UserAccounts.ToListAsync();           
            usuarioLogin = await _db.Login.ToListAsync();
        }
    }
}