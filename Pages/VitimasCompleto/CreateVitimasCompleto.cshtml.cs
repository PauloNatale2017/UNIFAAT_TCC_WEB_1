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
    public class CreateVitimasCompletoModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public VitimaBasic VitimaBasic { get; set; }

        public CreateVitimasCompletoModel(AplicationDbContext db)
        {
            _db = db;
        }
       

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.VitimaBasic.AddAsync(VitimaBasic);
                await _db.SaveChangesAsync();
                return RedirectToPage("Vitimas");
            }
            else
            {
                return Page();
            }
        }
    }
}