class TODOListProgram
{
    ListManager manager;
    public TODOListProgram(ListManager manager)
    {
        this.manager = manager;
    }
    public void Start()
    {
               while (true)
        {
            Greetings.Greet();
            int choice = char.ToLower(ConsoleReader.ReadChar("Enter your choice: "));
            switch (choice)
            {
                case 's':
                    manager.SeeAllItems();
                    continue;
                case 'a':
                    manager.AddItem();
                    continue;
                case 'r':
                    manager.RemoveItem();
                    continue;
                case 'e':
                    Console.WriteLine("Exiting the program.");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    continue;
            }
        }
    }

}
