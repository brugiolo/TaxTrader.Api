using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TaxTrader.Api.ViewModels;
using TaxTrader.Business.Models;

namespace TaxTrader.Api.Configuration
{
    public class AutomapperConfig : Profile
    {
        public AutomapperConfig()
        {
            CreateMap<TaxaJuros, TaxaJurosViewModel>().ReverseMap();
        }
    }
}
