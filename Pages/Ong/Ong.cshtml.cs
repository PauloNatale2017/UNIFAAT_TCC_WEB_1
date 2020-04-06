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
    public class OngModel : PageModel
    {

        private readonly AplicationDbContext _db;
        public IEnumerable<Ong> Ong { get; set; }

        public OngModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet()
        {
            Ong = await _db.Ong.ToListAsync();
        }


        public async Task<IActionResult> OnPostDelete(int id)
        {
            var entity = await _db.Ong.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _db.Ong.Remove(entity);
            await _db.SaveChangesAsync();

            return RedirectToPage("Ong");
        }

    }
}