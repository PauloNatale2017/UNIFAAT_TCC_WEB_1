
#region USING
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using ROSESHIELD.WEB.Entities;
using ROSESHIELD.WEB.Models;
#endregion

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
        
        #region CLASS

        public class buscacomp
        {
            public string Id { get; set; }
        }
        
        public class requestgeo
        {
            public string Endereco { get; set; }
            public string CEP { get; set; }
            public string Complemento { get; set; }
            public string Lat { get; set; }
            public string Long { get; set; }
            public string IdUsuario { get; set; }
        }

        public class UserLogin
        {
            public string User { get; set; }
            public string Password { get; set; }

        }

        public class entitymodel
        {
            public string AreaAtuacao { get; set; }
            public string Cargo { get; set; }
            public string Descricao { get; set; }
            public string FaixaSalarial { get; set; }
            public string HorarioTrabalho { get; set; }
            public string Id { get; set; }
            public string NomeVaga { get; set; }
        }

        #endregion


        [Route("externalgerperfill/{idusuario}")]
        [HttpGet]
        public async Task<IActionResult> GetPerfil(string IdUsuario)
        {
            var returnPerfiluser = _db.VinculoSistemaUsuario.Where(d => d.IdPerfil == IdUsuario).SingleOrDefault();
            var returns = _db.Perfil.ToList();
            var jsonEntity = JsonConvert.SerializeObject(returns.Where(d=>d.Id == int.Parse(returnPerfiluser.IdUsuario)));
            return Ok(jsonEntity);
        }

        [Route("externalusersall")]
        [HttpGet]        
        public async Task<IActionResult> GetUsuariosFull()
        {
            var returns = _db.Login.ToList();
            var jsonEntity = JsonConvert.SerializeObject(returns);
            return Ok(jsonEntity);
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
        
        [Route("externalparceiros")]
        [HttpGet]
        public async Task<IActionResult> GetParceiros()
        {
            var returns = _db.Parceiro.ToList();
            var jsonEntity = JsonConvert.SerializeObject(returns);
            return Ok(jsonEntity);
        }

        [Route("externalvagasempresa")]
        [HttpPost]
        public async Task<IActionResult> GetVagasEmpresa(buscacomp model)
        {
            var returns = _db.ParceiroEmpregos.Where(d => d.IdEmpresa == int.Parse(model.Id)).ToList();
            var jsonEntity = JsonConvert.SerializeObject(returns);
            return Ok(jsonEntity);
        }
               
        [Route("externalvagasempresasalvar")]
        [HttpPost]
        public async Task<IActionResult> SalvaVagasEmpresa(entitymodel model)
        {
            _db.ParceiroEmpregos.Add(new ParceiroEmpregos {
                 CreateDate = DateTime.Now,
                 UpdateDate = DateTime.Now,
                 AreaAtuacao = model.AreaAtuacao,
                 Cargo = model.Cargo,
                 Descricao = model.Descricao,
                 FaixaSalarial = model.FaixaSalarial,
                 HorarioTrabalho = model.HorarioTrabalho,
                 NomeVaga = model.NomeVaga,
                 IdEmpresa = int.Parse(model.Id)
            });
            _db.Vagas.Add(new Vagas
            {
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                AvisosDaEmpresa = "",
                Descricao = model.Descricao,
                IdEmpresa = int.Parse(model.Id.ToString()),
                InformacoeAdicionais = "",
                NomeVaga = model.NomeVaga,
                Restricoes = "",
                ValorSalario = model.FaixaSalarial
            });
            var parceiroUpdate = _db.Parceiro.Where(d => d.Id == int.Parse(model.Id)).SingleOrDefault();
            parceiroUpdate.TOTAL_VAGAS_CADASTRADAS = (parceiroUpdate.TOTAL_VAGAS_CADASTRADAS == null ? (1).ToString() : (int.Parse(parceiroUpdate.TOTAL_VAGAS_CADASTRADAS) + 1).ToString());
            _db.Parceiro.Update(parceiroUpdate);
            _db.SaveChanges();
            return Ok(true);
        }
               
        [Route("externalcadastrogeo")]
        [HttpPost]
        public async Task<IActionResult> SalvaGeoReferencia(requestgeo model)
        {
            var Geo = new GeoCadastro
            {
                CEP = model.CEP,
                Complemento = model.Complemento,
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                Endereco = model.Endereco,
                IdUsuario = int.Parse(model.IdUsuario),
                Lat = model.Lat,
                Long = model.Long
            };

            await _db.Geo.AddAsync(Geo);
            await _db.SaveChangesAsync();

            return Ok(true);
        }
        
        [Route("externalongs")]
        [HttpGet]
        public async Task<IActionResult> GetOngs()
        {
            var returns = _db.Ong.ToList();
            var jsonEntity = JsonConvert.SerializeObject(returns);
            return Ok(jsonEntity);
        }


        [Route("externalongsdelete")]
        [HttpPost]
        public async Task<IActionResult> DeleteOngs(buscacomp model)
        {
 
            var entity = _db.Ong.Where(d => d.Id == int.Parse(model.Id)).SingleOrDefault();
            if (entity == null)
            {
                return NotFound();
            }

             _db.Ong.Remove(entity);
            await _db.SaveChangesAsync();

            return Ok(true);
        }

        [Route("externalongssave")]
        [HttpPost]
        public async Task<IActionResult> SalvaOngs(UsuarioOng model)
        {
            var userong = new UsuarioOng
            {
                CreateDate = DateTime.Now,
                UpdateDate = DateTime.Now,
                IdOng = model.IdOng,
                Cargo = model.Cargo,
                Email = model.Email,
                NomeCompleto = model.NomeCompleto,
                Perfil = model.Perfil
            };
            await _db.UsuarioOng.AddAsync(userong);
            await _db.SaveChangesAsync();

            var login = new Login   {
                EmailUser = model.Email,
                Password = "123456",
                UpdateDate = DateTime.Now,
                CreateDate = DateTime.Now
            };
            _db.Login.AddAsync(login);
            _db.SaveChanges();

            var Ongs = _db.Ong.Where(d => d.Id == int.Parse(model.IdOng)).SingleOrDefault();
            Ongs.TotalFuncionarios = (Ongs.TotalFuncionarios == null ? (1).ToString() : (int.Parse(Ongs.TotalFuncionarios) + 1).ToString());
            _db.Ong.Update(Ongs);
            _db.SaveChanges();

            var LoginsConsulta = _db.Login.Where(d => d.EmailUser == login.EmailUser && d.Password == login.Password).SingleOrDefault();
            var usuariobasiclogin = new UserAccounts {
                 Cidade = "Atibaia",
                 Contato = Ongs.Contato,
                 Cpf = "",
                 CreateDate = DateTime.Now,
                 Endereco = Ongs.Endereco,
                 Idade = "",
                 IdLogin = LoginsConsulta.Id,
                 NomeCompleto = model.NomeCompleto,
                 UpdateDate = DateTime.Now,
                 UsuarioAccesso = new Login { 
                       EmailUser = LoginsConsulta.EmailUser,
                       Password =  LoginsConsulta.Password,
                       UpdateDate = DateTime.Now,
                       CreateDate = DateTime.Now
                 }
            };

            _db.UserAccounts.AddAsync(usuariobasiclogin);
            _db.SaveChanges();

            return Ok(true);
        }


    }
}