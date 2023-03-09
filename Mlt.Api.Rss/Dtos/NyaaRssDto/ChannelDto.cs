namespace Mlt.Api.Rss.Dtos.NyaaRssDto;

public class ChannelDto
{
    [XmlElement("title")]
    public string Title { get; set; } = null!;

    [XmlElement("description")]
    public string Description { get; set; } = null!;

    [XmlElement("link")]
    public string Link { get; set; } = null!;

    [XmlElement(Namespace = "http://www.w3.org/2005/Atom")]
    public AtomLinkDto AtomLink { get; set; } = null!;

    [XmlElement("item")]
    public List<ItemDto> Items { get; set; } = null!;
}