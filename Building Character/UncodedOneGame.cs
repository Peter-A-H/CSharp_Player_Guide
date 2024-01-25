using Building_Character.Party;
using Building_Character.Party.Characters.Enemies;
using Building_Character.Party.Characters.Heroes;
namespace Game;

public class UncodedOneGame
{
    public void Run()
    {
        Party heroes = new([new TrueProgrammer()]);
        Party monsters = new([new Skeleton()]);
        Battle battle = new(heroes, monsters);

        battle.Start();
    }
}
