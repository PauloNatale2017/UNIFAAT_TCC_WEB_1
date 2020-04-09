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
    public class CreateSiteSistemaModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public SiteSistema SiteSistema { get; set; }

        public CreateSiteSistemaModel(AplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.SiteSistema.AddAsync(SiteSistema);
                await _db.SaveChangesAsync();
                return RedirectToPage("SiteSistema");
            }
            else
            {
                return Page();
            }
        }
    }
}