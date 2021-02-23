using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Systhem.Catalog.Api.Configuration
{
    public static class SwaggerConfig
    {

        public static IServiceCollection AddSwaggerConfiguration(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Projeto de Api de Catalogo de Produtos com Asp.net Core",
                    Version = "v1",
                    Description = "Esta API faz parte de um projeto de Estudos em aplicações Distribuidas.",
                    Contact = new OpenApiContact() { Name = "Jucileudo Lima", Email = "" },
                    License = new OpenApiLicense() { Name = "MIT", Url = new Uri("https://opensource.org/licenses/MIT") }
                });
            });
            return services;
        }

        public static IApplicationBuilder UseSwaggerConfiguration(this IApplicationBuilder app)
        {
            app.UseSwagger();
            app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "Systhem.Auth.Api v1"));

            return app;
        }
    }
}
