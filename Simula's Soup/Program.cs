Console.Write("Pick a food type (soup, stew, gumbo): ");
string? foodType = Console.ReadLine();
FoodType foodTypeResponse = foodType switch
{
    "soup" => FoodType.Soup,
    "stew" => FoodType.Stew,
    "gumbo" => FoodType.Gumbo,
    _ => throw new NotImplementedException()
};

Console.Write("Pick a main ingredient (mushrooms, chicken, carrots, potatoes): ");
string? foodIngredient = Console.ReadLine();
Ingredient ingredientResponse = foodIngredient switch
{
    "mushrooms" => Ingredient.Mushrooms,
    "chicken" => Ingredient.Chicken,
    "carrots" => Ingredient.Carrots,
    "potatoes" => Ingredient.Potatoes,
    _ => throw new NotImplementedException()
};

Console.Write("Pick a seasoning (spicy, salty, sweet): ");
string? foodSeasoning = Console.ReadLine();
Seasoning seasoningResponse = foodSeasoning switch
{
    "spicy" => Seasoning.Spicy,
    "salty" => Seasoning.Salty,
    "sweet" => Seasoning.Sweet,
    _ => throw new NotImplementedException()
};

(FoodType FoodBase, Ingredient Ingredient, Seasoning Seasoning) soup = (foodTypeResponse, ingredientResponse, seasoningResponse);
Console.WriteLine($"{soup.FoodBase} {soup.Ingredient} {soup.Seasoning}");

enum FoodType { Soup, Stew, Gumbo }
enum Ingredient { Mushrooms, Chicken, Carrots, Potatoes }
enum Seasoning { Spicy, Salty, Sweet }