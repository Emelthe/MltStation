using Mlt.Api.Base.Services;
using Mlt.Api.RealDebrid.Dtos;

namespace Mlt.Api.RealDebrid.Services;

public class RealDebridService : BaseSvc, IRealDebridService
{
    private readonly ILogger<RealDebridService> _logger;
    private readonly IConfiguration _configuration;

    public RealDebridService(
        HttpClient client,
        ILogger<RealDebridService> logger,
        IConfiguration configuration) : base(client)
    {
        _logger = logger;
        _configuration = configuration;
    }

    public async Task<List<TorrentsDto>> Torrents(string queryString)
    {
        Console.WriteLine($"Token RealDebrid : {_configuration["RealDebridParams:Token"]}");
        _logger.LogCritical($"Token RealDebrid : {_configuration["RealDebridParams:Token"]}");

        return await GetAsync<List<TorrentsDto>>($"torrents{queryString}");
    }

    public async Task<TorrentsInfoDto> TorrentsInfo(string id)
        => await GetAsync<TorrentsInfoDto>($"torrents/info/{id}");

    public async Task<UnrestrictLinkDto> UnrestrictLink(IEnumerable<KeyValuePair<string, string>> content)
        => await PostAsync<UnrestrictLinkDto>($"unrestrict/link", content);

    public async Task<TorrentsAddMagnetDto> TorrentsAddMagnet(IEnumerable<KeyValuePair<string, string>> content)
        => await PostAsync<TorrentsAddMagnetDto>($"torrents/addMagnet", content);

    public async Task<string> TorrentsSelectFiles(string id, IEnumerable<KeyValuePair<string, string>> content)
        => await PostAsync<string>($"torrents/selectFiles/{id}", content);
}