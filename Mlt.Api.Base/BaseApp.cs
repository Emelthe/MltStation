using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;

namespace Mlt.Api.Base;

public class BaseApp
{
    public static void BuildAndRun<T>(string[] args) where T : class
        => Host.CreateDefaultBuilder(args)
               .ConfigureWebHostDefaults(webBuilder => { webBuilder.UseStartup<T>(); })
               .Build()
               .Run();
}