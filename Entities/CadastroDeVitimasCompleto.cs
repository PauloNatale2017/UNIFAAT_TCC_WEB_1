using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class CadastroDeVitimasCompleto : baseEntity
    {
        public VitimaBasic CadastroBasico { get; set; }
        public CadastroDeOcorrencia CadastroDeOcorrencia { get; set; }
        public CadastroComplementar CadastroComplementar { get; set; }
        public List<CadastroFilho> CadastroFilhos { get; set; }
        public List<CadastroIdoso> CadastroIdosos { get; set; }
        public List<CadastroSOS> CadastroSOS { get; set; }
    }
}
