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


        public class retur {
            public string label { get; set; }
            public int value { get; set; }
        }
        

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var loginEnt = _db.Login.ToList();
            var returns = _db.UserAccounts.ToList();

            List<retur> list = new List<retur>();
            int values = 1;
            foreach (var item in returns)
            {
                list.Add(new retur { 
                   label = item.Cidade,
                   value = (values)
                });
                values = values + 1;
            }
            
            return Ok(list);
        }
    }
}