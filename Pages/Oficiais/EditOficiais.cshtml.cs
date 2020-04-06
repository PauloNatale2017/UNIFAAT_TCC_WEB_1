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
    public class EditOficiaisModel : PageModel
    {

        private readonly AplicationDbContext _db;

        [BindProperty]
        public Oficiais Oficiais { get; set; }

        public EditOficiaisModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet(int id)
        {
            Oficiais = await _db.Oficiais.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var atualiza = await _db.Oficiais.FindAsync(Oficiais.Id);
                atualiza.Nome = Oficiais.Nome;
                await _db.SaveChangesAsync();
                return RedirectToPage("Oficiais");
            }
            return RedirectToPage();

        }
    }
}