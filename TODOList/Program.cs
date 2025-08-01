class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello");
        List<string> todo = new List<string>();
        ListManager manipulation = new ListManager(todo);
        TODOListProgram todoListProgram = new TODOListProgram(manipulation);
        todoListProgram.Start();
        Console.WriteLine("Press Any key to close");
        Console.ReadKey();
    }
}
