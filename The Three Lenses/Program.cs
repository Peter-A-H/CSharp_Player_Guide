int[] numArray = [1, 9, 2, 8, 3, 7, 4, 6, 5];
IEnumerable<int> procedural = Procedural(numArray);
IEnumerable<int> keyword = Keyword(numArray);
IEnumerable<int> methodCall = MethodCall(numArray);

foreach (int num in procedural)
{
    Console.WriteLine(num);
}

Console.WriteLine();

foreach (int num in keyword)
{
    Console.WriteLine(num);
}

Console.WriteLine();

foreach (int num in methodCall)
{
    Console.WriteLine(num);
}

static IEnumerable<int> Procedural(int[] input)
{
    Array.Sort(input);
    List<int> evenNumbers = [];

    foreach (int num in input)
    {
        if (num % 2 == 0)
        {
            evenNumbers.Add(num * 2);
        }
    }

    return evenNumbers;
}

static IEnumerable<int> Keyword(int[] input)
{
    return from num in input
           where num % 2 == 0
           orderby num
           select num * 2;
}

static IEnumerable<int> MethodCall(int[] input)
{
    return input
                .Where(num => num % 2 == 0)
                .OrderBy(num => num)
                .Select(num => num * 2);
}