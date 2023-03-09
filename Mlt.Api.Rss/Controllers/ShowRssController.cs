using Microsoft.AspNetCore.Mvc;
using Mlt.Api.Base.Controllers;
using Mlt.Api.Rss.Services;

namespace Mlt.Api.Rss.Controllers;

public class ShowRssController : BaseController
{
    private readonly IShowRssService _showRssService;

    private const string RssUrl =
        "https://showrss.info/user/101961.rss?magnets=true&namespaces=true&name=null&quality=null&re=null";

    public ShowRssController(IShowRssService showRssService)
        => _showRssService = showRssService;

    [HttpGet]
    public async Task<IActionResult?> Get()
        => await HandleServiceCallErrorsAsync(async () => await _showRssService.GetShowRss(RssUrl));
}