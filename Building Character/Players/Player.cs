using TheUncodedOne.Action;

namespace TheUncodedOne.Players;

public class Player : IPlayer
{
    public IAction ChooseAction(Character character)
    {
        Thread.Sleep(500);
        return new DoNothingAction();
    }
}
