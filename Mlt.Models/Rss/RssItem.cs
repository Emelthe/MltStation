namespace Mlt.Models.Rss;

public class RssItem
{
    public string Title { get; set; } = null!;

    public string Link { get; set; } = null!;

    public string Identification { get; set; } = null!;

    public DateTime PublicationDate { get; set; }

    public string Description { get; set; } = null!;

    public int ShowId { get; set; }
}