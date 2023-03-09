using Mlt.Api.Base;
using Mlt.Api.RealDebrid.Services;

namespace Mlt.Api.RealDebrid;

public class Startup : BaseStartup<Startup>
{
    public Startup(IConfiguration configuration) : base(configuration) { }

    public override void ConfigureServices(IServiceCollection services)
    {
        base.ConfigureServices(services);

        services.AddScoped<IRealDebridService, RealDebridService>();

        services.AddSingleton(_ =>
                              {
                                  var httpClient = new HttpClient
                                                   {
                                                       BaseAddress =
                                                           new Uri(Configuration["RealDebridParams:Url"]
                                                                   !)
                                                   };

                                  httpClient.DefaultRequestHeaders.Add("Authorization",
                                                                       $"Bearer {Configuration["RealDebridParams:Token"]}");

                                  return httpClient;
                              });
    }
}