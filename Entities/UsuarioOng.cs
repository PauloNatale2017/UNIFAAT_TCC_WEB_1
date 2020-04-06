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
        public OngPerfil Perfil { get; set; }
        public int IdOng { get; set; }
    }
}
