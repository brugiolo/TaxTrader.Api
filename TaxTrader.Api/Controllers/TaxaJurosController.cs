using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using TaxTrader.Api.ViewModels;
using TaxTrader.Business.Interface;

namespace TaxTrader.Api.Controllers
{
    [ApiController]
    public class TaxaJurosController : ControllerBase
    {
        private readonly ITaxaJurosService _taxaJurosService;
        private readonly IMapper _mapper;

        public TaxaJurosController(ITaxaJurosService taxaJurosService, IMapper mapper) : base()
        {
            _taxaJurosService = taxaJurosService;
            _mapper = mapper;
        }

        [HttpGet("TaxaJuros")]
        public async Task<ActionResult<TaxaJurosViewModel>> TaxaJuros()
        {
            var taxaJuros = await _taxaJurosService.Obter();
            var taxaJurosViewModel = _mapper.Map<TaxaJurosViewModel>(taxaJuros);

            return Ok(taxaJurosViewModel);
        }
    }
}