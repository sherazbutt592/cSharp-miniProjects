class RecipeCookBook
{
    List<Ingredient> ingredients;
    RecipeRepository repository;
    public RecipeCookBook(List<Ingredient> ingredients, RecipeRepository repository)
    {
        this.ingredients = ingredients;
        this.repository = repository;
    }
    public void Start()
    {
        repository.ReadRecipesFromFile();
        Console.WriteLine("Create a new cookie recipie! Avalaible Ingredients are:");
        ConsoleWriter.WriteIngredients(ingredients);
        List<int>? selectedIngredients = new List<int>();
        selectedIngredients = ConsoleReader.ReadIngredients(ingredients);
        if (selectedIngredients.Count == 0)
        {
            Console.WriteLine("No ingredients selected. Exiting.");
            return;
        }
        else
        {
            RecipePrinter.PrintRecipe(ingredients, selectedIngredients);
        }
        repository.SaveRecipeToFile(selectedIngredients);
    }
}