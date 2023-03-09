using Microsoft.AspNetCore.Mvc;
using Mlt.Api.Base.Controllers;
using Mlt.Api.Rss.Services;

namespace Mlt.Api.Rss.Controllers;

public class NyaaRssController : BaseController
{
    private readonly IShowRssService _showRssService;

    private const string RssNyaa = "https://nyaa.si/?page=rss&q=judas+one+piece&c=1_2&f=0";

    public NyaaRssController(IShowRssService showRssService)
        => _showRssService = showRssService;

    [HttpGet]
    public async Task<IActionResult> Get()
        => await HandleServiceCallErrorsAsync(async () => await _showRssService.GetNyaaRss(RssNyaa));
}