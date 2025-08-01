class ConsoleReader
{
    public static string ReadFileName()
    {
        while (true)
        {
            Console.WriteLine("Enter the Name of the file: ");
            var input = Console.ReadLine();
            if (input.IsNull())
            {
                Console.WriteLine("File name cannot be null");
                continue;
            }
            else if(input.IsEmpty())
            {
                Console.WriteLine("File name cannot be empty");
                continue;
            }
            else if(!File.Exists(input))
            {
                Console.WriteLine($"File {input} does not exist.");
                continue;
            }
            else
            {
                return input;
            }
        }
    }
}
