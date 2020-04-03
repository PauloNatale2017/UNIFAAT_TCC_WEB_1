using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class Login : baseEntity
    {
        [Required(ErrorMessage ="Usuario e obrigatorio.")]
        public string EmailUser { get; set; }
        [Required(ErrorMessage ="Senha obrigatoria.")]
        public string Password { get; set; }
    }
}
