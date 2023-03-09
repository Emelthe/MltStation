namespace Mlt.Api.Rss.Dtos.ShowRssDto;

public class ItemDto
{
    [XmlElement(ElementName = "title")]
    public string Title { get; set; } = null!;

    [XmlElement(ElementName = "link")]
    public string Link { get; set; } = null!;

    [XmlElement(ElementName = "guid")]
    public GuidDto Guid { get; set; } = null!;

    [XmlElement(ElementName = "pubDate")]
    public string PubDate { get; set; } = null!;

    [XmlElement(ElementName = "description")]
    public string Description { get; set; } = null!;

    [XmlElement(ElementName = "show_id", Namespace = "https://showrss.info")]
    public int ShowId { get; set; }

    [XmlElement(ElementName = "external_id", Namespace = "https://showrss.info")]
    public int ExternalId { get; set; }

    [XmlElement(ElementName = "show_name", Namespace = "https://showrss.info")]
    public string ShowName { get; set; } = null!;

    [XmlElement(ElementName = "episode_id", Namespace = "https://showrss.info")]
    public int EpisodeId { get; set; }

    [XmlElement(ElementName = "raw_title", Namespace = "https://showrss.info")]
    public string RawTitle { get; set; } = null!;

    [XmlElement(ElementName = "info_hash", Namespace = "https://showrss.info")]
    public string InfoHash { get; set; } = null!;

    [XmlElement(ElementName = "enclosure")]
    public EnclosureDto Enclosure { get; set; } = null!;
}