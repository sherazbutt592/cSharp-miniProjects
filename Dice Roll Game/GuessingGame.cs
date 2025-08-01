class GuessingGame
    {
        private readonly Dice _dice;
        private const int maxTries = 3;
        public GuessingGame(Dice dice)
        {
            _dice = dice;
        }
        public GameResult Play()
        {
            var diceRollResult = _dice.Roll();
            Console.WriteLine($"Dice Rolled. Guess the number in {maxTries} tries.");
        int tries = 0;
        while (tries < maxTries)
        {
            int guess = ConsoleReader.ReadInteger("Enter the number: ");
            if (guess == diceRollResult)
            {
                return GameResult.Win;
            }
            else
            {
                Console.WriteLine("Wrong guess.");
                tries++;
                continue;
            }
        }
        return GameResult.Lose;
        }
    public static void PrintResult(GameResult gameResult)
        {
        string message = gameResult == GameResult.Win ? "You Win!" : "You Loose.";
        Console.WriteLine(message);
    }

}
