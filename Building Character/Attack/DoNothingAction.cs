using TheUncodedOne.Parties;

namespace TheUncodedOne.AttackAction;

public class DoNothingAction : IAttack
{
    public string AttackName => "NOTHING";

    public void RunAction(Battle battle, Character character) => Console.WriteLine($"{character.Name} did {AttackName}.");
}
