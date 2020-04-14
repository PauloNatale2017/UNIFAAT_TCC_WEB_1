using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Mvc;
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
        public UserAccounts UserAccounts { get; set; }

        [BindProperty]
        public List<SelectListItem> Options { get; set; }



        public CreateAccountsModel(AplicationDbContext db)
        {
            _db = db;
        }
        
        public void OnGet() {

            Options = _db.UserAccounts.Select(a => new SelectListItem
            {
                Value = a.Id.ToString(),
                Text = a.Cidade
            }).ToList();
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.UserAccounts.AddAsync(UserAccounts);
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