using Building_Character.Action;

namespace Building_Character.Players;

public class ComputerPlayer : IPlayer
{
    public IAction ChooseAction(Character character)
    {
        Thread.Sleep(500);
        return new DoNothingAction();
    }
}
