using Building_Character.Action;

namespace Building_Character.Players;

public class Player : IPlayer
{
    public IAction ChooseAction(Character character)
    {
        Thread.Sleep(500);
        return new DoNothingAction();
    }
}
