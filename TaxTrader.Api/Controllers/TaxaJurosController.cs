using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaxTrader.Api.ViewModels;
using TaxTrader.Business.Interface;

namespace TaxTrader.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosService _taxaJurosService;

        public TaxaJurosController(ITaxaJurosService taxaJurosService) : base()
        {
            _taxaJurosService = taxaJurosService;
        }

        [HttpGet("taxajuros")]
        public async Task<ActionResult<TaxaJurosViewModel>> TaxaJuros()
        {
            var valorTaxaJuros = await _taxaJurosService.Obter();
            
            var taxaJurosViewModel = new TaxaJurosViewModel
            {
                Valor = valorTaxaJuros
            };

            return Ok(taxaJurosViewModel);
        }
    }
}