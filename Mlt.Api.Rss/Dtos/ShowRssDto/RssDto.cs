namespace Mlt.Api.Rss.Dtos.ShowRssDto;

[XmlRoot(ElementName = "rss")]
public class RssDto
{
    [XmlAttribute(AttributeName = "version")]
    public string Version { get; set; } = null!;

    [XmlAttribute(AttributeName = "tv", Namespace = "http://www.w3.org/2000/xmlns/")]
    public string Tv { get; set; } = null!;

    [XmlElement(ElementName = "channel")]
    public ChannelDto Channel { get; set; } = null!;
}