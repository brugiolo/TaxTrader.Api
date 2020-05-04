using FluentValidation.Results;
using System.ComponentModel.DataAnnotations.Schema;

namespace TaxTrader.Business.Models
{
    public abstract class Entidade
    {
        [NotMapped]
        public ValidationResult ValidationResult { get; protected set; }

        public abstract bool IsValid();
    }
}
