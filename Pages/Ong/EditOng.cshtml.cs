using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ROSESHIELD.WEB.Entities;
using ROSESHIELD.WEB.Models;

namespace ROSESHIELD.WEB
{
    public class EditOngModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public Ong Ong { get; set; }

        public EditOngModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet(int id)
        {
            Ong = await _db.Ong.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Ong.Id == 0)
                {
                    _db.Ong.Add(Ong);
                }
                else
                {
                    _db.Ong.Update(Ong);
                }

                await _db.SaveChangesAsync();
                return RedirectToPage("Ong");
            }
            return RedirectToPage();

        }
    }
    
}