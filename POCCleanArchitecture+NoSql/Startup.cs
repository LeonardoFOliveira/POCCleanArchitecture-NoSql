using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using POCCleanArchitecture_NoSql.ApplicationCore.Interfaces;
using POCCleanArchitecture_NoSql.ApplicationCore.Interfaces.Services;
using POCCleanArchitecture_NoSql.ApplicationCore.Services;
using POCCleanArchitecture_NoSql.Infrastructure;
using POCCleanArchitecture_NoSql.Infrastructure.Repositories;

namespace POCCleanArchitecture_NoSql
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
            services.Configure<POCCleanArchitectureNoSqlDatabaseSettings>(
                Configuration.GetSection(nameof(POCCleanArchitectureNoSqlDatabaseSettings)));

            services.AddSingleton<IPOCCleanArchitectureNoSqlDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<POCCleanArchitectureNoSqlDatabaseSettings>>().Value);

            services.AddScoped<IPDIRepository, PDIRepository>();
            services.AddScoped<IPDIService, PDIService>();

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
