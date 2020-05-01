using System.Threading.Tasks;

namespace TaxTrader.Business.Interface
{
    public interface ITaxaJurosService
    {
        Task<decimal> Obter();
    }
}
