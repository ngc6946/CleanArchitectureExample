using Employee.Core.Repositories;
using Employee.Core.Repositories.Base;
using Employee.Infrastructure.Data;
using Employee.Infrastructure.Repositories;
using Employee.Infrastructure.Repositories.Base;
using MediatR;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Employee.Infrastructure.Application
{
    public static class Configuration
    {
        public static void ConfigureApplicationServices(this IServiceCollection services, IConfiguration configuration, Assembly appAssembly)
        {
            services.AddDbContext<EmployeeContext>(m => m.UseSqlServer(configuration.GetConnectionString("EmployeeDB")), ServiceLifetime.Singleton);

            services.AddAutoMapper(appAssembly);
            services.AddMediatR(appAssembly);
        }

        public static void ConfigureApplicationDependencies(this IServiceCollection services) 
        {
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
        }
    }
}
