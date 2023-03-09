using Microsoft.Extensions.DependencyInjection;

namespace Mlt.Api.Base.Interfaces;

public interface IServiceConfiguration
{
    public void ConfigureServices(IServiceCollection services);
}