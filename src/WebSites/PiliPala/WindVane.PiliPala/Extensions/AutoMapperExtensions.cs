using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindVane.PiliPala.Application.AutoMapper;

namespace WindVane.PiliPala.Extensions
{
    public static class AutoMapperExtensions
    {
        public static IServiceCollection AddAutoMapperStartup(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper(typeof(AutoMapperConfig));
            AutoMapperConfig.RegisterMapperConfiguration();

            return services;
        }
    }
}
