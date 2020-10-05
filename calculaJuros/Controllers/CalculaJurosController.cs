using calculaJuros.Models;
using calculaJuros.Service;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace calculaJuros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculaJurosController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly JurosCompostos _jurosCompostos;
        private readonly IntegracaoTaxaJuros _integracaoTaxaJuros;

        public CalculaJurosController(IConfiguration configuration, JurosCompostos jurosCompostos, IntegracaoTaxaJuros integracaoTaxaJuros)
        {
            _configuration = configuration;
            _jurosCompostos = jurosCompostos;
            _integracaoTaxaJuros = integracaoTaxaJuros;
        }

        [HttpGet]
        public CalculaJurosResponse Get([FromQuery] CalculaJurosModel body)
        {
            var taxaDeJuros = _integracaoTaxaJuros.BuscarTaxaJuros(_configuration["urlApiTaxaJuros"]);

            return new CalculaJurosResponse
            {
                Resultado = _jurosCompostos.CalcularJurosCompostos(body.ValorInicial, body.QuantidadeDeMeses, taxaDeJuros)
            };
        }
    }
}
