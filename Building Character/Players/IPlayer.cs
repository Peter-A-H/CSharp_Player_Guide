using Building_Character.Party.Action;
using Building_Character.Party.Characters;

namespace Building_Character.Players;

public interface IPlayer
{
    IAction ChooseAction(Character character);
}
