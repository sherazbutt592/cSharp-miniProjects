
public class ConsoleWriter
{
    public static void WriteIngredients(List<Ingredient> ingredients)
    {
        foreach (var ingredient in ingredients)
        {
            Console.WriteLine($"{ingredient.Id}: {ingredient.Name}");
        }
    }
}
