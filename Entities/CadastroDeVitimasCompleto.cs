using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class CadastroDeVitimasCompleto : baseEntity
    {
        public int IdCadastroBasico { get; set; }
        public int IdCadastroDeOcorrencia { get; set; }
        public int IdCadastroComplementar { get; set; }
        public int IdCadastroFilhos { get; set; }
        public int IdCadastroIdosos { get; set; }
        public int IdCadastroSOS { get; set; }
        public string Rg_CPF { get; set; }
    }
}
