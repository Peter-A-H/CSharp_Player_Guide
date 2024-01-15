RecentNumbers recentNumbers = new()
{
    MostRecent = -1,
    SecondMostRecent = -2
};
Thread generatingThread = new(GenerateNumbers); // method to run
generatingThread.Start(recentNumbers); // shared data to pass 

while (true)
{
    Console.ReadKey(false);

    bool isDuplicate;
    lock (recentNumbers) // use a mutex to only allow 1 thread to access shared data at a time
    {
        isDuplicate = recentNumbers.MostRecent == recentNumbers.SecondMostRecent;
    }

    if (isDuplicate)
    {
        Console.WriteLine("You found a duplicate!");
    }
    else
    {
        Console.WriteLine("That is not a duplicate.");
    }
}

static void GenerateNumbers(object? obj)
{
    if (obj is null or not RecentNumbers) return;

    RecentNumbers recentNumbers = (RecentNumbers)obj; // downcast from obj to RecentNumbers type
    Random random = new();

    while (true)
    {
        int nextNumber = random.Next(10);

        lock (recentNumbers)
        {
            recentNumbers.SecondMostRecent = recentNumbers.MostRecent;
            recentNumbers.MostRecent = nextNumber;
        }

        Console.WriteLine(nextNumber);
        Thread.Sleep(1000);
    }
}

public class RecentNumbers
{
    public int MostRecent { get; set; }
    public int SecondMostRecent { get; set; }
}
