static void ConvertNumber()
{
    Console.WriteLine("Enter a number.");
    string? input = Console.ReadLine();

    if (int.TryParse(input, out int value))
    {
        Console.WriteLine($"You entered the number {value}.");
    }
    else
    {
        Console.WriteLine("That is not a number.");
        Console.WriteLine();
        ConvertNumber();
    }
}

ConvertNumber();
