using System;
using System.Threading.Tasks;

namespace TaxTrader.Business.Interface
{
    public interface IRepository<TEntidade> : IDisposable
    {
        Task<decimal> Obter();
    }
}
