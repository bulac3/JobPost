using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobPost.BL.DALInterfaces;
using JobPost.BL.DALInterfaces.Finders;
using JobPost.BL.Services;
using JobPost.DAL.MsSql;
using JobPost.DAL.MsSql.Finders;
using JobPost.DAL.MsSql.Repositories;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;

namespace JobPost.WebApi
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
            services.AddDbContext<JobPostContext>(opt =>
                opt.UseSqlServer(Configuration["ConnectionStrings:Default"], b => b.MigrationsAssembly("JobPost.DAL.MsSql")));

            // dependency injection
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IJobFinder, JobFinder>();
            services.AddScoped<JobService, JobService>();

            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
