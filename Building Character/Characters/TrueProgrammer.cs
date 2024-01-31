namespace TheUncodedOne.Characters;

public class TrueProgrammer(string name) : Character
{
    public override sbyte MaxHP => 25;
    public override sbyte CurrentHP => MaxHP;
    public override string Name => name;
}
