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
    public class EditGeoReferenciaModel : PageModel
    {
        private readonly AplicationDbContext _db;

        [BindProperty]
        public GeoCadastro Geo { get; set; }

        public EditGeoReferenciaModel(AplicationDbContext db)
        {
            _db = db;
        }
        public async Task OnGet(int id)
        {
            Geo = await _db.Geo.FindAsync(id);
        }

        public async Task<IActionResult> OnPost()
        {
            if (ModelState.IsValid)
            {
                if (Geo.Id == 0)
                {
                    _db.Geo.Add(Geo);
                }
                else
                {
                    _db.Geo.Update(Geo);
                }

                await _db.SaveChangesAsync();
                return RedirectToPage("GeoReferencia");
            }
            return RedirectToPage();

        }
    }
}