using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Employee.API
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IHostBuilder hostBuilder = Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<StartupClean>();
                });

            hostBuilder
                .Build()
                .Run();
        }
    }
}
