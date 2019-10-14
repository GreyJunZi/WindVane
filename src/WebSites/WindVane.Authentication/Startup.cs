using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using IdentityServer4;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;

namespace WindVane.Authentication
{
    public class Startup
    {
        public IConfiguration Configuration { get; }

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.AddAuthorization();

            services.AddAuthentication()
                .AddGoogle("Google", option =>
                {
                    option.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

                    option.ClientId = Configuration.GetSection("Authentication:Google:ClientId").Value;
                    option.ClientSecret = Configuration.GetSection("Authentication:Google:ClientSecret").Value;
                })
                .AddFacebook("Facebook", option =>
                {
                    option.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

                    option.ClientId = Configuration.GetSection("Authentication:Facebook:ClientId").Value;
                    option.ClientSecret = Configuration.GetSection("Authentication:Facebook:ClientSecret").Value;
                })
                .AddMicrosoftAccount("MicrosoftAccount", "Microsoft Account", option =>
                {
                    option.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

                    option.ClientId = Configuration.GetSection("Authentication:MicrosoftAccount:ClientId").Value;
                    option.ClientSecret = Configuration.GetSection("Authentication:MicrosoftAccount:ClientSecret").Value;
                })
                .AddGitHub("GitHub", option =>
                {
                    option.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

                    option.ClientId = "642fc13634ef85b4d521";
                    option.ClientSecret = "d47a1527e784877444846e5da99bbf3c44eae1d5";

                    option.Scope.Add("user:email");
                })
                .AddDiscord("Discord", option =>
                {
                    option.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

                    option.ClientId = Configuration.GetSection("Authentication:Discord:ClientId").Value;
                    option.ClientSecret = Configuration.GetSection("Authentication:Discord:ClientSecret").Value;
                })
                .AddTwitter("Twitter", option =>
                {
                    option.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

                    option.ConsumerKey = Configuration.GetSection("Authentication:Twitter:ConsumerKey").Value;
                    option.ConsumerSecret = Configuration.GetSection("Authentication:Twitter:ConsumerSecret").Value;
                })
                .AddQQ("QQ", option =>
                {
                    option.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

                    option.ClientId = Configuration.GetSection("Authentication:QQ:ClientId").Value;
                    option.ClientSecret = Configuration.GetSection("Authentication:QQ:ClientSecret").Value;
                })
                .AddWeixin("Weixin", option =>
                {
                    option.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;

                    option.ClientId = Configuration.GetSection("Authentication:Weixin:ClientId").Value;
                    option.ClientSecret = Configuration.GetSection("Authentication:Weixin:ClientSecret").Value;
                })
                .AddCookie("Cookie", option =>
                {
                    option.LoginPath = "/Login";
                    option.LogoutPath = "/Logout";
                })
                .AddOpenIdConnect("oidc", "OpenID Connect", option =>
                 {
                     option.SignInScheme = IdentityServerConstants.ExternalCookieAuthenticationScheme;
                     option.SignOutScheme = IdentityServerConstants.SignoutScheme;
                     option.SaveTokens = true;

                     option.Authority = "https://demo.identityserver.io";
                     option.ClientId = "implict";

                     option.TokenValidationParameters = new TokenValidationParameters
                     {
                         NameClaimType = "name",
                         RoleClaimType = "role"
                     };
                 });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }


            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            });
        }
    }
}
