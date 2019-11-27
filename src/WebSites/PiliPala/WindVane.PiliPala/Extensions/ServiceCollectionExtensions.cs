using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using WindVane.PiliPala.Application.Interfaces;
using WindVane.PiliPala.Application.Services;
using WindVane.PiliPala.Domain.Interfaces.Repositories;
using WindVane.PiliPala.Infrastructure;
using WindVane.PiliPala.Infrastructure.Repositories;
using WindVane.PiliPala.Infrastructure.Themes;

namespace WindVane.PiliPala.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPiliPala(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddDbContext(configuration);

            services.AddAuthenticationStartup();

            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<IMenuRepository, MenuRepository>();

            services.AddAutoMapperStartup();

            services.AddThemes();

            return services;
        }

        public static IServiceCollection AddDbContext(this IServiceCollection services, IConfiguration configuration)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddDbContext<PiliPalaDbContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            return services;
        }

        public static IServiceCollection AddThemes(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddSingleton<IThemeContext, ThemeContext>();

            services.Configure<RazorViewEngineOptions>(options =>
            {
                options.ViewLocationExpanders.Add(new ThemeableViewLocationExpander());
            });

            return services;
        }
    }
}
