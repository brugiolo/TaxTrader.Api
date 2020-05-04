using TaxTrader.Business.Validations;

namespace TaxTrader.Business.Models
{
    public partial class TaxaJuros : Entidade
    {
        public decimal Valor { get; set; }

        public override bool IsValid()
        {
            var taxaJurosValidacao = new TaxaJurosValidacao();
            ValidationResult = taxaJurosValidacao.Validate(this);

            return ValidationResult.IsValid;
        }
    }
}
