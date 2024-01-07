while (true)
{
    Console.WriteLine("Pick a method...");
    Console.WriteLine("1: Check for even numbers.");
    Console.WriteLine("2: Check for positive numbers.");
    Console.WriteLine("3: Check for multiples of 10.");
    int response = Convert.ToInt32(Console.ReadLine());

    Sieve sieve = response switch
    {
        1 => new(IsEven),
        2 => new(IsPositive),
        3 => new(IsMultipleOfTen),
        _ => new(IsEven),
    };

    Console.Write("Enter a number to check: ");
    int numberToCheck = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Delegate returned {sieve.IsGood(numberToCheck)}\n");
}

static bool IsEven(int number) => number % 2 == 0;
static bool IsPositive(int number) => number > 0;
static bool IsMultipleOfTen(int number) => number % 10 == 0;

public class Sieve(Func<int, bool> operation)
{
    private readonly Func<int, bool> _operation = operation;

    public bool IsGood(int number) => _operation(number);
}