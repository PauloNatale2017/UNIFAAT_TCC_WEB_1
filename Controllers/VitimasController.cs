﻿using System;
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
        public IEnumerable<CadastroComplementar> CadastroComplementar { get; set; }
        public IEnumerable<CadastroDeVitimasCompleto> CadastroDeVitimasCompleto { get; set; }

        [Route("cadastrosbasicos")]
        [HttpGet]
        public async Task<IActionResult> GetCadastrosBasic()
        {
            var VitimaBasic = await _db.VitimaBasic.ToListAsync();
            var Completo =  await _db.CadastroDeVitimasCompleto.ToListAsync();            
            var CadastroComplementar = await _db.CadastroComplementar.ToListAsync();
            var ocorrencias = await _db.CadastroDeOcorrencia.ToListAsync();

            dynamic dados = new { 
                vitimabasic = VitimaBasic,
                cadastrocompleto = Completo,
                complementar = CadastroComplementar,
                ocorrencias = ocorrencias
            };
            var jsonEntity = JsonConvert.SerializeObject(dados);
            return Ok(jsonEntity);

        }


        #region COMPLEMENTAR

        public class request
        {
            public int IdCadastroBasico { get; set; }
            public string Profissao { get; set; }
            public string RendaPessoal { get; set; }
            public string RendaFamiliar { get; set; }
            public string drogaslicitasSIM { get; set; }
            public string QualdrogaDescri1 { get; set; }
            public string drogaslicitasNAO { get; set; }
            public string QualdrogaDescri2 { get; set; }
            public string Possuifilhos { get; set; }
            public string Qtdo { get; set; }
            public string Idoso { get; set; }
            public string Quantidade { get; set; }
        }
          
        [Route("cadastrocomplementar")]
        [HttpPost]
        public async Task<IActionResult> AddComplementar(request model)
        {
            var retorno = _db.CadastroComplementar.Where(d => d.IdCadastroBasico == model.IdCadastroBasico).SingleOrDefault();
            if(retorno != null)
            {
                return BadRequest("Cadastro Complementar ja existente.");
            }
            else
            {
                _db.CadastroComplementar.Add(new CadastroComplementar
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    IdCadastroBasico = model.IdCadastroBasico,
                    DrogasilicitasNAO = model.drogaslicitasSIM != "" ? "1" : "0",
                    QualdrogaDescri1 = model.QualdrogaDescri1,
                    DrogasilicitasSIM = model.drogaslicitasNAO != "" ? "1" : "0",
                    QualdrogaDescri2 = model.QualdrogaDescri2,
                    IdosoNAO = model.Idoso == "1" ? "0" : "1",
                    IdosoSIM = model.Idoso == "1" ? "1" : "0",
                    Qtdo = model.Qtdo,
                    PossuifilhosSIM = model.Possuifilhos == "1" ? "1" : "0",
                    PossuiFilhosNAO = model.Possuifilhos == "1" ? "0" : "1",
                    Quantidade = model.Quantidade,
                    Profissao = model.Profissao,
                    RendaFamiliar = model.RendaFamiliar,
                    RendaPessoal = model.RendaPessoal,
                    drogaslicitasNAO = model.drogaslicitasSIM != "" ? "1" : "0",
                    drogaslicitasSIM = model.drogaslicitasSIM != "" ? "1" : "0"
                });
                _db.SaveChanges();
            }
           

            return Ok(true);
        }

        public class buscacomp {
            public string IdCadastroBasico { get; set; }
        }


        [Route("buscacomplementar")]
        [HttpPost]
        public async Task<IActionResult> GetComplementar(buscacomp model)
        {
            var jsonEntity = "";
            try
            {
                var retorno = _db.CadastroComplementar.Where(d => d.IdCadastroBasico == int.Parse(model.IdCadastroBasico)).SingleOrDefault();
                jsonEntity = JsonConvert.SerializeObject(retorno);
            }
            catch (Exception ex)
            {
                throw ex;
            }
           
            return Ok(jsonEntity);
        }


        #endregion

        #region OCORRENCIAS

        [Route("cadastroocorrencias")]
        [HttpPost]
        public async Task<IActionResult> AddOcorrencia(CadastroDeOcorrencia model)
        {
            var retorno = _db.CadastroDeOcorrencia.Where(d => d.IdCadastroBasico == model.IdCadastroBasico).SingleOrDefault();
            if (retorno != null) {
                return BadRequest("Cadastro Cadastro De Ocorrencia ja existente.");
            } else {
                _db.CadastroDeOcorrencia.Add(new CadastroDeOcorrencia
                {
                    CreateDate = DateTime.Now,
                    UpdateDate = DateTime.Now,
                    IdCadastroBasico = model.IdCadastroBasico,                     
                    TipoViolencia = model.TipoViolencia,
                    DiaOcorrido = model.DiaOcorrido,
                    LocalOcorrido = model.LocalOcorrido,
                    Testemunha = model.Testemunha,
                    UsodeDrogasIlicitas = "N/A",
                    UsodeDrograsLicitas = "N/A",
                    VinculocomAgressor = model.VinculocomAgressor,
                    BOSIM = model.NumeroBO != "" ? "1" : "0",
                    BONAO = model.NumeroBO != "" ? "1" : "0",
                    NumeroBO = model.NumeroBO
                });
                _db.SaveChanges();
            }


            return Ok(true);
        }


        [Route("buscaocorrencias")]
        [HttpPost]
        public async Task<IActionResult> GetOcorrencias(buscacomp model)
        {
            var jsonEntity = "";
            try
            {
                var retorno = _db.CadastroDeOcorrencia.Where(d => d.IdCadastroBasico == int.Parse(model.IdCadastroBasico)).SingleOrDefault();
                jsonEntity = JsonConvert.SerializeObject(retorno);
            }
            catch (Exception ex)
            {
                throw ex;
            }

            return Ok(jsonEntity);
        }


        #endregion

    }
}