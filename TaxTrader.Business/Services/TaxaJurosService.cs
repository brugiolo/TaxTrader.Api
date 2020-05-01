using System.Threading.Tasks;
using TaxTrader.Business.Interface;
using TaxTrader.Business.Models;

namespace TaxTrader.Business.Services
{
    public class TaxaJurosService : ITaxaJurosService
    {
        private readonly ITaxaJurosRepository _taxaJurosRepositorio;
        
        public TaxaJurosService(ITaxaJurosRepository taxaJurosRepositorio)
        {
            _taxaJurosRepositorio = taxaJurosRepositorio;
        }

        public async Task<TaxaJuros> Obter()
        {
            var taxaJuros = await _taxaJurosRepositorio.Obter();

            return taxaJuros;
        }
    }
}
