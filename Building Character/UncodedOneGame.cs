using Building_Character.Party;
using Building_Character.Party.Battle;
using Building_Character.Party.Characters;
namespace Game;

public class UncodedOneGame
{
    public static void Run()
    {
        Party heroes = new();
        heroes.Characters.Add(new TrueProgrammer());
        Party monsters = new();
        monsters.Characters.Add(new Skeleton());
        Battle battle = new(heroes, monsters);

        battle.Start();
    }
}
