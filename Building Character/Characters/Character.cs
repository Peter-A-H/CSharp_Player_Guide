using TheUncodedOne.Parties;

namespace TheUncodedOne.Characters;

public abstract class Character(sbyte hp)
{
    public sbyte CurrentHP { get; private set; } = hp;
    public sbyte MaxHP { get; } = hp;
    public abstract string Name { get; }

    public void TakeDamage(sbyte damageValue, Battle battle)
    {
        if (CurrentHP - damageValue <= 0)
        {
            CurrentHP = 0;
            IsCharacterDead(battle);
        }
        else CurrentHP -= damageValue;
    }

    public void IsCharacterDead(Battle battle)
    {
        if (CurrentHP <= 0)
        {
            Console.WriteLine($"{Name} has been defeated!");
            if (this is Skeleton)
            {
                battle.Monsters.Characters.Remove(this);
            }
            else
            {
                battle.Heroes.Characters.Remove(this);
            }
        }
    }
}