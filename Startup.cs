using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.EntityFrameworkCore;
using WikiPedia.Data;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.Extensions.Logging;
using WikiPedia.logs;
using System.IO;
using WikiPedia.signalR;
using WikiPedia.Interfaces;
using WikiPedia.Repositories;
using WikiPedia.Servises;

namespace WikiPedia
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // !!!!!!!!!!!!!!
        public void ConfigureServices(IServiceCollection services)
        {
            string connection = Configuration.GetConnectionString("DefaultConnection");
            //string connection = Configuration["Data:ConnectionString:DefaultConnection"];
            services.AddDbContext<PublicationContext>(options => options.UseSqlServer(connection));
            services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer(connection));
         

            services.AddDatabaseDeveloperPageExceptionFilter();

            services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = false)
                .AddRoles<IdentityRole>()
                .AddEntityFrameworkStores<ApplicationDbContext>();

            services.AddTransient<IGetPublication, PublicationRepository>();
            services.AddScoped<IEmailMessanger, EmailMessanger>();
            services.AddSingleton<IEmailConfiguration>(new EmailConfiguration
            {
                SmtpServer = Configuration["EmailConfiguration:SmtpServer"],
                SmtpPort = int.Parse(Configuration["EmailConfiguration:SmtpPort"]),
                SmtpUsername = Configuration["EmailConfiguration:SmtpUsername"],
                SmtpPassword = Configuration["EmailConfiguration:SmtpPassword"]
            });

            services.AddControllersWithViews();
            services.AddSignalR();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env, ILoggerFactory loggerFactory)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseMigrationsEndPoint();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapHub<ChatHub>("/chat");

                endpoints.MapDefaultControllerRoute();
                endpoints.MapRazorPages();
                
            });
            loggerFactory.AddFile(Path.Combine(Directory.GetCurrentDirectory(), Configuration.GetSection("AllLog").Value),
                Path.Combine(Directory.GetCurrentDirectory(), Configuration.GetSection("ErrorLog").Value));
            var logger = loggerFactory.CreateLogger("FileLogger");
        }
    }
}
