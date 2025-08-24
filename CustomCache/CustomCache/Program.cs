namespace CustomCache
{
    public class Program
    {
        static void Main(string[] args)
        {
            IDataDownloader dataDownloader = new SlowDataDownloader();
            IDataDownloader cachedDataDownloader = new CachedDataDownloader(dataDownloader);

            Console.WriteLine(cachedDataDownloader.DownloadData("id1"));
            Console.WriteLine(cachedDataDownloader.DownloadData("id2"));
            Console.WriteLine(cachedDataDownloader.DownloadData("id3"));
            Console.WriteLine(cachedDataDownloader.DownloadData("id1"));
            Console.WriteLine(cachedDataDownloader.DownloadData("id3"));
            Console.WriteLine(cachedDataDownloader.DownloadData("id1"));
            Console.WriteLine(cachedDataDownloader.DownloadData("id2"));

            Console.ReadKey();
        }
    }
}
public interface IDataDownloader
{
    string DownloadData(string resourceId);
}
public class CachedDataDownloader : IDataDownloader
{
    private readonly IDataDownloader _dataDownloader;
    private readonly Cache _cache = new Cache();
    public CachedDataDownloader(IDataDownloader dataDownloader)
    {
        _dataDownloader = dataDownloader;
    }
    public string DownloadData(string resourceId)
    {
        if(_cache.ContainsKey(resourceId))
        {
            return _cache.GetValue(resourceId);
        }
            var data = _dataDownloader.DownloadData(resourceId);
            _cache.SetValue(resourceId, data);
            return data;
    }
}
public class SlowDataDownloader : IDataDownloader
{
    public string DownloadData(string resourceId)
    {
        //let's imagine this method downloads real data,
        //and it does it slowly
        Thread.Sleep(1000);
        return $"Some data for {resourceId}";
    }
}

public class Cache
{
    private Dictionary<string, string> _cacheStorage = new Dictionary<string, string>();
    public string GetValue(string key) => _cacheStorage[key];
    public void SetValue(string key, string value) => _cacheStorage[key] = value;
    public bool ContainsKey(string key) => _cacheStorage.ContainsKey(key);
}
