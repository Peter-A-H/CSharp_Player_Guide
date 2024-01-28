using Building_Character.Party;
using Building_Character.Party.Characters;
using Building_Character.Players;
using Color;
namespace Game;

public class UncodedOneGame
{
    public static void Run()
    {
        string userName = ColoredConsole.Prompt("What is your name? ").ToUpper();
        Party heroes = new(new Player());
        heroes.Characters.Add(new TrueProgrammer(userName));
        Party monsters = new(new ComputerPlayer());
        monsters.Characters.Add(new Skeleton());
        Battle battle = new(heroes, monsters);

        battle.Start();
    }
}
