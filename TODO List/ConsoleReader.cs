interface IConsoleReader
{
    char ReadCharacter();
    string ReadString();
    int ReadInteger();
}
class ConsoleReader : IConsoleReader
{
    public char ReadCharacter()
    {
        while (true)
        {
            char input = Console.ReadKey().KeyChar;
            if (char.IsWhiteSpace(input) || char.IsControl(input))
            {
                Console.WriteLine("Please enter a valid Option.");
                continue; // Recursive call to read again
            }
            return char.ToLower(input);
        }
    }

    public string ReadString()
    {
        string input;
        while (true)
        {
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Please enter a valid string.");
                continue;
            }
            return input;
        }
    }

    public int ReadInteger()
    {
        while (true)
        {
            var input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
                continue;
            }
        }
    }
}
