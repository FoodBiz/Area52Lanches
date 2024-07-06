using Area52Lanches;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Area52Lanches
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args)
                .Build()
                .Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>()
                              .UseUrls("https://localhost:5001", "http://localhost:5000");
                });
    }
}