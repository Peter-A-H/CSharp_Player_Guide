using TheUncodedOne.Parties;

namespace TheUncodedOne.Attack;

public class Punch : IAttack
{
    public string AttackName { get; set; } = "PUNCH";
    public sbyte AttackDamage { get; } = 1;

    public void RunAction(Battle battle, Character character)
    {
        Character target = battle.Monsters.Characters[0];

        Console.WriteLine($"{character.Name} did {AttackName} on {target.Name}");
        Console.WriteLine($"{AttackName} dealt {AttackDamage} damage to {target.Name}");
        target.TakeDamage(AttackDamage);
        Console.WriteLine($"{target.Name} is now at {target.CurrentHP}");
    }
}
