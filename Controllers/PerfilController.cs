﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ROSESHIELD.WEB.Entities;
using ROSESHIELD.WEB.Models;

namespace ROSESHIELD.WEB.Controllers
{

    [Route("api/Perfil")]
    [ApiController]
    public class PerfilController : Controller
    {
        private readonly AplicationDbContext _db;

        public PerfilController(AplicationDbContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Perfil Perfil { get; set; }

        [Route("getall")]
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var returns = _db.Login.ToList();
            //var jsonEntity = JsonConvert.SerializeObject(returns);
            return Ok(returns);
        }

        [Route("getperfilall")]
        [HttpGet]
        public async Task<IActionResult> GetPerfilAll()
        {
            var returns = _db.Perfil.ToList();
            //var jsonEntity = JsonConvert.SerializeObject(returns);
            return Ok(returns);
        }



        [Route("createperfilvinculo")]
        [HttpPost]
        public async Task<IActionResult> PerfilVinculo(VinculoSistemaUsuario entityPerfil)
        {

            _db.VinculoSistemaUsuario.Add(new VinculoSistemaUsuario
            {
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                IdPerfil = entityPerfil.IdPerfil,
                IdSistema = entityPerfil.IdSistema,
                IdUsuario = entityPerfil.IdUsuario
            });
            _db.SaveChanges();

            return Ok("OK");
        }


        [Route("createperfil")]
        [HttpPost]
        public async Task<IActionResult> CreatePerfil(RequestPerfil entity)
        {

            try
            {
                var insert = new Perfil
                {
                    AccessPerfil = (entity.HOME + "&" + entity.MAPS + "&" + entity.NOTIFICACAO + "&" + entity.RELATORIOS + "&" + entity.ABERTURA_BOS + "&"),
                    ActionsPerfil = (entity.CRIAR + "&" + entity.EDITAR + "&" + entity.PESQUISA + "&" + entity.ACAO_FULL),
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    NomePerfil = entity.NOME_PERFIL,
                    IdSistema = int.Parse(entity.SISTEMA)
                };

                _db.Perfil.Add(insert);
                _db.SaveChanges();

            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Ok("OK");
        }

        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}