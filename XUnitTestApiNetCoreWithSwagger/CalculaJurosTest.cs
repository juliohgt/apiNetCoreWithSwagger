using calculaJuros.Interfaces;
using calculaJuros.Service;
using Microsoft.Extensions.Configuration;
using Moq;
using Xunit;

namespace XUnitTestApiNetCoreWithSwagger
{
    public class CalculaJurosTest
    {
        JurosCompostos _jurosCompostos;
        IConfiguration _configuration;

        public CalculaJurosTest()
        {
            _jurosCompostos = new JurosCompostos();
        }

        [Theory(DisplayName = "Cálculo de Juros Compostos")]
        [InlineData(100, 5, 0.01, "105.10")]
        public void Deve_Retornar_Valor_Calculado_Do_Juros_Composto(double valorInicial, int quantidadeMeses, double taxaJuros, string valorEsperado)
        {
            var result = _jurosCompostos.CalcularJurosCompostos(valorInicial, quantidadeMeses, taxaJuros);

            Assert.Equal(result, valorEsperado);
        }

        [Fact]
        public void Deve_Retornar_Valor_Calculado_Do_Juros_Composto_Moq()
        {
            var juros = new Mock<IJurosCompostos>();
            int valorInicial = 100;
            int qtdMeses = 5;
            double taxa = 0.01;

            juros.Object.CalcularJurosCompostos(valorInicial, qtdMeses, taxa);
            juros.Verify(r => r.CalcularJurosCompostos(valorInicial, qtdMeses, taxa), Times.Once());
        }
    }
}
