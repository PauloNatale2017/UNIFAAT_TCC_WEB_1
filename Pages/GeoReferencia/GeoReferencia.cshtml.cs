using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ROSESHIELD.WEB.Entities;
using ROSESHIELD.WEB.Models;

namespace ROSESHIELD.WEB
{
    public class GeoReferenciaModel : PageModel
    {
        private readonly AplicationDbContext _db;
        public IEnumerable<GeoCadastro> Geo { get; set; }

        public GeoReferenciaModel(AplicationDbContext db)
        {
            _db = db;
        }


        public async Task OnGetLocalizacao()
        {
           
        }

        public async Task OnGet()
        {
            Geo = await _db.Geo.ToListAsync();
        }

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var entity = await _db.Geo.FindAsync(id);
            if (entity == null)
            {
                return NotFound();
            }

            _db.Geo.Remove(entity);
            await _db.SaveChangesAsync();

            return RedirectToPage("GeoReferencia");
        }
    }
}