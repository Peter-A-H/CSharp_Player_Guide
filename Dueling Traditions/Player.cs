namespace FountainOfObjects;

public readonly struct Player(Location start)
{
    public Location Location { get; } = start;
}
