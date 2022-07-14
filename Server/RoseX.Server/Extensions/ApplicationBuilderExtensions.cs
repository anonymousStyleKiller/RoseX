using Microsoft.AspNetCore.HttpOverrides;

namespace RoseX.Server.Extensions;

internal static class ApplicationBuilderExtensions
{
    internal static void UseExceptionHandling(this IApplicationBuilder app, IWebHostEnvironment  environment)
    {
        if (environment.IsDevelopment())
        {
            app.UseExceptionHandler();
            app.UseDeveloperExceptionPage();
        }
    }

    internal static void ConfigureSwagger(this IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseSwagger();
        app.UseSwaggerUI(opt =>
        {
            opt.SwaggerEndpoint("swagger/v1/swagger.json", typeof(Program).Assembly.GetName().Name);
            opt.DisplayRequestDuration();
        });
    }

    internal static void UseForwarding(this IApplicationBuilder app, IConfiguration configuration)
    {
        app.UseCors();
        app.UseForwardedHeaders(new ForwardedHeadersOptions
        {
            ForwardedHeaders = ForwardedHeaders.XForwardedProto
        });
    }


    internal static void UseEndpoints(this IApplicationBuilder app)
    {
        app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
                endpoints.MapControllers();
                endpoints.MapFallbackToFile("index.html");
            }
            );
    }
    
    
    
}