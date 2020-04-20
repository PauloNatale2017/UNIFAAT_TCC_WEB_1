using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class GeoCadastro : baseEntity
    {
        public string  Endereco { get; set; }
        public string  CEP { get; set; }
        public string  Complemento { get; set; }
        public string  Lat { get; set; }
        public string  Long { get; set; }
        public int  IdUsuario { get; set; }

    }
}
