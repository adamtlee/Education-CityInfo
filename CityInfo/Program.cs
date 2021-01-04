using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NLog.Web;
using Microsoft.Extensions.DependencyInjection;
using CityInfo.Contexts;
using Microsoft.EntityFrameworkCore;

namespace CityInfo
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var logger = NLogBuilder
                    .ConfigureNLog("nlog.config")
                    .GetCurrentClassLogger();
            try
            {   
                logger.Info("Initializing application");
                var host = CreateHostBuilder(args).Build();

                using (var scope = host.Services.CreateScope())
                {
                    try
                    {
                        var context = scope.ServiceProvider.GetService<CityInfoContext>();

                        // For Demo purposes only I would never delete a db in production (hopefully not)
                        context.Database.EnsureDeleted();
                        context.Database.Migrate();
                    }
                    catch (Exception e)
                    {
                        logger.Error(e, "An error occured while migrating the database");
                    }
                }

                // Run the application
                host.Run();
            }
            catch (Exception e)
            {
                logger.Error(e, "Application Stopped because of exception. ");
                throw;
            }
            finally
            {
                NLog.LogManager.Shutdown();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .UseNLog();
    }
}
