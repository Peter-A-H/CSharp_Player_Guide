using TheUncodedOne.Parties;

namespace TheUncodedOne.Attack;

public class BoneCrunch : IAttack
{
    public string AttackName { get; } = "BONE CRUNCH";
    public sbyte AttackDamage { get; } = (sbyte)new Random().Next(2);

    public void RunAction(Battle battle, Character character)
    {
        Character target = battle.Heroes.Characters[0];

        Console.WriteLine($"{character.Name} did {AttackName} on {target.Name}");
        Console.WriteLine($"{AttackName} dealt {AttackDamage} damage to {target.Name}");
        target.TakeDamage(AttackDamage);
        Console.WriteLine($"{target.Name} is now at {target.CurrentHP}");
    }
}
