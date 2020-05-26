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
    public class VitimasModel : PageModel
    {
        private readonly AplicationDbContext _db;
        public IEnumerable<VitimaBasic> VitimaBasic { get; set; }

        public VitimasModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet()
        {
            VitimaBasic = await _db.VitimaBasic.ToListAsync();
        }


        public async Task<IActionResult> OnPostDelete(int id)
        {
            var entity = await _db.VitimaBasic.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _db.VitimaBasic.Remove(entity);
            await _db.SaveChangesAsync();

            return RedirectToPage("Vitimas");
        }
    }
}