using System.Threading.Tasks;
using TaxTrader.Business.Interface;
using TaxTrader.Business.Models;

namespace TaxTrader.Data.Repository
{
    public class Repository<TEntidade> : IRepository<TEntidade>
    {
        public async Task<TaxaJuros> Obter()
        {
            return new TaxaJuros { Valor = 0.01m };
        }

        public void Dispose()
        {
            // nada a fazer nesse momento...
        }
    }
}
