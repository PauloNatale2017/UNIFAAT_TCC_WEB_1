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
    public class EditProfissionalModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public Profissional Profissional { get; set; }

        public EditProfissionalModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet(int id)
        {
            Profissional = await _db.Profissional.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Profissional.Id == 0)
                {
                    _db.Profissional.Add(Profissional);
                }
                else
                {
                    _db.Profissional.Update(Profissional);
                }

                await _db.SaveChangesAsync();
                return RedirectToPage("Profissional");


            }
            return RedirectToPage();

        }
    }
}