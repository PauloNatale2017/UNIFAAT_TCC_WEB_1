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
    public class ParceiroModel : PageModel
    {

        private readonly AplicationDbContext _db;
        public IEnumerable<Parceiro> Parceiro { get; set; }

        public ParceiroModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet()
        {
            //Parceiro = await _db.Parceiro.ToListAsync();
        }


        public async Task<IActionResult> OnPostDelete(int id)
        {
            var entity = await _db.Parceiro.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _db.Parceiro.Remove(entity);
            await _db.SaveChangesAsync();

            return RedirectToPage("Parceiro");
        }

      
    }
}