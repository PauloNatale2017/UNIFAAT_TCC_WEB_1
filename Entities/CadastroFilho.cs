using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class CadastroFilho : baseEntity
    {
        public int IdCadastroBasico { get; set; }
        public string Nomefilho { get; set; }
        public string Escolaondeestuda { get; set; }
        public string DataNascimento { get; set; }
        public string Enderecoescola { get; set; }
        public string NecessidadesespeciaisSIM { get; set; }
        public string NecessidadesespeciaisNAO { get; set; }
        public string Qualnecessidade { get; set; }
    }
}
