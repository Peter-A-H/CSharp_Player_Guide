using TheUncodedOne.Attack;
using TheUncodedOne.Parties;

namespace TheUncodedOne.Players;

public class Player : IPlayer
{
    public IAttack ChooseAction(Battle battle, Character character)
    {
        Thread.Sleep(500);

        if (character is Skeleton) return new BoneCrunch();
        if (character is TrueProgrammer) return new Punch();
        return new DoNothingAction();
    }
}
