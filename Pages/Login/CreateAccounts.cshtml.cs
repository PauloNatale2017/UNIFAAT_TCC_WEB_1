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
                UserAccounts.UsuarioAccesso.CreateDate = DateTime.Now;
                UserAccounts.UsuarioAccesso.UpdateDate = DateTime.Now;

                Random randNum = new Random();
                string senhaRandom = randNum.Next(1, 9999999).ToString();

                string destinatario = UserAccounts.UsuarioAccesso.Password;

                UserAccounts.UsuarioAccesso.Password = senhaRandom;

                await _db.Login.AddAsync(UserAccounts.UsuarioAccesso);
                await _db.SaveChangesAsync();

                Notificacoes.SendEmail envio = new Notificacoes.SendEmail();
                envio.EnvioDeEmails("paulo000natale@gmail.com", destinatario, senhaRandom, UserAccounts.UsuarioAccesso.EmailUser);

                var loginnew = _db.Login.Where(d => d.EmailUser == UserAccounts.UsuarioAccesso.EmailUser && d.Password == UserAccounts.UsuarioAccesso.Password).SingleOrDefault();

                UserAccounts.IdLogin = loginnew.Id;

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