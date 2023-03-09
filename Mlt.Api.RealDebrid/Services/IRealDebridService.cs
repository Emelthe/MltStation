using Mlt.Api.RealDebrid.Dtos;

namespace Mlt.Api.RealDebrid.Services;

public interface IRealDebridService
{
    Task<List<TorrentsDto>> Torrents(string queryString);
    Task<TorrentsInfoDto> TorrentsInfo(string id);
    Task<UnrestrictLinkDto> UnrestrictLink(IEnumerable<KeyValuePair<string, string>> content);
    Task<TorrentsAddMagnetDto> TorrentsAddMagnet(IEnumerable<KeyValuePair<string, string>> content);
    Task<string> TorrentsSelectFiles(string id, IEnumerable<KeyValuePair<string, string>> content);
}