using TheUncodedOne.Action;

namespace TheUncodedOne.Players;

public interface IPlayer
{
    IAction ChooseAction(Character character);
}
