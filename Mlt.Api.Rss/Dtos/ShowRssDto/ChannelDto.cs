namespace Mlt.Api.Rss.Dtos.ShowRssDto;

public class ChannelDto
{
    [XmlElement(ElementName = "title")]
    public string Title { get; set; } = null!;

    [XmlElement(ElementName = "link")]
    public string Link { get; set; } = null!;

    [XmlElement(ElementName = "ttl")]
    public string Ttl { get; set; } = null!;

    [XmlElement(ElementName = "description")]
    public string Description { get; set; } = null!;

    [XmlElement(ElementName = "item")]
    public List<ItemDto> Items { get; set; } = null!;
}