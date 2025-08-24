
using System.Text.Json;
public interface IRepository
{
    List<string> Read();
    void Write(List<string> data);
}
public abstract class Repository: IRepository
{
    private readonly string _fileName;
    public Repository(string fileName)
    {
        _fileName = fileName;
    }
    public List<string> Read()
    {
               if (File.Exists(_fileName))
        {
            string jsonString = File.ReadAllText(_fileName);
            if (string.IsNullOrEmpty(jsonString))
            {
                return new List<string>();
            }
            return TextToString(jsonString);
        }
        return new List<string>();
    }
    public void Write(List<string> data)
    {
        File.WriteAllText(_fileName, StringToText(data));
    }

    protected abstract string StringToText(List<string> strings);

    protected abstract List<string> TextToString(string jsonString);
}
public class JsonRepository : Repository
{
    public JsonRepository(string fileName) : base(fileName) { }
    protected override string StringToText(List<string> strings)
    {
        return JsonSerializer.Serialize(strings);
    }
    protected override List<string> TextToString(string jsonString)
    {
        return JsonSerializer.Deserialize<List<string>>(jsonString);
    }
}
public class TextRepository : Repository
{
    public TextRepository(string fileName) : base(fileName) { }
    private readonly string _separator = Environment.NewLine;
    protected override string StringToText(List<string> strings)
    {
        return string.Join(_separator, strings);
    }
    protected override List<string> TextToString(string content)
    {
        return content.Split(_separator).ToList();
    }
}
public class RecipeRepository
{
    private readonly IRepository _repository;
    public RecipeRepository(IRepository repository)
    {
        _repository = repository;
    }
    public List<Recipe> Read()
    {
        var recipeStrings = _repository.Read();
        if(recipeStrings.Count==0)
        {
            return new List<Recipe>();
        }
        var recipes = new List<Recipe>();
        foreach (var recipe in recipeStrings)
        {
            recipes.Add(RecipeFromString(recipe));
        }
        return recipes;
    }

    public Recipe RecipeFromString(string recipeFromFile)
    {
        var stringIds = recipeFromFile.Split(',');
        List<Ingredient> ingredients = new List<Ingredient>();
        IngredientsRegister ingredientsRegister = new IngredientsRegister();

        foreach (var stringId in stringIds)
        {
            if (string.IsNullOrWhiteSpace(stringId))
            {
                return new Recipe(new List<Ingredient>());
            }
            var id = int.Parse(stringId);
            ingredients.Add(ingredientsRegister.All[id - 1]);
        }
        return new Recipe(ingredients);
    }

    public void Write(List<Recipe> recipes)
    {
        var recipeStrings = new List<string>();
        foreach (var recipe in recipes)
        {
            var ids = new List<int>();
            foreach (var ingredient in recipe.ingredients)
            {
                ids.Add(ingredient.Id);
            }
            recipeStrings.Add(string.Join(",",ids));
        }
        _repository.Write(recipeStrings);
    }
}