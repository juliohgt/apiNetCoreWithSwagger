using System.Globalization;

namespace calculaJuros.Utils
{
    public static class Extensions
    {
        public static string FormataValorDecimal(this double valor)
        {
            return valor.ToString("0.00", CultureInfo.InvariantCulture);
        }
    }
}
