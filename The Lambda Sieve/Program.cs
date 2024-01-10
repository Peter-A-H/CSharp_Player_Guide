while (true)
{
    Console.WriteLine("Pick a method...");
    Console.WriteLine("1: Check for even numbers.");
    Console.WriteLine("2: Check for positive numbers.");
    Console.WriteLine("3: Check for multiples of 10.");
    int response = Convert.ToInt32(Console.ReadLine());

    Sieve sieve = response switch
    {
        1 => new(number => number % 2 == 0),
        2 => new(number => number > 0),
        3 => new(number => number % 10 == 0),
        _ => new(number => number % 2 == 0),
    };

    Console.Write("Enter a number to check: ");
    int numberToCheck = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Delegate returned {sieve.IsGood(numberToCheck)}\n");
}

public class Sieve(Func<int, bool> operation)
{
    private readonly Func<int, bool> _operation = operation;

    public bool IsGood(int number) => _operation(number);
}