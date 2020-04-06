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
    public class OficiaisModel : PageModel
    {
        private readonly AplicationDbContext _db;
        public IEnumerable<Oficiais> Oficiais { get; set; }

        public OficiaisModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet()
        {
            Oficiais = await _db.Oficiais.ToListAsync();            
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var entity = await _db.Oficiais.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _db.Oficiais.Remove(entity);
            await _db.SaveChangesAsync();

            return RedirectToPage("Oficiais");
        }
    }
}