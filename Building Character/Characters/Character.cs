namespace TheUncodedOne.Characters;

public abstract class Character
{
    public abstract sbyte MaxHP { get; }
    public abstract sbyte CurrentHP { get; }
    public abstract string Name { get; }
}