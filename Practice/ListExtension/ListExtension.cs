namespace Practice.ListExtension;

public static class ListExtension
{
    public static List<int> TakeEverySecond (this List<int> input)
    {
        var result = new List<int>();
        foreach (int i in input) { 
        if(i%2 != 0) {
            result.Add(i);
            }
        }
        return result;
    }
}