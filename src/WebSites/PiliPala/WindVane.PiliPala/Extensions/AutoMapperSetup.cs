using AutoMapper;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WindVane.PiliPala.Application.AutoMapper;

namespace WindVane.PiliPala.Extensions
{
    public static class AutoMapperSetup
    {
        public static void AddAutoMapperSetup(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper();

            AutoMapperConfig.GetMapperConfiguration();
        }
    }
}
