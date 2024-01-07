while (true)
{
    Console.WriteLine("Pick a method...");
    Console.WriteLine("1: Check for even numbers.");
    Console.WriteLine("2: Check for positive numbers.");
    Console.WriteLine("3: Check for multiples of 10.");
    int response = Convert.ToInt32(Console.ReadLine());

    Sieve sieve;
    switch (response)
    {
        case 1:
            sieve = new(IsEven);
            break;
        case 2:
            sieve = new(IsPositive);
            break;
        case 3:
            sieve = new(IsMultipleOfTen);
            break;
        default:
            sieve = new(IsEven);
            break;
    }

    Console.Write("Enter a number to check: ");
    int numberToCheck = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine($"Delegate returned {sieve.IsGood(numberToCheck)}\n");
}

static bool IsEven(int number) => number % 2 == 0;
static bool IsPositive(int number) => number > 0;
static bool IsMultipleOfTen(int number) => number % 10 == 0;

public class Sieve(Func<int, bool> operation)
{
    public Func<int, bool> Operation { get; private set; } = operation;

    public bool IsGood(int number) => Operation(number);
}