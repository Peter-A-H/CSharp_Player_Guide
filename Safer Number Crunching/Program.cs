Parser.TryParseInt();
Parser.TryParseDouble();
Parser.TryParseBool();

public static class Parser
{
    public static void TryParseInt()
    {
        Console.WriteLine("Enter a number.");
        string? input = Console.ReadLine();

        if (int.TryParse(input, out int value))
        {
            Console.WriteLine($"You entered the number {value}.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("That is not a number.");
            Console.WriteLine();
            TryParseInt();
        }
    }

    public static void TryParseDouble()
    {
        Console.WriteLine("Enter a double.");
        string? input = Console.ReadLine();

        if (double.TryParse(input, out double value))
        {
            Console.WriteLine($"You entered the double {value}.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("That is not a double.");
            Console.WriteLine();
            TryParseDouble();
        }
    }

    public static void TryParseBool()
    {
        Console.WriteLine("Enter a bool.");
        string? input = Console.ReadLine();

        if (bool.TryParse(input, out bool value))
        {
            Console.WriteLine($"You entered the bool {value}.");
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("That is not a bool.");
            Console.WriteLine();
            TryParseBool();
        }
    }
}