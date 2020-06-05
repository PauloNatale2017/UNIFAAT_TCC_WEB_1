using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ROSESHIELD.WEB.Entities;
using ROSESHIELD.WEB.Models;

namespace ROSESHIELD.WEB
{
    public class EditModel : PageModel
    {

        private readonly AplicationDbContext _db;

        public EditModel(AplicationDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public UserAccounts UserAccounts { get; set; }

        public IEnumerable<Login> UsuarioLogin { get; set; }

        public async Task OnGet(int id)
        {
            UserAccounts = await _db.UserAccounts.FindAsync(id);
            UsuarioLogin =  await _db.Login.ToListAsync();
         
        }


        public async Task<IActionResult> OnPost()
        {
            UserAccounts.CreateDate = (UserAccounts.CreateDate == null ? DateTime.Now : UserAccounts.CreateDate);
            UserAccounts.UpdateDate = (UserAccounts.UpdateDate == null ? DateTime.Now : UserAccounts.UpdateDate);
            UserAccounts.Cidade = (UserAccounts.Cidade == null ? "Atibaia" : UserAccounts.Cidade);

            if(UserAccounts.Id == 0)
            {
                _db.UserAccounts.Add(UserAccounts);
            } else  {
                _db.UserAccounts.Update(UserAccounts);
            }
            
            await _db.SaveChangesAsync();
            return RedirectToPage("Index");
            
        }
    }
}