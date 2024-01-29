using TheUncodedOne.Action;

namespace TheUncodedOne.Players;

public class ComputerPlayer : IPlayer
{
    public IAction ChooseAction(Character character)
    {
        Thread.Sleep(500);
        return new DoNothingAction();
    }
}
