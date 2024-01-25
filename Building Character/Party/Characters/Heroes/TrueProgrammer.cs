using Building_Character.Party.Battle;
namespace Building_Character.Party.Characters.Heroes;

public class TrueProgrammer : Hero, IAttackAction
{
    public byte Attack()
    {
        byte damageAmount = 1;
        return damageAmount;
    }
}