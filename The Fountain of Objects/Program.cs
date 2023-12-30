Game.Run();

public static class Game
{
    public static bool InPlay { get; private set; } = true;
    public static bool IsFountainEnabled { get; private set; }

    public static void Run()
    {
        Map map = new();

        while (InPlay)
        {
            Location.Current();
            if (!InPlay) break;
            Location.MovePlayer();
        }
    }

    public static void End()
    {
        InPlay = false;
    }

    public static void EnableFountain()
    {
        IsFountainEnabled = true;
        Console.WriteLine("You hear rushing waters from the Fountain of Objects. It has been reactivated!");
    }

    public static bool HasPlayerEscaped()
    {
        if (IsFountainEnabled &&
            Location.Row == Location.Entrance[0] &&
            Location.Column == Location.Entrance[1])
        {
            return true;
        }

        return false;
    }
}

public readonly struct Map
{
    public RoomContents[,] Grid { get; } = new RoomContents[4, 4];

    public Map()
    {
        Grid[0, 0] = RoomContents.Entrance;
        Grid[0, 2] = RoomContents.Fountain;
    }
}

public static class Location
{
    public static int[] Player { get; private set; } = [0, 0];
    public static int[] Entrance { get; } = [0, 0];
    private static int[] Fountain { get; } = [0, 2];
    public static int Row { get; private set; } = Player[0];
    public static int Column { get; private set; } = Player[1];

    public static void MovePlayer()
    {
        Console.Write("What do you want to do? ");
        string? response = Console.ReadLine();
        switch (response)
        {
            case "move north":
                if (IsOffMap(Row - 1)) break;
                Row--;
                break;
            case "move south":
                if (IsOffMap(Row + 1)) break;
                Row++;
                break;
            case "move east":
                if (IsOffMap(Column + 1)) break;
                Column++;
                break;
            case "move west":
                if (IsOffMap(Column - 1)) break;
                Column--;
                break;
            case "enable fountain":
                Game.EnableFountain();
                break;
        };

        Console.WriteLine();
    }

    public static bool IsOffMap(int direction)
    {
        if (direction >= 0 &&
            direction <= 3)
        {
            return false;
        }

        Console.WriteLine("Direction is out of bounds.");
        return true;
    }

    public static void Current()
    {
        Console.WriteLine($"You are in the room at (Row={Row}, Column={Column})");

        if (Game.IsFountainEnabled &&
            Row == Entrance[0] &&
            Column == Entrance[1])
        {
            Console.WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life!");
            Console.WriteLine("You win!");
            Game.End();
        }
        else if (Row == Entrance[0] &&
                 Column == Entrance[1])
        {
            Console.WriteLine("You see light coming from the cavern entrance.");
        }

        if (!Game.IsFountainEnabled &&
            Row == Fountain[0] &&
            Column == Fountain[1])
        {
            Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");
        }
    }
}

public enum RoomContents { Empty, Fountain, Entrance }