namespace Mlt.Api.RealDebrid.Dtos;

// ReSharper disable InconsistentNaming
public class TorrentsDto
{
    public string id { get; set; } = null!;
    
    public string filename { get; set; } = null!;
 
    public string hash { get; set; } = null!;

    public double bytes { get; set; }

    public string host { get; set; }= null!;

    public int split { get; set; }

    public int progress { get; set; }

    public string status { get; set; }= null!;

    public DateTime added { get; set; }

    public List<string> links { get; set; } = null!;

    public DateTime ended { get; set; }
}