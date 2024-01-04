Random random = new();
Console.WriteLine(random.NextDouble(100));
Console.WriteLine(random.NextString("my", "name", "is", "peter"));
Console.WriteLine(random.CoinFlip());
Console.WriteLine(random.CoinFlip(0.25));

public static class RandomExtensions
{
    public static double NextDouble(this Random random, double max)
    {
        return random.NextDouble() * max;
    }

    public static string NextString(this Random random, params string[] input)
    {
        return input[random.Next(input.Length)];
    }

    public static bool CoinFlip(this Random random, double frequency = 0.5)
    {
        return random.NextDouble() < frequency;
    }
}