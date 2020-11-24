using Hygge_discord_bot.Core.Services.Items;
using Hygge_discord_bot.Core.Services.Profiles;
using Hygge_discord_bot.DAL;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Hygge_discord_bot
{
    public class Startup
    {
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<RPGContext>(options =>
            {
                options.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=RPGContext;Trusted_Connection=True;MultipleActiveResultSets=true",
                    x => x.MigrationsAssembly("Hygge_discord_bot.DAL.Migrations"));
                options.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            });

            services.AddScoped<IItemService, ItemService>();
            services.AddScoped<IExperienceService, ExperienceService>();
            services.AddScoped<IProfileService, Profileservice>();

            var serviceprovider = services.BuildServiceProvider();

            var bot = new Bot(serviceprovider);
            services.AddSingleton(bot);
        }

        public void configure(IApplicationBuilder app, IWebHostEnvironment env) { }

        //$ dotnet-ef migrations add AddedInventoryAndGold -p ../Hygge_discord_bot.DAL.Migrations/Hygge_discord_bot.DAL.Migrations.csproj --context Hygge_discord_bot.DAL.RPGContext
        //$ dotnet-ef database update AddedInventoryAndGold -p ../Hygge_discord_bot.DAL.Migrations/Hygge_discord_bot.DAL.Migrations.csproj --context Hygge_discord_bot.DAL.RPGContext

    }
}
