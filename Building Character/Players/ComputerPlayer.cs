using TheUncodedOne.AttackAction;
using TheUncodedOne.Parties;

namespace TheUncodedOne.Players;

public class ComputerPlayer : IPlayer
{
    public IAttack ChooseAction(Battle battle, Character character)
    {
        Thread.Sleep(2000);

        if (character is Skeleton)
        {
            return new Attack("BONE CRUNCH", (sbyte)new Random().Next(2), battle.Heroes.Characters[0]);
        }
        else if (character is UncodedOne)
        {
            return new Attack("UNRAVELLING", (sbyte)new Random().Next(15), battle.Heroes.Characters[0]);
        }
        else
        {

            return new DoNothingAction();
        }
    }
}
