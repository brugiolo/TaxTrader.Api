using System;
using System.Threading.Tasks;
using TaxTrader.Business.Models;

namespace TaxTrader.Business.Interface
{
    public interface ITaxaJurosService : IDisposable
    {
        Task<TaxaJuros> Obter();
    }
}
