using TheUncodedOne.Players;

namespace TheUncodedOne.Parties;

public class Party(IPlayer player)
{
    public IPlayer Player { get; } = player;
    public List<Character> Characters { get; } = [];
}
