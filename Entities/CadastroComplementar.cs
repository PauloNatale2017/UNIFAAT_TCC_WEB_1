using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class CadastroComplementar: baseEntity
    {
        public int IdCadastroBasico { get; set; }
        public string Profissao { get; set; }
        public string RendaPessoal { get; set; }
        public string RendaFamiliar { get; set; }
        public string drogaslicitasSIM { get; set; }
        public string drogaslicitasNAO { get; set; }
        public string QualdrogaDescri1 { get; set; }
        public string DrogasilicitasSIM { get; set; }
        public string DrogasilicitasNAO { get; set; }
        public string QualdrogaDescri2 { get; set; }
        public string PossuifilhosSIM { get; set; }
        public string PossuiFilhosNAO { get; set; }
        public string Qtdo { get; set; }
        public string IdosoSIM { get; set; }
        public string IdosoNAO { get; set; }
        public string Quantidade { get; set; }
    }
}
