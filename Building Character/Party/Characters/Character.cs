namespace Building_Character.Party.Characters;

public class Character
{
    public sbyte HP { get; private set; } = 100;

    public string DoNothing()
    {
        return "NOTHING";
    }
}