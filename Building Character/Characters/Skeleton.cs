namespace TheUncodedOne.Characters;

public class Skeleton() : Character(5)
{
    public override string Name => "SKELETON";

    public void TakeDamage(sbyte damageValue) => CurrentHP -= damageValue;
}