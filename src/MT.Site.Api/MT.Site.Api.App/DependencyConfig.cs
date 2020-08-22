using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MT.Site.Api.WebApi.ProcessingServices;

namespace MT.Site.Api.App
{
    internal class DependencyConfig
    {
        internal static void ConfigureServices(WebHostBuilderContext context, IServiceCollection services)
        {
            services.AddScoped<GameProcessingService>();
        }
    }
}
