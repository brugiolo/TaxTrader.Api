using Moq;
using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace TaxTrader.Tests.TaxaJuros
{
    [Collection(nameof(TaxaJurosCollection))]
    public class TaxaJurosServiceTests
    {
        public TaxaJurosTestsFixture Fixture { get; set; }

        public TaxaJurosServiceTests(TaxaJurosTestsFixture fixture)
        {
            Fixture = fixture;
        }

        //[Fact(DisplayName = "Obter Taxa Juros Valida")]
        //[Trait("Categoria", "Testes de Servico de Taxas de Juros")]
        //public async Task TaxaJurosService_ObterTaxaJurosValida()
        //{
        //    var taxaJurosService = Fixture.ObterTaxaJurosService();
        //    await taxaJurosService.Obter();

        //    Fixture.TaxaJurosRepositorioMock.Verify(u => u.Obter(), Times.Once);
        //    Fixture.MediatorMock.Verify(m => m.Publish(It.IsAny<string>(), CancellationToken.None), Times.Once);
        //}
    }
}
