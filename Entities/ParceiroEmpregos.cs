using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class ParceiroEmpregos : baseEntity
    {
        public int IdEmpresa { get; set; }
        public string NomeVaga { get; set; }
        public string AreaAtuacao { get; set; }
        public string Cargo { get; set; }
        public string Descricao { get; set; }
        public string FaixaSalarial { get; set; }
        public string HorarioTrabalho { get; set; }
    }
}
