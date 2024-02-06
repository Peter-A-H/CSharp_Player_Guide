using TheUncodedOne.Parties;
using TheUncodedOne.Players;
namespace TheUncodedOne;

public class UncodedOneGame
{
    public static void Run()
    {
        string userName = ColoredConsole.Prompt("What is your name? ").ToUpper();
        Party heroes = new(new Player());
        heroes.Characters.Add(new TrueProgrammer(userName));
        Party monsters = new(new ComputerPlayer());
        monsters.Characters.Add(new Skeleton("Skeleton1".ToUpper()));
        monsters.Characters.Add(new Skeleton("Skeleton2".ToUpper()));
        Battle battle = new(heroes, monsters);

        battle.Start();
    }
}
