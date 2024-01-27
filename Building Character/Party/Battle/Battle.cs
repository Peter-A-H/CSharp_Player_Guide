using Building_Character.Party.Characters;

namespace Building_Character.Party.Battle;

public class Battle(Party heroes, Party monsters)
{
    private readonly Party Heroes = heroes;
    private readonly Party Monsters = monsters;

    public void Start()
    {
        while (true)
        {
            List<Party> parties = [Heroes, Monsters];

            foreach (Party party in parties)
            {
                if (party == null) break;

                foreach (Character character in party.Characters)
                {
                    Console.WriteLine($"{character.Name} is taking a turn...");
                    character.DoNothing();
                    Console.WriteLine();
                    Thread.Sleep(500);
                }
            }
        }
    }
}