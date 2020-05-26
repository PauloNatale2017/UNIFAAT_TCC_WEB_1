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
    public class EditVitimasModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public VitimaBasic VitimaBasic { get; set; }

        public EditVitimasModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet(int id)
        {
            VitimaBasic = await _db.VitimaBasic.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                if (VitimaBasic.Id == 0)
                {
                    _db.VitimaBasic.Add(VitimaBasic);
                }
                else
                {
                    _db.VitimaBasic.Update(VitimaBasic);
                }

                await _db.SaveChangesAsync();
                return RedirectToPage("Vitimas");
            }
            return RedirectToPage();

        }
    }
}