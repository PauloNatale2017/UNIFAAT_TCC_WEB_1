﻿using System;
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

                if (Parceiro.Id == 0)
                {
                    _db.Parceiro.Add(Parceiro);
                }
                else
                {
                    _db.Parceiro.Update(Parceiro);
                }

                await _db.SaveChangesAsync();
                return RedirectToPage("Parceiro");

            }
            return RedirectToPage();

        }
    }
}