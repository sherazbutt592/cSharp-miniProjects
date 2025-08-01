class Program
{
    public static void Main(string[] args)
    {
        string fileName = ConsoleReader.ReadFileName();
        IJsonValidator jsonValidator = new JsonValidator();
        IGamePrinter gamePrinter = new GamePrinter();
        try
        {
            Repository.ReadGamesFileAndPrint(fileName, jsonValidator, gamePrinter);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}, Stack Trace: {ex.StackTrace}");
            LogException.Log(ex);
        }
        finally
        {
            Console.WriteLine("Press any key to exit...");
        }
        Console.ReadKey();
    }
}
