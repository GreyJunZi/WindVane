using AutoMapper;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityModel;
using WindVane.PiliPala.Application.AutoMapper;
using WindVane.PiliPala.Application.Interfaces;
using WindVane.PiliPala.Application.Services;
using WindVane.PiliPala.Domain.Interfaces.Repositories;
using WindVane.PiliPala.Infrastructure.Repositories;
using WindVane.PiliPala.Infrastructure.Themes;
using System.IdentityModel.Tokens.Jwt;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication.OpenIdConnect;
using Microsoft.AspNetCore.Authentication;

namespace WindVane.PiliPala.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddPiliPala(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddAuthenticationCore();

            services.AddScoped<IMenuService, MenuService>();
            services.AddScoped<IMenuRepository, MenuRepository>();

            services.AddAutoMapperCore();

            services.AddThemes();

            return services;
        }

        public static IServiceCollection AddAuthenticationCore(this IServiceCollection services)
        {
            JwtSecurityTokenHandler.DefaultInboundClaimTypeMap.Clear();

            services.AddAuthentication(options =>
            {
                options.DefaultScheme = CookieAuthenticationDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = OpenIdConnectDefaults.AuthenticationScheme;
            })
                .AddCookie(CookieAuthenticationDefaults.AuthenticationScheme)
                .AddOpenIdConnect(OpenIdConnectDefaults.AuthenticationScheme, options =>
                {
                    options.SignInScheme = CookieAuthenticationDefaults.AuthenticationScheme;

                    options.Authority = "https://localhost:44366";
                    options.RequireHttpsMetadata = true;

                    options.ClientId = "PiliPala";
                    options.ClientSecret = "secret";
                    options.ResponseType = "code id_token";

                    options.SaveTokens = true;
                    options.GetClaimsFromUserInfoEndpoint = true;

                    options.Scope.Add("api1");
                    options.Scope.Add("offline_access");

                    options.ClaimActions.MapJsonKey("website", "website");
                });
            return services;
        }

        public static IServiceCollection AddAutoMapperCore(this IServiceCollection services)
        {
            if (services == null)
                throw new ArgumentNullException(nameof(services));

            services.AddAutoMapper();

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
