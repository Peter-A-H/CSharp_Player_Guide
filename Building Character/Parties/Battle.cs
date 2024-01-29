namespace TheUncodedOne.Parties;

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
                    party.Player.ChooseAction(character).RunAction(character);
                    Console.WriteLine();
                }
            }
        }
    }
}