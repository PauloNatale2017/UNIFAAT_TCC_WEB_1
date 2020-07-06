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

                var entity = _db.VitimaBasic.Where(d => d.Rg_CPF == VitimaBasic.Rg_CPF).SingleOrDefault();

                if (entity != null)
                {

                    _db.VitimaBasic.Update(entity);
                    await _db.SaveChangesAsync();

                    var oldCadastro = _db.VitimaBasic.Where(d => d.Rg_CPF == VitimaBasic.Rg_CPF).SingleOrDefault();
                    var vinculoexist = _db.CadastroDeVitimasCompleto.Where(d => d.IdCadastroBasico == oldCadastro.Id).SingleOrDefault();
                    var complevincoOld = new CadastroDeVitimasCompleto();

                    if (vinculoexist.IdCadastroBasico == null)
                    {
                        complevincoOld = new CadastroDeVitimasCompleto
                        {
                            CreateDate = DateTime.Now,
                            UpdateDate = DateTime.Now,
                            IdCadastroBasico = oldCadastro.Id,
                            IdCadastroComplementar = 0,
                            IdCadastroDeOcorrencia = 0,
                            IdCadastroFilhos = 0,
                            IdCadastroIdosos = 0,
                            IdCadastroSOS = 0
                        };

                        await _db.CadastroDeVitimasCompleto.AddAsync(complevincoOld);
                    }
                    else
                    {

                       vinculoexist.IdCadastroBasico = oldCadastro.Id;
                       _db.CadastroDeVitimasCompleto.Update(vinculoexist);
                    }

                   
                    await _db.SaveChangesAsync();
                }
                else
                {
                    await _db.VitimaBasic.AddAsync(VitimaBasic);
                    await _db.SaveChangesAsync();

                    var entityNew = _db.VitimaBasic.Where(d => d.Rg_CPF == VitimaBasic.Rg_CPF).SingleOrDefault();

                    var complevinco = new CadastroDeVitimasCompleto
                    {
                        CreateDate = DateTime.Now,
                        UpdateDate = DateTime.Now,
                        IdCadastroBasico = entityNew.Id,
                        IdCadastroComplementar = 0,
                        IdCadastroDeOcorrencia = 0,
                        IdCadastroFilhos = 0,
                        IdCadastroIdosos = 0,
                        IdCadastroSOS = 0
                    };

                    await _db.CadastroDeVitimasCompleto.AddAsync(complevinco);
                    await _db.SaveChangesAsync();
                }
                return RedirectToPage("Vitimas");
            }
            else
            {
                return Page();
            }
        }
    }
}