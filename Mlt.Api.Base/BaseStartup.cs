using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;

namespace Mlt.Api.Base;

public abstract class BaseStartup<T> where T : class
{
    protected BaseStartup(IConfiguration configuration)
        => Configuration = configuration;

    protected IConfiguration Configuration { get; }

    public virtual void ConfigureServices(IServiceCollection services)
    {
        services.AddResponseCaching();

        services.AddSwaggerGen(options =>
                               {
                                   options.SwaggerDoc("v1",
                                                      new OpenApiInfo
                                                      {
                                                          Version = "v1",
                                                          Title = "MltStation API",
                                                          Description = "Api de gestion des séries"
                                                      });
                               });

        services.AddControllers();
        services.AddEndpointsApiExplorer();

        services.AddAutoMapper(typeof(T));

        // services.AddScoped<IBetaSerieSvc, BetaSerieSvc>();
        //
        // services.AddHttpClient("BetaSerieClient", client =>
        // {
        //     client.BaseAddress = new System.Uri(Configuration["BetaSerieParams:Url"]);
        //     client.DefaultRequestHeaders.Add("X-BetaSeries-Version", Configuration["BetaSerieParams:Version"]);
        //     client.DefaultRequestHeaders.Add("X-BetaSeries-Key", Configuration["BetaSerieParams:Key"]);
        //     client.DefaultRequestHeaders.Add("Authorization", $"Bearer {Configuration["BetaSerieParams:Token"]}");
        // });
        //

        // services.AddSingleton<ISynologySvc>(x =>
        //     new SynologySvc(
        //         x.GetRequiredService<IHttpClientFactory>(),
        //         Configuration["SynologyParams:UserName"],
        //         Configuration["SynologyParams:Passwd"]));
        //
        // services.AddHttpClient("SynologyClient", client =>
        // {
        //     client.BaseAddress = new System.Uri(Configuration["SynologyParams:Url"]);
        // });
    }

    public virtual void Configure(IApplicationBuilder app, IWebHostEnvironment env)
    {
        app.UseSwagger();

        app.UseSwaggerUI(options =>
                         {
                             options.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
                             options.RoutePrefix = string.Empty;
                         });

        app.UseRouting();
        app.UseAuthorization();
        app.UseResponseCaching();
        app.UseEndpoints(endpoints => { endpoints.MapControllers(); });
    }
}