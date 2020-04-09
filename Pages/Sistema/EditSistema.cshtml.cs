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
    public class EditSistemaModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public Sistemas Sistemas { get; set; }

        public EditSistemaModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet(int id)
        {
            Sistemas = await _db.Sistemas.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Sistemas.Id == 0)
                {
                    _db.Sistemas.Add(Sistemas);
                }
                else
                {
                    _db.Sistemas.Update(Sistemas);
                }

                await _db.SaveChangesAsync();
                return RedirectToPage("Sistemas");


            }
            return RedirectToPage();

        }
    }
}