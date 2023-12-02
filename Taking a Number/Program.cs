int AskForNumber(string text)
{
    Console.WriteLine(text);
    int response = Convert.ToInt32(Console.ReadLine());
    return response;
}

int result = AskForNumber("What is the air speed velocity of an unladen swallow? ");
Console.WriteLine(result);

int AskForNumberInRange(int min, int max)
{
    Console.WriteLine($"Enter a number between {min} and {max}");
    int response = Convert.ToInt32(Console.ReadLine());

    if (response >= min && response <= max)
    {
        return response;
    }
    else
    {
        AskForNumberInRange(min, max);
    }

    return 1;
}

AskForNumberInRange(1, 100);
