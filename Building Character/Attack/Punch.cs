using TheUncodedOne.Parties;

namespace TheUncodedOne.Attack;

public class Punch : IAttack
{
    public string AttackName { get; set; } = "PUNCH";

    public void RunAction(Battle battle, Character character) => Console.WriteLine($"{character.Name} did {AttackName} on {battle.Monsters.Characters[0].Name}");
}
