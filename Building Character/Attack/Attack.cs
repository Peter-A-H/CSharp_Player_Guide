using TheUncodedOne.Parties;

namespace TheUncodedOne.AttackAction;

public class Attack(string name, sbyte damage, Character target) : IAttack
{
    public string AttackName { get; } = name;
    public sbyte AttackDamage { get; } = damage;
    public Character Target { get; } = target;

    public void RunAction(Battle battle, Character character)
    {
        Console.WriteLine($"{character.Name} did {AttackName} on {Target.Name}");
        Console.WriteLine($"{AttackName} dealt {AttackDamage} damage to {Target.Name}");
        Target.TakeDamage(AttackDamage);
        Console.WriteLine($"{Target.Name} is now at {Target.CurrentHP}/{Target.MaxHP}");
    }
}