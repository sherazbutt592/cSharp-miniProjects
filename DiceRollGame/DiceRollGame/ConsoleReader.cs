public class ConsoleReader: IConsoleReader
{
    public int ReadInteger()
    {
        string input;
        while (true)
        {
            input = Console.ReadLine();
            if (int.TryParse(input, out int result))
            {
                return result;
            }
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
interface IConsoleReader
{
    int ReadInteger();
}