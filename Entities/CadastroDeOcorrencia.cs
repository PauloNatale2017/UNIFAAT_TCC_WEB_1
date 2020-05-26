using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class CadastroDeOcorrencia : baseEntity
    {
        public int IdCadastroBasico { get; set; }
        public string TipoViolencia { get; set; }
        public string DiaOcorrido { get; set; }
        public string LocalOcorrido { get; set; }
        public string Testemunha { get; set; }
        public string UsodeDrogasIlicitas { get; set; }
        public string UsodeDrograsLicitas { get; set; }
        public string VinculocomAgressor { get; set; }
        public string BOSIM { get; set; }
        public string BONAO { get; set; }
        public string NumeroBO { get; set; }
    }
}
