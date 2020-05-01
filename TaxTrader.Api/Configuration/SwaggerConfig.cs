﻿using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;

namespace TaxTrader.Api.Configuration
{
    public static class SwaggerConfig
    {
        public static IServiceCollection ConfigurarSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1",
                    new OpenApiInfo
                    {
                        Title = "Tax Trader",
                        Version = "v1",
                        Description = "API Asp.Net Core WebAPI criada para obtenção de taxa de juros.",
                        Contact = new OpenApiContact
                        {
                            Name = "Rafael Brugiolo Souza",
                            Url = new Uri("https://www.linkedin.com/in/rafael-brugiolo/")
                        }
                    });
            });

            return services;
        }

        public static IApplicationBuilder UseSwaggerConfig(this IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Tax Trader");
            });

            return app;
        }
    }
}
