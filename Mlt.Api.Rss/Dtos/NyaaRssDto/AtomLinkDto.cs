namespace Mlt.Api.Rss.Dtos.NyaaRssDto;

public class AtomLinkDto
{
    [XmlAttribute("href")]
    public string Href { get; set; } = null!;

    [XmlAttribute("rel")]
    public string Rel { get; set; } = null!;

    [XmlAttribute("type")]
    public string Type { get; set; } = null!;
}