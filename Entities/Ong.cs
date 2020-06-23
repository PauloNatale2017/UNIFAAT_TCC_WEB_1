using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class Ong : baseEntity
    {
        [Required(ErrorMessage = "Usuario e obrigatorio.")]
        public string RazaoSocial { get; set; }
        public string NomeFantasia { get; set; }
        public string NomeOng { get; set; }
        public string CNPJ_CPF { get; set; }
        public string Contato { get; set; }
        public string Endereco { get; set; }
        public string TotalFuncionarios { get; set; }
        public string Cidade { get; set; }      
        public string Email { get; set; }
       
    }
}
