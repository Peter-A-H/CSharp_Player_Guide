Potion currentPotion = Potion.Water;

while (true)
{

    Console.WriteLine($"You currently have a {DisplayPotion(currentPotion)} potion\n");
    int ingredientChoice = RequestIngredient();
    Ingredient retrievedIngredient = RetrieveIngredient(ingredientChoice);

    Console.WriteLine("\nDo you want to complete the potion?");
    string? response = Console.ReadLine();

    if (response == "yes") Console.WriteLine();
    else break;

    Potion newPotion = CreatePotion(retrievedIngredient, currentPotion);

    if (newPotion == Potion.Ruined)
    {
        Console.WriteLine("You ruined the potion! Start over.\n");
        continue;
    }

    currentPotion = newPotion;
}

static string DisplayPotion(Potion potion) => potion.ToString().ToLower();

static int RequestIngredient()
{
    Console.WriteLine("Enter an ingredient.");
    Console.WriteLine("1: Stardust");
    Console.WriteLine("2: Eyeshine gem");
    Console.WriteLine("3: Snake venom");
    Console.WriteLine("4: Dragon breath");
    Console.WriteLine("5: Shadow glass");

    return Convert.ToInt32(Console.ReadLine());
}

static Ingredient RetrieveIngredient(int choice)
{
    return choice switch
    {
        1 => Ingredient.Stardust,
        2 => Ingredient.EyeShineGem,
        3 => Ingredient.SnakeVenom,
        4 => Ingredient.DragonBreath,
        5 => Ingredient.ShadowGlass,
        _ => Ingredient.Stardust
    };
}

static Potion CreatePotion(Ingredient ingredient, Potion currentPotion)
{
    return ingredient switch
    {
        Ingredient.Stardust when currentPotion == Potion.Water => Potion.Elixir,
        Ingredient.EyeShineGem when currentPotion == Potion.Elixir => Potion.NightSight,
        Ingredient.SnakeVenom when currentPotion == Potion.Elixir => Potion.Poison,
        Ingredient.DragonBreath when currentPotion == Potion.Elixir => Potion.Flying,
        Ingredient.ShadowGlass when currentPotion == Potion.Elixir => Potion.Invisibility,
        Ingredient.EyeShineGem when currentPotion == Potion.Invisibility => Potion.CloudyBrew,
        Ingredient.Stardust when currentPotion == Potion.CloudyBrew => Potion.Wraith,
        _ => Potion.Ruined
    };
}

public enum Potion { Water, Elixir, Poison, Flying, Invisibility, NightSight, CloudyBrew, Wraith, Ruined }
public enum Ingredient { Stardust, EyeShineGem, SnakeVenom, DragonBreath, ShadowGlass }