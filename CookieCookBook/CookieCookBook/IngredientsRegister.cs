public class IngredientsRegister
{
    public readonly List<Ingredient> All = new List<Ingredient>
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
    public List<Ingredient> GetByIds(List<int> ids)
    {
        List<Ingredient> ingredients = new List<Ingredient>();
        foreach (var id in ids)
        {
            ingredients.Add(All[id - 1]);
        }
        return ingredients;
    }
    public int Count => All.Count;
}
