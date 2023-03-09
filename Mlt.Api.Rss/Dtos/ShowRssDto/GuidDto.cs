namespace Mlt.Api.Rss.Dtos.ShowRssDto;

[XmlRoot(ElementName = "guid")]
public class GuidDto
{
    [XmlAttribute(AttributeName = "isPermaLink")]
    public bool IsPermaLink { get; set; }

    [XmlText]
    public string Text { get; set; } = null!;
}