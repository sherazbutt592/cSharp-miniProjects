using System;
using System.Reflection.Metadata.Ecma335;

class Program
{
    public static void Main(string[] args)
    {
        RecipeRepository recipeRepository = new RecipeRepository(new JsonRepository("recipes.json"));
        CookBook cookBook = new CookBook(
            recipeRepository,
            new RecipesConosleUserInteraction(new IngredientsRegister())
        );
        cookBook.Run();
        Console.ReadKey();
    }
}
public class CookBook
{
    public RecipeRepository recipeRepository;
    public RecipesConosleUserInteraction recipesConosleUserInteraction;
    public CookBook(RecipeRepository recipeRepository, RecipesConosleUserInteraction recipesConosleUserInteraction)
    {
        this.recipeRepository = recipeRepository;
        this.recipesConosleUserInteraction = recipesConosleUserInteraction;
    }

    public void Run()
    {
         List<Recipe> allRecipes = recipeRepository.Read();
         recipesConosleUserInteraction.PrintExistingRecipes(allRecipes);
        recipesConosleUserInteraction.PrompToCreateRecipe();
        var ingredients = recipesConosleUserInteraction.ReadIngredientsFromUser();
        if (ingredients.Count ==0)
        {
            recipesConosleUserInteraction.ShowMessage("No ingredients have been selected. No recipe will be saved");
            return;
        }

        var newRecipe = new Recipe(ingredients);
        allRecipes.Add(newRecipe);
        recipeRepository.Write(allRecipes);
        recipesConosleUserInteraction.ShowMessage("Recipe added:");
        recipesConosleUserInteraction.ShowMessage(newRecipe.ToString());
        return;
    }
}

public class RecipesConosleUserInteraction
{
    private readonly IngredientsRegister _ingredientsRegister;

    public RecipesConosleUserInteraction(IngredientsRegister ingredientsRegister)
    {
        _ingredientsRegister = ingredientsRegister;
    }

    public void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }
    public void PrintExistingRecipes(List<Recipe> recipes)
    {
        if(recipes == null || recipes.Count == 0)
        {
            Console.WriteLine("No recipes found.");
            return;
        }
        int index = 1;
        foreach (var recipe in recipes)
        {
            Console.WriteLine($"*****{index}*****");
            Console.WriteLine(recipe);
            Console.WriteLine();
            index++;
        }
    }
    public void PrompToCreateRecipe()
    {
        Console.WriteLine("Create a new cookie recipe! Available ingredients are: ");
        foreach(var ingredient in _ingredientsRegister.All)
        {
            Console.WriteLine(ingredient);
        }
    }

    internal List<Ingredient> ReadIngredientsFromUser()
    {
        var ids = new List<int>();
        while (true)
        {
            Console.WriteLine("Select the Ingredient by typing its ID OR Type anything else to finish."); 
            string input = Console.ReadLine();
            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input cannot be null or empty");
                continue;
            }
            if(int.TryParse(input, out int id))
            {
                if (id <= 0 || id > _ingredientsRegister.Count)
                {
                    Console.WriteLine("Invalid ID");
                    continue;
                }
                ids.Add(id);
                continue;
            }
            if(ids.Count == 0)
            {
                return new List<Ingredient>();
            }
            return _ingredientsRegister.GetByIds(ids);
        }
    }

    public void Exit()
    { 
    }
}