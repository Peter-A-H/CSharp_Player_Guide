namespace TheUncodedOne.Characters;

public abstract class Character(sbyte hp)
{
    public sbyte CurrentHP { get; private set; } = hp;
    public sbyte MaxHP { get; } = hp;
    public abstract string Name { get; }

    public void TakeDamage(sbyte damageValue) => CurrentHP -= damageValue;
}