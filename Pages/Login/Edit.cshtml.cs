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
        public UserAccounts userAccounts { get; set; }

        public IEnumerable<Login> usuarioLogin { get; set; }

        public async Task OnGet(int id)
        {
            userAccounts = await _db.UserAccounts.FindAsync(id);
            usuarioLogin =  await _db.Login.ToListAsync();
         
        }


        public async Task<IActionResult> OnPost()
        {
            if(ModelState.IsValid)
            {
                var atualiza = await _db.UserAccounts.FindAsync(userAccounts.Id);
                atualiza.Idade = userAccounts.Idade;
                await _db.SaveChangesAsync();
            }
            return Page();

        }
    }
}