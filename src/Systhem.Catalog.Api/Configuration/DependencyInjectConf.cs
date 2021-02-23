using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Systhem.Catalog.Api.Data;
using Systhem.Catalog.Api.Data.Repository;
using Systhem.Catalog.Api.Interfaces;

namespace Systhem.Catalog.Api.Configuration
{
    public static class DependencyInjectConf
    {
        public static void RegisterServices(this IServiceCollection services)
        {
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<CatalogContext>();
        }
    }
}
