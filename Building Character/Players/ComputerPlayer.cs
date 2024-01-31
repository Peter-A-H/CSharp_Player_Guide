using TheUncodedOne.Attack;
using TheUncodedOne.Parties;

namespace TheUncodedOne.Players;

public class ComputerPlayer : IPlayer
{
    public IAttack ChooseAction(Battle battle, Character character)
    {
        Thread.Sleep(500);

        return new BoneCrunch();
    }
}
