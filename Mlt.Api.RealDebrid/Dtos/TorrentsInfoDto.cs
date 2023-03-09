namespace Mlt.Api.RealDebrid.Dtos;

// ReSharper disable InconsistentNaming
public class TorrentsInfoDto
{
    public string id { get; set; } = null!;

    public string filename { get; set; } = null!;

    public string original_filename { get; set; } = null!;

    public string hash { get; set; } = null!;

    public double bytes { get; set; }

    public double original_bytes { get; set; }

    public string host { get; set; } = null!;

    public int split { get; set; }

    public int progress { get; set; }

    public string status { get; set; } = null!;

    public DateTime added { get; set; }

    public List<File> files { get; set; } = null!;

    public List<object> links { get; set; } = null!;

    public class File
    {
        public int id { get; set; }

        public string path { get; set; } = null!;

        public double bytes { get; set; }

        public int selected { get; set; }
    }
}