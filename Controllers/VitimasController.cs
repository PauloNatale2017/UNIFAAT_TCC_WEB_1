using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using ROSESHIELD.WEB.Entities;
using ROSESHIELD.WEB.Models;

namespace ROSESHIELD.WEB.Controllers
{

    [Route("api/vitimas")]
    [ApiController]
    public class VitimasController : Controller
    {
        private readonly AplicationDbContext _db;
        public VitimasController(AplicationDbContext db){
            _db = db;
        }

        public IEnumerable<VitimaBasic> VitimaBasic { get; set; }
        public IEnumerable<CadastroDeVitimasCompleto> VitimaCompleto { get; set; }

        [Route("cadastrosbasicos")]
        [HttpGet]
        public async Task<IActionResult> GetCadastrosBasic()
        {
            var VitimaBasic = await _db.VitimaBasic.ToListAsync();
            //return Ok(VitimaBasic);

            var jsonEntity = JsonConvert.SerializeObject(VitimaBasic);
            return Ok(jsonEntity);

        }


        [Route("cadastrocomplementar")]
        [HttpPost]
        public async Task<IActionResult> AddComplementar(string IdUsuario)
        {
            return Ok(true);
        }
    }
}