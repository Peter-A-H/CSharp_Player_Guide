Game.Run();

public static class Game
{
    public static bool InPlay { get; private set; } = true;

    public static void Run()
    {
        Map map = new();
        Location location = new();
        map.DisplayMap();

        while (InPlay)
        {
            Console.WriteLine($"You are in the room at (Row={Location.Row}, Column={Location.Column})");
            location.MovePlayer();
        }
    }

    public static void IsFountainEnabled()
    {

    }
}

public class Map
{
    public RoomContents[,] Grid { get; } = new RoomContents[4, 4];

    public Map()
    {
        Grid[0, 0] = RoomContents.Entrance;
        Grid[0, 2] = RoomContents.Fountain;
    }

    public void DisplayMap()
    {
        for (int row = 0; row < Grid.GetLength(0); row++)
        {
            for (int column = 0; column < Grid.GetLength(1); column++)
            {
                Console.Write(Grid[row, column] + " ");
            }

            Console.WriteLine();
        }
    }
}

public class Location
{
    public static int[] Player { get; private set; } = [0, 0];
    public static int Row { get; private set; } = Player[0];
    public static int Column { get; private set; } = Player[1];

    public void MovePlayer()
    {
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
        };

        Console.WriteLine($"Player at ({Row}, {Column})");
    }

    public bool IsOffMap(int direction)
    {
        if (direction >= 0 && direction <= 3)
        {
            return false;
        }

        Console.WriteLine("Direction is out of bounds.");
        return true;
    }
}

public static class Player
{
    public static void Sense()
    {
        // player can sense what is in the next room
    }

    public static void Action()
    {
        // move player
    }
}

public enum RoomContents { Empty, Fountain, Entrance }