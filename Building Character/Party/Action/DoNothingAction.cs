using Building_Character.Party.Characters;

namespace Building_Character.Party.Action;

public class DoNothingAction : IAction
{
    public void RunAction(Character character) => Console.WriteLine($"{character.Name} did NOTHING.");
}
