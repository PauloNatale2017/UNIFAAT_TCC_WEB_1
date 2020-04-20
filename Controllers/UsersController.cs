using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
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

        [Route("location")]
        [HttpGet]
        public async Task<IActionResult> GetLocation()
        {

            #region SELENIUM

            IWebDriver driver = new ChromeDriver(@"C:\Users\paulo\OneDrive\Área de Trabalho\REPOSITOR_TCC\WEB_C\DriverChrome\v2\");
            driver.Navigate().GoToUrl("https://www.latlong.net/");

            driver.FindElement(By.Id("place")).Clear();
            driver.FindElement(By.Id("place")).SendKeys("Avenida Geronimo de camargo numero 2200");

            //driver.FindElement(By.Id("btnfind")).Click();
           
            #endregion

            return Ok("");
        }


        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var loginEnt = _db.Login.ToList();
            var returns = _db.UserAccounts.ToList();
            
            List<retur> list = new List<retur>();

            foreach (var item in returns)
            {
                var totalporcidade = returns.Where(d => d.Cidade == item.Cidade).Count();

                list.Add(new retur { 
                   label = item.Cidade,
                   value = (totalporcidade)
                });
            }


            return Ok(list);
        }
    }
}