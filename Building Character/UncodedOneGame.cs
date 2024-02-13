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
        monsters.Characters.Add(new Skeleton("Skeleton".ToUpper()));

        Party monstersBackup = new(new ComputerPlayer());
        monstersBackup.Characters.Add(new Skeleton("Fire Skeleton".ToUpper()));
        monstersBackup.Characters.Add(new Skeleton("Ice Skeleton".ToUpper()));

        Party monsterBoss = new(new ComputerPlayer());
        monsterBoss.Characters.Add(new UncodedOne("UncodedOne"));

        Battle firstBattle = new(heroes, monsters);
        Battle secondBattle = new(heroes, monstersBackup);
        Battle bossBattle = new(heroes, monsterBoss);

        firstBattle.Start();
        secondBattle.Start();
        bossBattle.Start();
    }
}
