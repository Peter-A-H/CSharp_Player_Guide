namespace FountainOfObjects;

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
