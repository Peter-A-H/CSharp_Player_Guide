int[] array = new int[] { 4, 51, -7, 13, -99, 15, -8, 45, 90 };

int currentSmallest = int.MaxValue;
foreach (int num in array)
{
    if (num < currentSmallest)
    {
        currentSmallest = num;
    }
}

int total = 0;
foreach (int number in array)
{
    total += number;
}

float average = (float)total / array.Length;

Console.WriteLine($"Smallest: {currentSmallest}");
Console.WriteLine($"Average: {average}");
