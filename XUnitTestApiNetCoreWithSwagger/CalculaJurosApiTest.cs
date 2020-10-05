using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net.Http;
using calculaJuros;
using FluentAssertions;
using System.Net;
using System.Threading.Tasks;
using Xunit;

namespace XUnitTestApiNetCoreWithSwagger
{
    public class CalculaJurosApiTest
    {
        public HttpClient Client { get; set; }
        public HttpClient Client2 { get; set; }        
        private TestServer _server;
        private TestServer _server2;
        public CalculaJurosApiTest()
        {
            SetupClient();
        }
        private void SetupClient()
        {
            _server = new TestServer(new WebHostBuilder().UseStartup<Startup>());            
            Client = _server.CreateClient();            
        }       

        [Fact]
        public async Task CalculaJuros_Get_ReturnsOkResponse()
        {
            var response = await Client.GetAsync("/CalculaJuros?ValorInicial=100&QuantidadeDeMeses=5");
            response.EnsureSuccessStatusCode();
            response.StatusCode.Should().Be(HttpStatusCode.OK);
        }       

        [Fact]
        public async Task CalculaJuros_Get_ReturnsBadRequestResponse()
        {
            var response = await Client.GetAsync("/CalculaJuros?ValorInicial=100&QuantidadeDeMeses=z");
            response.StatusCode.Should().Be(HttpStatusCode.BadRequest);
        }        
    }
}
