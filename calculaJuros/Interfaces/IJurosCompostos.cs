using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calculaJuros.Interfaces
{
    public interface IJurosCompostos
    {
        public string CalcularJurosCompostos(double valorInicial, int quantidadeDeMeses, double juros);
    }
}
