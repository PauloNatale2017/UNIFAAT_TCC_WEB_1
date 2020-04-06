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
    public class EditOngModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public Ong Ong { get; set; }

        public EditOngModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet(int id)
        {
            Ong = await _db.Ong.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var atualiza = await _db.Ong.FindAsync(Ong.Id);
                atualiza.RazaoSocial = Ong.RazaoSocial;
                atualiza.NomeFantasia = Ong.NomeFantasia;
                atualiza.NomeOng = Ong.NomeOng;
                atualiza.TotalFuncionarios = Ong.TotalFuncionarios;
                atualiza.UpdateDate = Ong.UpdateDate;
                atualiza.Endereco = Ong.Endereco;
                atualiza.Email = Ong.Email;
                atualiza.CreateDate = Ong.CreateDate;
                atualiza.Contato = Ong.Contato;
                atualiza.CNPJ_CPF = Ong.CNPJ_CPF;
                atualiza.Cidade = Ong.Cidade;
            
                await _db.SaveChangesAsync();
                return RedirectToPage("Ong");
            }
            return RedirectToPage();

        }
    }
    
}