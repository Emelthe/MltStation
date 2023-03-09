namespace Mlt.Api.Rss.Dtos.ShowRssDto;

public class EnclosureDto
{
    [XmlAttribute(AttributeName = "url")]
    public string Url { get; set; } = null!;

    [XmlAttribute(AttributeName = "length")]
    public int Length { get; set; }

    [XmlAttribute(AttributeName = "type")]
    public string Type { get; set; } = null!;
}