using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class UserAccounts : baseEntity
    {
        public int IdLogin { get; set; }
        [Required(ErrorMessage ="Nome e obrigatorio.")]
        public string NomeCompleto { get; set; }

        [Required(ErrorMessage = "Idade e obrigatorio.")]
        public string Idade { get; set; }

        [Required(ErrorMessage = "Endereço e obrigatorio.")]
        public string Endereco { get; set; }

        [Required(ErrorMessage = "Contato e obrigatorio.")]
        public string Contato { get; set; }

        [Required(ErrorMessage = "CPF e obrigatorio.")]
        public string Cpf { get; set; }

        [Required(ErrorMessage = "Cidade e obrigatorio.")]
        public string Cidade { get; set; }

        public Login UsuarioAccesso { get; set; }
    }
}
