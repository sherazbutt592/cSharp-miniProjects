public class Dice
    {
        private readonly Random _random;
        private const int sidesOfDice = 6;
        public Dice(Random random)
        {
            _random = random;
        }
       public int Roll() => _random.Next(1, sidesOfDice + 1);
        public void Describe()
        {
            Console.WriteLine($"This is a {sidesOfDice}-sided dice.");
        }
}
