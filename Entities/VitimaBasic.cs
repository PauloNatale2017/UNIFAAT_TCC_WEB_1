using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class VitimaBasic : baseEntity
    {
        [Required]
        public string NomeCompleto { get; set; }
        [Required]
        public string Rg_CPF { get; set; }
        public string Endereco { get; set; }
        public string Contato { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string RedeSocial { get; set; }
        public string ContatoRecado { get; set; }
        public bool Ativo { get; set; }
    }
}
