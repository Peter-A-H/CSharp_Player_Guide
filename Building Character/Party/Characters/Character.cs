namespace Building_Character.Party.Characters;

public abstract class Character
{
    public abstract sbyte HP { get; }
    public abstract string Name { get; }

    public void DoNothing() => Console.WriteLine($"{Name} did NOTHING.");
}