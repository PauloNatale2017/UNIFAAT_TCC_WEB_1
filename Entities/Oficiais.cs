using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class Oficiais : baseEntity
    {
        public string Nome { get; set; }
        public string Contato { get; set; }
        public string Endereco { get; set; }
        public string Email { get; set; }
        public bool Notificacao { get; set; }
        public string Horario { get; set; }
        public string NumeroBO { get; set; }
        public bool BOfeito { get; set; }
        public string NomeDepartamento { get; set; }
        public string AbrangenciaDeAtuacao { get; set; }
        public string PontoFocalDeContato { get; set; }
    }
}
