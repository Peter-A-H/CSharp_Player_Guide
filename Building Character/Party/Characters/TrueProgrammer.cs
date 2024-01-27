namespace Building_Character.Party.Characters;

public class TrueProgrammer(string name) : Character
{
    public override sbyte HP => 100;
    public override string Name => name;
}
