using System.Text.Unicode;
using AspHomework2.FileSystem;
using AspHomework2.Hubs;
using AspHomework2.Persistence;
using AspHomework2.Persistence.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using AutoMapper;
using Mapper = ASPHomework.Mapper.Mapper;

namespace AspHomework2
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
            services.AddControllersWithViews();

            services.AddSignalR();
            
            var connection = Configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<AppDatabaseContext>(
                options =>
                {

                    options.UseSqlServer(connection);
                }
            );
            
            services.AddWebEncoders(o =>
            {
                o.TextEncoderSettings = new System.Text.Encodings.Web.TextEncoderSettings(UnicodeRanges.All);
            });

            services.AddMvc(
                    options =>
                    {
                        options.EnableEndpointRouting = false;
                    }
                )
                .AddDataAnnotationsLocalization()
                .AddViewLocalization()
                .SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services.AddTransient<IBranchRepository, BranchRepository>();
            services.AddTransient<IJobApplicationRepository, JobApplicationRepository>();
            services.AddTransient<FileWriter>();

            services.AddAutoMapper(typeof(Mapper));

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
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

            app.UseRouting();

            app.UseAuthorization();
            
            app.UseCors(builder =>
                {
                    builder.WithOrigins("https://localhost:3000");
                    builder.AllowAnyHeader();
                }
            );
            
            app.UseSignalR(routes =>
            {
                routes.MapHub<JobApplicationHub>("/applicationHub");
            });
            
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}");
            });
        }
    }
}