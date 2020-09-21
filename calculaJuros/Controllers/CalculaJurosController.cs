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

        public CalculaJurosController(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        [HttpGet]
        public string Get([FromQuery] CalculaJurosModel body)
        {          
            var serviceCalculaJuros = new JurosCompostos(_configuration);
            var taxaJuros = serviceCalculaJuros.BuscaTaxaJuros();

            return serviceCalculaJuros.CalculaValorFinalJurosCompostos(body.ValorInicial, body.QuantidadeDeMeses, taxaJuros);           
        }
    }
}
