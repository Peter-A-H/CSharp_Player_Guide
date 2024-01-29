using Building_Character.Action;

namespace Building_Character.Players;

public interface IPlayer
{
    IAction ChooseAction(Character character);
}
