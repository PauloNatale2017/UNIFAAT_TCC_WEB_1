using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class Profissional : baseEntity
    {
        public string NomeProfissional { get; set; }
        public string Contato { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }  
        public string RamoAtuacao { get; set; }
        public string DiaAtendimento { get; set; }
        public string HorarioAtendimento { get; set; }
        public string ValorCobrado { get; set; }
        public string Desconto { get; set; }
    }
}
