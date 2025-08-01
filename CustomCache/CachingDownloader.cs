public class CachingDownloader : IDataDownloader
{
    private readonly IDataDownloader _downloader;
    private Cache<string, string> _cache = new();
    public CachingDownloader(IDataDownloader downloader)
    {
        _downloader = downloader;
    }
    public string DownloadData(string resourceId)
    {
        return _cache.Get(resourceId, _downloader.DownloadData);
    }
}
