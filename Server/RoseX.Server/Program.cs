using RoseX.Server;
using RoseX.Server.Extensions;

public class Program
{
    public static async Task Main(string[] args)
    {
      
        var host = CreateHostBuilder(args).Build();
        await host.StartAsync();
    }

    private static IHostBuilder CreateHostBuilder(string[] args)
    {
        return Host.CreateDefaultBuilder(args)
            .UseSerilog()
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStaticWebAssets();
                webBuilder.UseStartup<Startup>();
            });
    }
}