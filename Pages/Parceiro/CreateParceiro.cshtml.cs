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
    public class CreateParceiroModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public Parceiro Parceiro { get; set; }

        public CreateParceiroModel(AplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {            
             await _db.Parceiro.AddAsync(Parceiro);
            await _db.SaveChangesAsync();
            return RedirectToPage("Parceiro");
    
        }
    }
}