using TheUncodedOne.Parties;

namespace TheUncodedOne.Attack;

public class BoneCrunch : IAttack
{
    public string AttackName { get; set; } = "BONE CRUNCH";

    public void RunAction(Battle battle, Character character) => Console.WriteLine($"{character.Name} did {AttackName} on {battle.Heroes.Characters[0].Name}");
}
