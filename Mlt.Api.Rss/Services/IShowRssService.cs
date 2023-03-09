namespace Mlt.Api.Rss.Services;

public interface IShowRssService
{
    public Task<Models.Rss.Rss?> GetShowRss(string rssUrl);
}

public interface INyaaRssService
{
    public Task<Models.Rss.Rss?> GetNyaaRss(string rssUrl);
}