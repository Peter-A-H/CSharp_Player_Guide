namespace TheUncodedOne.Parties;

public class Battle(Party heroes, Party monsters)
{
    public Party Heroes { get; } = heroes;
    public Party Monsters { get; } = monsters;

    public void Start()
    {
        while (true)
        {
            List<Party> parties = [Heroes, Monsters];

            foreach (Party party in parties)
            {
                if (party == null) break;

                foreach (Character character in party.Characters.ToList())
                {
                    Console.WriteLine($"{character.Name} is taking a turn...");
                    party.Player.ChooseAction(this, character).RunAction(this, character);
                    Console.WriteLine();
                }
            }
        }
    }
}