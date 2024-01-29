using Building_Character.Players;

namespace Building_Character.Parties;

public class Party(IPlayer player)
{
    public IPlayer Player { get; } = player;
    public List<Character> Characters { get; } = [];
}
