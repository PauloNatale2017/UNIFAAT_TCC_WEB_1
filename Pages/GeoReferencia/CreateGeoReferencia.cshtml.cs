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
    public class CreateGeoReferenciaModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public GeoCadastro Geo { get; set; }

        public CreateGeoReferenciaModel(AplicationDbContext db)
        {
            _db = db;
        }

        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            await _db.Geo.AddAsync(Geo);
            await _db.SaveChangesAsync();
            return RedirectToPage("GeoReferencia");
        }
    }
}