Chest chest = Chest.Locked;

while (true)
{
    string chestStatus = chest switch
    {
        Chest.Open => "open",
        Chest.Closed => "unlocked",
        Chest.Locked => "locked",
        _ => ""
    };

    Console.Write($"The chest is {chestStatus}. What do you want to do? ");
    string? action = Console.ReadLine();

    switch (action)
    {
        case "unlock":
            if (chest != Chest.Locked) Console.WriteLine("Invalid action.");
            chest = Chest.Closed;
            break;
        case "open":
            if (chest != Chest.Closed) Console.WriteLine("Invalid action.");
            chest = Chest.Open;
            break;
        case "lock":
            if (chest != Chest.Closed) Console.WriteLine("Invalid action.");
            chest = Chest.Locked;
            break;
        case "close":
            if (chest != Chest.Open) Console.WriteLine("Invalid action.");
            chest = Chest.Closed;
            break;
        default:
            Console.WriteLine("Invalid action.");
            break;
    }
}

enum Chest { Open, Closed, Locked };