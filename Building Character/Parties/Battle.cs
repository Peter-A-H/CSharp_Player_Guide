namespace TheUncodedOne.Parties;

public class Battle(Party heroes, Party monsters)
{
    public Party Heroes { get; } = heroes;
    public Party Monsters { get; } = monsters;
    private bool _gamePlaying = true;

    public void Start()
    {
        while (_gamePlaying)
        {
            List<Party> parties = [Heroes, Monsters];

            foreach (Party party in parties)
            {
                if (party == null) break;

                foreach (Character character in party.Characters.ToList())
                {
                    if (Heroes.Characters.Count == 0)
                    {
                        Console.WriteLine("The enemy wins!");
                        _gamePlaying = false;
                        break;
                    }

                    if (Monsters.Characters.Count == 0)
                    {
                        Console.WriteLine("The Hero wins!");
                        _gamePlaying = false;
                        break;
                    }

                    Console.WriteLine($"{character.Name} is taking a turn...");
                    party.Player.ChooseAction(this, character).RunAction(this, character);
                    Console.WriteLine();
                }
            }
        }
    }
}