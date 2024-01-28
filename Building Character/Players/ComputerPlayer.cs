using Building_Character.Party.Action;
using Building_Character.Party.Characters;

namespace Building_Character.Players;

public class ComputerPlayer : IPlayer
{
    public IAction ChooseAction(Character character)
    {
        Thread.Sleep(500);
        return new DoNothingAction();
    }
}
