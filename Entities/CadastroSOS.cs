using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class CadastroSOS : baseEntity
    {
        public int IdCadastroBasico { get; set; }
        public string NomeSOS { get; set; }
        public string NumeroCelular { get; set; }
        public string Vinculo { get; set; }
    }
}
