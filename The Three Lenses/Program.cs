List<GameObject> objects = [];
objects.Add(new Ship
{
    ID = 1,
    X = 0,
    Y = 0,
    HP = 50,
    MaxHP = 100,
    PlayerID = 1
});
objects.Add(new Ship
{
    ID = 2,
    X = 4,
    Y = 2,
    HP = 75,
    MaxHP = 100,
    PlayerID = 1
});
objects.Add(new Ship
{
    ID = 3,
    X = 9,
    Y = 3,
    HP = 0,
    MaxHP = 100,
    PlayerID = 2
});

List<Player> players = [];
players.Add(new Player(1, "Player 1", "Red"));
players.Add(new Player(1, "Player 2", "Blue"));

IEnumerable<string> deadShip = from Ship obj in objects
                               where obj.HP == 0
                               select $"{obj.HP}/{obj.MaxHP}";

foreach (string hp in deadShip)
{
    Console.WriteLine($"HP: {hp}");
}

public class GameObject
{
    public int ID { get; init; }
    public double X { get; init; }
    public double Y { get; init; }
    public int MaxHP { get; init; }
    public int HP { get; init; }
    public int PlayerID { get; init; }
}

public class Ship : GameObject { }

public record Player(int ID, string UserName, string TeamColor);
