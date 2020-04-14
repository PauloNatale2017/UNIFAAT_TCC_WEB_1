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
    public class EditSiteSistemaModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public SiteSistema SiteSistemas { get; set; }

        public EditSiteSistemaModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet(int id)
        {
            SiteSistemas = await _db.SiteSistema.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                if (SiteSistemas.Id == 0)
                {
                    _db.SiteSistema.Add(SiteSistemas);
                }
                else
                {
                    _db.SiteSistema.Update(SiteSistemas);
                }

                await _db.SaveChangesAsync();
                return RedirectToPage("SiteSistemas");
            }
            return RedirectToPage();

        }
    }

   
}