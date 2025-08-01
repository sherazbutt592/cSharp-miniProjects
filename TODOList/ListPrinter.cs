class ListPrinter
{
    public static void PrintListItemsWithIndex(List<string> list)
    {
        int lineNumber = 1;
        foreach (string item in list)
        {
            Console.WriteLine($"{lineNumber}: {item}");
            lineNumber++;
        }
    }
}
