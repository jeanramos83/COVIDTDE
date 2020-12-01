using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Codiv19.API.Models
{
    public class Paciente
    {
        public int id { get; set; }
        public string nome { get; set; }
        public int idade { get; set; }
        public string cidade { get; set; }
        public string estado { get; set; }
        public string uf { get; set; }
        public string sexo { get; set; }
        public string estadoCivil { get; set; }
        public bool flComorbidade { get; set; }
        public DateTime dataRegistro { get; set; }
        public string cpf { get; set; }

    }
}
