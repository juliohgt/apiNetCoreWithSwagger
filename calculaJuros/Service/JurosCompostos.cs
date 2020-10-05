using calculaJuros.Interfaces;
using calculaJuros.Utils;
using System;

namespace calculaJuros.Service
{
    public class JurosCompostos : IJurosCompostos
    {        
     
        public string CalcularJurosCompostos(double valorInicial, int quantidadeDeMeses, double juros)
        {
            try
            {
                var valorFinal = valorInicial * Math.Pow(1 + juros, quantidadeDeMeses);
                return valorFinal.FormataValorDecimal();
            }
            catch (Exception ex)
            {
                return $"Não Foi Possível realizar a Operação. Erro: {ex}";
            }
        }
       
    }
}
