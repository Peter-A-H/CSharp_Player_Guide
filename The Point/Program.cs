Point point = new(2, 3);
Point point1 = new(-4, 0);
Console.WriteLine($"({point.X}, {point.Y})");
Console.WriteLine($"({point1.X}, {point1.Y})");

public class Point(int x, int y)
{
    public int X { get; } = x;
    public int Y { get; } = y;

    // Call primary constructor, default to 0, 0 if no params are passed
    public Point() : this(0, 0) { }
}