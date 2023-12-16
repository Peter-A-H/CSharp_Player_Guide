Color color = new(221, 134, 67);
Color red = Color.Red;
Color green = Color.Green;
Color blue = Color.Blue;
Console.WriteLine($"R: {color.R} G: {color.G} B: {color.B}");
Console.WriteLine($"R: {red.R} G: {red.G} B: {red.B}");
Console.WriteLine($"R: {green.R} G: {green.G} B: {green.B}");
Console.WriteLine($"R: {blue.R} G: {blue.G} B: {blue.B}");

public class Color(int R, int G, int B)
{
    public int R { get; } = R;
    public int G { get; } = G;
    public int B { get; } = B;

    public static Color White { get; } = new(255, 255, 255);
    public static Color Black { get; } = new(0, 0, 0);
    public static Color Red { get; } = new(255, 0, 0);
    public static Color Orange { get; } = new(255, 165, 255);
    public static Color Yellow { get; } = new(255, 255, 0);
    public static Color Green { get; } = new(0, 128, 0);
    public static Color Blue { get; } = new(0, 0, 255);
    public static Color Purple { get; } = new(128, 0, 128);
}