using AutoMoq;
using MediatR;
using Moq;
using System;
using TaxTrader.Business.Interface;
using TaxTrader.Business.Services;
using Xunit;

namespace TaxTrader.Tests.TaxaJuros
{
    [CollectionDefinition(nameof(TaxaJurosCollection))]
    public class TaxaJurosCollection : ICollectionFixture<TaxaJurosTestsFixture>
    {
    }

    public class TaxaJurosTestsFixture : IDisposable
    {
        public Mock<ITaxaJurosRepository> TaxaJurosRepositorioMock { get; set; }
        public Mock<ITaxaJurosService> TaxaJurosServiceMock { get; set; }
        public Mock<IMediator> MediatorMock { get; set; }

        public TaxaJurosService ObterTaxaJurosService()
        {
            var autoMoqer = new AutoMoqer();
            autoMoqer.Create<TaxaJurosService>();

            var taxaJurosService = autoMoqer.Resolve<TaxaJurosService>();

            TaxaJurosRepositorioMock = autoMoqer.GetMock<ITaxaJurosRepository>();
            TaxaJurosServiceMock = autoMoqer.GetMock<ITaxaJurosService>();
            MediatorMock = autoMoqer.GetMock<IMediator>();

            return taxaJurosService;
        }
        
        public TaxTrader.Business.Models.TaxaJuros ObterTaxaJurosValida()
        {
            var taxaJuros = new TaxTrader.Business.Models.TaxaJuros
            {
                Valor = 1m
            };

            return taxaJuros;
        }

        public TaxTrader.Business.Models.TaxaJuros ObterTaxaJurosInvalida()
        {
            var taxaJuros = new TaxTrader.Business.Models.TaxaJuros
            {
                Valor = -1m
            };

            return taxaJuros;
        }

        public void Dispose()
        {
            // nada a fazer nesse momento...
        }
    }
}