using TheUncodedOne.AttackAction;
using TheUncodedOne.Parties;

namespace TheUncodedOne.Players;

public class Player : IPlayer
{
    public IAttack ChooseAction(Battle battle, Character character)
    {
        Thread.Sleep(2000);

        if (character is TrueProgrammer)
        {
            return new Attack("PUNCH", 1, battle.Monsters.Characters[0]);
        }
        else
        {
            return new DoNothingAction();
        }
    }
}
