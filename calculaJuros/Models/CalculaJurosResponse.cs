using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculaJuros.Models
{
    public class CalculaJurosResponse
    {
        public string Resultado { get; set; }
        public List<string> Erros { get; set; }
    }
}
