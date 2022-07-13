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
}