﻿Console.WriteLine("Make a new arrow");
Console.Write("Enter an arrowhead type (1: steel, 2: wood, 3: obsidian.): ");
string? arrowheadResponse = Console.ReadLine();
Arrowhead arrowhead = arrowheadResponse switch
{
    "1" => Arrowhead.Steel,
    "2" => Arrowhead.Wood,
    "3" => Arrowhead.Obsidian,
    _ => Arrowhead.Wood
};

Console.Write("Enter a fletching type (1: plastic, 2: turkey feathers, 3: goose feathers.): ");
string? fletchingResponse = Console.ReadLine();
Fletching fletching = fletchingResponse switch
{
    "1" => Fletching.Plastic,
    "2" => Fletching.TurkeyFeathers,
    "3" => Fletching.GooseFeathers,
    _ => Fletching.Plastic
};

Console.Write("Enter an arrow length in cm between 60 and 100.): ");
int length = Convert.ToInt32(Console.ReadLine());

Arrow arrow = new(arrowhead, fletching, length);

Console.WriteLine($"Cost for an arrow with a {arrow.Arrowhead} arrowhead, {arrow.Fletching} fletching and a length of {arrow.Length}cm is {arrow.GetCost()} gold.");

// Primary constructor syntax in C#12, removes the need to use a constructor with the same name as the class.
internal class Arrow(Arrowhead arrowhead, Fletching fletching, int length)
{
    public Arrowhead Arrowhead { get; } = arrowhead;
    public Fletching Fletching { get; } = fletching;
    public int Length { get; } = length;

    public float GetCost()
    {
        int arrowheadCost = Arrowhead switch
        {
            Arrowhead.Wood => 3,
            Arrowhead.Obsidian => 5,
            Arrowhead.Steel => 10,
            _ => 3
        };

        int fletchingCost = Fletching switch
        {
            Fletching.GooseFeathers => 3,
            Fletching.TurkeyFeathers => 5,
            Fletching.Plastic => 10,
            _ => 3
        };

        float lengthCost = Length * 0.05f;

        return arrowheadCost + fletchingCost + lengthCost;
    }
}

internal enum Arrowhead { Steel, Wood, Obsidian }
internal enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }
