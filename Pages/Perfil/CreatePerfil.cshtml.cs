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
    public class CreatePerfilModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public Perfil Perfil { get; set; }

        [BindProperty]
        public Sistemas Sistemas { get; set; }

        [BindProperty]
        public IEnumerable<SiteSistema> SiteSistema { get; set; }

        public CreatePerfilModel(AplicationDbContext db)
        {
            _db = db;
        }

        public async Task OnGet()
        {
            SiteSistema = await _db.SiteSistema.ToListAsync();
        }

       

        public async Task<IActionResult> OnPost()
        {




            await _db.Perfil.AddAsync(Perfil);
            await _db.SaveChangesAsync();
            return RedirectToPage("Perfil");
        }
    }
}