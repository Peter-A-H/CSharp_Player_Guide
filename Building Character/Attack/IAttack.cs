using TheUncodedOne.Parties;

namespace TheUncodedOne.AttackAction;

public interface IAttack
{
    string AttackName { get; }

    void RunAction(Battle battle, Character character);
}
