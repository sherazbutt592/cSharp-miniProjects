using System;
public class Program
{
    public static void Main(string[] args)
    {
        string fileName = "cookie_recipes.json";
        List<Ingredient> ingredients = new List<Ingredient>
        {
            new WheatFlour(),
            new CoconutFlour(),
            new Butter(),
            new Chocolate(),
            new Sugar(),
            new Cardamon(),
            new Cinnamon(),
            new CocoaPowder()
        };
        RecipeRepository repository = new RecipeRepository(fileName, ingredients);
        RecipeCookBook cookBook = new RecipeCookBook(ingredients, repository);
        cookBook.Start();
        Console.WriteLine("Press any key to Exit");
        Console.ReadKey();
    }
}
