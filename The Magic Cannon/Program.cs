for (int i = 1; i < 101; i++)
{
    string gem = "Normal";
    Console.ForegroundColor = ConsoleColor.White;

    if (i % 3 == 0)
    {
        gem = "Fire";
        Console.ForegroundColor = ConsoleColor.Red;
    }
    else if (i % 5 == 0)
    {
        gem = "Electric";
        Console.ForegroundColor = ConsoleColor.Yellow;
    }

    Console.WriteLine($"{i}: {gem}");
}

Console.ForegroundColor = ConsoleColor.White;
