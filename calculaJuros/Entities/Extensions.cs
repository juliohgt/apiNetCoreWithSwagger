using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace calculaJuros.Entities
{
    public static class Extensions
    {
        public static string FormataValorDecimal(this double valor)
        {
            return valor.ToString("0.00", CultureInfo.InvariantCulture);
        }
    }
}
