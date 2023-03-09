namespace Mlt.Api.Rss.Dtos.NyaaRssDto;

public class ItemDto
{
    [XmlElement("title")]
    public string Title { get; set; } = null!;

    [XmlElement("link")]
    public string Link { get; set; } = null!;

    [XmlElement("guid")]
    public string Guid { get; set; } = null!;

    [XmlElement("pubDate")]
    public string PubDate { get; set; } = null!;

    [XmlElement("nyaa", Namespace = "https://nyaa.si/xmlns/nyaa")]
    public NyaaDto Nyaa { get; set; } = null!;

    [XmlElement("description")]
    public string Description { get; set; } = null!;
}