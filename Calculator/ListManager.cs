class ListManager
{
    private List<string> list = new List<string>();
    public ListManager(List<string> list)
    {
        this.list = list;
    }
    public void SeeAllItems()
    {
        if (list.Count == 0)
        {
            Console.WriteLine("No items in the TODO List");
        }
        else
        {
            ListPrinter.PrintListItemsWithIndex(list); 
        }
    }
    public void AddItem() {
        while (true)
        {
            string description = ConsoleReader.ReadString("Enter the TODO description: ");
            if (list.Contains(description))
            {
                Console.WriteLine("The description should be unique");
                continue;
            }
            else {
                list.Add(description);
                return;
            }
        }
    }
    public void RemoveItem() {
        SeeAllItems();
        Console.WriteLine("Enter the index of the TODO you want to remove:");
            int index = ConsoleReader.ReadInteger();
                Console.WriteLine("The Removed TODO is: " + list[index - 1]);
                list.RemoveAt(index - 1);
                return;
    }
}
