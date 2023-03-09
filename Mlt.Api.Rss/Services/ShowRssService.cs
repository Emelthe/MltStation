using AutoMapper;
using Mlt.Api.Base.Services;
using showRss = Mlt.Api.Rss.Dtos.ShowRssDto;
using nyaaRss = Mlt.Api.Rss.Dtos.NyaaRssDto;

namespace Mlt.Api.Rss.Services;

public class ShowRssService : BaseSvc, IShowRssService
{
    private readonly IMapper _mapper;

    public ShowRssService(IMapper mapper, HttpClient client) : base(client)
        => _mapper = mapper;

    public async Task<Models.Rss.Rss?> GetShowRss(string rssUrl)
        => _mapper.Map<Models.Rss.Rss>(await GetAsync<showRss.RssDto>(rssUrl));
}

public class NyaaRssService : BaseSvc, INyaaRssService
{
    private readonly IMapper _mapper;

    public NyaaRssService(IMapper mapper, HttpClient client) : base(client)
        => _mapper = mapper;

    public async Task<Models.Rss.Rss?> GetNyaaRss(string rssUrl)
        => _mapper.Map<Models.Rss.Rss>(await GetAsync<nyaaRss.RssDto>(rssUrl));
}