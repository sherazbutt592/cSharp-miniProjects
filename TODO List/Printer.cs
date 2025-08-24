interface IPrinter
{
    void PrintOptions();
    void PrintCollections(List<Todo> todos);
}
class Printer : IPrinter
{
    public void PrintOptions()
    {
        Console.WriteLine("What do you want to do?" +
            "\n[S]ee all TODOs" +
            "\n[A]dd a TODO" +
            "\n[R]emove a TODO" +
            "\n[E]xit");
    }
    public void PrintCollections(List<Todo> todos)
    {
        if (todos.Count == 0)
        {
            Console.WriteLine("No TODOs available.");
            return;
        }
        Console.WriteLine("TODO List:");
        for (int i = 0; i < todos.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {todos[i].Description}");
        }
    }
}
