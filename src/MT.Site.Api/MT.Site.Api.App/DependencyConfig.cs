using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MT.Site.Api.Domain.Games.Managers;
using MT.Site.Api.Domain.Games.Models;
using MT.Site.Api.Domain.Interfaces.Games.Managers;
using MT.Site.Api.Domain.Interfaces.Games.Models;
using MT.Site.Api.Storage.Interfaces.Providers;
using MT.Site.Api.Storage.Providers;
using MT.Site.Api.WebApi.ProcessingServices;

namespace MT.Site.Api.App
{
    internal class DependencyConfig
    {
        internal static void ConfigureServices(WebHostBuilderContext context, IServiceCollection services)
        {
            services.AddScoped<GameProcessingService>();

            services.AddScoped<IGame, Game>();

            services.AddScoped<IGameManager, GameManager>();

            services.AddScoped<IGameStorageProvider, GameStorageProvider>();
        }
    }
}
