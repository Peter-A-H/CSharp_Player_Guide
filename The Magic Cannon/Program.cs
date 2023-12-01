for (int i = 1; i < 101; i++)
{
    string gem = "Normal";

    if (i % 3 == 0)
    {
        gem = "Fire";
    }
    else if (i % 5 == 0)
    {
        gem = "Electric";
    }

    Console.WriteLine($"{i}: {gem}");
}