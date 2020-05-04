using FluentValidation;
using TaxTrader.Business.Models;

namespace TaxTrader.Business.Validations
{
    public class TaxaJurosValidacao : AbstractValidator<TaxaJuros>
    {
        public TaxaJurosValidacao()
        {
            RuleFor(u => u.Valor).GreaterThanOrEqualTo(0);
        }
    }
}
