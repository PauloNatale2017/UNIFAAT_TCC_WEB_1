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
    public class SiteSistemaModel : PageModel
    {
        private readonly AplicationDbContext _db;
        public IEnumerable<SiteSistema> SiteSistema { get; set; }

        public SiteSistemaModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet()
        {
            SiteSistema = await _db.SiteSistema.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var entity = await _db.SiteSistema.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _db.SiteSistema.Remove(entity);
            await _db.SaveChangesAsync();

            return RedirectToPage("SiteSistema");
        }
    }
}