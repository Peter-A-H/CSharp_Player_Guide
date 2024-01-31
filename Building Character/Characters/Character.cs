namespace TheUncodedOne.Characters;

public abstract class Character(sbyte hp)
{
    public sbyte CurrentHP { get; protected set; } = hp;
    public sbyte MaxHP { get; } = hp;
    public abstract string Name { get; }
}