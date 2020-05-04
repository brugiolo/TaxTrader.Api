using MediatR;
using System.Threading.Tasks;
using TaxTrader.Business.Events;
using TaxTrader.Business.Interface;
using TaxTrader.Business.Models;

namespace TaxTrader.Business.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        private readonly ITaxaJurosRepository _taxaJurosRepositorio;
        private readonly IMediator _mediator;

        public TaxaJurosService(ITaxaJurosRepository taxaJurosRepositorio, IMediator mediator)
        {
            _taxaJurosRepositorio = taxaJurosRepositorio;
            _mediator = mediator;
        }

        public async Task<TaxaJuros> Obter()
        {
            var taxaJuros = await _taxaJurosRepositorio.Obter();

            if (taxaJuros.IsValid())
                await _mediator.Publish(new NotificacaoTeste("TaxaJurosService - Taxa de juros obtida com sucesso."));

            return taxaJuros;
        }

        public void Dispose()
        {
            _taxaJurosRepositorio?.Dispose();
        }
    }
}
