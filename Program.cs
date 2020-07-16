using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using PKWebApp.Data;
using Microsoft.AspNetCore;

namespace PKWebApp
{
    public class Program
    {
        public static void Main(string[] args)
        {;
            var host = CreateWebHost(args);
            SeedDb(host);
            host.Run();
        }

        private static void SeedDb(IWebHost host)
        {
            var scopeFactory = host.Services.GetService<IServiceScopeFactory>();

            using (var scope = scopeFactory.CreateScope())
            {
                var seeder = scope.ServiceProvider.GetService<PKSeeder>();
                seeder.Seed();
            }
        }

        public static IWebHost CreateWebHost(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
            .ConfigureAppConfiguration(SetupConfiguration)
            .UseStartup<Startup>()
            .Build();


        private static void SetupConfiguration(WebHostBuilderContext context, IConfigurationBuilder builder)
        {
            builder.Sources.Clear();
            builder.AddJsonFile("config.json", false, true);
            builder.Build();
        }
    }
}
