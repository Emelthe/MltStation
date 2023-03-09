using Mlt.Models.Enums;

namespace Mlt.Models.Torrent;

public class Torrent
{
    public string Id { get; set; } = null!;

    public string FileName { get; set; } = null!;

    public string Hash { get; set; } = null!;

    public TorrentStatus Status { get; set; }

    public List<string> Links { get; set; } = null!;

    public double? Bytes { get; set; }
}