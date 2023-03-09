using Mlt.Api.Base;
using Mlt.Api.Rss.Services;

namespace Mlt.Api.Rss;

public class Startup : BaseStartup<Startup>
{
    public Startup(IConfiguration configuration) : base(configuration) { }

    public override void ConfigureServices(IServiceCollection services)
    {
        base.ConfigureServices(services);

        services.AddScoped<IShowRssService, ShowRssService>();
        services.AddSingleton(_ => new HttpClient());
    }
}