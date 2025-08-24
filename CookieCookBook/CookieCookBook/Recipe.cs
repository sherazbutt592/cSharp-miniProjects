public class Recipe
{
    public List<Ingredient> ingredients { get; }
    public Recipe(List<Ingredient> ingredients)
    {
        this.ingredients = ingredients;
    }
    public override string ToString()
    {
        var steps = new List<string>();
        foreach (var ingredient in ingredients)
        {
            steps.Add($"{ingredient.Name}. {ingredient.Instruction}");
        }
        return string.Join(Environment.NewLine, steps);
    }
}
