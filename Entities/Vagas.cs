using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class Vagas : baseEntity
    {
        public string NomeVaga { get; set; }
        public string ValorSalario { get; set; }
        public string Descricao { get; set; }
        public string InformacoeAdicionais { get; set; }               
        public string AvisosDaEmpresa { get; set; }
        public string Restricoes { get; set; }
        public int IdEmpresa { get; set; }      

    }
}
