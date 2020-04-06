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
    public class EditParceiroModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public Parceiro Parceiro { get; set; }

        public EditParceiroModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet(int id)
        {
            Parceiro = await _db.Parceiro.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                var atualiza = await _db.Parceiro.FindAsync(Parceiro.Id);
                atualiza.NOMEEMPRESA = Parceiro.NOMEEMPRESA;
                atualiza.CNPJ_CPF = Parceiro.CNPJ_CPF;
                atualiza.CONTATO = Parceiro.CONTATO;
                atualiza.ENDERECO = Parceiro.ENDERECO;
                atualiza.UpdateDate = Parceiro.UpdateDate;
                atualiza.EMAIL = Parceiro.EMAIL;
                atualiza.TOTAL_VAGAS_CADASTRADAS = Parceiro.TOTAL_VAGAS_CADASTRADAS;
                //atualiza.Vagas = new ParceiroEmpregos { 
                //    NomeVaga        = Parceiro.Vagas.NomeVaga        ,
                //    HorarioTrabalho = Parceiro.Vagas.HorarioTrabalho ,
                //    FaixaSalarial   = Parceiro.Vagas.FaixaSalarial   ,
                //    Descricao       = Parceiro.Vagas.Descricao       ,
                //    Cargo           = Parceiro.Vagas.Cargo           ,
                //    AreaAtuacao     = Parceiro.Vagas.AreaAtuacao
                //};


                await _db.SaveChangesAsync();
                return RedirectToPage("Parceiro");
            }
            return RedirectToPage();

        }
    }
}