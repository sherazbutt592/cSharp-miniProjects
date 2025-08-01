namespace Practice.GenericTypes;
class Pair<T>
{
    public T First { get; private set; }
    public T Second { get; private set; }
    public Pair(T first, T second)
    {
        First = first;
        Second = second;
    }
    public void ResetFirst()
    {
        First = default(T);
    }
    public void ResetSecond()
    {
        Second = default(T);
    }
}
