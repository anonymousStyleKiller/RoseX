using Microsoft.Extensions.Localization;

namespace RoseX.Server;

public class Startup
{
    private readonly IConfiguration _configuration;

    public Startup(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    public void ConfigurationService(IServiceCollection serviceCollection)
    {
        
    }

    public void Configuration(IApplicationBuilder app, IWebHostEnvironment env, IStringLocalizer<Startup> localizer)
    {
        
    }
}