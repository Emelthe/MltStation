using Mlt.Models.Enums;

namespace Mlt.Models.Rss;

public class RssFlux
{
    public string FluxName { get; set; }
    public string Categorie { get; set; }
    public string Url { get; set; }
    public RssType Type { get; set; }
}