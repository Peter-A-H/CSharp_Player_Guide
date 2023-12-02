Console.WriteLine("Enter 5 numbers.");

int[] numbers = new int[5];
int[] numbers2 = new int[5];

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine("Please enter a number: ");
    int response = Convert.ToInt32(Console.ReadLine());

    numbers[i] = response;
    numbers2[i] = numbers[i];

    for (int j = 0; j < numbers.Length; j++)
    {
        Console.WriteLine($"Numbers array: {numbers[j]}");
        Console.WriteLine($"Numbers2 array: {numbers2[j]}");
    }
}

