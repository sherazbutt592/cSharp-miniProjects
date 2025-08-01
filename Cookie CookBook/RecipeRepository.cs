using System.Text.Json;

public class RecipeRepository
{
    private string fileName;
    private List<Ingredient> ingredients;
    public RecipeRepository(string fileName, List<Ingredient> ingredients)
    {
        this.fileName = fileName;
        this.ingredients = ingredients;
    }

    public void SaveRecipeToFile(List<int> selectedIngredients)
    {
        string jsonString = JsonSerializer.Serialize(selectedIngredients);
        File.AppendAllText(fileName, jsonString + Environment.NewLine);
        Console.WriteLine("Recipe saved successfully!");
    }
    public void ReadRecipesFromFile()
    {
        if (!File.Exists(fileName))
        {
            Console.WriteLine("No recipe file found.");
            return;
        }
        string[] jsonString = File.ReadAllLines(fileName);
        if (jsonString.Length == 0)
        {
            Console.WriteLine("No recipes found.");
            return;
        }
        for (int i = 0; i < jsonString.Length; i++)
        {
            Console.WriteLine($"====={i+1}=====");
            RecipePrinter.PrintRecipe(ingredients, JsonSerializer.Deserialize<List<int>>(jsonString[i]));
        }
    }
}