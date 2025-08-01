
public class ConsoleReader
{
    public static List<int> ReadIngredients(List<Ingredient> ingredients)
    {
        List<int> index = new List<int>();
        while (true)
        {
            Console.WriteLine("Enter ingredient ID or type anything else to finish:");
            if (int.TryParse(Console.ReadLine(), out int userInput))
            {
                if (userInput > 0 && userInput <= ingredients.Count)
                {
                    index.Add(userInput);
                }
                else if(index.Contains(userInput))
                {
                    Console.WriteLine("Ingredient already selected. Please choose a different one or finish.");
                }
                else
                {
                    Console.WriteLine("Invalid ingredient ID. Please try again.");
                }
            }
            else
            {
                break;// Exit the loop if input is not a valid integer
            }
        }
        return index;
    }
}