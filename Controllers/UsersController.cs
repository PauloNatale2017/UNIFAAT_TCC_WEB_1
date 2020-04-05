using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ROSESHIELD.WEB.Entities;
using ROSESHIELD.WEB.Models;

namespace ROSESHIELD.WEB.Controllers
{

    [Route("api/Users")]
    [ApiController]
    public class UsersController : Controller
    {
        private readonly AplicationDbContext _db;

        public UsersController(AplicationDbContext db)
        {
            _db = db;
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var returns = _db.Login.ToList();  
            return Json(JsonConvert.SerializeObject(returns));
        }
    }
}