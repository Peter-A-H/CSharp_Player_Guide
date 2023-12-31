using System.Diagnostics;

Game game = CreateGame();
game.Run();

static Game CreateGame()
{
    int TOTAL_ROWS = 4;
    int TOTAL_COLS = 4;
    Map map = new(TOTAL_ROWS, TOTAL_COLS);

    int START_ROW = 0;
    int START_COL = 0;
    Location start = new(START_ROW, START_COL);

    Player player = new(start);
    return new Game(map, player);
}

public class Game(Map map, Player player)
{
    public bool InPlay { get; private set; } = true;
    public bool IsFountainEnabled { get; private set; }
    public Map Map { get; } = map;
    public Player Player { get; } = player;
    public Stopwatch Time { get; } = new();

    public void Run()
    {
        while (InPlay)
        {
            Time.Start();
            Player.Location.Current(this);
            if (!InPlay) break;
            Player.Location.Move(this);
        }
    }

    public void End()
    {
        InPlay = false;
        TimeInCaverns();
    }

    public void EnableFountain()
    {
        IsFountainEnabled = true;
        Console.WriteLine("You hear rushing waters from the Fountain of Objects. It has been reactivated!");
    }

    public bool HasPlayerEscaped()
    {
        if (IsFountainEnabled &&
            Player.Location.Row == Player.Location.Entrance[0] &&
            Player.Location.Column == Player.Location.Entrance[1])
        {
            return true;
        }

        return false;
    }

    public void TimeInCaverns()
    {
        Time.Stop();
        TimeSpan timespan = Time.Elapsed;

        string elapsedTime = $"{timespan.Minutes} minutes, {timespan.Seconds} seconds, {timespan.Milliseconds / 10} milliseconds";
        Console.WriteLine($"Time in caverns: {elapsedTime}");
    }
}

public readonly struct Player(Location start)
{
    public Location Location { get; } = start;
}

public struct Map
{
    public RoomType[,]? Grid { get; private set; }

    public Map(int rows, int columns)
    {
        Grid = new RoomType[rows, columns];
        Grid[0, 0] = RoomType.Entrance;
        Grid[0, 2] = RoomType.Fountain;
    }
}

public class Location
{
    public static int[] Player { get; private set; } = [0, 0];
    public int[] Entrance { get; } = [0, 0];
    private int[] Fountain { get; } = [0, 2];
    public int Row { get; private set; } = Player[0];
    public int Column { get; private set; } = Player[1];

    public Location(int startRow, int startCol)
    {
        Player = [startRow, startCol];
    }

    public void Move(Game game)
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
                game.EnableFountain();
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

    public void Current(Game game)
    {
        Console.WriteLine($"You are in the room at (Row={Row}, Column={Column})");

        if (game.IsFountainEnabled &&
            Row == Entrance[0] &&
            Column == Entrance[1])
        {
            Console.WriteLine("The Fountain of Objects has been reactivated, and you have escaped with your life!");
            Console.WriteLine("You win!");
            game.End();
        }
        else if (Row == Entrance[0] &&
                 Column == Entrance[1])
        {
            Console.WriteLine("You see light coming from the cavern entrance.");
        }

        if (!game.IsFountainEnabled &&
            Row == Fountain[0] &&
            Column == Fountain[1])
        {
            Console.WriteLine("You hear water dripping in this room. The Fountain of Objects is here!");
        }
    }
}

public enum RoomType { Empty, Fountain, Entrance }
