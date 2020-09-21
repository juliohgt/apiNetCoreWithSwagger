using calculaJuros.Entities;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using RestSharp;
using System;

namespace calculaJuros.Service
{
    public class JurosCompostos
    {
        private readonly IConfiguration _configuration;

        public JurosCompostos(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public JurosCompostos()
        {
        }

        public string CalculaValorFinalJurosCompostos(double valorInicial, int quantidadeDeMeses, double juros)
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

        public double BuscaTaxaJuros()
        {
            try
            {
                var url = _configuration["urlApiTaxaJuros"];

                var client = new RestClient(url);
                client.Timeout = -1;
                var request = new RestRequest(Method.GET);
                IRestResponse response = client.Execute(request);

                dynamic content = JsonConvert.DeserializeObject(response.Content);

                return content["valorDoJuros"];
            }
            catch (Exception ex)
            {
                throw new Exception($"Não Foi Possível realizar a Operação. Erro: {ex}");
            }
        }
    }
}
