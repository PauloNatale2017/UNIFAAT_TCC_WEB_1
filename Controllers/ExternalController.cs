using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ROSESHIELD.WEB.Models;

namespace ROSESHIELD.WEB.Controllers
{
    [Route("api/external")]
    [ApiController]
    public class ExternalController : Controller
    {

        private readonly AplicationDbContext _db;
        public ExternalController(AplicationDbContext db)
        {
            _db = db;
        }
        
        [Route("externalusers")]
        [HttpPost]
        public async Task<IActionResult> GetUsuarios(UserLogin user)
        {
            var returns = _db.Login.Where(d => d.EmailUser == user.User && d.Password == user.Password).SingleOrDefault();
            var jsonEntity = JsonConvert.SerializeObject(returns);
            return Ok(jsonEntity);
        }

        [Route("externalvagas")]
        [HttpGet]
        public async Task<IActionResult> GetVagas()
        {
            var returns = _db.Vagas.ToList();
            var jsonEntity = JsonConvert.SerializeObject(returns);
            return Ok(jsonEntity);
        }

        [Route("externalvitimasbasic")]
        [HttpGet]
        public async Task<IActionResult> GetVitimasBasico()
        {
            var returns = _db.VitimaBasic.ToList();
            var jsonEntity = JsonConvert.SerializeObject(returns);
            return Ok(jsonEntity);
        }

        public class UserLogin
        {
            public string User { get; set; }
            public string Password { get; set; }

        }
    }
}