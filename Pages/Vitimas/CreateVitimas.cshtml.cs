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
    public class CreateVitimasModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public VitimaBasic VitimaBasic { get; set; }

        public CreateVitimasModel(AplicationDbContext db)
        {
            _db = db;
        }
       

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                await _db.VitimaBasic.AddAsync(VitimaBasic);               
                await _db.SaveChangesAsync();

                var entity =  _db.VitimaBasic.Where(d=>d.Rg_CPF == VitimaBasic.Rg_CPF).SingleOrDefault();

                var complevinco = new CadastroDeVitimasCompleto
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    IdCadastroBasico = entity.Id,
                    IdCadastroComplementar = 0,
                    IdCadastroDeOcorrencia = 0,
                    IdCadastroFilhos = 0,
                    IdCadastroIdosos = 0,
                    IdCadastroSOS = 0
                };

                await _db.CadastroDeVitimasCompleto.AddAsync(complevinco);
                await _db.SaveChangesAsync();

                return RedirectToPage("Vitimas");
            }
            else
            {
                return Page();
            }
        }
    }
}