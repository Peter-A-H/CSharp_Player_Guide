using TheUncodedOne.AttackAction;
using TheUncodedOne.Parties;

namespace TheUncodedOne.Players;

public class Player : IPlayer
{
    public IAttack ChooseAction(Battle battle, Character character)
    {
        Thread.Sleep(2000);

        if (character is Skeleton)
        {
            return new Attack("BONE CRUNCH", (sbyte)new Random().Next(2), battle.Heroes.Characters[0]);
        }
        if (character is TrueProgrammer)
        {
            return new Attack("PUNCH", 1, battle.Monsters.Characters[0]);
        }

        return new DoNothingAction();
    }
}
