using System.Threading.Tasks;
using TaxTrader.Business.Interface;

namespace TaxTrader.Business.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        private readonly ITaxaJurosRepository _taxaJurosRepositorio;
        
        public TaxaJurosService(ITaxaJurosRepository taxaJurosRepositorio)
        {
            _taxaJurosRepositorio = taxaJurosRepositorio;
        }

        public async Task<decimal> Obter()
        {
            var valorTaxaJuros = await _taxaJurosRepositorio.Obter();

            return valorTaxaJuros;
        }
    }
}
