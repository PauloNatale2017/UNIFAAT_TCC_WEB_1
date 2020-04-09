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
    public class VinculaPerfilModel : PageModel
    {
        private readonly AplicationDbContext _db;
        public IEnumerable<Sistemas> Sistemas { get; set; }
        public IEnumerable<Perfil> Perfil { get; set; }
        public IEnumerable<Login> Login { get; set; }
        public VinculaPerfilModel(AplicationDbContext db) {
            _db = db;
        }
        public async Task OnGet()
        {
            Sistemas = await _db.Sistemas.ToListAsync();
            Perfil = await _db.Perfil.ToListAsync();
            Login = await _db.Login.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var entity = await _db.Perfil.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _db.Perfil.Remove(entity);
            await _db.SaveChangesAsync();

            return RedirectToPage("Perfil");
        }
    }
}