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
    public class EditVagasModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public Vagas Vagas { get; set; }

        public EditVagasModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet(int id)
        {
            Vagas = await _db.Vagas.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {

                if (Vagas.Id == 0)
                {
                    _db.Vagas.Add(Vagas);
                }
                else
                {
                    _db.Vagas.Update(Vagas);
                }

                await _db.SaveChangesAsync();
                return RedirectToPage("Vagas");

            }
            return RedirectToPage();

        }
    }
}