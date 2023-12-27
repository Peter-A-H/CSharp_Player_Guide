ColoredItem<Sword> sword = new(new Sword(), ConsoleColor.Blue);
ColoredItem<Bow> bow = new(new Bow(), ConsoleColor.Red);
ColoredItem<Axe> axe = new(new Axe(), ConsoleColor.Green);

sword.Display();
bow.Display();
axe.Display();
Console.ForegroundColor = ConsoleColor.White;

public readonly struct ColoredItem<T>(T item, ConsoleColor color)
{
    public T Item { get; } = item;
    public ConsoleColor Color { get; } = color;

    public void Display()
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(Item);
    }
}

public class Sword { }
public class Bow { }
public class Axe { }
