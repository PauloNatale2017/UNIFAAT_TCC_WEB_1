using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class Perfil : baseEntity
    {
        public string NomePerfil { get; set; }
        public int IdSistema { get; set; }
        public string AccessPerfil { get; set; }
        public string ActionsPerfil { get; set; }

    }
}
