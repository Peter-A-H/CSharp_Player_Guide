using Building_Character.Party.Battle;
namespace Building_Character.Party.Characters.Heroes;

public class TrueProgrammer : Hero, IAttackAction
{
    public string Name { get; private set; } = "TOG";

    public byte Attack()
    {
        byte damageAmount = 1;
        return damageAmount;
    }
}