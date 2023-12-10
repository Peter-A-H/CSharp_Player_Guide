Console.WriteLine("Make a new arrow");
Console.Write("Enter an arrowhead type (1: steel, 2: wood, 3: obsidian. ");
string? arrowheadResponse = Console.ReadLine();
Arrowhead arrowhead = arrowheadResponse switch
{
    "1" => Arrowhead.Steel,
    "2" => Arrowhead.Wood,
    "3" => Arrowhead.Obsidian,
    _ => Arrowhead.Wood
};

Console.Write("Enter a fletching type (1: plastic, 2: turkey feathers, 3: goose feathers. ");
string? fletchingResponse = Console.ReadLine();
Fletching fletching = fletchingResponse switch
{
    "1" => Fletching.Plastic,
    "2" => Fletching.TurkeyFeathers,
    "3" => Fletching.GooseFeathers,
    _ => Fletching.Plastic
};

Console.Write("Enter an arrow length in cm between 60 and 100. ");
int length = Convert.ToInt32(Console.ReadLine());

Arrow arrow = new(arrowhead, fletching, length);

public class Arrow
{
    Arrowhead _arrowhead;
    Fletching _fletching;
    int _length;

    public Arrow(Arrowhead arrowhead, Fletching fletching, int length)
    {
        _arrowhead = arrowhead;
        _fletching = fletching;
        _length = length;
    }

    float GetCost()
    {

    }
}

public enum Arrowhead { Steel, Wood, Obsidian }
public enum Fletching { Plastic, TurkeyFeathers, GooseFeathers }
