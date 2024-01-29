using Building_Character.Action;
using Building_Character.Characters;

namespace Building_Character.Players;

public interface IPlayer
{
    IAction ChooseAction(Character character);
}
