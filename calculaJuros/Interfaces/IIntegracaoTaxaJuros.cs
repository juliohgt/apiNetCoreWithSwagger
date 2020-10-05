using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculaJuros.Interfaces
{
    public interface IIntegracaoTaxaJuros
    {
        public double BuscarTaxaJuros(string url);
    }
}
