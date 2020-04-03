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
    public class CreateAccountsModel : PageModel
    {
        private readonly AplicationDbContext _db;
        
        [BindProperty]
        public UserAccounts userAccounts { get; set; }

        public CreateAccountsModel(AplicationDbContext db)
        {
            _db = db;
        }
        
        public void OnGet() {

        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.UserAccounts.AddAsync(userAccounts);
                await _db.SaveChangesAsync();
                return RedirectToPage("Index");
            }
            else
            {
                return Page();
            }
        }
    }
}