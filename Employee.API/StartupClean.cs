using Employee.Application.Queries;
using Employee.Infrastructure.Api;
using Employee.Infrastructure.Application;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Employee.API
{
    public class StartupClean
    {
        private readonly IConfiguration _configuration;

        public StartupClean(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            app.ConfigureApiApp(env);
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.ConfigureApiServices();
            services.ConfigureApplicationServices(_configuration, typeof(GetAllEmployeeQuery).GetTypeInfo().Assembly);

            services.ConfigureApplicationDependencies();
        }
    }
}