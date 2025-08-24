class Program
{
    public static void Main(string[] args)
    {
        int sides = 6; // Default to a 6-sided dice
        var random = new Random();
        var dice = new Dice(random, sides);
        IConsoleReader reader = new ConsoleReader();
        dice.Describe();
        Console.WriteLine("Welcome to the Dice Roll Game!");
        var game = new DiceRollGame(dice, reader);
        GameResult result = game.Play();
        if (result==GameResult.Win)
        {
            Console.WriteLine("You Win!");
        }
        else
        {
            Console.WriteLine("You Lose!");
        }
    }
}
