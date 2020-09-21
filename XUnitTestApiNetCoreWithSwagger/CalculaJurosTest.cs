using calculaJuros.Service;
using calculaJuros.Models;
using Microsoft.Extensions.Configuration;
using Xunit;
using System.IO;

namespace XUnitTestApiNetCoreWithSwagger
{
    public class CalculaJurosTest
    {
        JurosCompostos _jurosCompostos;
        IConfiguration _configuration;

        public CalculaJurosTest()
        {
            _configuration = new ConfigurationBuilder()
           .SetBasePath(Directory.GetCurrentDirectory())
           .AddJsonFile("appsettings.json")
           .Build();

            _jurosCompostos = new JurosCompostos(_configuration);
        }

        [Theory(DisplayName = "Cálculo de Juros Compostos")]
        [InlineData(100, 5, 0.01, "105.10")]
        public void Deve_Retornar_Valor_Calculado_Do_Juros_Composto(double valorInicial, int quantidadeMeses, double taxaJuros, string valorEsperado)
        {
            var result = _jurosCompostos.CalculaValorFinalJurosCompostos(valorInicial, quantidadeMeses, taxaJuros);

            Assert.Equal(result, valorEsperado);
        }       
    }
}
