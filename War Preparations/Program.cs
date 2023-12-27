Sword basicSword = new(Material.Iron, Gem.None);
Sword rareSword = basicSword with { Gemstone = Gem.Bitstone };
Sword steelSword = basicSword with { Material = Material.Steel };
Console.WriteLine(rareSword.ToString());

public readonly record struct Sword(Material Material, Gem Gemstone)
{
    public int Length { get; } = 70;
    public int Width { get; } = 7;
}

public enum Material { Wood, Bronze, Iron, Steel, Binarium }
public enum Gem { Emerald, Amber, Sapphire, Diamond, Bitstone, None }