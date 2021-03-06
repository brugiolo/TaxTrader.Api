﻿using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using TaxTrader.Business.Interface;
using TaxTrader.Business.Services;
using TaxTrader.Data.Repository;

namespace TaxTrader.Api.Configuration
{
    public static class InjecaoDependenciaConfig
    {
        public static IServiceCollection ResolverDependencias(this IServiceCollection services)
        {
            services.AddScoped<ITaxaJurosRepository, TaxaJurosRepository>();

            services.AddScoped<ITaxaJurosService, TaxaJurosService>();

            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddMediatR(Assembly.GetExecutingAssembly());

            services.AddSwaggerGen();

            return services;
        }
    }
}
