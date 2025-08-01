using System.Net.Http.Headers;

IDataDownloader dataDownloader = new CachingDownloader(new SlowDataDownloader());

Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id3"));
Console.WriteLine(dataDownloader.DownloadData("id1"));
Console.WriteLine(dataDownloader.DownloadData("id2"));

Console.ReadKey();

public interface IDataDownloader
{
    string DownloadData(string resourceId);
}

public class SlowDataDownloader : IDataDownloader
{
    public string DownloadData(string resourceId)
    {
        //let's imagine this method downloads real data,
        //and it does it slowly
        Thread.Sleep(1000);
        string result = $"Some data for {resourceId}";
        return result;
    }
}
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
        return _cache.Get(resourceId,_downloader.DownloadData);
    }
}
public class Cache<TKey, TValue>
{
    private readonly  Dictionary<TKey, TValue> _cacheData = new();
    public TValue Get (TKey key , Func<TKey, TValue> predicate)
    {
        if (_cacheData.ContainsKey(key))
        {
            return _cacheData[key];
        }
        _cacheData[key] = predicate(key);
        return _cacheData[key];
    }

}