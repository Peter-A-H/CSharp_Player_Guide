using Building_Character.Parties;
using Building_Character.Players;
using Color;
namespace Building_Character;

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
