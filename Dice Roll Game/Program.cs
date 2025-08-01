class Program
    {
        static void Main(string[] args)
        {
            var random = new Random();
            var dice = new Dice(random);
            var game = new GuessingGame(dice);
            Console.WriteLine("Welcome to the Dice Roll Game!");
            dice.Describe();
            GameResult gameResult = game.Play();
        GuessingGame.PrintResult(gameResult);
        Console.WriteLine("Press any key to close");
            Console.ReadKey();
        }
 }
