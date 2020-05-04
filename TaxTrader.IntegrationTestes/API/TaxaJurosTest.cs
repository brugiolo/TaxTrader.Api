using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.TestHost;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using TaxTrader.Api;
using Xunit;

namespace TaxTrader.IntegrationTestes.API
{
    public class TaxaJurosTest
    {
        private readonly HttpClient _httpClient;

        public TaxaJurosTest()
        {
            var server = new TestServer(new WebHostBuilder()
                .UseEnvironment("Development")
                .UseStartup<Startup>());
            _httpClient = server.CreateClient();
        }

        [Theory]
        [InlineData("GET")]
        public async Task ObterTaxaJuros(string httpMethod)
        {
            var requisicao = new HttpRequestMessage(new HttpMethod(httpMethod), "/TaxaJuros");
            var resposta = await _httpClient.SendAsync(requisicao);

            resposta.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, resposta.StatusCode);
        }
    }
}
