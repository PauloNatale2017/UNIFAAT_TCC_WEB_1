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
    public class CreateSistemaModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public Sistemas Sistemas { get; set; }

        public CreateSistemaModel(AplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            await _db.Sistemas.AddAsync(Sistemas);
            await _db.SaveChangesAsync();
            return RedirectToPage("Sistema");
        }
    }
}