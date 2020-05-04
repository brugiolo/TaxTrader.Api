using FluentAssertions;
using Xunit;

namespace TaxTrader.Tests.TaxaJuros
{
    [Collection(nameof(TaxaJurosCollection))]
    public class TaxaJurosTests
    {
        public TaxaJurosTestsFixture Fixture { get; set; }

        public TaxaJurosTests(TaxaJurosTestsFixture fixture)
        {
            Fixture = fixture;
        }

        [Fact(DisplayName = "Obter Taxa Válida")]
        [Trait("Categoria", "Testes de Taxas de Juros")]
        public void TaxaJuros_Obter_TaxaValida()
        {
            var taxaJuros = Fixture.ObterTaxaJurosValida();
            var resultado = taxaJuros.IsValid();

            resultado.Should().BeTrue();
            taxaJuros.ValidationResult.Errors.Should().HaveCount(0);

            Assert.True(resultado);
            Assert.Equal(0, taxaJuros.ValidationResult.Errors.Count);
        }

        [Fact(DisplayName = "Obter Taxa Inválida")]
        [Trait("Categoria", "Testes de Taxas de Juros")]
        public void TaxaJuros_Obter_TaxaInvalida()
        {
            var taxaJuros = Fixture.ObterTaxaJurosInvalida();
            var resultado = taxaJuros.IsValid();

            resultado.Should().BeFalse();
            taxaJuros.ValidationResult.Errors.Should().HaveCount(c => c > 0);

            Assert.False(resultado);
            Assert.NotEqual(0, taxaJuros.ValidationResult.Errors.Count);
        }
    }
}
