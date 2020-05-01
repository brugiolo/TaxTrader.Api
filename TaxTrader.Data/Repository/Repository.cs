using System.Threading.Tasks;
using TaxTrader.Business.Interface;

namespace TaxTrader.Data.Repository
{
    public class Repository<TEntidade> : IRepository<TEntidade>
    {
        public async Task<decimal> Obter()
        {
            return 0.01m;
        }

        public void Dispose()
        {
            // nada a fazer nesse momento...
        }
    }
}
