public class Ingredient
{
    public virtual string Name { get; set; }
    public virtual int Id { get; set; }
    public virtual string Instruction => $"Add to other Ingredient";
    public override string ToString()
    {
        return $"{Id}. {Name}";
    }
}
public class WheatFlour : Ingredient
{
    public override string Name => nameof(WheatFlour);
    public override int Id => 1;
    public override string Instruction => $"Sieve. {base.Instruction}";
}
public class CoconutFlour : Ingredient
{
    public override string Name => nameof(CoconutFlour);
    public override int Id => 2;
    public override string Instruction => $"Sieve. {base.Instruction}";
}
public class Butter : Ingredient
{
    public override string Name => nameof(Butter);
    public override int Id => 3;
    public override string Instruction => $"Melt on low heat. {base.Instruction}";
}
public class Chocolate : Ingredient
{
    public override string Name => nameof(Chocolate);
    public override int Id => 4;
    public override string Instruction => $"Melt in a water bath. {base.Instruction}";
}
public class Sugar : Ingredient
{
    public override string Name => nameof(Sugar);
    public override int Id => 5;
    public override string Instruction => $"{base.Instruction}";
}
public class Cardamon : Ingredient
{
    public override string Name => nameof(Cardamon);
    public override int Id => 6;
    public override string Instruction => $"Take half a teaspoon. {base.Instruction}";
}
public class Cinnamon : Ingredient
{
    public override string Name => nameof(Cinnamon);
    public override int Id => 7;
    public override string Instruction => $"Take half a teaspoon. {base.Instruction}";
}
public class CocoaPowder : Ingredient
{
    public override string Name => nameof(CocoaPowder);
    public override int Id => 8;
    public override string Instruction => $"{base.Instruction}";
}