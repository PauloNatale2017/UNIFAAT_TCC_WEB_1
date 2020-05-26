using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class CadastroIdoso : baseEntity
    {
        public int IdCadastroBasico { get; set; }
        public string Nomoidoso { get; set; }
        public string DataNascimento { get; set; }
        public string NecessidadesEspeciaisSIM { get; set; }
        public string NecessidadesEspeciaisNAO { get; set; }
        public string Qual { get; set; }
    }
}
