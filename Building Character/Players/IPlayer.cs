using TheUncodedOne.AttackAction;
using TheUncodedOne.Parties;

namespace TheUncodedOne.Players;

public interface IPlayer
{
    IAttack ChooseAction(Battle battle, Character character);
}
