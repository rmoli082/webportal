using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TimeCard.API.Infrastructure;
using TimeCard.API.Controllers;

namespace TimeCard
{
    public class Program
    {
        public static TimeCardController controller;
        public static void Main(string[] args)
        {
            controller = new TimeCardController(new Logger<TimeCardController>(new LoggerFactory()), new TimeCardContext());

            CreateHostBuilder(args).Build().Run();

        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
