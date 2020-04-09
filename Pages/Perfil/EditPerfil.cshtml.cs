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
    public class EditPerfilModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public Perfil Perfil { get; set; }

        public EditPerfilModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet(int id)
        {
            Perfil = await _db.Perfil.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {

                if (Perfil.Id == 0)
                {
                    _db.Perfil.Add(Perfil);
                }
                else
                {
                    _db.Perfil.Update(Perfil);
                }

                await _db.SaveChangesAsync();
                return RedirectToPage("Perfil");

            }
            return RedirectToPage();

        }
    }
}