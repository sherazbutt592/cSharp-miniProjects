class TodoApplication
{
    private readonly IPrinter _printer;
    private readonly TodoManipulation _manipulation;
    private readonly IConsoleReader _consoleReader = new ConsoleReader();

    public TodoApplication(TodoManipulation manipulation, IPrinter printer, IConsoleReader consoleReader)
    {
        _printer = printer;
        _manipulation = manipulation;
        _consoleReader = consoleReader;
    }

    public void Run()
    {
        Console.WriteLine("Hello");
        while (true)
        {
            _printer.PrintOptions();
            char input = _consoleReader.ReadCharacter();
            switch (char.ToLower(input))
            {
                case 's':
                    _manipulation.SeeAllTodos();
                    continue;
                case 'a':
                    _manipulation.AddTodo();
                    continue;
                case 'r':
                    _manipulation.RemoveTodo();
                    continue;
                case 'e':
                    Console.WriteLine("Exiting the application.");
                    return; // Exit the loop and end the program
                default:
                    Console.WriteLine("Invalid option. Please try again.");
                    break;
            }
        }
    }
}
