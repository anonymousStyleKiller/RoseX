namespace RoseX.Server.Extensions;
using Serilog;

internal static class HostBuilderExtensions
{
    internal static IHostBuilder UseSerilog(this IHostBuilder builder)
    {
        var config = new ConfigurationBuilder()
            .AddJsonFile("appsettings.Develop.json")
            .AddJsonFile("appsettings.json")
            .AddEnvironmentVariables()
            .Build();
        Log.Logger = new LoggerConfiguration().ReadFrom.Configuration(config).CreateLogger();
        SerilogHostBuilderExtensions.UseSerilog(builder);
        return builder;
    }
}