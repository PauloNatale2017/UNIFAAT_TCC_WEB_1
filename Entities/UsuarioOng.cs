using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class UsuarioOng : baseEntity
    {
        public string NomeCompleto { get; set; }
        public string Cargo { get; set; }
        public string Email { get; set; }
        public string Perfil { get; set; }
        public string IdOng { get; set; }
    }
}
