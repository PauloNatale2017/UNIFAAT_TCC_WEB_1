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
    public class VagasModel : PageModel
    {
        private readonly AplicationDbContext _db;
        public IEnumerable<Vagas> Vagas { get; set; }

        public VagasModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet()
        {
            Vagas = await _db.Vagas.ToListAsync();
        }


        public async Task<IActionResult> OnPostDelete(int id)
        {
            var entity = await _db.Vagas.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _db.Vagas.Remove(entity);
            await _db.SaveChangesAsync();

            return RedirectToPage("Ong");
        }
    }
}