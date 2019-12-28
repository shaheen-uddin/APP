using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Pomelo.EntityFrameworkCore.MySql.Infrastructure;
using Microsoft.AspNetCore.HttpOverrides;
using Microsoft.AspNetCore.Identity;
using AppProject.Models;
using System.Net;
using AppProject.Services;


namespace AppProject
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
          /*   services.Configure<CookiePolicyOptions>(options =>
            {
                // This lambda determines whether user consent for non-essential cookies is needed for a given request.
                options.CheckConsentNeeded = context => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            }); */
             services.Configure<ForwardedHeadersOptions>(options =>
                {
                    options.KnownProxies.Add(IPAddress.Parse("192.168.0.8"));
             });
            services.AddDbContextPool<ApplicationContext>(options => options.UseMySql(Configuration.GetConnectionString("SContext"),
            mySqlOptions => mySqlOptions.ServerVersion(new Version(5,7,25),ServerType.MySql)));

            services.AddDbContextPool<AdminUserContext>(options => options.UseMySql(Configuration.GetConnectionString("AContext"),
            mySqlOptions => mySqlOptions.ServerVersion(new Version(5,7,25),ServerType.MySql)));

         //   services.AddPaging();


            services.AddTransient<ImageProcess>();


            services.AddAntiforgery(o => o.HeaderName = "XSRF-TOKEN");
            services.AddIdentity<IdentityUser, IdentityRole>().AddEntityFrameworkStores<AdminUserContext>().AddDefaultTokenProviders();
            services.ConfigureApplicationCookie(options =>
                {
                    //cookie setting
                      options.Cookie.HttpOnly = true;
                      options.ExpireTimeSpan = TimeSpan.FromMinutes(5);

                      options.LoginPath = $"/Admin/Login";
                      options.LogoutPath = $"/Admin/Logout";
                      options.AccessDeniedPath = $"/Admin/AccessDenied";
                      options.SlidingExpiration = true;


                }
            );

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            app.UseForwardedHeaders(new ForwardedHeadersOptions
            {
                ForwardedHeaders = ForwardedHeaders.XForwardedFor | ForwardedHeaders.XForwardedProto
            });

            
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseCookiePolicy();
            app.UseAuthentication();

            app.UseMvc(routes =>
            {
                routes.MapRoute(
                    name: "default",
                    template: "{controller=Trainee}/{action=Create}/{id?}");
            });
        }
    }
}
