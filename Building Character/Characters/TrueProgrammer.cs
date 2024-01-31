namespace TheUncodedOne.Characters;

public class TrueProgrammer(string name) : Character(25)
{
    public override string Name { get; } = name;

    public void TakeDamage(sbyte damageValue) => CurrentHP -= damageValue;

}
