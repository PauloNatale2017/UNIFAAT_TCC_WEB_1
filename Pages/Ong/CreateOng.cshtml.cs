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
    public class CreateOngModel : PageModel
    {

        private readonly AplicationDbContext _db;

        [BindProperty]
        public Ong Ong { get; set; }

        public CreateOngModel(AplicationDbContext db)
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
                Ong.CreateDate = DateTime.Now;
                Ong.UpdateDate = DateTime.Now;

                await _db.Ong.AddAsync(Ong);
                await _db.SaveChangesAsync();
                return RedirectToPage("Ong");
            }
            else
            {
                return Page();
            }
        }

    }
}