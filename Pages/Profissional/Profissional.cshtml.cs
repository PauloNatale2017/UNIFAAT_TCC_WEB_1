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
    public class ProfissionalModel : PageModel
    {
        private readonly AplicationDbContext _db;
        public IEnumerable<Profissional> Profissional { get; set; }

        public ProfissionalModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet()
        {
            Profissional = await _db.Profissional.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var entity = await _db.Profissional.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _db.Profissional.Remove(entity);
            await _db.SaveChangesAsync();

            return RedirectToPage("Profissional");
        }
    }
}