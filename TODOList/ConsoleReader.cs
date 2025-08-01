public class ConsoleReader
{
    public static string ReadString(string message)
    {
        while (true)
        {
            Console.WriteLine(message);
            string description = Console.ReadLine();
            if (description == "")
            {
                Console.WriteLine("The Description cannot be empty");
                continue;
            }
            return description;
        }
    }
    public static int ReadInteger()
    {
        int value;
        while(true)
        {
            if(int.TryParse(Console.ReadLine(), out value))
            {
                if (value <= 0)
                {
                    Console.WriteLine("Enter the value greater than 0");
                }
                else
                {
                    return value;
                }
            }
            else
            {
                Console.WriteLine("Enter a valid Index");
                continue;
            }
        }
    }

    internal static char ReadChar(string message)
    {
        char choice;
        do
        {
            Console.WriteLine(message);
        }while(!char.TryParse(Console.ReadLine(), out choice));
        return choice;
    }
}