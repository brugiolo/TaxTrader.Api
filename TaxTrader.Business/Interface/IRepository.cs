using System;
using System.Threading.Tasks;
using TaxTrader.Business.Models;

namespace TaxTrader.Business.Interface
{
    public interface IRepository<TEntidade> : IDisposable
    {
        Task<TaxaJuros> Obter();
    }
}
