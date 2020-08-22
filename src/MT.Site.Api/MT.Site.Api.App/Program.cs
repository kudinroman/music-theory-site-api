using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace MT.Site.Api.App
{
    class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .ConfigureServices(DependencyConfig.ConfigureServices)
                .UseStartup<Startup>();
    }
}
