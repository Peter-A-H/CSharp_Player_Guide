using TheUncodedOne.Parties;

namespace TheUncodedOne.Attack;

public interface IAttack
{
    string AttackName { get; }

    void RunAction(Battle battle, Character character);
}
