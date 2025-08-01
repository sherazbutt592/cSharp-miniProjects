class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine(Transform(2));
        Console.ReadKey();
    }
    public static int Transform(int number)
    {
        var transformations = new List<INumbericTransformation>
        {
            new By1Increment(),
            new By2Multiplier(),
            new ToPowerOfRaiser()
        };
        var result = number;
        foreach (var transformation in transformations)
        {
            result = transformation.Transform(result);
        }
        return result;
    }
}

public class ToPowerOfRaiser : INumbericTransformation
{
    public int Transform(int number)
    {
        return (int)Math.Pow(number, 2);
    }
}

public class By2Multiplier : INumbericTransformation
{
     public int Transform(int number)
    {
        return number * 2;
    }
}

public class By1Increment : INumbericTransformation
{
    public int Transform(int number)
    {
        return number + 1;
    }
}
public interface INumbericTransformation
{
    int Transform(int number);
}