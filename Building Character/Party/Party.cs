using Building_Character.Party.Characters;

namespace Building_Character.Party;

public class Party(List<Character> characters)
{
    public List<Character> Characters { get; private set; } = characters;
}
