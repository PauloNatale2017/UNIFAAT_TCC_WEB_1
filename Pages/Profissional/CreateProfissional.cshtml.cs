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
    public class CreateProfissionalModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public Profissional Profissional { get; set; }

        public CreateProfissionalModel(AplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            //if (ModelState.IsValid)
            //{
                await _db.Profissional.AddAsync(Profissional);
                await _db.SaveChangesAsync();
                return RedirectToPage("Profissional");
            //}
            //else
            //{
            //    return Page();
            //}
        }
    }
}