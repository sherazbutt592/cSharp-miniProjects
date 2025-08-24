class DiceRollGame
{
    private readonly Dice _dice;
    private int _guessCount = 3;
    private IConsoleReader _reader;
    public DiceRollGame(Dice dice, IConsoleReader reader)
    {
        _dice = dice;
        _reader = reader;
    }

    public GameResult Play()
    {
        int number = _dice.Roll();
        Console.WriteLine("Guess the number in 3 tries");
        while (_guessCount > 0)
        {
            _guessCount--;
            Console.Write("Enter your guess: ");
            int guess = _reader.ReadInteger();
            if(guess == number)
            {
                return GameResult.Win;
            }
            Console.WriteLine("Wrong Number.");
        }
        return GameResult.Lose;
    }
}