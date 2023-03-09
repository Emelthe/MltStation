namespace Mlt.Api.Rss.Dtos.NyaaRssDto;

public class NyaaDto
{
    [XmlElement("seeders")]
    public int Seeders { get; set; }

    [XmlElement("leechers")]
    public int Leechers { get; set; }

    [XmlElement("downloads")]
    public int Downloads { get; set; }

    [XmlElement("infoHash")]
    public string InfoHash { get; set; } = null!;

    [XmlElement("categoryId")]
    public string CategoryId { get; set; } = null!;

    [XmlElement("category")]
    public string Category { get; set; } = null!;

    [XmlElement("size")]
    public string Size { get; set; } = null!;

    [XmlElement("comments")]
    public int Comments { get; set; }

    [XmlElement("trusted")]
    public string Trusted { get; set; } = null!;

    [XmlElement("remake")]
    public string Remake { get; set; } = null!;
}