namespace Mlt.Api.Rss.Dtos.NyaaRssDto;

[XmlRoot(ElementName = "rss")]
public class RssDto
{
    [XmlAttribute("version")]
    public string Version { get; set; } = null!;

    [XmlElement("channel")]
    public ChannelDto Channel { get; set; } = null!;
}