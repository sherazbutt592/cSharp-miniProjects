class Dice
{
    private int _sides;
    private Random _random;

    public Dice(Random random, int sides)
    {
        _random = random;
        _sides = sides;
    }

    public int Roll()
    {
        Console.WriteLine("Dice Rolled.");
        return _random.Next(1, _sides+1);
    }
    public void Describe()
    {
        Console.WriteLine($"This is a {_sides}-sided dice.");
    }
}
