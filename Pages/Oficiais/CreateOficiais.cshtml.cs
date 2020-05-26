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
    public class CreateOficiaisModel : PageModel
    {

        private readonly AplicationDbContext _db;

        [BindProperty]
        public Oficiais Oficiais { get; set; }

        public CreateOficiaisModel(AplicationDbContext db)
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
                await _db.Oficiais.AddAsync(Oficiais);
                await _db.SaveChangesAsync();
                return RedirectToPage("Vagas");
            }
            else
            {
                return Page();
            }
        }
    }
}