using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class VinculoSistemaUsuario :baseEntity
    {
        public string IdUsuario { get; set; }
               
        public string IdPerfil { get; set; }
               
        public string IdSistema { get; set; }
    }
}
