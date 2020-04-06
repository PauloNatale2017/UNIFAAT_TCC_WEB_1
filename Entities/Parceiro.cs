using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class Parceiro : baseEntity
    {
        public string NOMEEMPRESA { get; set; }
        public string CNPJ_CPF { get; set; }
        public string CONTATO { get; set; }
        public string ENDERECO { get; set; }
        public string EMAIL { get; set; }
        public string TOTAL_VAGAS_CADASTRADAS { get; set; }        
        public int IdVaga { get; set; }


    }
}
