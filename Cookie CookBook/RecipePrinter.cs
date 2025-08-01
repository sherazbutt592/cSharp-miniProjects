public class RecipePrinter
{
    public static void PrintRecipe(List<Ingredient>ingredients, List<int> selectedIngredients)
    {
        Console.WriteLine("Recipie Added: ");
        foreach (var id in selectedIngredients)
        {
            Console.WriteLine($"Ingredient ID: {id}");
            Console.WriteLine($"Ingredient Name: {ingredients[id - 1].Name}");
            Console.WriteLine($"Preparation Instruction: {ingredients[id - 1].PreparationInstructions()}");
        }
    }
}