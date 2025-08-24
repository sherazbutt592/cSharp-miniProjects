class Program
{
    public static void Main(string[] args)
    {
        IPrinter printer = new Printer();
        IConsoleReader consoleReader = new ConsoleReader();
        IRepository repository = new Repository("todos.json");
        TodoManipulation todoManipulation = new TodoManipulation(repository, printer, consoleReader);
        var application = new TodoApplication(todoManipulation, printer, consoleReader);
        try
        {
            application.Run();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
            Logger.Log(ex);
        }
        finally
        {
            Console.WriteLine("Press any key to close the window.");
            Console.ReadKey();
        }
    }
}