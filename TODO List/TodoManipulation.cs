class TodoManipulation
{
    private readonly IRepository _repository;
    private readonly IPrinter _printer;
    private readonly IConsoleReader _consoleReader;
    private List<Todo> _todos = new List<Todo>();
    public TodoManipulation(IRepository repository, IPrinter printer, IConsoleReader reader)
    {
        _repository = repository;
        _printer = printer;
        _consoleReader = reader;
        _todos = _repository.ReadFromFile();
    }
    public void SeeAllTodos()
    {
        if (_todos.Count != 0)
        {
            _printer.PrintCollections(_todos);
            return;
        }
        Console.WriteLine("No Todos found");
        return;
    }
    public void AddTodo()
    {
        string input;
        while (true)
        {
            Console.WriteLine("Enter the TODO Description: ");
            input = _consoleReader.ReadString();
            Todo todo = new Todo(input);
            if (!IsUniqueTodo(todo))
            {
                Console.WriteLine("The description must be unique");
                continue;
            }
            else
            {

                _todos.Add(todo);
                Console.WriteLine("Press [1] To Enter More:\n" +
                    "Press [2] To Finish");
                while (true)
                {
                    int choice = _consoleReader.ReadInteger();
                    if (choice == 1)
                    {
                        break;
                    }
                    else if (choice == 2)
                    {
                        _repository.WriteCollectionToFile(_todos);
                        return; // Exit the loop and finish adding todos
                    }
                    else
                    {
                        Console.WriteLine("Invalid choice. Please try again.");
                        continue; // Continue to ask for a valid choice
                    }
                }
            }
        }
    }
    public void RemoveTodo()
    {
        if (_todos.Count != 0)
        {
            _printer.PrintCollections(_todos);
            while (true)
            {
                Console.WriteLine("Enter the index of the todo you want to remove: ");
                int index = _consoleReader.ReadInteger();
                if (index <= 0 || index > _todos.Count)
                {
                    Console.WriteLine("Invalid index. Please try again.");
                    continue;
                }
                _todos.RemoveAt(index - 1);
                _repository.WriteCollectionToFile(_todos);
                return;
            }
        }
        Console.WriteLine("No Todos have been added yet");
        return; // If there are no todos, just return
    }

    private bool IsUniqueTodo(Todo input)
    {
        if (_todos.Count != 0 && _todos.Any(todo => string.Equals(todo.Description, input.Description, StringComparison.OrdinalIgnoreCase)))
        {
            return false; // The description is not unique
        }
        return true; // The description is unique
    }
}