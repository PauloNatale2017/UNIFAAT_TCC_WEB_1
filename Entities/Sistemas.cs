using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ROSESHIELD.WEB.Entities
{
    public class Sistemas : baseEntity
    {
        public string NomeSistema { get; set; }
        public string Options { get; set; }
        public string Url { get; set; }
    }
}
