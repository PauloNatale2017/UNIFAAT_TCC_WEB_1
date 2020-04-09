using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class VinculoSistemaUsuario :baseEntity
    {
        public int IdUsuario { get; set; }

        public int IdPerfil { get; set; }

        public int IdSistema { get; set; }
    }
}
