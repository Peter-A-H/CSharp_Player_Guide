using Building_Character.Party.Battle;
namespace Building_Character.Party.Characters.Enemies;

public class Skeleton : Monster, IAttackAction
{
    public string Name { get; private set; } = "SKELETON";

    public byte Attack()
    {
        Random random = new();
        byte damageAmount = (byte)random.Next(0, 2);
        return damageAmount;
    }
}