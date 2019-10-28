using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindVane.PiliPala.Application.AutoMapper;
using WindVane.PiliPala.Application.Interfaces;
using WindVane.PiliPala.Application.Services;
using WindVane.PiliPala.Domain.Interfaces.Repositories;
using WindVane.PiliPala.Infrastructure.Repositories;

namespace WindVane.PiliPala.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPiliPala(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<IMenuRepository, MenuRepository>();

            services.AddAutoMapperCore();

            return services;
        }

        public static IServiceCollection AddAutoMapperCore(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper();

            return services;
        }
    }
}
