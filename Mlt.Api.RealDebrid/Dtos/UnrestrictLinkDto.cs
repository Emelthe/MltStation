namespace Mlt.Api.RealDebrid.Dtos;

// ReSharper disable InconsistentNaming
public class UnrestrictLinkDto
{
    public string id { get; set; }= null!;

    public string filename { get; set; }= null!;

    public string mimeType { get; set; }= null!;

    public double filesize { get; set; }

    public string link { get; set; }= null!;

    public string host { get; set; }= null!;

    public string host_icon { get; set; }= null!;

    public int chunks { get; set; }

    public int crc { get; set; }

    public string download { get; set; }= null!;

    public int streamable { get; set; }
}