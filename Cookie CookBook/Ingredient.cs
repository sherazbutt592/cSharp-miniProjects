public abstract class Ingredient
{
    public abstract int Id { get; }
    public abstract string Name { get; }
    public virtual string PreparationInstructions() => "Add to other Ingredients.";

}
public class WheatFlour : Ingredient
{
    public override int Id { get; } = 1;
    public override string Name { get; } = "Wheat Flour";
    public override string PreparationInstructions() => $"Sieve.{base.PreparationInstructions}";
}
public class CoconutFlour : Ingredient
{
    public override int Id { get; } = 2;
    public override string Name { get; } = "Coconut Flour";
    public override string PreparationInstructions() => $"Sieve.{base.PreparationInstructions}";
}
public class Butter : Ingredient
{
    public override int Id { get; } = 3;
    public override string Name { get; } = "Butter";
    public override string PreparationInstructions() => $"Melt on low heat. {base.PreparationInstructions}";
}
public class Chocolate : Ingredient
{
    public override int Id { get; } = 4;
    public override string Name { get; } = "Chocolate";
    public override string PreparationInstructions() => $"Melt in water bath. {base.PreparationInstructions}";
}
public class Sugar : Ingredient
{
    public override int Id { get; } = 5;
    public override string Name { get; } = "Sugar";
}
public class Cardamon : Ingredient
{
    public override int Id { get; } = 6;
    public override string Name { get; } = "Cardamon";
    public override string PreparationInstructions() => $"Take half a teaspoon. {base.PreparationInstructions}";
}
public class Cinnamon : Ingredient
{
    public override int Id { get; } = 7;
    public override string Name { get; } = "Cinnamon";
    public override string PreparationInstructions() => $"Take half a teaspoon. {base.PreparationInstructions}";
}
public class CocoaPowder : Ingredient
{
    public override int Id { get; } = 8;
    public override string Name { get; } = "Cocoa Powder";
}