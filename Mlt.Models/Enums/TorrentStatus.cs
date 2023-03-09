namespace Mlt.Models.Enums;

public enum TorrentStatus
{
    MagnetError,
    MagnetConversion,
    WaitingFilesSelection,
    Queued,
    Downloading,
    Downloaded,
    Error,
    Virus,
    Compressing,
    Uploading,
    Dead
}