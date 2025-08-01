public class Cache<TKey, TValue>
{
    private readonly Dictionary<TKey, TValue> _cacheData = new();
    public TValue Get(TKey key, Func<TKey, TValue> predicate)
    {
        if (_cacheData.ContainsKey(key))
        {
            return _cacheData[key];
        }
        _cacheData[key] = predicate(key);
        return _cacheData[key];
    }

}