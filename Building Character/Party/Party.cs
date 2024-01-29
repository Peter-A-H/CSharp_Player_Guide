using Building_Character.Characters;
using Building_Character.Players;

namespace Building_Character.Party;

public class Party(IPlayer player)
{
    public IPlayer Player { get; } = player;
    public List<Character> Characters { get; } = [];
}
