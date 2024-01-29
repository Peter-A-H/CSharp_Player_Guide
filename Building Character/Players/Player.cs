using Building_Character.Action;
using Building_Character.Characters;

namespace Building_Character.Players;

public class Player : IPlayer
{
    public IAction ChooseAction(Character character)
    {
        Thread.Sleep(500);
        return new DoNothingAction();
    }
}
