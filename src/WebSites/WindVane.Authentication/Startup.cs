using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using WindVane.Data;
using WindVane.Data.Models;

namespace WindVane.Authentication
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            var builder = services.AddIdentityServer()
                .AddInMemoryIdentityResources(Config.GetIdentityResources())
                .AddInMemoryApiResources(Config.GetApis())
                .AddInMemoryClients(Config.GetClients())
                .AddTestUsers(Config.GetUsers())
                .AddDeveloperSigningCredential();

            services.AddAuthentication()
                .AddCookie()
                .AddOpenIdConnect("oidc", "OpenID Connect", options =>
                {
                    options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                    options.SignOutScheme = IdentityServerConstants.SignoutScheme;
                    options.SaveTokens = true;

                    options.Authority = "https://demo.identityserver.io/";
                    options.ClientId = "implicit";

                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        NameClaimType = "name",
                        RoleClaimType = "role"
                    };
                })
                .AddJwtBearer("Jwt", options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuer = true,
                        ValidateAudience = false,
                        ValidateLifetime = true,
                        ValidateIssuerSigningKey = true,
                        ValidIssuer = "",
                        IssuerSigningKey = new SymmetricSecurityKey(new byte[10])
                    };
                })
                .AddGoogle("Google", options =>
                {
                    options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

                    options.ClientId = Configuration.GetSection("Authentication:GitHub:ClientId").Value;
                    options.ClientSecret = Configuration.GetSection("Authentication:GitHub:ClientSecret").Value;
                })
                .AddFacebook("Facebook", options =>
                {
                    options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

                    options.ClientId = Configuration.GetSection("Authentication:GitHub:ClientId").Value;
                    options.ClientSecret = Configuration.GetSection("Authentication:GitHub:ClientSecret").Value;
                })
                .AddMicrosoftAccount("MicrosoftAccount", options =>
                {
                    options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

                    options.ClientId = Configuration.GetSection("Authentication:GitHub:ClientId").Value;
                    options.ClientSecret = Configuration.GetSection("Authentication:GitHub:ClientSecret").Value;
                })
                .AddGitHub("GitHub", options =>
                {
                    options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

                    options.ClientId = Configuration.GetSection("Authentication:GitHub:ClientId").Value;
                    options.ClientSecret = Configuration.GetSection("Authentication:GitHub:ClientSecret").Value;
                })/*
                .AddTwitter("Twitter", options =>
                {
                    options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

                    options.ConsumerKey = Configuration.GetSection("Authentication:Twitter:ConsumerKey").Value;
                    options.ConsumerSecret = Configuration.GetSection("Authentication:Twitter:ConsumerSecret").Value;
                })
                .AddDiscord("Discord", options =>
                {
                    options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

                    options.ClientId = Configuration.GetSection("Authentication:Discord:ClientId").Value;
                    options.ClientSecret = Configuration.GetSection("Authentication:Discord:ClientSecret").Value;
                })
                .AddQQ("QQ", options =>
                {
                    options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

                    options.ClientId = Configuration.GetSection("Authentication:QQ:ClientId").Value;
                    options.ClientSecret = Configuration.GetSection("Authentication:QQ:ClientSecret").Value;
                })
                .AddWeixin("Weixin", options =>
                {
                    options.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

                    options.ClientId = Configuration.GetSection("Authentication:Weixin:ClientId").Value;
                    options.ClientSecret = Configuration.GetSection("Authentication:Weixin:ClientSecret").Value;
                })*/;
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();

            app.UseRouting();

            app.UseIdentityServer();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapDefaultControllerRoute();
            });
        }
    }
}
