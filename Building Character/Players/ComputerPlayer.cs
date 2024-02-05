using TheUncodedOne.AttackAction;
using TheUncodedOne.Parties;

namespace TheUncodedOne.Players;

public class ComputerPlayer : IPlayer
{
    public IAttack ChooseAction(Battle battle, Character character)
    {
        Thread.Sleep(2000);

        return new Attack("BONE CRUNCH", (sbyte)new Random().Next(2), battle.Heroes.Characters[0]);
    }
}
